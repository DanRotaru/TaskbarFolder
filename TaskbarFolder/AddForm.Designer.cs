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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.form_title = new System.Windows.Forms.Label();
            this.addFormClose = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.radioEditApps = new System.Windows.Forms.RadioButton();
            this.radioAddApps = new System.Windows.Forms.RadioButton();
            this.editAppsPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_by = new System.Windows.Forms.Label();
            this.heart_icon = new System.Windows.Forms.Label();
            this.form_link = new System.Windows.Forms.Label();
            this.form_message2 = new System.Windows.Forms.Label();
            this.byPanel = new System.Windows.Forms.Panel();
            this.editAppsInfo = new TaskbarFolder.DisabledLabel();
            ((System.ComponentModel.ISupportInitialize)(this.addFormClose)).BeginInit();
            this.dragPanel.SuspendLayout();
            this.byPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag and drop files here to add ";
            this.label1.Click += new System.EventHandler(this.selectFile);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(260, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
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
            this.label3.Location = new System.Drawing.Point(169, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 50);
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
            this.form_title.Location = new System.Drawing.Point(14, 22);
            this.form_title.Name = "form_title";
            this.form_title.Size = new System.Drawing.Size(258, 48);
            this.form_title.TabIndex = 20;
            this.form_title.Text = "Taskbar Folder";
            // 
            // addFormClose
            // 
            this.addFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFormClose.Image = ((System.Drawing.Image)(resources.GetObject("addFormClose.Image")));
            this.addFormClose.Location = new System.Drawing.Point(619, 25);
            this.addFormClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragPanel.Controls.Add(this.label3);
            this.dragPanel.Location = new System.Drawing.Point(14, 131);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(654, 562);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.Click += new System.EventHandler(this.selectFile);
            // 
            // radioEditApps
            // 
            this.radioEditApps.AutoSize = true;
            this.radioEditApps.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEditApps.ForeColor = System.Drawing.Color.White;
            this.radioEditApps.Location = new System.Drawing.Point(195, 81);
            this.radioEditApps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioEditApps.Name = "radioEditApps";
            this.radioEditApps.Size = new System.Drawing.Size(146, 34);
            this.radioEditApps.TabIndex = 27;
            this.radioEditApps.Text = "Edit app list";
            this.radioEditApps.UseVisualStyleBackColor = true;
            this.radioEditApps.CheckedChanged += new System.EventHandler(this.radioAppsCheck);
            // 
            // radioAddApps
            // 
            this.radioAddApps.AutoSize = true;
            this.radioAddApps.Checked = true;
            this.radioAddApps.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAddApps.ForeColor = System.Drawing.Color.White;
            this.radioAddApps.Location = new System.Drawing.Point(21, 81);
            this.radioAddApps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAddApps.Name = "radioAddApps";
            this.radioAddApps.Size = new System.Drawing.Size(170, 34);
            this.radioAddApps.TabIndex = 26;
            this.radioAddApps.TabStop = true;
            this.radioAddApps.Text = "Add new apps";
            this.radioAddApps.UseVisualStyleBackColor = true;
            this.radioAddApps.CheckedChanged += new System.EventHandler(this.radioAddApps_CheckedChanged);
            // 
            // editAppsPanel
            // 
            this.editAppsPanel.Location = new System.Drawing.Point(14, 131);
            this.editAppsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editAppsPanel.Name = "editAppsPanel";
            this.editAppsPanel.Size = new System.Drawing.Size(654, 512);
            this.editAppsPanel.TabIndex = 28;
            // 
            // label_by
            // 
            this.label_by.AutoSize = true;
            this.label_by.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_by.Location = new System.Drawing.Point(127, 0);
            this.label_by.Name = "label_by";
            this.label_by.Size = new System.Drawing.Size(37, 30);
            this.label_by.TabIndex = 32;
            this.label_by.Text = "by";
            // 
            // heart_icon
            // 
            this.heart_icon.AutoSize = true;
            this.heart_icon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heart_icon.ForeColor = System.Drawing.Color.Red;
            this.heart_icon.Location = new System.Drawing.Point(106, 0);
            this.heart_icon.Name = "heart_icon";
            this.heart_icon.Size = new System.Drawing.Size(28, 30);
            this.heart_icon.TabIndex = 31;
            this.heart_icon.Text = "♥";
            // 
            // form_link
            // 
            this.form_link.AutoSize = true;
            this.form_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.form_link.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.form_link.Location = new System.Drawing.Point(158, 0);
            this.form_link.Name = "form_link";
            this.form_link.Size = new System.Drawing.Size(119, 30);
            this.form_link.TabIndex = 30;
            this.form_link.Text = "DanRotaru";
            this.form_link.Click += new System.EventHandler(this.form_link_Click);
            // 
            // form_message2
            // 
            this.form_message2.AutoSize = true;
            this.form_message2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_message2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_message2.Location = new System.Drawing.Point(0, 0);
            this.form_message2.Name = "form_message2";
            this.form_message2.Size = new System.Drawing.Size(115, 30);
            this.form_message2.TabIndex = 29;
            this.form_message2.Text = "Made with";
            // 
            // byPanel
            // 
            this.byPanel.Controls.Add(this.form_link);
            this.byPanel.Controls.Add(this.heart_icon);
            this.byPanel.Controls.Add(this.label_by);
            this.byPanel.Controls.Add(this.form_message2);
            this.byPanel.Location = new System.Drawing.Point(397, 656);
            this.byPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byPanel.Name = "byPanel";
            this.byPanel.Size = new System.Drawing.Size(281, 35);
            this.byPanel.TabIndex = 33;
            this.byPanel.Visible = false;
            // 
            // editAppsInfo
            // 
            this.editAppsInfo.AutoSize = true;
            this.editAppsInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppsInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.editAppsInfo.Location = new System.Drawing.Point(17, 650);
            this.editAppsInfo.Name = "editAppsInfo";
            this.editAppsInfo.Size = new System.Drawing.Size(316, 42);
            this.editAppsInfo.TabIndex = 4;
            this.editAppsInfo.Text = "ℹ️ Click on icon to select new app icon\r\nClick on app name or path to select new " +
    "app";
            this.editAppsInfo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AddForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 711);
            this.Controls.Add(this.byPanel);
            this.Controls.Add(this.editAppsInfo);
            this.Controls.Add(this.editAppsPanel);
            this.Controls.Add(this.radioEditApps);
            this.Controls.Add(this.radioAddApps);
            this.Controls.Add(this.addFormClose);
            this.Controls.Add(this.form_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.byPanel.ResumeLayout(false);
            this.byPanel.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioEditApps;
        private System.Windows.Forms.RadioButton radioAddApps;
        private System.Windows.Forms.Panel editAppsPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private DisabledLabel editAppsInfo;
        private System.Windows.Forms.Label form_link;
        private System.Windows.Forms.Label form_message2;
        private System.Windows.Forms.Label label_by;
        private System.Windows.Forms.Label heart_icon;
        private System.Windows.Forms.Panel byPanel;
    }
}