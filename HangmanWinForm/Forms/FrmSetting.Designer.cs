namespace HangmanWinForm
{
    partial class FrmSetting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWordMgt = new HangmanWinForm.CustomControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tlpGameplay = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnableHint = new HangmanWinForm.CustomControls.RJButton();
            this.btnEnableTimer = new HangmanWinForm.CustomControls.RJButton();
            this.btnEnableScore = new HangmanWinForm.CustomControls.RJButton();
            this.btnDificulty = new HangmanWinForm.CustomControls.RJButton();
            this.btnSound = new HangmanWinForm.CustomControls.RJButton();
            this.btnVolume = new HangmanWinForm.CustomControls.RJButton();
            this.btnDisplayWord = new HangmanWinForm.CustomControls.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlpGameplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOptions.Controls.Add(this.tlpGameplay);
            this.gbOptions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(3, 30);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(376, 400);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Gameplay";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Difficulty";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enable Timer";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enable Hint";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnWordMgt);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(405, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // btnWordMgt
            // 
            this.btnWordMgt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWordMgt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnWordMgt.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.btnWordMgt.BorderColor = System.Drawing.Color.Black;
            this.btnWordMgt.BorderRadius = 10;
            this.btnWordMgt.BorderSize = 1;
            this.btnWordMgt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordMgt.FlatAppearance.BorderSize = 0;
            this.btnWordMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordMgt.ForeColor = System.Drawing.Color.Black;
            this.btnWordMgt.Location = new System.Drawing.Point(6, 27);
            this.btnWordMgt.Name = "btnWordMgt";
            this.btnWordMgt.Size = new System.Drawing.Size(364, 50);
            this.btnWordMgt.TabIndex = 1;
            this.btnWordMgt.Text = "Word Management";
            this.btnWordMgt.TextColor = System.Drawing.Color.Black;
            this.btnWordMgt.UseVisualStyleBackColor = false;
            this.btnWordMgt.Click += new System.EventHandler(this.btnWordMgt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sound";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Display correct word at the end";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Volume";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enable Score";
            // 
            // tlpGameplay
            // 
            this.tlpGameplay.ColumnCount = 2;
            this.tlpGameplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpGameplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGameplay.Controls.Add(this.btnDisplayWord, 1, 6);
            this.tlpGameplay.Controls.Add(this.btnVolume, 1, 5);
            this.tlpGameplay.Controls.Add(this.btnSound, 1, 4);
            this.tlpGameplay.Controls.Add(this.btnDificulty, 1, 3);
            this.tlpGameplay.Controls.Add(this.btnEnableScore, 1, 2);
            this.tlpGameplay.Controls.Add(this.btnEnableTimer, 1, 1);
            this.tlpGameplay.Controls.Add(this.label6, 0, 5);
            this.tlpGameplay.Controls.Add(this.label1, 0, 0);
            this.tlpGameplay.Controls.Add(this.label4, 0, 4);
            this.tlpGameplay.Controls.Add(this.label2, 0, 1);
            this.tlpGameplay.Controls.Add(this.label3, 0, 3);
            this.tlpGameplay.Controls.Add(this.label7, 0, 2);
            this.tlpGameplay.Controls.Add(this.label5, 0, 6);
            this.tlpGameplay.Controls.Add(this.btnEnableHint, 1, 0);
            this.tlpGameplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGameplay.Location = new System.Drawing.Point(3, 22);
            this.tlpGameplay.Name = "tlpGameplay";
            this.tlpGameplay.RowCount = 7;
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpGameplay.Size = new System.Drawing.Size(370, 375);
            this.tlpGameplay.TabIndex = 0;
            // 
            // btnEnableHint
            // 
            this.btnEnableHint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnableHint.BackColor = System.Drawing.Color.Crimson;
            this.btnEnableHint.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnEnableHint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnableHint.BorderRadius = 20;
            this.btnEnableHint.BorderSize = 0;
            this.btnEnableHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnableHint.Enabled = false;
            this.btnEnableHint.FlatAppearance.BorderSize = 0;
            this.btnEnableHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableHint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableHint.ForeColor = System.Drawing.Color.White;
            this.btnEnableHint.Location = new System.Drawing.Point(264, 10);
            this.btnEnableHint.Name = "btnEnableHint";
            this.btnEnableHint.Size = new System.Drawing.Size(100, 40);
            this.btnEnableHint.TabIndex = 4;
            this.btnEnableHint.TabStop = false;
            this.btnEnableHint.Text = "Disabled";
            this.btnEnableHint.TextColor = System.Drawing.Color.White;
            this.btnEnableHint.UseVisualStyleBackColor = false;
            // 
            // btnEnableTimer
            // 
            this.btnEnableTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnableTimer.BackColor = System.Drawing.Color.Crimson;
            this.btnEnableTimer.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnEnableTimer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnableTimer.BorderRadius = 20;
            this.btnEnableTimer.BorderSize = 0;
            this.btnEnableTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnableTimer.Enabled = false;
            this.btnEnableTimer.FlatAppearance.BorderSize = 0;
            this.btnEnableTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableTimer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableTimer.ForeColor = System.Drawing.Color.White;
            this.btnEnableTimer.Location = new System.Drawing.Point(264, 66);
            this.btnEnableTimer.Name = "btnEnableTimer";
            this.btnEnableTimer.Size = new System.Drawing.Size(100, 40);
            this.btnEnableTimer.TabIndex = 5;
            this.btnEnableTimer.TabStop = false;
            this.btnEnableTimer.Text = "Disabled";
            this.btnEnableTimer.TextColor = System.Drawing.Color.White;
            this.btnEnableTimer.UseVisualStyleBackColor = false;
            // 
            // btnEnableScore
            // 
            this.btnEnableScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnableScore.BackColor = System.Drawing.Color.Crimson;
            this.btnEnableScore.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnEnableScore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnableScore.BorderRadius = 20;
            this.btnEnableScore.BorderSize = 0;
            this.btnEnableScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnableScore.Enabled = false;
            this.btnEnableScore.FlatAppearance.BorderSize = 0;
            this.btnEnableScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableScore.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableScore.ForeColor = System.Drawing.Color.White;
            this.btnEnableScore.Location = new System.Drawing.Point(264, 118);
            this.btnEnableScore.Name = "btnEnableScore";
            this.btnEnableScore.Size = new System.Drawing.Size(100, 40);
            this.btnEnableScore.TabIndex = 6;
            this.btnEnableScore.TabStop = false;
            this.btnEnableScore.Text = "Disabled";
            this.btnEnableScore.TextColor = System.Drawing.Color.White;
            this.btnEnableScore.UseVisualStyleBackColor = false;
            // 
            // btnDificulty
            // 
            this.btnDificulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDificulty.BackColor = System.Drawing.Color.Crimson;
            this.btnDificulty.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDificulty.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDificulty.BorderRadius = 20;
            this.btnDificulty.BorderSize = 0;
            this.btnDificulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDificulty.Enabled = false;
            this.btnDificulty.FlatAppearance.BorderSize = 0;
            this.btnDificulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDificulty.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificulty.ForeColor = System.Drawing.Color.White;
            this.btnDificulty.Location = new System.Drawing.Point(264, 170);
            this.btnDificulty.Name = "btnDificulty";
            this.btnDificulty.Size = new System.Drawing.Size(100, 40);
            this.btnDificulty.TabIndex = 7;
            this.btnDificulty.TabStop = false;
            this.btnDificulty.Text = "Disabled";
            this.btnDificulty.TextColor = System.Drawing.Color.White;
            this.btnDificulty.UseVisualStyleBackColor = false;
            // 
            // btnSound
            // 
            this.btnSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSound.BackColor = System.Drawing.Color.Crimson;
            this.btnSound.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnSound.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSound.BorderRadius = 20;
            this.btnSound.BorderSize = 0;
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.Enabled = false;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.Color.White;
            this.btnSound.Location = new System.Drawing.Point(264, 222);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(100, 40);
            this.btnSound.TabIndex = 8;
            this.btnSound.TabStop = false;
            this.btnSound.Text = "Disabled";
            this.btnSound.TextColor = System.Drawing.Color.White;
            this.btnSound.UseVisualStyleBackColor = false;
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolume.BackColor = System.Drawing.Color.Crimson;
            this.btnVolume.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnVolume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolume.BorderRadius = 20;
            this.btnVolume.BorderSize = 0;
            this.btnVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolume.Enabled = false;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.ForeColor = System.Drawing.Color.White;
            this.btnVolume.Location = new System.Drawing.Point(264, 274);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(100, 40);
            this.btnVolume.TabIndex = 9;
            this.btnVolume.TabStop = false;
            this.btnVolume.Text = "Disabled";
            this.btnVolume.TextColor = System.Drawing.Color.White;
            this.btnVolume.UseVisualStyleBackColor = false;
            // 
            // btnDisplayWord
            // 
            this.btnDisplayWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplayWord.BackColor = System.Drawing.Color.Crimson;
            this.btnDisplayWord.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDisplayWord.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDisplayWord.BorderRadius = 20;
            this.btnDisplayWord.BorderSize = 0;
            this.btnDisplayWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayWord.Enabled = false;
            this.btnDisplayWord.FlatAppearance.BorderSize = 0;
            this.btnDisplayWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayWord.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayWord.ForeColor = System.Drawing.Color.White;
            this.btnDisplayWord.Location = new System.Drawing.Point(264, 327);
            this.btnDisplayWord.Name = "btnDisplayWord";
            this.btnDisplayWord.Size = new System.Drawing.Size(100, 40);
            this.btnDisplayWord.TabIndex = 10;
            this.btnDisplayWord.TabStop = false;
            this.btnDisplayWord.Text = "Disabled";
            this.btnDisplayWord.TextColor = System.Drawing.Color.White;
            this.btnDisplayWord.UseVisualStyleBackColor = false;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman | Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSetting_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tlpGameplay.ResumeLayout(false);
            this.tlpGameplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.RJButton btnWordMgt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tlpGameplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJButton btnEnableHint;
        private CustomControls.RJButton btnDisplayWord;
        private CustomControls.RJButton btnVolume;
        private CustomControls.RJButton btnSound;
        private CustomControls.RJButton btnDificulty;
        private CustomControls.RJButton btnEnableScore;
        private CustomControls.RJButton btnEnableTimer;
    }
}