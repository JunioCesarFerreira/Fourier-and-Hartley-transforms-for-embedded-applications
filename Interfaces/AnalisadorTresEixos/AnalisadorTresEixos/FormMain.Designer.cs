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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Y = new System.Windows.Forms.Button();
            this.Btn_Z = new System.Windows.Forms.Button();
            this.Btn_X = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Seq = new System.Windows.Forms.Button();
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
            this.Button_SerialClose = new System.Windows.Forms.Button();
            this.Button_SerialOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_DataReceived = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xyGraph_FZ = new componentXtra.XYGraph();
            this.xyGraph_x = new componentXtra.XYGraph();
            this.xyGraph_FX = new componentXtra.XYGraph();
            this.xyGraph_z = new componentXtra.XYGraph();
            this.xyGraph_y = new componentXtra.XYGraph();
            this.xyGraph_FY = new componentXtra.XYGraph();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_Save);
            this.groupBox4.Controls.Add(this.Button_Seq);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(1011, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 65);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Planilha";
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Save.Location = new System.Drawing.Point(127, 19);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(54, 34);
            this.Button_Save.TabIndex = 9;
            this.Button_Save.Text = "Salvar";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Seq
            // 
            this.Button_Seq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Seq.Location = new System.Drawing.Point(6, 19);
            this.Button_Seq.Name = "Button_Seq";
            this.Button_Seq.Size = new System.Drawing.Size(56, 34);
            this.Button_Seq.TabIndex = 8;
            this.Button_Seq.Text = "Seq.";
            this.Button_Seq.UseVisualStyleBackColor = false;
            this.Button_Seq.Click += new System.EventHandler(this.Button_Seq_Click);
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
            this.textBox_FS.TextChanged += new System.EventHandler(this.TextBox_FS_TextChanged);
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
            this.groupBox1.Controls.Add(this.Button_SerialClose);
            this.groupBox1.Controls.Add(this.Button_SerialOpen);
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
            this.CB_Baud.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
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
            this.CB_Porta.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
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
            // Button_SerialClose
            // 
            this.Button_SerialClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SerialClose.Location = new System.Drawing.Point(477, 19);
            this.Button_SerialClose.Name = "Button_SerialClose";
            this.Button_SerialClose.Size = new System.Drawing.Size(76, 34);
            this.Button_SerialClose.TabIndex = 1;
            this.Button_SerialClose.Text = "Fechar";
            this.Button_SerialClose.UseVisualStyleBackColor = false;
            this.Button_SerialClose.Click += new System.EventHandler(this.Button_SerialClose_Click);
            // 
            // Button_SerialOpen
            // 
            this.Button_SerialOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SerialOpen.Location = new System.Drawing.Point(398, 19);
            this.Button_SerialOpen.Name = "Button_SerialOpen";
            this.Button_SerialOpen.Size = new System.Drawing.Size(73, 34);
            this.Button_SerialOpen.TabIndex = 0;
            this.Button_SerialOpen.Text = "Abrir";
            this.Button_SerialOpen.UseVisualStyleBackColor = false;
            this.Button_SerialOpen.Click += new System.EventHandler(this.Button_SerialOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TextBox_DataReceived);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(7, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1344, 625);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Recebidos";
            // 
            // TextBox_DataReceived
            // 
            this.TextBox_DataReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_DataReceived.BackColor = System.Drawing.SystemColors.MenuText;
            this.TextBox_DataReceived.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBox_DataReceived.Location = new System.Drawing.Point(6, 19);
            this.TextBox_DataReceived.Multiline = true;
            this.TextBox_DataReceived.Name = "TextBox_DataReceived";
            this.TextBox_DataReceived.Size = new System.Drawing.Size(1332, 600);
            this.TextBox_DataReceived.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinais Tempo e Frequência";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_FZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_x, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_FX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_z, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_y, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.xyGraph_FY, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1349, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // xyGraph_FZ
            // 
            this.xyGraph_FZ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_FZ.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph_FZ.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_FZ.Location = new System.Drawing.Point(674, 468);
            this.xyGraph_FZ.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_FZ.Name = "xyGraph_FZ";
            this.xyGraph_FZ.Size = new System.Drawing.Size(675, 234);
            this.xyGraph_FZ.TabIndex = 2;
            this.xyGraph_FZ.XtraAutoScale = true;
            this.xyGraph_FZ.XtraClassicLabels = true;
            this.xyGraph_FZ.XtraFrame = false;
            this.xyGraph_FZ.XtraLabelX = "X-Title";
            this.xyGraph_FZ.XtraLabelY = "Y-Title";
            this.xyGraph_FZ.XtraLogX = false;
            this.xyGraph_FZ.XtraLogY = false;
            this.xyGraph_FZ.XtraMinLeftMargin = 0;
            this.xyGraph_FZ.XtraSelectPoint = false;
            this.xyGraph_FZ.XtraShowGrid = false;
            this.xyGraph_FZ.XtraShowLegend = false;
            this.xyGraph_FZ.XtraTitle = "XYGraph Title";
            this.xyGraph_FZ.XtraUpdateCursor = true;
            this.xyGraph_FZ.XtraXdigits = 0;
            this.xyGraph_FZ.XtraXmax = 0F;
            this.xyGraph_FZ.XtraXmin = 0F;
            this.xyGraph_FZ.XtraXstep = 0F;
            this.xyGraph_FZ.XtraYdigits = 0;
            this.xyGraph_FZ.XtraYmax = 0F;
            this.xyGraph_FZ.XtraYmin = 0F;
            this.xyGraph_FZ.XtraYstep = 0F;
            // 
            // xyGraph_x
            // 
            this.xyGraph_x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_x.BackColor = System.Drawing.Color.Black;
            this.xyGraph_x.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_x.Location = new System.Drawing.Point(0, 0);
            this.xyGraph_x.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_x.Name = "xyGraph_x";
            this.xyGraph_x.Size = new System.Drawing.Size(674, 234);
            this.xyGraph_x.TabIndex = 6;
            this.xyGraph_x.XtraAutoScale = true;
            this.xyGraph_x.XtraClassicLabels = true;
            this.xyGraph_x.XtraFrame = false;
            this.xyGraph_x.XtraLabelX = "X-Title";
            this.xyGraph_x.XtraLabelY = "Y-Title";
            this.xyGraph_x.XtraLogX = false;
            this.xyGraph_x.XtraLogY = false;
            this.xyGraph_x.XtraMinLeftMargin = 0;
            this.xyGraph_x.XtraSelectPoint = false;
            this.xyGraph_x.XtraShowGrid = false;
            this.xyGraph_x.XtraShowLegend = false;
            this.xyGraph_x.XtraTitle = "XYGraph Title";
            this.xyGraph_x.XtraUpdateCursor = true;
            this.xyGraph_x.XtraXdigits = 0;
            this.xyGraph_x.XtraXmax = 0F;
            this.xyGraph_x.XtraXmin = 0F;
            this.xyGraph_x.XtraXstep = 0F;
            this.xyGraph_x.XtraYdigits = 0;
            this.xyGraph_x.XtraYmax = 0F;
            this.xyGraph_x.XtraYmin = 0F;
            this.xyGraph_x.XtraYstep = 0F;
            // 
            // xyGraph_FX
            // 
            this.xyGraph_FX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_FX.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph_FX.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_FX.Location = new System.Drawing.Point(674, 0);
            this.xyGraph_FX.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_FX.Name = "xyGraph_FX";
            this.xyGraph_FX.Size = new System.Drawing.Size(675, 234);
            this.xyGraph_FX.TabIndex = 0;
            this.xyGraph_FX.XtraAutoScale = true;
            this.xyGraph_FX.XtraClassicLabels = true;
            this.xyGraph_FX.XtraFrame = false;
            this.xyGraph_FX.XtraLabelX = "X-Title";
            this.xyGraph_FX.XtraLabelY = "Y-Title";
            this.xyGraph_FX.XtraLogX = false;
            this.xyGraph_FX.XtraLogY = false;
            this.xyGraph_FX.XtraMinLeftMargin = 0;
            this.xyGraph_FX.XtraSelectPoint = false;
            this.xyGraph_FX.XtraShowGrid = false;
            this.xyGraph_FX.XtraShowLegend = false;
            this.xyGraph_FX.XtraTitle = "XYGraph Title";
            this.xyGraph_FX.XtraUpdateCursor = true;
            this.xyGraph_FX.XtraXdigits = 0;
            this.xyGraph_FX.XtraXmax = 0F;
            this.xyGraph_FX.XtraXmin = 0F;
            this.xyGraph_FX.XtraXstep = 0F;
            this.xyGraph_FX.XtraYdigits = 0;
            this.xyGraph_FX.XtraYmax = 0F;
            this.xyGraph_FX.XtraYmin = 0F;
            this.xyGraph_FX.XtraYstep = 0F;
            // 
            // xyGraph_z
            // 
            this.xyGraph_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_z.BackColor = System.Drawing.Color.Black;
            this.xyGraph_z.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_z.Location = new System.Drawing.Point(0, 468);
            this.xyGraph_z.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_z.Name = "xyGraph_z";
            this.xyGraph_z.Size = new System.Drawing.Size(674, 234);
            this.xyGraph_z.TabIndex = 8;
            this.xyGraph_z.XtraAutoScale = true;
            this.xyGraph_z.XtraClassicLabels = true;
            this.xyGraph_z.XtraFrame = false;
            this.xyGraph_z.XtraLabelX = "X-Title";
            this.xyGraph_z.XtraLabelY = "Y-Title";
            this.xyGraph_z.XtraLogX = false;
            this.xyGraph_z.XtraLogY = false;
            this.xyGraph_z.XtraMinLeftMargin = 0;
            this.xyGraph_z.XtraSelectPoint = false;
            this.xyGraph_z.XtraShowGrid = false;
            this.xyGraph_z.XtraShowLegend = false;
            this.xyGraph_z.XtraTitle = "XYGraph Title";
            this.xyGraph_z.XtraUpdateCursor = true;
            this.xyGraph_z.XtraXdigits = 0;
            this.xyGraph_z.XtraXmax = 0F;
            this.xyGraph_z.XtraXmin = 0F;
            this.xyGraph_z.XtraXstep = 0F;
            this.xyGraph_z.XtraYdigits = 0;
            this.xyGraph_z.XtraYmax = 0F;
            this.xyGraph_z.XtraYmin = 0F;
            this.xyGraph_z.XtraYstep = 0F;
            // 
            // xyGraph_y
            // 
            this.xyGraph_y.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_y.BackColor = System.Drawing.Color.Black;
            this.xyGraph_y.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_y.Location = new System.Drawing.Point(0, 234);
            this.xyGraph_y.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_y.Name = "xyGraph_y";
            this.xyGraph_y.Size = new System.Drawing.Size(674, 234);
            this.xyGraph_y.TabIndex = 7;
            this.xyGraph_y.XtraAutoScale = true;
            this.xyGraph_y.XtraClassicLabels = true;
            this.xyGraph_y.XtraFrame = false;
            this.xyGraph_y.XtraLabelX = "X-Title";
            this.xyGraph_y.XtraLabelY = "Y-Title";
            this.xyGraph_y.XtraLogX = false;
            this.xyGraph_y.XtraLogY = false;
            this.xyGraph_y.XtraMinLeftMargin = 0;
            this.xyGraph_y.XtraSelectPoint = false;
            this.xyGraph_y.XtraShowGrid = false;
            this.xyGraph_y.XtraShowLegend = false;
            this.xyGraph_y.XtraTitle = "XYGraph Title";
            this.xyGraph_y.XtraUpdateCursor = true;
            this.xyGraph_y.XtraXdigits = 0;
            this.xyGraph_y.XtraXmax = 0F;
            this.xyGraph_y.XtraXmin = 0F;
            this.xyGraph_y.XtraXstep = 0F;
            this.xyGraph_y.XtraYdigits = 0;
            this.xyGraph_y.XtraYmax = 0F;
            this.xyGraph_y.XtraYmin = 0F;
            this.xyGraph_y.XtraYstep = 0F;
            // 
            // xyGraph_FY
            // 
            this.xyGraph_FY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyGraph_FY.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph_FY.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph_FY.Location = new System.Drawing.Point(674, 234);
            this.xyGraph_FY.Margin = new System.Windows.Forms.Padding(0);
            this.xyGraph_FY.Name = "xyGraph_FY";
            this.xyGraph_FY.Size = new System.Drawing.Size(675, 234);
            this.xyGraph_FY.TabIndex = 1;
            this.xyGraph_FY.XtraAutoScale = true;
            this.xyGraph_FY.XtraClassicLabels = true;
            this.xyGraph_FY.XtraFrame = false;
            this.xyGraph_FY.XtraLabelX = "X-Title";
            this.xyGraph_FY.XtraLabelY = "Y-Title";
            this.xyGraph_FY.XtraLogX = false;
            this.xyGraph_FY.XtraLogY = false;
            this.xyGraph_FY.XtraMinLeftMargin = 0;
            this.xyGraph_FY.XtraSelectPoint = false;
            this.xyGraph_FY.XtraShowGrid = false;
            this.xyGraph_FY.XtraShowLegend = false;
            this.xyGraph_FY.XtraTitle = "XYGraph Title";
            this.xyGraph_FY.XtraUpdateCursor = true;
            this.xyGraph_FY.XtraXdigits = 0;
            this.xyGraph_FY.XtraXmax = 0F;
            this.xyGraph_FY.XtraXmin = 0F;
            this.xyGraph_FY.XtraXstep = 0F;
            this.xyGraph_FY.XtraYdigits = 0;
            this.xyGraph_FY.XtraYmax = 0F;
            this.xyGraph_FY.XtraYmin = 0F;
            this.xyGraph_FY.XtraYstep = 0F;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 735);
            this.tabControl1.TabIndex = 10;
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Seq;
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
        private System.Windows.Forms.Button Button_SerialClose;
        private System.Windows.Forms.Button Button_SerialOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_DataReceived;
        private System.Windows.Forms.TabPage tabPage1;
        private componentXtra.XYGraph xyGraph_FZ;
        private componentXtra.XYGraph xyGraph_FY;
        private componentXtra.XYGraph xyGraph_FX;
        private System.Windows.Forms.TabControl tabControl1;
        private componentXtra.XYGraph xyGraph_z;
        private componentXtra.XYGraph xyGraph_y;
        private componentXtra.XYGraph xyGraph_x;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Y;
        private System.Windows.Forms.Button Btn_Z;
        private System.Windows.Forms.Button Btn_X;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

