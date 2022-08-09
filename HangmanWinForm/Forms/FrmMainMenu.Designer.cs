namespace HangmanWinForm
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelbackground = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new HangmanWinForm.CustomControls.RJButton();
            this.btnSetting = new HangmanWinForm.CustomControls.RJButton();
            this.btnNewGame = new HangmanWinForm.CustomControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelParent.SuspendLayout();
            this.panelbackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.panelbackground);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(784, 461);
            this.panelParent.TabIndex = 0;
            // 
            // panelbackground
            // 
            this.panelbackground.BackColor = System.Drawing.Color.Transparent;
            this.panelbackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelbackground.BackgroundImage")));
            this.panelbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbackground.Controls.Add(this.label3);
            this.panelbackground.Controls.Add(this.label2);
            this.panelbackground.Controls.Add(this.btnExit);
            this.panelbackground.Controls.Add(this.btnSetting);
            this.panelbackground.Controls.Add(this.btnNewGame);
            this.panelbackground.Controls.Add(this.label1);
            this.panelbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbackground.Location = new System.Drawing.Point(0, 0);
            this.panelbackground.Name = "panelbackground";
            this.panelbackground.Size = new System.Drawing.Size(784, 461);
            this.panelbackground.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developed by Synir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version 0.2";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnExit.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderSize = 3;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Oswald Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(457, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSetting.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetting.BorderRadius = 10;
            this.btnSetting.BorderSize = 3;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Oswald Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(457, 126);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(300, 60);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextColor = System.Drawing.Color.Black;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewGame.BorderRadius = 10;
            this.btnNewGame.BorderSize = 3;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Oswald Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(457, 49);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(300, 60);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.TextColor = System.Drawing.Color.Black;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangman";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.panelParent.ResumeLayout(false);
            this.panelbackground.ResumeLayout(false);
            this.panelbackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelbackground;
        private CustomControls.RJButton btnNewGame;
        private CustomControls.RJButton btnExit;
        private CustomControls.RJButton btnSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

