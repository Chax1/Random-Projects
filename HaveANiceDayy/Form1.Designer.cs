namespace HaveANiceDay
{
    partial class MainWindow
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SecondaryLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(800, 450);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "N/A";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPanel.Controls.Add(this.SecondaryLabel);
            this.MainPanel.Location = new System.Drawing.Point(-9, -8);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(898, 35);
            this.MainPanel.TabIndex = 1;
            // 
            // SecondaryLabel
            // 
            this.SecondaryLabel.AutoSize = true;
            this.SecondaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SecondaryLabel.Location = new System.Drawing.Point(15, 14);
            this.SecondaryLabel.Name = "SecondaryLabel";
            this.SecondaryLabel.Size = new System.Drawing.Size(88, 13);
            this.SecondaryLabel.TabIndex = 0;
            this.SecondaryLabel.Text = "Have a nice day!";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Have a nice day";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label SecondaryLabel;
    }
}

