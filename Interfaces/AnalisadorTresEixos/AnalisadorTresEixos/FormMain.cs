using System;
using componentXtra;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ExcelLibrary.SpreadSheet;
using System.Collections.Generic;

namespace AnalisadorTresEixos
{
    public partial class FormMain : Form
    {
        #region Properties
        // Objeto SerialComPort - hipe
        private readonly SerialPort SerialComPort = new SerialPort();     

        // Buffer de recepção serial
        private string SerialDataBuffer = string.Empty;
        private delegate void DataReceivedDelegate(string a);

        // Comprimento dos vetores
        private int LengthVector=512;
        // Frequencia de amostragem
        private float SamplingFrequency=1140;

        // Coeficientes de conversão para gráficos, inicializados com valores padrão
        private float freqCoefX = (float)(1140 / 256);
        private float freqCoefY = (float)(0.01);
        private float timeCoefX = (float)(0.001);
        private float timeCoefY = (float)(0.01);
        private bool MulX = false, MulY = false, MulZ = false;

        // Arquivos de planilhas
        private readonly Workbook workbook = new Workbook();
        private readonly Worksheet worksheet1 = new Worksheet("Configurações");
        private readonly Worksheet worksheet2 = new Worksheet("Resultados");
        private int RowWorksheet1 = 1;
        private int ColumnWorksheet2 = 0;
        private bool EnableRegForAll = false; // Habilita a geração de planilhas com todos os resultados recebidos

        // Lista de gráficos da interface
        private readonly XYGraph[] XYGraphs;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            SerialComPort.DataReceived += new SerialDataReceivedEventHandler(SerialComPort_DataReceived);
            XYGraphs = new XYGraph[]
            {
                xyGraph_x, xyGraph_y, xyGraph_z,
                xyGraph_FX, xyGraph_FY, xyGraph_FZ
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Starts Worksheet Configuration Page
            worksheet1.Cells[0, 0] = new Cell("PORTA");
            worksheet1.Cells[0, 1] = new Cell("BAUD RATE (bps)");
            worksheet1.Cells[0, 2] = new Cell("Tamanho Vetor");
            worksheet1.Cells[0, 3] = new Cell("Amostragem(Smp/s)");
            worksheet1.Cells[0, 4] = new Cell("Data");
            for (ushort i = 0; i < 5; i++) worksheet1.Cells.ColumnWidth[i] = 5000;
            #endregion

            #region Initialize Graphs
            xyGraph_FX.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_FX.XtraTitle = "Espectro de Frequências (Hz) Eixo X";

            xyGraph_FY.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_FY.XtraTitle = "Espectro de Frequências (Hz) Eixo Y";

            xyGraph_FZ.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_FZ.XtraTitle = "Espectro de Frequências (Hz) Eixo Z";

            xyGraph_z.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_z.XtraTitle = "Sinal tempo (s) Eixo Z";

            xyGraph_y.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_y.XtraTitle = "Sinal tempo (s) Eixo Y";

            xyGraph_x.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph_x.XtraTitle = "Sinal tempo (s) Eixo X";

            Init_AllGraphs(70);
            #endregion

            #region Connection status
            Status_COM.ForeColor = Color.Red;
            Status_COM.BackColor = Color.DarkRed;
            Status_COM.Text = "OFF";
            Button_SerialClose.Enabled = false;
            #endregion

            #region List COM Serials
            string[] ListCom = SerialPort.GetPortNames();
            if (ListCom != null && ListCom.Length > 0)
            {
                CB_Porta.Items.AddRange(ListCom);
                CB_Porta.SelectedIndex = 0;
            }
            #endregion

            #region Load BaudRate values into ComboBox
            string[] BaudRates = 
                { 
                "100", "300", "600", "1200",
                "2400", "4800", "9600", "14400",
                "19200", "38400", "56000", "57600", 
                "115200", "128000", "256000"
                };
            CB_Baud.Items.AddRange(BaudRates);
            CB_Baud.Text = "115200";
            #endregion

            TextBox_FS_TextChanged(this, EventArgs.Empty); // Atualiza frequência de amostragem

            CB_VectorLenght.SelectedIndex = 5; // Seleciona comprimento dos vetores
        }

