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
            this.btn1 = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.Panel();
            this.btn3 = new System.Windows.Forms.Panel();
            this.btn4 = new System.Windows.Forms.Panel();
            this.delimiter = new System.Windows.Forms.Panel();
            this.disabledLabel4 = new TaskbarFolder.DisabledLabel();
            this.disabledLabel3 = new TaskbarFolder.DisabledLabel();
            this.disabledLabel2 = new TaskbarFolder.DisabledLabel();
            this.disabledLabel1 = new TaskbarFolder.DisabledLabel();
            this.btn1.SuspendLayout();
            this.btn2.SuspendLayout();
            this.btn3.SuspendLayout();
            this.btn4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn1.Controls.Add(this.disabledLabel1);
            this.btn1.Location = new System.Drawing.Point(10, 10);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn2.Controls.Add(this.disabledLabel2);
            this.btn2.Location = new System.Drawing.Point(10, 50);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(180, 35);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "btn2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn3.Controls.Add(this.disabledLabel3);
            this.btn3.Location = new System.Drawing.Point(10, 90);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(180, 35);
            this.btn3.TabIndex = 1;
            this.btn3.Tag = "btn3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn4.Controls.Add(this.disabledLabel4);
            this.btn4.Location = new System.Drawing.Point(10, 138);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(180, 35);
            this.btn4.TabIndex = 2;
            this.btn4.Tag = "btn4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
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
            // 
            // ContextMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(200, 190);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContextMenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ContextMenuForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContextMenuForm_Load);
            this.btn1.ResumeLayout(false);
            this.btn1.PerformLayout();
            this.btn2.ResumeLayout(false);
            this.btn2.PerformLayout();
            this.btn3.ResumeLayout(false);
            this.btn3.PerformLayout();
            this.btn4.ResumeLayout(false);
            this.btn4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btn1;
        private System.Windows.Forms.Panel btn2;
        private System.Windows.Forms.Panel btn3;
        private System.Windows.Forms.Panel btn4;
        private System.Windows.Forms.Panel delimiter;
        private DisabledLabel disabledLabel1;
        private DisabledLabel disabledLabel2;
        private DisabledLabel disabledLabel3;
        private DisabledLabel disabledLabel4;
    }
}