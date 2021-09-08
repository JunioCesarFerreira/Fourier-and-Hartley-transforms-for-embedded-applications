using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing.Drawing2D;

namespace AnalisadorTresEixos
{
    public partial class FormMain : Form
    {
        #region Variaveis e objetos
        // Objeto SerialComPort - hipe
        SerialPort SerialComPort = new SerialPort();     

        // Buffer de recepção serial
        string ResultadoBuffer = string.Empty;
        public delegate void FundDelegate(string a);
        String Data_Process="0"; // Auxilia no processo de atualização dos gráficos

        // Comprimento dos vetores
        int VL=512;
        // Frequencia de amostragem
        float FS=1140;
        // Coeficientes de conversão
        float CoefX1 = (float)(1140 / 256), CoefY1 = (float)(0.01), CoefX2 = (float)(0.001), CoefY2 = (float)(0.01);
        bool MulX = false, MulY = false, MulZ = false;

        // Arquivos de planilhas
        ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
        ExcelLibrary.SpreadSheet.Worksheet worksheet1 = new ExcelLibrary.SpreadSheet.Worksheet("Configurações");
        ExcelLibrary.SpreadSheet.Worksheet worksheet2 = new ExcelLibrary.SpreadSheet.Worksheet("Resultados");
        int Linha = 1, Coluna=0; // Obs.: Linha utilizada na worksheet1 e Coluna utilizada na worksheet2
        bool res_seq = false; // Habilita a geração de planilhas com todos os resultados recebidos
        #endregion

        public FormMain()
        {
            InitializeComponent();
            SerialComPort.DataReceived += new SerialDataReceivedEventHandler(SerialComPort_DataReceived);
        }

        #region Set Graph
        private void Set_Graph1()
        {
            xyGraph1.XtraXmax = FS/2;
            xyGraph1.XtraXmin = 0;
            xyGraph1.XtraYmax = 1;
            xyGraph1.XtraYmin = 0;
            xyGraph1.Validate(true);
            xyGraph1.XtraShowGrid = true;
        }

        private void Set_Graph2()
        {
            xyGraph2.XtraXmax = FS / 2;
            xyGraph2.XtraXmin = 0;
            xyGraph2.XtraYmax = 1;
            xyGraph2.XtraYmin = 0;
            xyGraph2.Validate(true);
            xyGraph2.XtraShowGrid = true;
        }

        private void Set_Graph3()
        {
            xyGraph3.XtraXmax = FS / 2;
            xyGraph3.XtraXmin = 0;
            xyGraph3.XtraYmax = 1;
            xyGraph3.XtraYmin = 0;
            xyGraph3.Validate(true);
            xyGraph3.XtraShowGrid = true;
        }

        private void Set_Graph4(float L)
        {
            xyGraph4.XtraXmin = 0;
            xyGraph4.XtraXmax = L * (1 / FS);
            xyGraph4.XtraYmax = 2;
            xyGraph4.XtraYmin = -2;
            xyGraph4.Validate(true);
            xyGraph4.XtraShowGrid = true;
        }

        private void Set_Graph5(float L)
        {
            xyGraph5.XtraXmin = 0;
            xyGraph5.XtraXmax = L * (1 / FS);
            xyGraph5.XtraYmax = 2;
            xyGraph5.XtraYmin = -2;
            xyGraph5.Validate(true);
            xyGraph5.XtraShowGrid = true;
        }

