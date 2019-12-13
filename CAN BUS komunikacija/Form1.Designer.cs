namespace CAN_BUS_komunikacija
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCopyTelegram = new System.Windows.Forms.Button();
            this.buttonCopySignal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.comboBox_BROJ_Poruka = new System.Windows.Forms.ComboBox();
            this.comboBox_MS = new System.Windows.Forms.ComboBox();
            this.textBox_CAN_ID_INPUT = new System.Windows.Forms.TextBox();
            this.textBox0I = new System.Windows.Forms.TextBox();
            this.textBox1I = new System.Windows.Forms.TextBox();
            this.textBox2I = new System.Windows.Forms.TextBox();
            this.textBox3I = new System.Windows.Forms.TextBox();
            this.textBox4I = new System.Windows.Forms.TextBox();
            this.textBox5I = new System.Windows.Forms.TextBox();
            this.textBox6I = new System.Windows.Forms.TextBox();
            this.textBox7I = new System.Windows.Forms.TextBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CAN_ID_OUTPUT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7_0 = new System.Windows.Forms.TextBox();
            this.textBox0_0 = new System.Windows.Forms.TextBox();
            this.textBox1_O = new System.Windows.Forms.TextBox();
            this.textBox2_0 = new System.Windows.Forms.TextBox();
            this.textBox3_0 = new System.Windows.Forms.TextBox();
            this.textBox4_0 = new System.Windows.Forms.TextBox();
            this.checkBox7o = new System.Windows.Forms.CheckBox();
            this.checkBox6o = new System.Windows.Forms.CheckBox();
            this.textBox5_0 = new System.Windows.Forms.TextBox();
            this.checkBox5o = new System.Windows.Forms.CheckBox();
            this.textBox6_0 = new System.Windows.Forms.TextBox();
            this.checkBox4o = new System.Windows.Forms.CheckBox();
            this.checkBox3o = new System.Windows.Forms.CheckBox();
            this.checkBox0o = new System.Windows.Forms.CheckBox();
            this.checkBox2o = new System.Windows.Forms.CheckBox();
            this.checkBox1o = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "CAN ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payload";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ciklus slanja poruka(ms): -->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(523, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "Broj poslanih poruka : -->";
            // 
            // buttonCopyTelegram
            // 
            this.buttonCopyTelegram.BackColor = System.Drawing.Color.Black;
            this.buttonCopyTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyTelegram.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyTelegram.ForeColor = System.Drawing.Color.White;
            this.buttonCopyTelegram.Location = new System.Drawing.Point(50, 341);
            this.buttonCopyTelegram.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCopyTelegram.Name = "buttonCopyTelegram";
            this.buttonCopyTelegram.Size = new System.Drawing.Size(150, 75);
            this.buttonCopyTelegram.TabIndex = 11;
            this.buttonCopyTelegram.Text = "   Send\r\nCopyTelegram";
            this.buttonCopyTelegram.UseVisualStyleBackColor = false;
            this.buttonCopyTelegram.Click += new System.EventHandler(this.buttonCopyTelegram_Click);
            // 
            // buttonCopySignal
            // 
            this.buttonCopySignal.BackColor = System.Drawing.Color.Black;
            this.buttonCopySignal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopySignal.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopySignal.ForeColor = System.Drawing.Color.White;
            this.buttonCopySignal.Location = new System.Drawing.Point(800, 341);
            this.buttonCopySignal.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCopySignal.Name = "buttonCopySignal";
            this.buttonCopySignal.Size = new System.Drawing.Size(150, 75);
            this.buttonCopySignal.TabIndex = 12;
            this.buttonCopySignal.Text = "  Send\r\nCopySignal";
            this.buttonCopySignal.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 450);
            this.groupBox1.MaximumSize = new System.Drawing.Size(950, 250);
            this.groupBox1.MinimumSize = new System.Drawing.Size(950, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Enabled = false;
            this.textBoxSend.Location = new System.Drawing.Point(25, 35);
            this.textBoxSend.MaximumSize = new System.Drawing.Size(900, 200);
            this.textBoxSend.MinimumSize = new System.Drawing.Size(900, 200);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSend.Size = new System.Drawing.Size(900, 200);
            this.textBoxSend.TabIndex = 2;
            // 
            // comboBox_BROJ_Poruka
            // 
            this.comboBox_BROJ_Poruka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BROJ_Poruka.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BROJ_Poruka.FormattingEnabled = true;
            this.comboBox_BROJ_Poruka.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_BROJ_Poruka.Location = new System.Drawing.Point(808, 243);
            this.comboBox_BROJ_Poruka.Name = "comboBox_BROJ_Poruka";
            this.comboBox_BROJ_Poruka.Size = new System.Drawing.Size(121, 27);
            this.comboBox_BROJ_Poruka.TabIndex = 13;
            // 
            // comboBox_MS
            // 
            this.comboBox_MS.BackColor = System.Drawing.Color.White;
            this.comboBox_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MS.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MS.FormattingEnabled = true;
            this.comboBox_MS.Items.AddRange(new object[] {
            "0 ms",
            "25 ms",
            "50 ms",
            "75 ms",
            "100 ms",
            "125 ms",
            "150 ms",
            "175 ms",
            "200 ms"});
            this.comboBox_MS.Location = new System.Drawing.Point(330, 246);
            this.comboBox_MS.Name = "comboBox_MS";
            this.comboBox_MS.Size = new System.Drawing.Size(121, 27);
            this.comboBox_MS.TabIndex = 14;
            // 
            // textBox_CAN_ID_INPUT
            // 
            this.textBox_CAN_ID_INPUT.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CAN_ID_INPUT.Location = new System.Drawing.Point(103, 37);
            this.textBox_CAN_ID_INPUT.Name = "textBox_CAN_ID_INPUT";
            this.textBox_CAN_ID_INPUT.Size = new System.Drawing.Size(100, 26);
            this.textBox_CAN_ID_INPUT.TabIndex = 15;
            this.textBox_CAN_ID_INPUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CAN_ID_OUTPUT_KeyPress);
            // 
            // textBox0I
            // 
            this.textBox0I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox0I.Location = new System.Drawing.Point(108, 76);
            this.textBox0I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox0I.MaxLength = 2;
            this.textBox0I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox0I.Name = "textBox0I";
            this.textBox0I.Size = new System.Drawing.Size(30, 26);
            this.textBox0I.TabIndex = 17;
            this.textBox0I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox1I
            // 
            this.textBox1I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1I.Location = new System.Drawing.Point(150, 76);
            this.textBox1I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox1I.MaxLength = 2;
            this.textBox1I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox1I.Name = "textBox1I";
            this.textBox1I.Size = new System.Drawing.Size(30, 26);
            this.textBox1I.TabIndex = 18;
            this.textBox1I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox2I
            // 
            this.textBox2I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2I.Location = new System.Drawing.Point(192, 76);
            this.textBox2I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox2I.MaxLength = 2;
            this.textBox2I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox2I.Name = "textBox2I";
            this.textBox2I.Size = new System.Drawing.Size(30, 26);
            this.textBox2I.TabIndex = 19;
            this.textBox2I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox3I
            // 
            this.textBox3I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3I.Location = new System.Drawing.Point(234, 76);
            this.textBox3I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox3I.MaxLength = 2;
            this.textBox3I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox3I.Name = "textBox3I";
            this.textBox3I.Size = new System.Drawing.Size(30, 26);
            this.textBox3I.TabIndex = 20;
            this.textBox3I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox4I
            // 
            this.textBox4I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4I.Location = new System.Drawing.Point(276, 76);
            this.textBox4I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox4I.MaxLength = 2;
            this.textBox4I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox4I.Name = "textBox4I";
            this.textBox4I.Size = new System.Drawing.Size(30, 26);
            this.textBox4I.TabIndex = 21;
            this.textBox4I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox5I
            // 
            this.textBox5I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5I.Location = new System.Drawing.Point(318, 76);
            this.textBox5I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox5I.MaxLength = 2;
            this.textBox5I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox5I.Name = "textBox5I";
            this.textBox5I.Size = new System.Drawing.Size(30, 26);
            this.textBox5I.TabIndex = 22;
            this.textBox5I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox6I
            // 
            this.textBox6I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6I.Location = new System.Drawing.Point(360, 76);
            this.textBox6I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox6I.MaxLength = 2;
            this.textBox6I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox6I.Name = "textBox6I";
            this.textBox6I.Size = new System.Drawing.Size(30, 26);
            this.textBox6I.TabIndex = 23;
            this.textBox6I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // textBox7I
            // 
            this.textBox7I.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7I.Location = new System.Drawing.Point(402, 76);
            this.textBox7I.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox7I.MaxLength = 2;
            this.textBox7I.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox7I.Name = "textBox7I";
            this.textBox7I.Size = new System.Drawing.Size(30, 26);
            this.textBox7I.TabIndex = 24;
            this.textBox7I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7I_KeyPress);
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.BackColor = System.Drawing.Color.Transparent;
            this.checkBox0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox0.ForeColor = System.Drawing.Color.White;
            this.checkBox0.Location = new System.Drawing.Point(6, 161);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(62, 23);
            this.checkBox0.TabIndex = 33;
            this.checkBox0.Text = "B[0]";
            this.checkBox0.UseVisualStyleBackColor = false;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(65, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 23);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "B[1]";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(123, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 23);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "B[2]";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(184, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 23);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "B[3]";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(245, 161);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 23);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "B[4]";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(306, 161);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 23);
            this.checkBox5.TabIndex = 38;
            this.checkBox5.Text = "B[5]";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(365, 161);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 23);
            this.checkBox6.TabIndex = 39;
            this.checkBox6.Text = "B[6]";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(425, 161);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(63, 23);
            this.checkBox7.TabIndex = 40;
            this.checkBox7.Text = "B[7]";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_CAN_ID_INPUT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox7I);
            this.groupBox2.Controls.Add(this.textBox0I);
            this.groupBox2.Controls.Add(this.textBox1I);
            this.groupBox2.Controls.Add(this.textBox2I);
            this.groupBox2.Controls.Add(this.textBox3I);
            this.groupBox2.Controls.Add(this.textBox4I);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.textBox5I);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.textBox6I);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox0);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.MaximumSize = new System.Drawing.Size(490, 200);
            this.groupBox2.MinimumSize = new System.Drawing.Size(490, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 200);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Signal- Redni broj bytea unutar payloada";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_CAN_ID_OUTPUT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox7_0);
            this.groupBox3.Controls.Add(this.textBox0_0);
            this.groupBox3.Controls.Add(this.textBox1_O);
            this.groupBox3.Controls.Add(this.textBox2_0);
            this.groupBox3.Controls.Add(this.textBox3_0);
            this.groupBox3.Controls.Add(this.textBox4_0);
            this.groupBox3.Controls.Add(this.checkBox7o);
            this.groupBox3.Controls.Add(this.checkBox6o);
            this.groupBox3.Controls.Add(this.textBox5_0);
            this.groupBox3.Controls.Add(this.checkBox5o);
            this.groupBox3.Controls.Add(this.textBox6_0);
            this.groupBox3.Controls.Add(this.checkBox4o);
            this.groupBox3.Controls.Add(this.checkBox3o);
            this.groupBox3.Controls.Add(this.checkBox0o);
            this.groupBox3.Controls.Add(this.checkBox2o);
            this.groupBox3.Controls.Add(this.checkBox1o);
            this.groupBox3.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(502, 12);
            this.groupBox3.MaximumSize = new System.Drawing.Size(490, 200);
            this.groupBox3.MinimumSize = new System.Drawing.Size(490, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 200);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Signal- Redni broj bytea unutar payloada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "CAN ID";
            // 
            // textBox_CAN_ID_OUTPUT
            // 
            this.textBox_CAN_ID_OUTPUT.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CAN_ID_OUTPUT.Location = new System.Drawing.Point(103, 37);
            this.textBox_CAN_ID_OUTPUT.Name = "textBox_CAN_ID_OUTPUT";
            this.textBox_CAN_ID_OUTPUT.Size = new System.Drawing.Size(100, 26);
            this.textBox_CAN_ID_OUTPUT.TabIndex = 15;
            this.textBox_CAN_ID_OUTPUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CAN_ID_OUTPUT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Payload";
            // 
            // textBox7_0
            // 
            this.textBox7_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_0.Location = new System.Drawing.Point(402, 76);
            this.textBox7_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox7_0.MaxLength = 2;
            this.textBox7_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox7_0.Name = "textBox7_0";
            this.textBox7_0.Size = new System.Drawing.Size(30, 26);
            this.textBox7_0.TabIndex = 24;
            this.textBox7_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // textBox0_0
            // 
            this.textBox0_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox0_0.Location = new System.Drawing.Point(108, 76);
            this.textBox0_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox0_0.MaxLength = 2;
            this.textBox0_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox0_0.Name = "textBox0_0";
            this.textBox0_0.Size = new System.Drawing.Size(30, 26);
            this.textBox0_0.TabIndex = 17;
            this.textBox0_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // textBox1_O
            // 
            this.textBox1_O.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_O.Location = new System.Drawing.Point(150, 76);
            this.textBox1_O.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox1_O.MaxLength = 2;
            this.textBox1_O.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox1_O.Name = "textBox1_O";
            this.textBox1_O.Size = new System.Drawing.Size(30, 26);
            this.textBox1_O.TabIndex = 18;
            this.textBox1_O.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // textBox2_0
            // 
            this.textBox2_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_0.Location = new System.Drawing.Point(192, 76);
            this.textBox2_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox2_0.MaxLength = 2;
            this.textBox2_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox2_0.Name = "textBox2_0";
            this.textBox2_0.Size = new System.Drawing.Size(30, 26);
            this.textBox2_0.TabIndex = 19;
            this.textBox2_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // textBox3_0
            // 
            this.textBox3_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_0.Location = new System.Drawing.Point(234, 76);
            this.textBox3_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox3_0.MaxLength = 2;
            this.textBox3_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox3_0.Name = "textBox3_0";
            this.textBox3_0.Size = new System.Drawing.Size(30, 26);
            this.textBox3_0.TabIndex = 20;
            this.textBox3_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // textBox4_0
            // 
            this.textBox4_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_0.Location = new System.Drawing.Point(276, 76);
            this.textBox4_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox4_0.MaxLength = 2;
            this.textBox4_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox4_0.Name = "textBox4_0";
            this.textBox4_0.Size = new System.Drawing.Size(30, 26);
            this.textBox4_0.TabIndex = 21;
            this.textBox4_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // checkBox7o
            // 
            this.checkBox7o.AutoSize = true;
            this.checkBox7o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7o.Location = new System.Drawing.Point(425, 161);
            this.checkBox7o.Name = "checkBox7o";
            this.checkBox7o.Size = new System.Drawing.Size(63, 23);
            this.checkBox7o.TabIndex = 40;
            this.checkBox7o.Text = "B[7]";
            this.checkBox7o.UseVisualStyleBackColor = true;
            this.checkBox7o.CheckedChanged += new System.EventHandler(this.checkBox7o_CheckedChanged);
            // 
            // checkBox6o
            // 
            this.checkBox6o.AutoSize = true;
            this.checkBox6o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6o.Location = new System.Drawing.Point(365, 161);
            this.checkBox6o.Name = "checkBox6o";
            this.checkBox6o.Size = new System.Drawing.Size(63, 23);
            this.checkBox6o.TabIndex = 39;
            this.checkBox6o.Text = "B[6]";
            this.checkBox6o.UseVisualStyleBackColor = true;
            this.checkBox6o.CheckedChanged += new System.EventHandler(this.checkBox6o_CheckedChanged);
            // 
            // textBox5_0
            // 
            this.textBox5_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_0.Location = new System.Drawing.Point(318, 76);
            this.textBox5_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox5_0.MaxLength = 2;
            this.textBox5_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox5_0.Name = "textBox5_0";
            this.textBox5_0.Size = new System.Drawing.Size(30, 26);
            this.textBox5_0.TabIndex = 22;
            this.textBox5_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // checkBox5o
            // 
            this.checkBox5o.AutoSize = true;
            this.checkBox5o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5o.Location = new System.Drawing.Point(306, 161);
            this.checkBox5o.Name = "checkBox5o";
            this.checkBox5o.Size = new System.Drawing.Size(62, 23);
            this.checkBox5o.TabIndex = 38;
            this.checkBox5o.Text = "B[5]";
            this.checkBox5o.UseVisualStyleBackColor = true;
            this.checkBox5o.CheckedChanged += new System.EventHandler(this.checkBox5o_CheckedChanged);
            // 
            // textBox6_0
            // 
            this.textBox6_0.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_0.Location = new System.Drawing.Point(360, 76);
            this.textBox6_0.MaximumSize = new System.Drawing.Size(30, 26);
            this.textBox6_0.MaxLength = 2;
            this.textBox6_0.MinimumSize = new System.Drawing.Size(30, 26);
            this.textBox6_0.Name = "textBox6_0";
            this.textBox6_0.Size = new System.Drawing.Size(30, 26);
            this.textBox6_0.TabIndex = 23;
            this.textBox6_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_0_KeyPress);
            // 
            // checkBox4o
            // 
            this.checkBox4o.AutoSize = true;
            this.checkBox4o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4o.Location = new System.Drawing.Point(245, 161);
            this.checkBox4o.Name = "checkBox4o";
            this.checkBox4o.Size = new System.Drawing.Size(64, 23);
            this.checkBox4o.TabIndex = 37;
            this.checkBox4o.Text = "B[4]";
            this.checkBox4o.UseVisualStyleBackColor = true;
            this.checkBox4o.CheckedChanged += new System.EventHandler(this.checkBox4o_CheckedChanged);
            // 
            // checkBox3o
            // 
            this.checkBox3o.AutoSize = true;
            this.checkBox3o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3o.Location = new System.Drawing.Point(184, 161);
            this.checkBox3o.Name = "checkBox3o";
            this.checkBox3o.Size = new System.Drawing.Size(64, 23);
            this.checkBox3o.TabIndex = 36;
            this.checkBox3o.Text = "B[3]";
            this.checkBox3o.UseVisualStyleBackColor = true;
            this.checkBox3o.CheckedChanged += new System.EventHandler(this.checkBox3o_CheckedChanged);
            // 
            // checkBox0o
            // 
            this.checkBox0o.AutoSize = true;
            this.checkBox0o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox0o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox0o.Location = new System.Drawing.Point(6, 161);
            this.checkBox0o.Name = "checkBox0o";
            this.checkBox0o.Size = new System.Drawing.Size(62, 23);
            this.checkBox0o.TabIndex = 33;
            this.checkBox0o.Text = "B[0]";
            this.checkBox0o.UseVisualStyleBackColor = true;
            this.checkBox0o.CheckedChanged += new System.EventHandler(this.checkBox0o_CheckedChanged);
            // 
            // checkBox2o
            // 
            this.checkBox2o.AutoSize = true;
            this.checkBox2o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2o.Location = new System.Drawing.Point(123, 161);
            this.checkBox2o.Name = "checkBox2o";
            this.checkBox2o.Size = new System.Drawing.Size(64, 23);
            this.checkBox2o.TabIndex = 35;
            this.checkBox2o.Text = "B[2]";
            this.checkBox2o.UseVisualStyleBackColor = true;
            this.checkBox2o.CheckedChanged += new System.EventHandler(this.checkBox2o_CheckedChanged);
            // 
            // checkBox1o
            // 
            this.checkBox1o.AutoSize = true;
            this.checkBox1o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1o.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1o.Location = new System.Drawing.Point(65, 161);
            this.checkBox1o.Name = "checkBox1o";
            this.checkBox1o.Size = new System.Drawing.Size(61, 23);
            this.checkBox1o.TabIndex = 34;
            this.checkBox1o.Text = "B[1]";
            this.checkBox1o.UseVisualStyleBackColor = true;
            this.checkBox1o.CheckedChanged += new System.EventHandler(this.checkBox1o_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CAN_BUS_komunikacija.Properties.Resources.backimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_MS);
            this.Controls.Add(this.comboBox_BROJ_Poruka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCopySignal);
            this.Controls.Add(this.buttonCopyTelegram);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAN BUS Komunikacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCopyTelegram;
        private System.Windows.Forms.Button buttonCopySignal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ComboBox comboBox_BROJ_Poruka;
        private System.Windows.Forms.ComboBox comboBox_MS;
        private System.Windows.Forms.TextBox textBox_CAN_ID_INPUT;
        private System.Windows.Forms.TextBox textBox0I;
        private System.Windows.Forms.TextBox textBox1I;
        private System.Windows.Forms.TextBox textBox2I;
        private System.Windows.Forms.TextBox textBox3I;
        private System.Windows.Forms.TextBox textBox4I;
        private System.Windows.Forms.TextBox textBox5I;
        private System.Windows.Forms.TextBox textBox6I;
        private System.Windows.Forms.TextBox textBox7I;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CAN_ID_OUTPUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7_0;
        private System.Windows.Forms.TextBox textBox0_0;
        private System.Windows.Forms.TextBox textBox1_O;
        private System.Windows.Forms.TextBox textBox2_0;
        private System.Windows.Forms.TextBox textBox3_0;
        private System.Windows.Forms.TextBox textBox4_0;
        private System.Windows.Forms.CheckBox checkBox7o;
        private System.Windows.Forms.CheckBox checkBox6o;
        private System.Windows.Forms.TextBox textBox5_0;
        private System.Windows.Forms.CheckBox checkBox5o;
        private System.Windows.Forms.TextBox textBox6_0;
        private System.Windows.Forms.CheckBox checkBox4o;
        private System.Windows.Forms.CheckBox checkBox3o;
        private System.Windows.Forms.CheckBox checkBox0o;
        private System.Windows.Forms.CheckBox checkBox2o;
        private System.Windows.Forms.CheckBox checkBox1o;
    }
}

