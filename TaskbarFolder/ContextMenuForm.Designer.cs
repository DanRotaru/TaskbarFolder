namespace TaskbarFolder
{
    partial class ContextMenuForm
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
            this.showBtn = new System.Windows.Forms.Panel();
            this.disabledLabel1 = new TaskbarFolder.DisabledLabel();
            this.restartBtn = new System.Windows.Forms.Panel();
            this.disabledLabel2 = new TaskbarFolder.DisabledLabel();
            this.settingsBtn = new System.Windows.Forms.Panel();
            this.disabledLabel3 = new TaskbarFolder.DisabledLabel();
            this.exitBtn = new System.Windows.Forms.Panel();
            this.disabledLabel4 = new TaskbarFolder.DisabledLabel();
            this.delimiter = new System.Windows.Forms.Panel();
            this.showBtn.SuspendLayout();
            this.restartBtn.SuspendLayout();
            this.settingsBtn.SuspendLayout();
            this.exitBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.showBtn.Controls.Add(this.disabledLabel1);
            this.showBtn.Location = new System.Drawing.Point(10, 10);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(180, 35);
            this.showBtn.TabIndex = 0;
            this.showBtn.Tag = "btn1";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // disabledLabel1
            // 
            this.disabledLabel1.AutoSize = true;
            this.disabledLabel1.Enabled = false;
            this.disabledLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.disabledLabel1.ForeColor = System.Drawing.Color.White;
            this.disabledLabel1.Location = new System.Drawing.Point(25, 6);
            this.disabledLabel1.Name = "disabledLabel1";
            this.disabledLabel1.Size = new System.Drawing.Size(51, 23);
            this.disabledLabel1.TabIndex = 1;
            this.disabledLabel1.Text = "Show";
            this.disabledLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.restartBtn.Controls.Add(this.disabledLabel2);
            this.restartBtn.Location = new System.Drawing.Point(10, 50);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(180, 35);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Tag = "btn2";
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // disabledLabel2
            // 
            this.disabledLabel2.AutoSize = true;
            this.disabledLabel2.Enabled = false;
            this.disabledLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.disabledLabel2.ForeColor = System.Drawing.Color.White;
            this.disabledLabel2.Location = new System.Drawing.Point(25, 6);
            this.disabledLabel2.Name = "disabledLabel2";
            this.disabledLabel2.Size = new System.Drawing.Size(63, 23);
            this.disabledLabel2.TabIndex = 2;
            this.disabledLabel2.Text = "Restart";
            this.disabledLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.settingsBtn.Controls.Add(this.disabledLabel3);
            this.settingsBtn.Location = new System.Drawing.Point(10, 90);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(180, 35);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Tag = "btn3";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // disabledLabel3
            // 
            this.disabledLabel3.AutoSize = true;
            this.disabledLabel3.Enabled = false;
            this.disabledLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.disabledLabel3.ForeColor = System.Drawing.Color.White;
            this.disabledLabel3.Location = new System.Drawing.Point(25, 6);
            this.disabledLabel3.Name = "disabledLabel3";
            this.disabledLabel3.Size = new System.Drawing.Size(71, 23);
            this.disabledLabel3.TabIndex = 3;
            this.disabledLabel3.Text = "Settings";
            this.disabledLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.exitBtn.Controls.Add(this.disabledLabel4);
            this.exitBtn.Location = new System.Drawing.Point(10, 138);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(180, 35);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Tag = "btn4";
            this.exitBtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // disabledLabel4
            // 
            this.disabledLabel4.AutoSize = true;
            this.disabledLabel4.Enabled = false;
            this.disabledLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.disabledLabel4.ForeColor = System.Drawing.Color.White;
            this.disabledLabel4.Location = new System.Drawing.Point(25, 6);
            this.disabledLabel4.Name = "disabledLabel4";
            this.disabledLabel4.Size = new System.Drawing.Size(37, 23);
            this.disabledLabel4.TabIndex = 4;
            this.disabledLabel4.Text = "Exit";
            this.disabledLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // delimiter
            // 
            this.delimiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.delimiter.Location = new System.Drawing.Point(10, 131);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(180, 1);
            this.delimiter.TabIndex = 3;
            this.delimiter.Tag = "delimiter";
            // 
            // ContextMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(200, 185);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.showBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContextMenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ContextMenuForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContextMenuForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ContextMenuForm_VisibleChanged);
            this.showBtn.ResumeLayout(false);
            this.showBtn.PerformLayout();
            this.restartBtn.ResumeLayout(false);
            this.restartBtn.PerformLayout();
            this.settingsBtn.ResumeLayout(false);
            this.settingsBtn.PerformLayout();
            this.exitBtn.ResumeLayout(false);
            this.exitBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showBtn;
        private System.Windows.Forms.Panel restartBtn;
        private System.Windows.Forms.Panel settingsBtn;
        private System.Windows.Forms.Panel exitBtn;
        private System.Windows.Forms.Panel delimiter;
        private DisabledLabel disabledLabel1;
        private DisabledLabel disabledLabel2;
        private DisabledLabel disabledLabel3;
        private DisabledLabel disabledLabel4;
    }
}