        private void Set_Graph6(float L)
        {
            xyGraph6.XtraXmin = 0;
            xyGraph6.XtraXmax = L * (1 / FS);
            xyGraph6.XtraYmax = 2;
            xyGraph6.XtraYmin = -2;
            xyGraph6.Validate(true);
            xyGraph6.XtraShowGrid = true;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Inicializa Pagina de configuração da Planilha
            worksheet1.Cells[0, 0] = new ExcelLibrary.SpreadSheet.Cell("PORTA");
            worksheet1.Cells[0, 1] = new ExcelLibrary.SpreadSheet.Cell("BAUD RATE (bps)");
            worksheet1.Cells[0, 2] = new ExcelLibrary.SpreadSheet.Cell("Tamanho Vetor");
            worksheet1.Cells[0, 3] = new ExcelLibrary.SpreadSheet.Cell("Amostragem(Smp/s)");
            worksheet1.Cells[0, 4] = new ExcelLibrary.SpreadSheet.Cell("Data");
            for (ushort i = 0; i < 5; i++) worksheet1.Cells.ColumnWidth[i] = 5000;
            #endregion

            #region Inicializa Graph 1
            xyGraph1.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph1.XtraLabelX = "";
            xyGraph1.XtraLabelY = "";
            xyGraph1.XtraTitle = "Espectro de Frequências (Hz) Eixo X";
            xyGraph1.XtraAutoScale = false;
            Set_Graph1();
            #endregion

            #region Inicializa Graph 2
            xyGraph2.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph2.XtraLabelX = "";
            xyGraph2.XtraLabelY = "";
            xyGraph2.XtraTitle = "Espectro de Frequências (Hz) Eixo Y";
            xyGraph2.XtraAutoScale = false;
            Set_Graph2();
            #endregion

            #region Inicializa Graph 3
            xyGraph3.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph3.XtraLabelX = "";
            xyGraph3.XtraLabelY = "";
            xyGraph3.XtraTitle = "Espectro de Frequências (Hz) Eixo Z";
            xyGraph3.XtraAutoScale = false;
            Set_Graph3();
            #endregion

            #region Inicializa Graph 4
            xyGraph4.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph4.XtraLabelX = "";
            xyGraph4.XtraLabelY = "";
            xyGraph4.XtraTitle = "Sinal tempo (s) Eixo Z";
            xyGraph4.XtraAutoScale = false;
            Set_Graph4(70);
            #endregion

            #region Inicializa Graph 5
            xyGraph5.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph5.XtraLabelX = "";
            xyGraph5.XtraLabelY = "";
            xyGraph5.XtraTitle = "Sinal tempo (s) Eixo Y";
            xyGraph5.XtraAutoScale = false;
            Set_Graph5(70);
            #endregion

            #region Inicializa Graph 6
            xyGraph6.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph6.XtraLabelX = "";
            xyGraph6.XtraLabelY = "";
            xyGraph6.XtraTitle = "Sinal tempo (s) Eixo X";
            xyGraph6.XtraAutoScale = false;
            Set_Graph6(70);
            #endregion

            #region Status Conect
            Status_COM.ForeColor = Color.Red;
            Status_COM.BackColor = Color.DarkRed;
            Status_COM.Text = "OFF";
            bt_Fechar.Enabled = false;
            #endregion

            #region Configuração Serial do Terminal
            String[] ListCom = SerialPort.GetPortNames();

            string NameCom;
            int x = 0;
            for (int i = 0; i < ListCom.Length; i++)
            {

                NameCom = ListCom[i];
                CB_Porta.Items.Add(NameCom);
                if (NameCom == "COM1")
                {
                    x = i;
                }
            }
            if (ListCom.Length > 0)
                CB_Porta.SelectedIndex = x;
            #endregion

            #region Carrega valores de BaudRate no ComboBox
            Int32[] BaudRateValores = { 100,300,600,1200,2400,4800,9600,14400,19200,
                                        38400,56000,57600,115200,128000,256000
                                       };
            int x1 = 0;
            for (int i = 0; i < BaudRateValores.Length; i++)
            {
                CB_Baud.Items.Add(BaudRateValores[i].ToString());
                if (BaudRateValores[i] == 115200)
                {
                    x1 = i;
                }
            }
            CB_Baud.SelectedIndex = x1;
            #endregion

            textBox_FS_TextChanged(sender,e);    // Atualiza FS

            CB_VectorLenght.SelectedIndex = 5;   // Comprimento dos vetores

            timer1.Interval = 200;
        }

