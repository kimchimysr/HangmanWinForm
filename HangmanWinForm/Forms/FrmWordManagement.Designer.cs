namespace HangmanWinForm
{
    partial class FrmWordManagement
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
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.tabTopic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTopic = new HangmanWinForm.CustomControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewTopic = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveTopic = new HangmanWinForm.CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedTopic = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTopicList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchTopic = new System.Windows.Forms.TextBox();
            this.tabWord = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewHint = new System.Windows.Forms.TextBox();
            this.btnAddWord = new HangmanWinForm.CustomControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveWord = new HangmanWinForm.CustomControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedWord = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbTopicList = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.lbWordList = new System.Windows.Forms.ListBox();
            this.tabHint = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnRemoveHint = new HangmanWinForm.CustomControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentHint = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbTopicList2 = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchWord2 = new System.Windows.Forms.TextBox();
            this.lbWordList2 = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewHint2 = new System.Windows.Forms.TextBox();
            this.btnAddHint = new HangmanWinForm.CustomControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectedWord2 = new System.Windows.Forms.TextBox();
            this.tcManagement.SuspendLayout();
            this.tabTopic.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabWord.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabHint.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.tabTopic);
            this.tcManagement.Controls.Add(this.tabWord);
            this.tcManagement.Controls.Add(this.tabHint);
            this.tcManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManagement.Location = new System.Drawing.Point(0, 0);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(784, 461);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.SelectedIndexChanged += new System.EventHandler(this.tcManagement_SelectedIndexChanged);
            // 
            // tabTopic
            // 
            this.tabTopic.BackColor = System.Drawing.Color.White;
            this.tabTopic.Controls.Add(this.tableLayoutPanel1);
            this.tabTopic.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTopic.Location = new System.Drawing.Point(4, 22);
            this.tabTopic.Name = "tabTopic";
            this.tabTopic.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopic.Size = new System.Drawing.Size(776, 435);
            this.tabTopic.TabIndex = 0;
            this.tabTopic.Text = "Topic Manager";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnAddTopic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNewTopic);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD";
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTopic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAddTopic.BorderColor = System.Drawing.Color.Gray;
            this.btnAddTopic.BorderRadius = 10;
            this.btnAddTopic.BorderSize = 3;
            this.btnAddTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTopic.Enabled = false;
            this.btnAddTopic.FlatAppearance.BorderSize = 0;
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopic.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopic.ForeColor = System.Drawing.Color.Black;
            this.btnAddTopic.Location = new System.Drawing.Point(19, 106);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(344, 50);
            this.btnAddTopic.TabIndex = 1;
            this.btnAddTopic.Text = "Add New Topic";
            this.btnAddTopic.TextColor = System.Drawing.Color.Black;
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Topic:";
            // 
            // txtNewTopic
            // 
            this.txtNewTopic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewTopic.Location = new System.Drawing.Point(126, 51);
            this.txtNewTopic.Name = "txtNewTopic";
            this.txtNewTopic.Size = new System.Drawing.Size(237, 23);
            this.txtNewTopic.TabIndex = 0;
            this.txtNewTopic.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtNewTopic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnRemoveTopic);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSelectedTopic);
            this.groupBox2.Location = new System.Drawing.Point(3, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REMOVE";
            // 
            // btnRemoveTopic
            // 
            this.btnRemoveTopic.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTopic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTopic.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveTopic.BorderRadius = 10;
            this.btnRemoveTopic.BorderSize = 3;
            this.btnRemoveTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTopic.FlatAppearance.BorderSize = 0;
            this.btnRemoveTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTopic.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTopic.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTopic.Location = new System.Drawing.Point(19, 106);
            this.btnRemoveTopic.Name = "btnRemoveTopic";
            this.btnRemoveTopic.Size = new System.Drawing.Size(344, 50);
            this.btnRemoveTopic.TabIndex = 2;
            this.btnRemoveTopic.Text = "Remove Selected Topic";
            this.btnRemoveTopic.TextColor = System.Drawing.Color.Black;
            this.btnRemoveTopic.UseVisualStyleBackColor = false;
            this.btnRemoveTopic.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Topic:";
            // 
            // txtSelectedTopic
            // 
            this.txtSelectedTopic.Location = new System.Drawing.Point(126, 51);
            this.txtSelectedTopic.Name = "txtSelectedTopic";
            this.txtSelectedTopic.ReadOnly = true;
            this.txtSelectedTopic.Size = new System.Drawing.Size(237, 23);
            this.txtSelectedTopic.TabIndex = 0;
            this.txtSelectedTopic.TabStop = false;
            this.txtSelectedTopic.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lbTopicList);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSearchTopic);
            this.groupBox3.Location = new System.Drawing.Point(388, 7);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(379, 414);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOPIC LIST";
            // 
            // lbTopicList
            // 
            this.lbTopicList.FormattingEnabled = true;
            this.lbTopicList.ItemHeight = 18;
            this.lbTopicList.Location = new System.Drawing.Point(6, 62);
            this.lbTopicList.Name = "lbTopicList";
            this.lbTopicList.Size = new System.Drawing.Size(367, 346);
            this.lbTopicList.TabIndex = 0;
            this.lbTopicList.TabStop = false;
            this.lbTopicList.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search:";
            // 
            // txtSearchTopic
            // 
            this.txtSearchTopic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchTopic.Location = new System.Drawing.Point(71, 22);
            this.txtSearchTopic.Name = "txtSearchTopic";
            this.txtSearchTopic.Size = new System.Drawing.Size(302, 23);
            this.txtSearchTopic.TabIndex = 3;
            this.txtSearchTopic.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // tabWord
            // 
            this.tabWord.BackColor = System.Drawing.Color.White;
            this.tabWord.Controls.Add(this.tableLayoutPanel2);
            this.tabWord.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWord.Location = new System.Drawing.Point(4, 22);
            this.tabWord.Name = "tabWord";
            this.tabWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabWord.Size = new System.Drawing.Size(776, 435);
            this.tabWord.TabIndex = 1;
            this.tabWord.Text = "Word Manager";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 429);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNewHint);
            this.groupBox4.Controls.Add(this.btnAddWord);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtNewWord);
            this.groupBox4.Location = new System.Drawing.Point(3, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 200);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ADD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "*Maximum: 13 letters";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "*Minimum: 6 letters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Word Hint:";
            // 
            // txtNewHint
            // 
            this.txtNewHint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewHint.Location = new System.Drawing.Point(126, 69);
            this.txtNewHint.Name = "txtNewHint";
            this.txtNewHint.Size = new System.Drawing.Size(237, 23);
            this.txtNewHint.TabIndex = 6;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAddWord.BorderColor = System.Drawing.Color.Gray;
            this.btnAddWord.BorderRadius = 10;
            this.btnAddWord.BorderSize = 3;
            this.btnAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWord.FlatAppearance.BorderSize = 0;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWord.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWord.ForeColor = System.Drawing.Color.Black;
            this.btnAddWord.Location = new System.Drawing.Point(19, 106);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(344, 50);
            this.btnAddWord.TabIndex = 7;
            this.btnAddWord.Text = "Add New Word";
            this.btnAddWord.TextColor = System.Drawing.Color.Black;
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Word:";
            // 
            // txtNewWord
            // 
            this.txtNewWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewWord.Location = new System.Drawing.Point(126, 40);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(237, 23);
            this.txtNewWord.TabIndex = 5;
            this.txtNewWord.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtNewWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.btnRemoveWord);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSelectedWord);
            this.groupBox5.Location = new System.Drawing.Point(3, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 200);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "REMOVE";
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveWord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRemoveWord.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveWord.BorderRadius = 10;
            this.btnRemoveWord.BorderSize = 3;
            this.btnRemoveWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveWord.FlatAppearance.BorderSize = 0;
            this.btnRemoveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveWord.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWord.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveWord.Location = new System.Drawing.Point(19, 106);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(344, 50);
            this.btnRemoveWord.TabIndex = 8;
            this.btnRemoveWord.Text = "Remove Selected Word";
            this.btnRemoveWord.TextColor = System.Drawing.Color.Black;
            this.btnRemoveWord.UseVisualStyleBackColor = false;
            this.btnRemoveWord.Click += new System.EventHandler(this.Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selected Word:";
            // 
            // txtSelectedWord
            // 
            this.txtSelectedWord.Location = new System.Drawing.Point(126, 51);
            this.txtSelectedWord.Name = "txtSelectedWord";
            this.txtSelectedWord.ReadOnly = true;
            this.txtSelectedWord.Size = new System.Drawing.Size(237, 23);
            this.txtSelectedWord.TabIndex = 0;
            this.txtSelectedWord.TabStop = false;
            this.txtSelectedWord.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.cbTopicList);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(388, 7);
            this.groupBox6.Name = "groupBox6";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox6, 2);
            this.groupBox6.Size = new System.Drawing.Size(379, 414);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TOPIC LIST";
            // 
            // cbTopicList
            // 
            this.cbTopicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTopicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopicList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopicList.FormattingEnabled = true;
            this.cbTopicList.Location = new System.Drawing.Point(6, 22);
            this.cbTopicList.Name = "cbTopicList";
            this.cbTopicList.Size = new System.Drawing.Size(367, 30);
            this.cbTopicList.TabIndex = 4;
            this.cbTopicList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtSearchWord);
            this.groupBox7.Controls.Add(this.lbWordList);
            this.groupBox7.Location = new System.Drawing.Point(0, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(379, 356);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "WORD LIST";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Search:";
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchWord.Location = new System.Drawing.Point(67, 22);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(306, 23);
            this.txtSearchWord.TabIndex = 9;
            this.txtSearchWord.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // lbWordList
            // 
            this.lbWordList.FormattingEnabled = true;
            this.lbWordList.ItemHeight = 18;
            this.lbWordList.Location = new System.Drawing.Point(6, 58);
            this.lbWordList.Name = "lbWordList";
            this.lbWordList.Size = new System.Drawing.Size(367, 292);
            this.lbWordList.TabIndex = 0;
            this.lbWordList.TabStop = false;
            this.lbWordList.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // tabHint
            // 
            this.tabHint.BackColor = System.Drawing.Color.White;
            this.tabHint.Controls.Add(this.tableLayoutPanel3);
            this.tabHint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHint.Location = new System.Drawing.Point(4, 22);
            this.tabHint.Name = "tabHint";
            this.tabHint.Size = new System.Drawing.Size(776, 435);
            this.tabHint.TabIndex = 2;
            this.tabHint.Text = "Hint Manager";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox10, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 429);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox9.Controls.Add(this.btnRemoveHint);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.txtCurrentHint);
            this.groupBox9.Location = new System.Drawing.Point(3, 221);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(379, 200);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "REMOVE";
            // 
            // btnRemoveHint
            // 
            this.btnRemoveHint.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveHint.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRemoveHint.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveHint.BorderRadius = 10;
            this.btnRemoveHint.BorderSize = 3;
            this.btnRemoveHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveHint.FlatAppearance.BorderSize = 0;
            this.btnRemoveHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHint.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHint.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveHint.Location = new System.Drawing.Point(19, 106);
            this.btnRemoveHint.Name = "btnRemoveHint";
            this.btnRemoveHint.Size = new System.Drawing.Size(344, 50);
            this.btnRemoveHint.TabIndex = 14;
            this.btnRemoveHint.Text = "Remove Current Hint";
            this.btnRemoveHint.TextColor = System.Drawing.Color.Black;
            this.btnRemoveHint.UseVisualStyleBackColor = false;
            this.btnRemoveHint.Click += new System.EventHandler(this.Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current Hint:";
            // 
            // txtCurrentHint
            // 
            this.txtCurrentHint.Location = new System.Drawing.Point(126, 51);
            this.txtCurrentHint.Name = "txtCurrentHint";
            this.txtCurrentHint.ReadOnly = true;
            this.txtCurrentHint.Size = new System.Drawing.Size(237, 23);
            this.txtCurrentHint.TabIndex = 0;
            this.txtCurrentHint.TabStop = false;
            this.txtCurrentHint.ReadOnlyChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox10.Controls.Add(this.cbTopicList2);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(388, 7);
            this.groupBox10.Name = "groupBox10";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox10, 2);
            this.groupBox10.Size = new System.Drawing.Size(379, 414);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "TOPIC LIST";
            // 
            // cbTopicList2
            // 
            this.cbTopicList2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTopicList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopicList2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopicList2.FormattingEnabled = true;
            this.cbTopicList2.Location = new System.Drawing.Point(6, 22);
            this.cbTopicList2.Name = "cbTopicList2";
            this.cbTopicList2.Size = new System.Drawing.Size(367, 30);
            this.cbTopicList2.TabIndex = 10;
            this.cbTopicList2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.txtSearchWord2);
            this.groupBox11.Controls.Add(this.lbWordList2);
            this.groupBox11.Location = new System.Drawing.Point(0, 58);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(379, 356);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "WORD LIST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Search:";
            // 
            // txtSearchWord2
            // 
            this.txtSearchWord2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchWord2.Location = new System.Drawing.Point(67, 22);
            this.txtSearchWord2.Name = "txtSearchWord2";
            this.txtSearchWord2.Size = new System.Drawing.Size(306, 23);
            this.txtSearchWord2.TabIndex = 11;
            this.txtSearchWord2.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // lbWordList2
            // 
            this.lbWordList2.FormattingEnabled = true;
            this.lbWordList2.ItemHeight = 18;
            this.lbWordList2.Location = new System.Drawing.Point(6, 58);
            this.lbWordList2.Name = "lbWordList2";
            this.lbWordList2.Size = new System.Drawing.Size(367, 292);
            this.lbWordList2.TabIndex = 0;
            this.lbWordList2.TabStop = false;
            this.lbWordList2.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.txtNewHint2);
            this.groupBox8.Controls.Add(this.btnAddHint);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtSelectedWord2);
            this.groupBox8.Location = new System.Drawing.Point(3, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(379, 200);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ADD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "New Hint:";
            // 
            // txtNewHint2
            // 
            this.txtNewHint2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewHint2.Location = new System.Drawing.Point(126, 69);
            this.txtNewHint2.Name = "txtNewHint2";
            this.txtNewHint2.Size = new System.Drawing.Size(237, 23);
            this.txtNewHint2.TabIndex = 12;
            this.txtNewHint2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btnAddHint
            // 
            this.btnAddHint.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddHint.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAddHint.BorderColor = System.Drawing.Color.Gray;
            this.btnAddHint.BorderRadius = 10;
            this.btnAddHint.BorderSize = 3;
            this.btnAddHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHint.FlatAppearance.BorderSize = 0;
            this.btnAddHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHint.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHint.ForeColor = System.Drawing.Color.Black;
            this.btnAddHint.Location = new System.Drawing.Point(19, 106);
            this.btnAddHint.Name = "btnAddHint";
            this.btnAddHint.Size = new System.Drawing.Size(344, 50);
            this.btnAddHint.TabIndex = 13;
            this.btnAddHint.Text = "Add New Hint";
            this.btnAddHint.TextColor = System.Drawing.Color.Black;
            this.btnAddHint.UseVisualStyleBackColor = false;
            this.btnAddHint.Click += new System.EventHandler(this.Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Selected Word:";
            // 
            // txtSelectedWord2
            // 
            this.txtSelectedWord2.Enabled = false;
            this.txtSelectedWord2.Location = new System.Drawing.Point(126, 40);
            this.txtSelectedWord2.Name = "txtSelectedWord2";
            this.txtSelectedWord2.ReadOnly = true;
            this.txtSelectedWord2.Size = new System.Drawing.Size(237, 23);
            this.txtSelectedWord2.TabIndex = 0;
            this.txtSelectedWord2.TabStop = false;
            this.txtSelectedWord2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // FrmWordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tcManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmWordManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman | Word Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWordManagement_FormClosed);
            this.Load += new System.EventHandler(this.FrmWordManagement_Load);
            this.tcManagement.ResumeLayout(false);
            this.tabTopic.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabWord.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabHint.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManagement;
        private System.Windows.Forms.TabPage tabTopic;
        private System.Windows.Forms.TabPage tabWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedTopic;
        private CustomControls.RJButton btnAddTopic;
        private CustomControls.RJButton btnRemoveTopic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private CustomControls.RJButton btnAddWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.GroupBox groupBox5;
        private CustomControls.RJButton btnRemoveWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedWord;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbTopicList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewHint;
        private System.Windows.Forms.TabPage tabHint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewHint2;
        private CustomControls.RJButton btnAddHint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelectedWord2;
        private System.Windows.Forms.GroupBox groupBox9;
        private CustomControls.RJButton btnRemoveHint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentHint;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbTopicList2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lbTopicList;
        private System.Windows.Forms.ListBox lbWordList;
        private System.Windows.Forms.ListBox lbWordList2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchTopic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchWord2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}