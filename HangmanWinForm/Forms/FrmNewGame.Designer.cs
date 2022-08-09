namespace HangmanWinForm
{
    partial class FrmNewGame
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panelC1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowPanelBlanks = new System.Windows.Forms.FlowLayoutPanel();
            this.panelC2 = new System.Windows.Forms.Panel();
            this.lblWordHint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbStickman = new System.Windows.Forms.PictureBox();
            this.btnRestart = new HangmanWinForm.CustomControls.RJButton();
            this.btnBack = new HangmanWinForm.CustomControls.RJButton();
            this.btnUseHint = new HangmanWinForm.CustomControls.RJButton();
            this.panelBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelC1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStickman)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.White;
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1184, 661);
            this.panelBackground.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.flowPanelButtons, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelC2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.67322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.32678F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowPanelButtons
            // 
            this.flowPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelButtons.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPanelButtons.Location = new System.Drawing.Point(3, 371);
            this.flowPanelButtons.Name = "flowPanelButtons";
            this.flowPanelButtons.Size = new System.Drawing.Size(704, 287);
            this.flowPanelButtons.TabIndex = 5;
            // 
            // panelC1
            // 
            this.panelC1.Controls.Add(this.tableLayoutPanel2);
            this.panelC1.Controls.Add(this.btnRestart);
            this.panelC1.Controls.Add(this.btnBack);
            this.panelC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC1.Location = new System.Drawing.Point(3, 3);
            this.panelC1.Name = "panelC1";
            this.panelC1.Size = new System.Drawing.Size(704, 362);
            this.panelC1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowPanelBlanks, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 60);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // flowPanelBlanks
            // 
            this.flowPanelBlanks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelBlanks.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPanelBlanks.Location = new System.Drawing.Point(99, 5);
            this.flowPanelBlanks.Name = "flowPanelBlanks";
            this.flowPanelBlanks.Size = new System.Drawing.Size(500, 50);
            this.flowPanelBlanks.TabIndex = 7;
            // 
            // panelC2
            // 
            this.panelC2.Controls.Add(this.lblWordHint);
            this.panelC2.Controls.Add(this.label3);
            this.panelC2.Controls.Add(this.pbStickman);
            this.panelC2.Controls.Add(this.btnUseHint);
            this.panelC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelC2.Location = new System.Drawing.Point(713, 3);
            this.panelC2.Name = "panelC2";
            this.tableLayoutPanel1.SetRowSpan(this.panelC2, 2);
            this.panelC2.Size = new System.Drawing.Size(468, 655);
            this.panelC2.TabIndex = 1;
            // 
            // lblWordHint
            // 
            this.lblWordHint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordHint.Location = new System.Drawing.Point(3, 474);
            this.lblWordHint.Name = "lblWordHint";
            this.lblWordHint.Size = new System.Drawing.Size(462, 23);
            this.lblWordHint.TabIndex = 4;
            this.lblWordHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note:  Use hint will choose 1 letter correctly and display hint.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStickman
            // 
            this.pbStickman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStickman.Location = new System.Drawing.Point(59, 37);
            this.pbStickman.Name = "pbStickman";
            this.pbStickman.Size = new System.Drawing.Size(350, 400);
            this.pbStickman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStickman.TabIndex = 3;
            this.pbStickman.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestart.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestart.BorderRadius = 5;
            this.btnRestart.BorderSize = 0;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(109, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 40);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "New Game";
            this.btnRestart.TextColor = System.Drawing.Color.White;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 5;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnUseHint
            // 
            this.btnUseHint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUseHint.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnUseHint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUseHint.BorderRadius = 5;
            this.btnUseHint.BorderSize = 0;
            this.btnUseHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseHint.FlatAppearance.BorderSize = 0;
            this.btnUseHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseHint.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseHint.ForeColor = System.Drawing.Color.White;
            this.btnUseHint.Location = new System.Drawing.Point(159, 557);
            this.btnUseHint.Name = "btnUseHint";
            this.btnUseHint.Size = new System.Drawing.Size(150, 40);
            this.btnUseHint.TabIndex = 3;
            this.btnUseHint.Text = "Use Hint";
            this.btnUseHint.TextColor = System.Drawing.Color.White;
            this.btnUseHint.UseVisualStyleBackColor = false;
            this.btnUseHint.Click += new System.EventHandler(this.Button_Click);
            // 
            // FrmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman | New Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewGame_Load);
            this.panelBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelC1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelC2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStickman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelC2;
        private System.Windows.Forms.FlowLayoutPanel flowPanelButtons;
        private System.Windows.Forms.PictureBox pbStickman;
        private CustomControls.RJButton btnUseHint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelC1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBlanks;
        private CustomControls.RJButton btnRestart;
        private CustomControls.RJButton btnBack;
        private System.Windows.Forms.Label lblWordHint;
    }
}