        // Recebe dados da serial
        void SerialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                ResultadoBuffer = SerialComPort.ReadExisting();
                FundDelegate EnviaTextBox = new FundDelegate(EscreveTXT);
                EnviaTextBox.Invoke(ResultadoBuffer);
            }
            catch { }
            //FundDelegate EnviaDecodificar = new FundDelegate(Trata_Dados);
            //EnviaDecodificar.Invoke(ResultadoBuffer);
        }

        // Escreve testo recebido na interface
        public void EscreveTXT(string a)
        {
            if (this.textBox1.InvokeRequired)
            {
                FundDelegate d = new FundDelegate(EscreveTXT);
                this.Invoke(d, new object[] { a });
            }
            else
            {
                if (a.Substring(0,2)=="x:") // Verifica inicio de pacote de dados
                {
                    Data_Process = textBox1.Text; 
                    this.textBox1.Text = a;
                }else
                {
                    this.textBox1.Text += a;
                }
            }
        }

        // Temporizador de atualização dos gráficos
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               Trata_Dados(Data_Process);
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString());
            }
        }

        // Verifica e trata protocolo de recebimento dos dados
        private void Trata_Dados(String Txt_Received)
        {
            Char[] arraybytes = Txt_Received.ToCharArray(); // Converte Texto recebido em Array de Bytes
            String Aux;                                     // String Auxiliar na conversão de texto em float
            float[] OutGraph_X = new float[VL / 2];
            float[] OutGraph_Y = new float[VL / 2];
            float[] OutGraph_Z = new float[VL / 2]; 
            float[] OutGraph_x = new float[VL];
            float[] OutGraph_y = new float[VL];
            float[] OutGraph_z = new float[VL];
            float Maior = 1, Menor = 0;
            int index = 0;                                  // Indexador, guarda indece no tratamento do protocolo de recebimento 
            int n = 0;                                      // Indexador do vetor de float

            #region Verifica Extremidades do pacote de dados
            for (int i=0; i < Txt_Received.Length; i++)
            {
                if (arraybytes[i] == 'x' || arraybytes[i] == 'y' || arraybytes[i] == 'z'
                 || arraybytes[i] == 'X' || arraybytes[i] == 'Y' || arraybytes[i] == 'Z' 
                 || arraybytes[i] == ';') index++;
            }

            if (index != 12) return;
            index = 0;
            #endregion

            #region Converte_Vetor_Entrada_x
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'x')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            // Converte dados entre []
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux = "";
                if (arraybytes[i] == '[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL)
                    {
                        OutGraph_x[n] = float.Parse(Aux) * CoefY2;
                        if (OutGraph_x[n] > Maior) Maior = OutGraph_x[n];
                        if (OutGraph_x[n] < Menor) Menor = OutGraph_x[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph6.XtraYmax = Maior;
            xyGraph6.XtraYmin = Menor;
            // Limpa gráfico
            xyGraph6.ClearGraphs();
            // Carrega valores para o gráfico
            for (n = 0; n < VL; n++)
            {
                xyGraph6.AddValue(0, n * (1 / FS), OutGraph_x[n]);
                xyGraph6.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Entrada_y
            Maior = 1; Menor = 0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'y')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            // Converte dados entre []
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux = "";
                if (arraybytes[i] == '[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL)
                    {
                        OutGraph_y[n] = float.Parse(Aux) * CoefY2;
                        if (OutGraph_y[n] > Maior) Maior = OutGraph_y[n];
                        if (OutGraph_y[n] < Menor) Menor = OutGraph_y[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph5.XtraYmax = Maior;
            xyGraph5.XtraYmin = Menor;
            // Limpa gráfico
            xyGraph5.ClearGraphs();
            // Carrega valores para o gráfico
            for (n = 0; n < VL; n++)
            {
                xyGraph5.AddValue(0, n * (1 / FS), OutGraph_y[n]);
                xyGraph5.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Entrada_z
            Maior = 1; Menor = 0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'z')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            // Converte dados entre []
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux = "";
                if (arraybytes[i] == '[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL)
                    {
                        OutGraph_z[n] = float.Parse(Aux) * CoefY2;
                        if (OutGraph_z[n] > Maior) Maior = OutGraph_z[n];
                        if (OutGraph_z[n] < Menor) Menor = OutGraph_z[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph4.XtraYmax = Maior;
            xyGraph4.XtraYmin = Menor;
            // Limpa gráfico
            xyGraph4.ClearGraphs();
            // Carrega valores para o gráfico
            for (n = 0; n < VL; n++)
            {
                xyGraph4.AddValue(0, n * (1 / FS), OutGraph_z[n]);
                xyGraph4.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Eixo_X
            Maior = 1; Menor = 0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'X')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux="";
                if (arraybytes[i]=='[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL/2)
                    {
                        OutGraph_X[n] = float.Parse(Aux) * CoefY1;
                        if (MulX) OutGraph_X[n] *= 10;
                        if (OutGraph_X[n] > Maior) Maior = OutGraph_X[n];
                        if (OutGraph_X[n] < Menor) Menor = OutGraph_X[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph1.XtraYmax = Maior;
            xyGraph1.XtraYmin = Menor;
            // Insere valores no gráfico
            xyGraph1.ClearGraphs();
            for (n = 0; n < (VL/2); n++)
            {
                xyGraph1.AddValue(0, n*CoefX1, OutGraph_X[n]);
                xyGraph1.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Eixo_Y
            Maior = 1; Menor = 0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'Y')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux = "";
                if (arraybytes[i] == '[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL / 2)
                    {
                        OutGraph_Y[n] = float.Parse(Aux)*CoefY1;
                        if (MulY) OutGraph_Y[n] *= 10;
                        if (OutGraph_Y[n] > Maior) Maior = OutGraph_Y[n];
                        if (OutGraph_Y[n] < Menor) Menor = OutGraph_Y[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph2.XtraYmax = Maior;
            xyGraph2.XtraYmin = Menor;
            // Insere valores no gráfico
            xyGraph2.ClearGraphs();
            for (n = 0; n < (VL / 2); n++)
            {
                xyGraph2.AddValue(0, n * CoefX1, OutGraph_Y[n]);
                xyGraph2.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Eixo_Z
            Maior = 1; Menor = 0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'Z')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n = 0;
            for (int i = index; i < Txt_Received.Length; i++)
            {
                Aux = "";
                if (arraybytes[i] == '[')
                {
                    i++;
                    for (; i < Txt_Received.Length; i++)
                    {
                        if (arraybytes[i] == ']') break;
                        Aux += arraybytes[i];
                    }
                    if (n < VL / 2)
                    {
                        OutGraph_Z[n] = float.Parse(Aux)*CoefY1;
                        if (MulZ) OutGraph_Z[n] *= 10;
                        if (OutGraph_Z[n] > Maior) Maior = OutGraph_Z[n];
                        if (OutGraph_Z[n] < Menor) Menor = OutGraph_Z[n];
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            // Adequa gráfico
            xyGraph3.XtraYmax = Maior;
            xyGraph3.XtraYmin = Menor;
            // Insere valores no gráfico
            xyGraph3.ClearGraphs();
            for (n = 0; n < (VL / 2); n++)
            {
                xyGraph3.AddValue(0, n * CoefX1, OutGraph_Z[n]);
                xyGraph3.DrawAll();
            }
            #endregion  

            #region Gera Planilha

            if (res_seq)
            {
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Temp");
                worksheet2.Cells[0, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell("Sinal x");
                for (index = 0; index < VL; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(index));
                    worksheet2.Cells[index + 1, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_x[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Frequencia");
                worksheet2.Cells[0, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell("Espectro X");
                for (index = 0; index < VL / 2; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(CoefX1*index));
                    worksheet2.Cells[index + 1, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_X[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Temp");
                worksheet2.Cells[0, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell("Sinal y");
                for (index = 0; index < VL; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(index));
                    worksheet2.Cells[index + 1, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_y[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Frequencia");
                worksheet2.Cells[0, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell("Espectro Y");
                for (index = 0; index < VL / 2; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(CoefX1 * index));
                    worksheet2.Cells[index + 1, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_Y[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Temp");
                worksheet2.Cells[0, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell("Sinal z");
                for (index = 0; index < VL; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(index));
                    worksheet2.Cells[index + 1, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_z[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Frequencia");
                worksheet2.Cells[0, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell("Espectro Z");
                for (index = 0; index < VL / 2; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(CoefX1 * index));
                    worksheet2.Cells[index + 1, Coluna + 1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_Z[index]));
                }
                Coluna+=2;
            }

            #endregion
        }

        #region Botões
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (!res_seq)
            {
                //MessageBox.Show("Não há dados na planilha, você não ativou a gravação.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                res_seq = true;
                Trata_Dados(textBox1.Text);
                Insere_Confg_Excel();
                res_seq = false;
            }

            DialogResult result;
            saveFileDialog1.FileName = "Resultados";
            result = saveFileDialog1.ShowDialog();
            string local = saveFileDialog1.FileName.ToString();

            if (result != DialogResult.Cancel)
            {
                try
                {
                    Insere_Confg_Excel();
                    workbook.Worksheets.Add(worksheet1);
                    workbook.Worksheets.Add(worksheet2);
                    workbook.Save(local);
                }
                catch
                {
                    workbook.Worksheets.Remove(worksheet1);
                    workbook.Worksheets.Remove(worksheet2);
                    MessageBox.Show("Não foi Possível Salvar o Arquivo!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_nova_planilha_Click(object sender, EventArgs e)
        {
            if (res_seq)
            {
                MessageBox.Show("O modo sequencial já está ativo, salve a planilha e reinicie o programa para gerar uma nova planilha.",
                    "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            res_seq = true;
            Insere_Confg_Excel();
        }

        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            try
            {
                SerialComPort.PortName = CB_Porta.Text;
                SerialComPort.BaudRate = Int32.Parse(CB_Baud.Text);
                SerialComPort.DataBits = 8;

                SerialComPort.WriteTimeout = 1000;
                SerialComPort.ReadTimeout = 1000;
                System.Text.ASCIIEncoding AsCII = new System.Text.ASCIIEncoding();
                SerialComPort.Encoding = AsCII;

                SerialComPort.Open();
                timer1.Enabled = true;
                Status_COM.ForeColor = Color.LightGreen;
                Status_COM.BackColor = Color.DarkGreen;
                Status_COM.Text = "ON";
                bt_Fechar.Enabled = true;
                bt_Abrir.Enabled = false;
            }
            catch
            {

                MessageBox.Show("Falha: verifique sua conexão COM");
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            try
            {
                while (SerialComPort.BytesToWrite > 0) ;
                timer1.Enabled = false;   // Desativa temporizador vinculado a atualização dos dados 
                SerialComPort.Dispose();  // Fecha a porta e libera o recurso da memória
                SerialComPort.Close();    // Fecha a porta COM
                // Muda status na interface
                Status_COM.ForeColor = Color.Red;
                Status_COM.BackColor = Color.DarkRed;
                Status_COM.Text = "OFF";
                bt_Abrir.Enabled = true;
                bt_Fechar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Falha ao encerrar COM");
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            string local = openFileDialog1.FileName.ToString();
            if (result != DialogResult.Cancel)
            {
                try
                {

                }
                catch
                {
                    MessageBox.Show("Não foi Possível abrir o Arquivo!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void Btn_X_Click(object sender, EventArgs e)
        {
            MulX = !MulX;
            if (MulX)
            {
                Btn_X.ForeColor = Color.Black;
            }
            else
            {
                Btn_X.ForeColor = Color.White;
            }
        }

        private void Btn_Y_Click(object sender, EventArgs e)
        {
            MulY = !MulY;
            if (MulY)
            {
                Btn_Y.ForeColor = Color.Black;
            }
            else
            {
                Btn_Y.ForeColor = Color.White;
            }
        }

        private void Btn_Z_Click(object sender, EventArgs e)
        {
            MulZ = !MulZ;
            if (MulZ)
            {
                Btn_Z.ForeColor = Color.Black;
            }
            else
            {
                Btn_Z.ForeColor = Color.White;
            }
        }
        #endregion

        #region Parâmetros de entrada
        private void Insere_Confg_Excel()
        {
            if (res_seq)
            {
                worksheet1.Cells[Linha, 0] = new ExcelLibrary.SpreadSheet.Cell(CB_Porta.Text);
                worksheet1.Cells[Linha, 1] = new ExcelLibrary.SpreadSheet.Cell(CB_Baud.Text);
                worksheet1.Cells[Linha, 2] = new ExcelLibrary.SpreadSheet.Cell(CB_VectorLenght.Text);
                worksheet1.Cells[Linha, 3] = new ExcelLibrary.SpreadSheet.Cell(textBox_FS.Text);
                worksheet1.Cells[Linha, 4] = new ExcelLibrary.SpreadSheet.Cell(DateTime.Now.ToString());
                Linha++;
            }
        }

        private void CB_VectorLenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VL = int.Parse(CB_VectorLenght.Text);
                CoefX1 = FS / VL;
                Set_Graph1();
                Set_Graph2();
                Set_Graph3();
                Set_Graph4(VL);
                Set_Graph5(VL);
                Set_Graph6(VL);
                Insere_Confg_Excel();
            }
            catch
            {
                MessageBox.Show("Falha ao converter valor");
            }
        }

        private void textBox_FS_TextChanged(object sender, EventArgs e)
        {
            float FS_act = FS;
            try
            {
                FS = float.Parse(textBox_FS.Text);
                CoefX1 = FS / VL;
                CoefX2 = 1 / FS;
                Set_Graph1();
                Set_Graph2();
                Set_Graph3();
                Set_Graph4(VL);
                Set_Graph5(VL);
                Set_Graph6(VL);
                Insere_Confg_Excel();
            }
            catch
            {
                MessageBox.Show("Falha! Valor deve ser numerico");
                textBox_FS.Text = FS_act.ToString();
            }
        }

        private void CB_Porta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insere_Confg_Excel();
        }

        private void CB_Baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insere_Confg_Excel();
        }
        #endregion
    }
}