        #region Set Graph
        private void Init_Graph(int idGraph, float XMax, float XMin, float YMax, float YMin)
        {
            XYGraphs[idGraph].XtraLabelX = "";
            XYGraphs[idGraph].XtraLabelY = "";
            XYGraphs[idGraph].XtraAutoScale = false;
            XYGraphs[idGraph].XtraXmax = XMax;
            XYGraphs[idGraph].XtraXmin = XMin;
            XYGraphs[idGraph].XtraYmax = YMax;
            XYGraphs[idGraph].XtraYmin = YMin;
            XYGraphs[idGraph].Validate(true);
            XYGraphs[idGraph].XtraShowGrid = true;
        }

        private void Init_AllGraphs(float L)
        {
            for (int i = 0; i < 3; i++)
            {
                Init_Graph(i, L * (1 / SamplingFrequency), 0, 2, -2);
            }
            for (int i = 3; i < 6; i++)
            {
                Init_Graph(i, SamplingFrequency / 2, 0, 1, 0);
            }
        }
        #endregion

        /// <summary>
        /// Evento de recebimento de dados via serial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialDataBuffer = SerialComPort.ReadExisting();
            DataReceivedDelegate dataReceived = new DataReceivedDelegate(DelegateMethod);
            dataReceived.Invoke(SerialDataBuffer);
        }

        /// <summary>
        /// Método delegado para escrita de texto na interface e disparo do processamento do pacote recebido
        /// </summary>
        /// <param name="textValue">Valor de texto a ser adicionado</param>
        public void DelegateMethod(string textValue)
        {
            if (TextBox_DataReceived.InvokeRequired)
            {
                DataReceivedDelegate dataReceived = new DataReceivedDelegate(DelegateMethod);
                Invoke(dataReceived, new object[] { textValue });
            }
            else
            {
                if (textValue.Substring(0,2)=="x:") // Verifica inicio de pacote de dados
                {
                    TextBox_DataReceived.Text = textValue;
                }
                else
                {
                    TextBox_DataReceived.Text += textValue;
                }
                #region Check data packet is completed
                char[] arraybytes = TextBox_DataReceived.Text.ToCharArray();
                int index = 0;
                for (int i = 0; i < TextBox_DataReceived.Text.Length; i++)
                {
                    if (arraybytes[i] == 'x' || arraybytes[i] == 'y' || arraybytes[i] == 'z'
                     || arraybytes[i] == 'X' || arraybytes[i] == 'Y' || arraybytes[i] == 'Z'
                     || arraybytes[i] == ';') index++;
                }
                if (index == 12) // Verifica se já recebeu o pacote inteiro
                {
                    BuildGraphs(TextBox_DataReceived.Text);
                }
                #endregion
            }
        }

