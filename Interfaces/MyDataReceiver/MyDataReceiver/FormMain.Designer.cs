namespace MyDataReceiver
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
            this.xyGraph1 = new componentXtra.XYGraph();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xyGraph2 = new componentXtra.XYGraph();
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_VectorLenght = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_nova_planilha = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // xyGraph1
            // 
            this.xyGraph1.BackColor = System.Drawing.Color.DarkBlue;
            this.xyGraph1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph1.Location = new System.Drawing.Point(686, 74);
            this.xyGraph1.Name = "xyGraph1";
            this.xyGraph1.Size = new System.Drawing.Size(669, 464);
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
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xyGraph2
            // 
            this.xyGraph2.BackColor = System.Drawing.Color.Black;
            this.xyGraph2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xyGraph2.Location = new System.Drawing.Point(12, 74);
            this.xyGraph2.Name = "xyGraph2";
            this.xyGraph2.Size = new System.Drawing.Size(668, 464);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 30);
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
            this.Status_COM.Location = new System.Drawing.Point(426, 30);
            this.Status_COM.Name = "Status_COM";
            this.Status_COM.Size = new System.Drawing.Size(30, 13);
            this.Status_COM.TabIndex = 6;
            this.Status_COM.Text = "OFF";
            // 
            // CB_Baud
            // 
            this.CB_Baud.FormattingEnabled = true;
            this.CB_Baud.Location = new System.Drawing.Point(259, 27);
            this.CB_Baud.Name = "CB_Baud";
            this.CB_Baud.Size = new System.Drawing.Size(83, 21);
            this.CB_Baud.TabIndex = 5;
            this.CB_Baud.SelectedIndexChanged += new System.EventHandler(this.CB_Baud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 30);
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
            this.bt_Fechar.Location = new System.Drawing.Point(574, 19);
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
            this.bt_Abrir.Location = new System.Drawing.Point(495, 19);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(73, 34);
            this.bt_Abrir.TabIndex = 0;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = false;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(11, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1344, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Recebidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vetor de entrada para uso no Matlab";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(6, 110);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1332, 75);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1332, 72);
            this.textBox1.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(686, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 65);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parâmetros de conversão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sample/s";
            // 
            // textBox_FS
            // 
            this.textBox_FS.Location = new System.Drawing.Point(335, 27);
            this.textBox_FS.Name = "textBox_FS";
            this.textBox_FS.Size = new System.Drawing.Size(53, 20);
            this.textBox_FS.TabIndex = 5;
            this.textBox_FS.Text = "1000";
            this.textBox_FS.TextChanged += new System.EventHandler(this.textBox_FS_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 30);
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
            this.CB_VectorLenght.Location = new System.Drawing.Point(124, 27);
            this.CB_VectorLenght.Name = "CB_VectorLenght";
            this.CB_VectorLenght.Size = new System.Drawing.Size(77, 21);
            this.CB_VectorLenght.TabIndex = 3;
            this.CB_VectorLenght.Text = "128";
            this.CB_VectorLenght.SelectedIndexChanged += new System.EventHandler(this.CB_VectorLenght_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tamanho do Vetor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_load);
            this.groupBox4.Controls.Add(this.btn_Salvar);
            this.groupBox4.Controls.Add(this.btn_nova_planilha);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(1158, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 65);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Planilha";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_load.Location = new System.Drawing.Point(71, 19);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(50, 34);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(124, 19);
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
            this.btn_nova_planilha.Location = new System.Drawing.Point(15, 19);
            this.btn_nova_planilha.Name = "btn_nova_planilha";
            this.btn_nova_planilha.Size = new System.Drawing.Size(50, 34);
            this.btn_nova_planilha.TabIndex = 8;
            this.btn_nova_planilha.Text = "Seq.";
            this.btn_nova_planilha.UseVisualStyleBackColor = false;
            this.btn_nova_planilha.Click += new System.EventHandler(this.btn_nova_planilha_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1365, 737);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.xyGraph1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.xyGraph2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Analise Espectral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private componentXtra.XYGraph xyGraph1;
        private componentXtra.XYGraph xyGraph2;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_VectorLenght;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_nova_planilha;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

