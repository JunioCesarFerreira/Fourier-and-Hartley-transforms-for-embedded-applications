namespace AnalisadorTresEixos
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_nova_planilha = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_VectorLenght = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status_COM = new System.Windows.Forms.Label();
            this.CB_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Porta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Abrir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.xyGraph4 = new componentXtra.XYGraph();
            this.xyGraph5 = new componentXtra.XYGraph();
            this.xyGraph6 = new componentXtra.XYGraph();
            this.xyGraph3 = new componentXtra.XYGraph();
            this.xyGraph2 = new componentXtra.XYGraph();
            this.xyGraph1 = new componentXtra.XYGraph();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Y = new System.Windows.Forms.Button();
            this.Btn_Z = new System.Windows.Forms.Button();
            this.Btn_X = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ods";
            this.saveFileDialog1.Filter = "All files  (*.ods*)|*.xls*|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados e configurações";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_load);
            this.groupBox4.Controls.Add(this.btn_Salvar);
            this.groupBox4.Controls.Add(this.btn_nova_planilha);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(1011, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 65);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Planilha";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_load.Location = new System.Drawing.Point(68, 19);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(53, 34);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(127, 19);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(54, 34);
            this.btn_Salvar.TabIndex = 9;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_nova_planilha
            // 
            this.btn_nova_planilha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nova_planilha.Location = new System.Drawing.Point(6, 19);
            this.btn_nova_planilha.Name = "btn_nova_planilha";
            this.btn_nova_planilha.Size = new System.Drawing.Size(56, 34);
            this.btn_nova_planilha.TabIndex = 8;
            this.btn_nova_planilha.Text = "Seq.";
            this.btn_nova_planilha.UseVisualStyleBackColor = false;
            this.btn_nova_planilha.Click += new System.EventHandler(this.btn_nova_planilha_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_FS);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.CB_VectorLenght);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(572, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parâmetros de conversão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sample/s";
            // 
            // textBox_FS
            // 
            this.textBox_FS.Location = new System.Drawing.Point(308, 27);
            this.textBox_FS.Name = "textBox_FS";
            this.textBox_FS.Size = new System.Drawing.Size(53, 20);
            this.textBox_FS.TabIndex = 5;
            this.textBox_FS.Text = "1140";
            this.textBox_FS.TextChanged += new System.EventHandler(this.textBox_FS_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taxa Amostragem:";
            // 
            // CB_VectorLenght
            // 
            this.CB_VectorLenght.FormattingEnabled = true;
            this.CB_VectorLenght.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "128",
            "256",
            "512",
            "1024"});
            this.CB_VectorLenght.Location = new System.Drawing.Point(118, 27);
            this.CB_VectorLenght.Name = "CB_VectorLenght";
            this.CB_VectorLenght.Size = new System.Drawing.Size(77, 21);
            this.CB_VectorLenght.TabIndex = 3;
            this.CB_VectorLenght.Text = "512";
            this.CB_VectorLenght.SelectedIndexChanged += new System.EventHandler(this.CB_VectorLenght_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tamanho do Vetor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Status_COM);
            this.groupBox1.Controls.Add(this.CB_Baud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CB_Porta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_Fechar);
            this.groupBox1.Controls.Add(this.bt_Abrir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "COM:";
            // 
            // Status_COM
            // 
            this.Status_COM.AutoSize = true;
            this.Status_COM.BackColor = System.Drawing.Color.Red;
            this.Status_COM.ForeColor = System.Drawing.Color.Maroon;
            this.Status_COM.Location = new System.Drawing.Point(362, 30);
            this.Status_COM.Name = "Status_COM";
            this.Status_COM.Size = new System.Drawing.Size(30, 13);
            this.Status_COM.TabIndex = 6;
            this.Status_COM.Text = "OFF";
            // 
            // CB_Baud
            // 
            this.CB_Baud.FormattingEnabled = true;
            this.CB_Baud.Location = new System.Drawing.Point(233, 27);
            this.CB_Baud.Name = "CB_Baud";
            this.CB_Baud.Size = new System.Drawing.Size(83, 21);
            this.CB_Baud.TabIndex = 5;
            this.CB_Baud.SelectedIndexChanged += new System.EventHandler(this.CB_Baud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAUD RATE:";
            // 
            // CB_Porta
            // 
            this.CB_Porta.FormattingEnabled = true;
            this.CB_Porta.Location = new System.Drawing.Point(66, 27);
            this.CB_Porta.Name = "CB_Porta";
            this.CB_Porta.Size = new System.Drawing.Size(73, 21);
            this.CB_Porta.TabIndex = 3;
            this.CB_Porta.SelectedIndexChanged += new System.EventHandler(this.CB_Porta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PORTA:";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Fechar.Location = new System.Drawing.Point(477, 19);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(76, 34);
            this.bt_Fechar.TabIndex = 1;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Abrir.Location = new System.Drawing.Point(398, 19);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(73, 34);
            this.bt_Abrir.TabIndex = 0;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = false;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(7, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1344, 625);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Recebidos";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1332, 600);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.xyGraph4);
            this.tabPage1.Controls.Add(this.xyGraph5);
            this.tabPage1.Controls.Add(this.xyGraph6);
            this.tabPage1.Controls.Add(this.xyGraph3);
            this.tabPage1.Controls.Add(this.xyGraph2);
            this.tabPage1.Controls.Add(this.xyGraph1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinais Tempo e Frequência";
            // 
            // xyGraph4
            // 
            this.xyGraph4.BackColor = System.Drawing.Color.Black;
            this.xyGraph4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph4.Location = new System.Drawing.Point(5, 468);
            this.xyGraph4.Name = "xyGraph4";
            this.xyGraph4.Size = new System.Drawing.Size(663, 234);
            this.xyGraph4.TabIndex = 8;
            this.xyGraph4.XtraAutoScale = true;
            this.xyGraph4.XtraClassicLabels = true;
            this.xyGraph4.XtraFrame = false;
            this.xyGraph4.XtraLabelX = "X-Title";
            this.xyGraph4.XtraLabelY = "Y-Title";
            this.xyGraph4.XtraLogX = false;
            this.xyGraph4.XtraLogY = false;
            this.xyGraph4.XtraMinLeftMargin = 0;
            this.xyGraph4.XtraSelectPoint = false;
            this.xyGraph4.XtraShowGrid = false;
            this.xyGraph4.XtraShowLegend = false;
            this.xyGraph4.XtraTitle = "XYGraph Title";
            this.xyGraph4.XtraUpdateCursor = true;
            this.xyGraph4.XtraXdigits = 0;
            this.xyGraph4.XtraXmax = 0F;
            this.xyGraph4.XtraXmin = 0F;
            this.xyGraph4.XtraXstep = 0F;
            this.xyGraph4.XtraYdigits = 0;
            this.xyGraph4.XtraYmax = 0F;
            this.xyGraph4.XtraYmin = 0F;
            this.xyGraph4.XtraYstep = 0F;
            // 
            // xyGraph5
            // 
            this.xyGraph5.BackColor = System.Drawing.Color.Black;
            this.xyGraph5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph5.Location = new System.Drawing.Point(5, 238);
            this.xyGraph5.Name = "xyGraph5";
            this.xyGraph5.Size = new System.Drawing.Size(663, 234);
            this.xyGraph5.TabIndex = 7;
            this.xyGraph5.XtraAutoScale = true;
            this.xyGraph5.XtraClassicLabels = true;
            this.xyGraph5.XtraFrame = false;
            this.xyGraph5.XtraLabelX = "X-Title";
            this.xyGraph5.XtraLabelY = "Y-Title";
            this.xyGraph5.XtraLogX = false;
            this.xyGraph5.XtraLogY = false;
            this.xyGraph5.XtraMinLeftMargin = 0;
            this.xyGraph5.XtraSelectPoint = false;
            this.xyGraph5.XtraShowGrid = false;
            this.xyGraph5.XtraShowLegend = false;
            this.xyGraph5.XtraTitle = "XYGraph Title";
            this.xyGraph5.XtraUpdateCursor = true;
            this.xyGraph5.XtraXdigits = 0;
            this.xyGraph5.XtraXmax = 0F;
            this.xyGraph5.XtraXmin = 0F;
            this.xyGraph5.XtraXstep = 0F;
            this.xyGraph5.XtraYdigits = 0;
            this.xyGraph5.XtraYmax = 0F;
            this.xyGraph5.XtraYmin = 0F;
            this.xyGraph5.XtraYstep = 0F;
            // 
            // xyGraph6
            // 
            this.xyGraph6.BackColor = System.Drawing.Color.Black;
            this.xyGraph6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph6.Location = new System.Drawing.Point(5, 6);
            this.xyGraph6.Name = "xyGraph6";
            this.xyGraph6.Size = new System.Drawing.Size(663, 234);
            this.xyGraph6.TabIndex = 6;
            this.xyGraph6.XtraAutoScale = true;
            this.xyGraph6.XtraClassicLabels = true;
            this.xyGraph6.XtraFrame = false;
            this.xyGraph6.XtraLabelX = "X-Title";
            this.xyGraph6.XtraLabelY = "Y-Title";
            this.xyGraph6.XtraLogX = false;
            this.xyGraph6.XtraLogY = false;
            this.xyGraph6.XtraMinLeftMargin = 0;
            this.xyGraph6.XtraSelectPoint = false;
            this.xyGraph6.XtraShowGrid = false;
            this.xyGraph6.XtraShowLegend = false;
            this.xyGraph6.XtraTitle = "XYGraph Title";
            this.xyGraph6.XtraUpdateCursor = true;
            this.xyGraph6.XtraXdigits = 0;
            this.xyGraph6.XtraXmax = 0F;
            this.xyGraph6.XtraXmin = 0F;
            this.xyGraph6.XtraXstep = 0F;
            this.xyGraph6.XtraYdigits = 0;
            this.xyGraph6.XtraYmax = 0F;
            this.xyGraph6.XtraYmin = 0F;
            this.xyGraph6.XtraYstep = 0F;
            // 
            // xyGraph3
            // 
            this.xyGraph3.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph3.Location = new System.Drawing.Point(674, 468);
            this.xyGraph3.Name = "xyGraph3";
            this.xyGraph3.Size = new System.Drawing.Size(675, 234);
            this.xyGraph3.TabIndex = 2;
            this.xyGraph3.XtraAutoScale = true;
            this.xyGraph3.XtraClassicLabels = true;
            this.xyGraph3.XtraFrame = false;
            this.xyGraph3.XtraLabelX = "X-Title";
            this.xyGraph3.XtraLabelY = "Y-Title";
            this.xyGraph3.XtraLogX = false;
            this.xyGraph3.XtraLogY = false;
            this.xyGraph3.XtraMinLeftMargin = 0;
            this.xyGraph3.XtraSelectPoint = false;
            this.xyGraph3.XtraShowGrid = false;
            this.xyGraph3.XtraShowLegend = false;
            this.xyGraph3.XtraTitle = "XYGraph Title";
            this.xyGraph3.XtraUpdateCursor = true;
            this.xyGraph3.XtraXdigits = 0;
            this.xyGraph3.XtraXmax = 0F;
            this.xyGraph3.XtraXmin = 0F;
            this.xyGraph3.XtraXstep = 0F;
            this.xyGraph3.XtraYdigits = 0;
            this.xyGraph3.XtraYmax = 0F;
            this.xyGraph3.XtraYmin = 0F;
            this.xyGraph3.XtraYstep = 0F;
            // 
            // xyGraph2
            // 
            this.xyGraph2.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph2.Location = new System.Drawing.Point(674, 238);
            this.xyGraph2.Name = "xyGraph2";
            this.xyGraph2.Size = new System.Drawing.Size(675, 234);
            this.xyGraph2.TabIndex = 1;
            this.xyGraph2.XtraAutoScale = true;
            this.xyGraph2.XtraClassicLabels = true;
            this.xyGraph2.XtraFrame = false;
            this.xyGraph2.XtraLabelX = "X-Title";
            this.xyGraph2.XtraLabelY = "Y-Title";
            this.xyGraph2.XtraLogX = false;
            this.xyGraph2.XtraLogY = false;
            this.xyGraph2.XtraMinLeftMargin = 0;
            this.xyGraph2.XtraSelectPoint = false;
            this.xyGraph2.XtraShowGrid = false;
            this.xyGraph2.XtraShowLegend = false;
            this.xyGraph2.XtraTitle = "XYGraph Title";
            this.xyGraph2.XtraUpdateCursor = true;
            this.xyGraph2.XtraXdigits = 0;
            this.xyGraph2.XtraXmax = 0F;
            this.xyGraph2.XtraXmin = 0F;
            this.xyGraph2.XtraXstep = 0F;
            this.xyGraph2.XtraYdigits = 0;
            this.xyGraph2.XtraYmax = 0F;
            this.xyGraph2.XtraYmin = 0F;
            this.xyGraph2.XtraYstep = 0F;
            // 
            // xyGraph1
            // 
            this.xyGraph1.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph1.Location = new System.Drawing.Point(674, 6);
            this.xyGraph1.Name = "xyGraph1";
            this.xyGraph1.Size = new System.Drawing.Size(675, 234);
            this.xyGraph1.TabIndex = 0;
            this.xyGraph1.XtraAutoScale = true;
            this.xyGraph1.XtraClassicLabels = true;
            this.xyGraph1.XtraFrame = false;
            this.xyGraph1.XtraLabelX = "X-Title";
            this.xyGraph1.XtraLabelY = "Y-Title";
            this.xyGraph1.XtraLogX = false;
            this.xyGraph1.XtraLogY = false;
            this.xyGraph1.XtraMinLeftMargin = 0;
            this.xyGraph1.XtraSelectPoint = false;
            this.xyGraph1.XtraShowGrid = false;
            this.xyGraph1.XtraShowLegend = false;
            this.xyGraph1.XtraTitle = "XYGraph Title";
            this.xyGraph1.XtraUpdateCursor = true;
            this.xyGraph1.XtraXdigits = 0;
            this.xyGraph1.XtraXmax = 0F;
            this.xyGraph1.XtraXmin = 0F;
            this.xyGraph1.XtraXstep = 0F;
            this.xyGraph1.XtraYdigits = 0;
            this.xyGraph1.XtraYmax = 0F;
            this.xyGraph1.XtraYmin = 0F;
            this.xyGraph1.XtraYstep = 0F;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 735);
            this.tabControl1.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_Y);
            this.groupBox5.Controls.Add(this.Btn_Z);
            this.groupBox5.Controls.Add(this.Btn_X);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(1207, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 65);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Multiplica Escala Espectro por 10";
            // 
            // Btn_Y
            // 
            this.Btn_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Y.Location = new System.Drawing.Point(47, 27);
            this.Btn_Y.Name = "Btn_Y";
            this.Btn_Y.Size = new System.Drawing.Size(33, 34);
            this.Btn_Y.TabIndex = 10;
            this.Btn_Y.Text = "Y";
            this.Btn_Y.UseVisualStyleBackColor = false;
            this.Btn_Y.Click += new System.EventHandler(this.Btn_Y_Click);
            // 
            // Btn_Z
            // 
            this.Btn_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Z.Location = new System.Drawing.Point(86, 27);
            this.Btn_Z.Name = "Btn_Z";
            this.Btn_Z.Size = new System.Drawing.Size(33, 34);
            this.Btn_Z.TabIndex = 9;
            this.Btn_Z.Text = "Z";
            this.Btn_Z.UseVisualStyleBackColor = false;
            this.Btn_Z.Click += new System.EventHandler(this.Btn_Z_Click);
            // 
            // Btn_X
            // 
            this.Btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_X.Location = new System.Drawing.Point(8, 27);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(33, 34);
            this.Btn_X.TabIndex = 8;
            this.Btn_X.Text = "X";
            this.Btn_X.UseVisualStyleBackColor = false;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1365, 737);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Analise Espectral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_nova_planilha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_VectorLenght;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status_COM;
        private System.Windows.Forms.ComboBox CB_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Porta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Abrir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private componentXtra.XYGraph xyGraph3;
        private componentXtra.XYGraph xyGraph2;
        private componentXtra.XYGraph xyGraph1;
        private System.Windows.Forms.TabControl tabControl1;
        private componentXtra.XYGraph xyGraph4;
        private componentXtra.XYGraph xyGraph5;
        private componentXtra.XYGraph xyGraph6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Y;
        private System.Windows.Forms.Button Btn_Z;
        private System.Windows.Forms.Button Btn_X;
    }
}