        /// <summary>
        /// Monta gráfico indexado
        /// </summary>
        /// <param name="index">Indice do gráfico</param>
        /// <param name="part">Parte do texto recebido que contém valores para o gráfico indexado</param>
        /// <returns>Array de valores extraídos durante a construção do gráfico</returns>
        private float[] BuildGraph(int index, string part)
        {
            string[] array = part.Remove(0, 2).Split(',');
            if (index < 3)
            {
                float[] OutGraph = new float[LengthVector];
                for (int i = 0; i < array.Length; i++)
                {
                    OutGraph[i] = float.Parse(array[i]) * timeCoefY;
                    if (OutGraph[i] > XYGraphs[index].XtraYmax) XYGraphs[index].XtraYmax = OutGraph[i];
                    if (OutGraph[i] < XYGraphs[index].XtraYmin) XYGraphs[index].XtraYmin = OutGraph[i];
                }
                // Limpa gráfico
                XYGraphs[index].ClearGraphs();
                // Carrega valores para o gráfico
                for (int n = 0; n < LengthVector; n++)
                {
                    XYGraphs[index].AddValue(0, n * (1 / SamplingFrequency), OutGraph[n]);
                    XYGraphs[index].DrawAll();
                }
                return OutGraph;
            }
            else
            {
                float[] OutGraph = new float[LengthVector];
                for (int i = 0; i < array.Length; i++)
                {
                    OutGraph[i] = float.Parse(array[i]) * freqCoefY;
                    if (index == 3 && MulX) OutGraph[i] *= 10;
                    else if (index == 4 && MulY) OutGraph[i] *= 10;
                    else if (index == 5 && MulZ) OutGraph[i] *= 10;
                    if (OutGraph[i] > XYGraphs[index].XtraYmax) XYGraphs[index].XtraYmax = OutGraph[i];
                    if (OutGraph[i] < XYGraphs[index].XtraYmin) XYGraphs[index].XtraYmin = OutGraph[i];
                }
                // Limpa gráfico
                XYGraphs[index].ClearGraphs();
                // Carrega valores para o gráfico
                for (int n = 0; n < LengthVector / 2; n++)
                {
                    XYGraphs[index].AddValue(0, n * freqCoefX, OutGraph[n]);
                    XYGraphs[index].DrawAll();
                }
                return OutGraph;
            }
        }
        /// <summary>
        /// Monta todos os gráficos
        /// </summary>
        /// <param name="PacketReceived">Pacote de dados recebidos via serial</param>
        private void BuildGraphs(string PacketReceived)
        {
            string[] parts = PacketReceived.Split(';');
            List<float[]> ListResults = new List<float[]>();
            for (int index=0; index<6; index++)
            {
                ListResults.Add(BuildGraph(index, parts[index]));
            }
            if (EnableRegForAll)
            {
                BuildWorksheet2(ListResults);
            }
        }
        /// <summary>
        /// Registra planílha
        /// </summary>
        /// <param name="PacketReceived">Pacote de dados recebidos</param>
        private void SaveWorksheet2(string PacketReceived)
        {
            string[] parts = PacketReceived.Split(';');
            List<float[]> ListResults = new List<float[]>();
            for (int index = 0; index < 6; index++)
            {
                ListResults.Add(BuildGraph(index, parts[index]));
            }
            BuildWorksheet2(ListResults);
        }
        /// <summary>
        /// Monta pagina de dados da planílha
        /// </summary>
        /// <param name="values">Lista de valores seguindo indexação dos gráficos</param>
        private void BuildWorksheet2(List<float[]> values)
        {
            string[] cellTitle1 = { "Temp", "Temp", "Temp", "Frequencia", "Frequencia", "Frequencia" };
            string[] cellTitle2 = { "x", "y", "z", "X", "Y", "Z" };
            for (int i = 0; i < 6; i++)
            {
                worksheet2.Cells[0, ColumnWorksheet2] = new Cell(cellTitle1[i]);
                worksheet2.Cells[0, ColumnWorksheet2 + 1] = new Cell(cellTitle2[i]);
                for (int index = 0; index < LengthVector; index++)
                {
                    worksheet2.Cells[index + 1, ColumnWorksheet2] = new Cell(Convert.ToDecimal(index));
                    worksheet2.Cells[index + 1, ColumnWorksheet2 + 1] = new Cell(Convert.ToDecimal(values[i][index]));
                }
                ColumnWorksheet2 += 2;
            }
        }
        /// <summary>
        /// Incrementa linhas na worksheet1 e adiciona dados de configurações atuais
        /// </summary>
        private void Inc_RowsWorksheet1()
        {
            if (EnableRegForAll)
            {
                worksheet1.Cells[RowWorksheet1, 0] = new Cell(CB_Porta.Text);
                worksheet1.Cells[RowWorksheet1, 1] = new Cell(CB_Baud.Text);
                worksheet1.Cells[RowWorksheet1, 2] = new Cell(CB_VectorLenght.Text);
                worksheet1.Cells[RowWorksheet1, 3] = new Cell(textBox_FS.Text);
                worksheet1.Cells[RowWorksheet1, 4] = new Cell(DateTime.Now.ToString());
                RowWorksheet1++;
            }
        }

        #region Spreadsheet buttons
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (!EnableRegForAll)
            {
                EnableRegForAll = true;
                SaveWorksheet2(TextBox_DataReceived.Text);
                Inc_RowsWorksheet1();
                EnableRegForAll = false;
            }

