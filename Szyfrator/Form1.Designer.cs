namespace Szyfrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.text_box_cryptogram_replace = new System.Windows.Forms.TextBox();
            this.label_option_cryptogram = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_message_2 = new System.Windows.Forms.Label();
            this.label_cryptogram_2 = new System.Windows.Forms.Label();
            this.label_keyword_2 = new System.Windows.Forms.Label();
            this.label_cryptogram = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.text_box_cryptogram = new System.Windows.Forms.TextBox();
            this.text_box_message = new System.Windows.Forms.TextBox();
            this.text_box_keyword = new System.Windows.Forms.TextBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.label_keyword = new System.Windows.Forms.Label();
            this.manuea = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.manuea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(571, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.cryptogramToolStripMenuItem});
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // keywordToolStripMenuItem
            // 
            this.keywordToolStripMenuItem.Name = "keywordToolStripMenuItem";
            this.keywordToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.keywordToolStripMenuItem.Text = "keyword";
            this.keywordToolStripMenuItem.Click += new System.EventHandler(this.keywordToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.messageToolStripMenuItem.Text = "message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // cryptogramToolStripMenuItem
            // 
            this.cryptogramToolStripMenuItem.Name = "cryptogramToolStripMenuItem";
            this.cryptogramToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cryptogramToolStripMenuItem.Text = "cryptogram";
            this.cryptogramToolStripMenuItem.Click += new System.EventHandler(this.cryptogramToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripMenuItem1,
            this.messageToolStripMenuItem1,
            this.cryptogramToolStripMenuItem1});
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // keywordToolStripMenuItem1
            // 
            this.keywordToolStripMenuItem1.Name = "keywordToolStripMenuItem1";
            this.keywordToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.keywordToolStripMenuItem1.Text = "keyword";
            this.keywordToolStripMenuItem1.Click += new System.EventHandler(this.keywordToolStripMenuItem1_Click);
            // 
            // messageToolStripMenuItem1
            // 
            this.messageToolStripMenuItem1.Name = "messageToolStripMenuItem1";
            this.messageToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.messageToolStripMenuItem1.Text = "message";
            this.messageToolStripMenuItem1.Click += new System.EventHandler(this.messageToolStripMenuItem1_Click);
            // 
            // cryptogramToolStripMenuItem1
            // 
            this.cryptogramToolStripMenuItem1.Name = "cryptogramToolStripMenuItem1";
            this.cryptogramToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.cryptogramToolStripMenuItem1.Text = "cryptogram";
            this.cryptogramToolStripMenuItem1.Click += new System.EventHandler(this.cryptogramToolStripMenuItem1_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(541, 436);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Instruction";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(35, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(464, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "If you want change some options click \"Options\" page.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(35, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(437, 48);
            this.label10.TabIndex = 1;
            this.label10.Text = "To decrypt cryptogram you have to insert keyword, \r\ncryptogram and cilick buttom " +
    "decrypt.\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(35, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 48);
            this.label9.TabIndex = 0;
            this.label9.Text = "To encrypt message you have to insert keyword, \r\nmessage and click button encrypt" +
    ".\r\n";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(541, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Example";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 419);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label_description);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(541, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Description";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nihilist Transposition";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_description.Location = new System.Drawing.Point(66, 98);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(440, 168);
            this.label_description.TabIndex = 0;
            this.label_description.Text = resources.GetString("label_description.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.text_box_cryptogram_replace);
            this.tabPage2.Controls.Add(this.label_option_cryptogram);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text_box_cryptogram_replace
            // 
            this.text_box_cryptogram_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_cryptogram_replace.Location = new System.Drawing.Point(218, 249);
            this.text_box_cryptogram_replace.MaxLength = 1;
            this.text_box_cryptogram_replace.Name = "text_box_cryptogram_replace";
            this.text_box_cryptogram_replace.Size = new System.Drawing.Size(60, 26);
            this.text_box_cryptogram_replace.TabIndex = 13;
            this.text_box_cryptogram_replace.Text = "-";
            this.text_box_cryptogram_replace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_option_cryptogram
            // 
            this.label_option_cryptogram.AutoSize = true;
            this.label_option_cryptogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_option_cryptogram.Location = new System.Drawing.Point(42, 249);
            this.label_option_cryptogram.Name = "label_option_cryptogram";
            this.label_option_cryptogram.Size = new System.Drawing.Size(170, 20);
            this.label_option_cryptogram.TabIndex = 14;
            this.label_option_cryptogram.Text = "replace empty place by";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox4.Location = new System.Drawing.Point(46, 173);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(261, 24);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "don\'t recognize the capital letters";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox3.Location = new System.Drawing.Point(46, 143);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(206, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "skipping white characters";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(46, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(261, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "don\'t recognize the capital letters";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(46, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "skipping white characters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "cryptogram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "keyword";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label_message_2);
            this.tabPage1.Controls.Add(this.label_cryptogram_2);
            this.tabPage1.Controls.Add(this.label_keyword_2);
            this.tabPage1.Controls.Add(this.label_cryptogram);
            this.tabPage1.Controls.Add(this.label_message);
            this.tabPage1.Controls.Add(this.text_box_cryptogram);
            this.tabPage1.Controls.Add(this.text_box_message);
            this.tabPage1.Controls.Add(this.text_box_keyword);
            this.tabPage1.Controls.Add(this.button_decrypt);
            this.tabPage1.Controls.Add(this.button_encrypt);
            this.tabPage1.Controls.Add(this.label_keyword);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryptor";
            // 
            // label_message_2
            // 
            this.label_message_2.AutoSize = true;
            this.label_message_2.Location = new System.Drawing.Point(190, 405);
            this.label_message_2.Name = "label_message_2";
            this.label_message_2.Size = new System.Drawing.Size(14, 15);
            this.label_message_2.TabIndex = 23;
            this.label_message_2.Text = "0";
            // 
            // label_cryptogram_2
            // 
            this.label_cryptogram_2.AutoSize = true;
            this.label_cryptogram_2.Location = new System.Drawing.Point(447, 405);
            this.label_cryptogram_2.Name = "label_cryptogram_2";
            this.label_cryptogram_2.Size = new System.Drawing.Size(14, 15);
            this.label_cryptogram_2.TabIndex = 22;
            this.label_cryptogram_2.Text = "0";
            // 
            // label_keyword_2
            // 
            this.label_keyword_2.AutoSize = true;
            this.label_keyword_2.Location = new System.Drawing.Point(233, 52);
            this.label_keyword_2.Name = "label_keyword_2";
            this.label_keyword_2.Size = new System.Drawing.Size(14, 15);
            this.label_keyword_2.TabIndex = 21;
            this.label_keyword_2.Text = "0";
            // 
            // label_cryptogram
            // 
            this.label_cryptogram.AutoSize = true;
            this.label_cryptogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cryptogram.Location = new System.Drawing.Point(337, 405);
            this.label_cryptogram.Name = "label_cryptogram";
            this.label_cryptogram.Size = new System.Drawing.Size(104, 24);
            this.label_cryptogram.TabIndex = 20;
            this.label_cryptogram.Text = "cryptogram";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.Location = new System.Drawing.Point(97, 405);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(87, 24);
            this.label_message.TabIndex = 19;
            this.label_message.Text = "message";
            // 
            // text_box_cryptogram
            // 
            this.text_box_cryptogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_cryptogram.Location = new System.Drawing.Point(278, 79);
            this.text_box_cryptogram.Multiline = true;
            this.text_box_cryptogram.Name = "text_box_cryptogram";
            this.text_box_cryptogram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_box_cryptogram.Size = new System.Drawing.Size(245, 323);
            this.text_box_cryptogram.TabIndex = 18;
            // 
            // text_box_message
            // 
            this.text_box_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_message.Location = new System.Drawing.Point(18, 79);
            this.text_box_message.Multiline = true;
            this.text_box_message.Name = "text_box_message";
            this.text_box_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_box_message.Size = new System.Drawing.Size(245, 323);
            this.text_box_message.TabIndex = 17;
            this.text_box_message.TextChanged += new System.EventHandler(this.text_box_message_TextChanged);
            // 
            // text_box_keyword
            // 
            this.text_box_keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_box_keyword.Location = new System.Drawing.Point(12, 6);
            this.text_box_keyword.Multiline = true;
            this.text_box_keyword.Name = "text_box_keyword";
            this.text_box_keyword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_box_keyword.Size = new System.Drawing.Size(298, 43);
            this.text_box_keyword.TabIndex = 5;
            this.text_box_keyword.TextChanged += new System.EventHandler(this.text_box_keyword_TextChanged);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_decrypt.Location = new System.Drawing.Point(416, 6);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(94, 70);
            this.button_decrypt.TabIndex = 8;
            this.button_decrypt.Text = "decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click_1);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_encrypt.Location = new System.Drawing.Point(316, 6);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(94, 70);
            this.button_encrypt.TabIndex = 7;
            this.button_encrypt.Text = "encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click_1);
            // 
            // label_keyword
            // 
            this.label_keyword.AutoSize = true;
            this.label_keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_keyword.Location = new System.Drawing.Point(108, 52);
            this.label_keyword.Name = "label_keyword";
            this.label_keyword.Size = new System.Drawing.Size(81, 24);
            this.label_keyword.TabIndex = 6;
            this.label_keyword.Text = "keyword";
            // 
            // manuea
            // 
            this.manuea.Controls.Add(this.tabPage1);
            this.manuea.Controls.Add(this.tabPage5);
            this.manuea.Controls.Add(this.tabPage2);
            this.manuea.Controls.Add(this.tabPage3);
            this.manuea.Controls.Add(this.tabPage4);
            this.manuea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.manuea.Location = new System.Drawing.Point(12, 27);
            this.manuea.Name = "manuea";
            this.manuea.SelectedIndex = 0;
            this.manuea.Size = new System.Drawing.Size(549, 462);
            this.manuea.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(39, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 48);
            this.label3.TabIndex = 21;
            this.label3.Text = "To Load or save keyword message or\r\n cryptogram click icon";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manuea);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nihilist Transposition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.manuea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keywordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keywordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cryptogramToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox text_box_cryptogram_replace;
        private System.Windows.Forms.Label label_option_cryptogram;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_message_2;
        private System.Windows.Forms.Label label_cryptogram_2;
        private System.Windows.Forms.Label label_keyword_2;
        private System.Windows.Forms.Label label_cryptogram;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.TextBox text_box_cryptogram;
        private System.Windows.Forms.TextBox text_box_message;
        private System.Windows.Forms.TextBox text_box_keyword;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Label label_keyword;
        private System.Windows.Forms.TabControl manuea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}

