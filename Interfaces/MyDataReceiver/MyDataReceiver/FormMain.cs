using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyDataReceiver
{
    public partial class FormMain : Form
    {
        #region Variaveis e objetos
        // Objeto SerialComPort - hipe
        private readonly SerialPort SerialComPort = new SerialPort();     

        // Variaveis para representação gráfico XY
        float eixo_x = 0;
        float eixo_y = 0;

        // Buffer de recepção serial
        string ResultadoBuffer = string.Empty;
        public delegate void FundDelegate(string a);
        string Data_Process="0"; // Auxilia no processo de atualização dos gráficos

        // Comprimento dos vetores
        int VL=128;
        // Frequencia de amostragem
        float FS=1000;
        // Coeficientes de conversão
        float CoefX1 = (float)(1000/128), CoefY1 = (float)(0.01), CoefX2 = (float)(0.001), CoefY2 = (float)(0.01);

        // Arquivos de planilhas
        readonly ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
        readonly ExcelLibrary.SpreadSheet.Worksheet worksheet1 = new ExcelLibrary.SpreadSheet.Worksheet("Configurações");
        readonly ExcelLibrary.SpreadSheet.Worksheet worksheet2 = new ExcelLibrary.SpreadSheet.Worksheet("Resultados");
        int Linha = 1, Coluna=0; // Obs.: Linha utilizada na worksheet1 e Coluna utilizada na worksheet2
        bool res_seq = false; // Habilita a geração de planilhas com todos os resultados recebidos
        #endregion

        public FormMain()
        {
            InitializeComponent();
            SerialComPort.DataReceived += new SerialDataReceivedEventHandler(SerialComPort_DataReceived);
        }

        #region Set Graph
        private void Set_Graph1(float L)
        {
            xyGraph1.XtraXmax = FS/2;
            xyGraph1.XtraXmin = 0;//-FS/2;
            xyGraph1.XtraYmax = 1;
            xyGraph1.XtraYmin = 0;
            xyGraph1.Validate(true);
            xyGraph1.XtraShowGrid = true;
        }

        private void Set_Graph2(float L)
        {
            xyGraph2.XtraXmin = 0;
            xyGraph2.XtraXmax = L*(1/FS);
            xyGraph2.XtraYmax = 2;
            xyGraph2.XtraYmin = -2;
            xyGraph2.Validate(true);
            xyGraph2.XtraShowGrid = true;
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
            xyGraph1.XtraLabelX = "Frequência (Hz)";
            xyGraph1.XtraLabelY = "|F(w)|";
            xyGraph1.XtraTitle = "Espectro de Frequências";
            xyGraph1.XtraAutoScale = false;
            Set_Graph1(70);
            #endregion

            #region Inicializa Graph 2
            xyGraph2.AddGraph("XtraTitle", DashStyle.Solid, Color.White, 1, false);
            xyGraph2.XtraLabelX = "Tempo (s)";
            xyGraph2.XtraLabelY = "Amplitude (V)";
            xyGraph2.XtraTitle = "Sinal de entrada";
            xyGraph2.XtraAutoScale = false;
            Set_Graph2(140);
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

            CB_VectorLenght.SelectedIndex = 3;

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
                if (a.Substring(0,2)=="E:") // Verifica inicio de pacote de dados
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
            float[] OutGraph_t = new float[VL];             // Vetor do espectro no tempo
            float[] OutGraph_F = new float[VL];         // Vetor de espectro de frenquencias
            int index = 0;                                  // Indexador, guarda indece no tratamento do protocolo de recebimento 

            #region Verifica Extremidades do pacote de dados
            for (int i=0; i < Txt_Received.Length; i++)
            {
                if (arraybytes[i] == 'E' || arraybytes[i] == 'S' || arraybytes[i] == ';') index++;
            }

            if (index != 4) return;
            index = 0;
            #endregion

            textBox2.Text = "[";

            #region Converte_Vetor_Entrada
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'E')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            // Converte dados entre []
            int n = 0; // Indexador do vetor de float
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
                        textBox2.Text += Aux + " ";
                        OutGraph_t[n] = float.Parse(Aux);
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }
            textBox2.Text += "]";
            // Limpa gráfico
            xyGraph2.ClearGraphs(); 
            // Carrega valores para o gráfico
            for (n = 0; n < VL; n++)
            {
                eixo_y = OutGraph_t[n]*CoefY2;
                eixo_x = n * (1 / FS);
                xyGraph2.AddValue(0, eixo_x, eixo_y);
                xyGraph2.DrawAll();
            }
            #endregion

            #region Converte_Vetor_Saida
            index =0;
            for (int i = 0; i < Txt_Received.Length; i++)
            {
                index = i;
                if (arraybytes[i] == 'S')
                {
                    i++;
                    if (arraybytes[i] == ':') break;
                }
            }
            n=0;
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
                        OutGraph_F[n] = float.Parse(Aux);
                        n++;
                    }
                }
                if (arraybytes[i] == ';') break;
            }

            // Insere valores no gráfico
            xyGraph1.ClearGraphs();
            for (n = 0; n < (VL/2); n++)
            {
                eixo_y = OutGraph_F[n]*CoefY1;
                eixo_x = n*CoefX1;
                xyGraph1.AddValue(0, eixo_x, eixo_y);
                xyGraph1.DrawAll();
            }
            #endregion

            #region Gera Planilha
            if (res_seq)
            {
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Tempo");
                worksheet2.Cells[0, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell("Sinal");
                for (index = 0; index < VL; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(index));
                    worksheet2.Cells[index + 1, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_t[index]));
                }
                Coluna += 2;
                worksheet2.Cells[0, Coluna] = new ExcelLibrary.SpreadSheet.Cell("Frequencia");
                worksheet2.Cells[0, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell("Espectro");
                for (index = 0; index < VL / 2; index++)
                {
                    worksheet2.Cells[index + 1, Coluna] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(CoefX1*index));
                    worksheet2.Cells[index + 1, Coluna+1] = new ExcelLibrary.SpreadSheet.Cell(Convert.ToDecimal(OutGraph_F[index]));
                }
                Coluna+=2;
            }
            #endregion
        }

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
                Set_Graph1(VL / 2);
                Set_Graph2(VL);
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
                Set_Graph1(VL / 2);
                Set_Graph2(VL);
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
        #endregion
    }
}
