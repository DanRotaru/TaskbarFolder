namespace TaskbarFolder
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.form_title = new System.Windows.Forms.Label();
            this.addFormClose = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.addFormClose)).BeginInit();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag and drop files here to add ";
            this.label1.Click += new System.EventHandler(this.selectFile);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(231, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or click to select";
            this.label2.Click += new System.EventHandler(this.selectFile);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(150, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Or click here to edit TaskbarFolder.ini file \r\nby adding apps path, delimited wit" +
    "h ;";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // form_title
            // 
            this.form_title.AutoSize = true;
            this.form_title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_title.ForeColor = System.Drawing.Color.White;
            this.form_title.Location = new System.Drawing.Point(12, 18);
            this.form_title.Name = "form_title";
            this.form_title.Size = new System.Drawing.Size(216, 41);
            this.form_title.TabIndex = 20;
            this.form_title.Text = "Taskbar Folder";
            // 
            // addFormClose
            // 
            this.addFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFormClose.Image = ((System.Drawing.Image)(resources.GetObject("addFormClose.Image")));
            this.addFormClose.Location = new System.Drawing.Point(550, 20);
            this.addFormClose.Name = "addFormClose";
            this.addFormClose.Size = new System.Drawing.Size(36, 36);
            this.addFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addFormClose.TabIndex = 21;
            this.addFormClose.TabStop = false;
            this.addFormClose.Click += new System.EventHandler(this.addFormClose_Click);
            this.addFormClose.MouseEnter += new System.EventHandler(this.addFormClose_MouseEnter);
            this.addFormClose.MouseLeave += new System.EventHandler(this.addFormClose_MouseLeave);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dragPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dragPanel.BackgroundImage")));
            this.dragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dragPanel.Controls.Add(this.label3);
            this.dragPanel.Location = new System.Drawing.Point(12, 105);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(581, 450);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.Click += new System.EventHandler(this.selectFile);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(606, 569);
            this.Controls.Add(this.addFormClose);
            this.Controls.Add(this.form_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taskbar Folder - Add Apps";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.AddForm_DragLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.addFormClose)).EndInit();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox addFormClose;
        private System.Windows.Forms.Label form_title;
        private System.Windows.Forms.Panel dragPanel;
    }
}