            DialogResult result;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "Resultados"
            };
            result = saveFileDialog1.ShowDialog();
            string local = saveFileDialog1.FileName.ToString();

            if (result != DialogResult.Cancel)
            {
                try
                {
                    Inc_RowsWorksheet1();
                    workbook.Worksheets.Add(worksheet1);
                    workbook.Worksheets.Add(worksheet2);
                    workbook.Save(local);
                }
                catch (Exception E)
                {
                    workbook.Worksheets.Remove(worksheet1);
                    workbook.Worksheets.Remove(worksheet2);
                    MessageBox.Show("Não foi Possível Salvar o Arquivo!\r\nException:" + E.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Seq_Click(object sender, EventArgs e)
        {
            if (EnableRegForAll)
            {
                MessageBox.Show("O modo sequencial já está ativo, salve a planilha e reinicie o programa para gerar uma nova planilha.",
                    "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            EnableRegForAll = true;
            Inc_RowsWorksheet1();
        }
        #endregion

        #region Serial buttons
        private void Button_SerialOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialComPort.PortName = CB_Porta.Text;
                SerialComPort.BaudRate = int.Parse(CB_Baud.Text);
                SerialComPort.DataBits = 8;

                SerialComPort.WriteTimeout = 1000;
                SerialComPort.ReadTimeout = 1000;
                SerialComPort.Encoding = new System.Text.ASCIIEncoding();

                SerialComPort.Open();

                #region Change status on interface
                Status_COM.ForeColor = Color.LightGreen;
                Status_COM.BackColor = Color.DarkGreen;
                Status_COM.Text = "ON";
                Button_SerialClose.Enabled = true;
                Button_SerialOpen.Enabled = false;
                #endregion
            }
            catch
            {
                MessageBox.Show("Falha: verifique sua conexão COM.");
            }
        }

        private void Button_SerialClose_Click(object sender, EventArgs e)
        {
            try
            {
                while (SerialComPort.BytesToWrite > 0) ; // Aguarda finalização de envio
                SerialComPort.Dispose();  // Fecha a porta e libera o recurso da memória
                SerialComPort.Close();    // Fecha a porta COM
                #region Change status on interface
                Status_COM.ForeColor = Color.Red;
                Status_COM.BackColor = Color.DarkRed;
                Status_COM.Text = "OFF";
                Button_SerialOpen.Enabled = true;
                Button_SerialClose.Enabled = false;
                #endregion
            }
            catch (Exception E)
            {
                MessageBox.Show("Falha ao encerrar COM. Exception: " + E.Message);
            }
        }
        #endregion

        #region Scale change buttons
        private void Btn_X_Click(object sender, EventArgs e)
        {
            MulX = !MulX;
            if (MulX) Btn_X.ForeColor = Color.Black;
            else Btn_X.ForeColor = Color.White;
        }

        private void Btn_Y_Click(object sender, EventArgs e)
        {
            MulY = !MulY;
            if (MulY) Btn_Y.ForeColor = Color.Black;
            else Btn_Y.ForeColor = Color.White;
        }

        private void Btn_Z_Click(object sender, EventArgs e)
        {
            MulZ = !MulZ;
            if (MulZ) Btn_Z.ForeColor = Color.Black;
            else Btn_Z.ForeColor = Color.White;
        }
        #endregion

        private void CB_VectorLenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CB_VectorLenght.Text, out LengthVector))
            {
                freqCoefX = SamplingFrequency / LengthVector;
                Init_AllGraphs(LengthVector);
                Inc_RowsWorksheet1();
            }
            else
            {
                MessageBox.Show("Falha ao converter valor");
            }
        }

        private void TextBox_FS_TextChanged(object sender, EventArgs e)
        {
            float FS_act = SamplingFrequency;
            if (float.TryParse(textBox_FS.Text, out SamplingFrequency))
            {
                freqCoefX = SamplingFrequency / LengthVector;
                timeCoefX = 1 / SamplingFrequency;
                Init_AllGraphs(LengthVector);
                Inc_RowsWorksheet1();
            }
            else
            {
                MessageBox.Show("Valor deve ser numérico.");
                textBox_FS.Text = FS_act.ToString();
            }
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inc_RowsWorksheet1();
        }
    }
}