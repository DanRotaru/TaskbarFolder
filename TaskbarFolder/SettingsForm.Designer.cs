namespace TaskbarFolder
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.form_title = new System.Windows.Forms.Label();
            this.form_message = new System.Windows.Forms.Label();
            this.form_message2 = new System.Windows.Forms.Label();
            this.form_link = new System.Windows.Forms.Label();
            this.form_menu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.form_settings_theme1 = new System.Windows.Forms.Label();
            this.themeLight = new System.Windows.Forms.RadioButton();
            this.themeDark = new System.Windows.Forms.RadioButton();
            this.form_settings_theme = new System.Windows.Forms.Label();
            this.themeIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimalView = new System.Windows.Forms.CheckBox();
            this.form_settings_view1 = new System.Windows.Forms.Label();
            this.form_settings_view = new System.Windows.Forms.Label();
            this.minimalViewIcon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.onTopCheck = new System.Windows.Forms.CheckBox();
            this.form_settings_ontop1 = new System.Windows.Forms.Label();
            this.form_settings_ontop = new System.Windows.Forms.Label();
            this.onTopIcon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.location_y_val = new System.Windows.Forms.TextBox();
            this.location_x_val = new System.Windows.Forms.TextBox();
            this.saveLocationCheck = new System.Windows.Forms.CheckBox();
            this.form_settings_location1 = new System.Windows.Forms.Label();
            this.form_settings_location = new System.Windows.Forms.Label();
            this.locationIcon = new System.Windows.Forms.PictureBox();
            this.textBoxPadding1 = new System.Windows.Forms.Panel();
            this.textBoxPadding2 = new System.Windows.Forms.Panel();
            this.form_menu_msg = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.columns = new System.Windows.Forms.TextBox();
            this.useColumnsIndex = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPadding3 = new System.Windows.Forms.Panel();
            this.heart_icon = new System.Windows.Forms.Label();
            this.label_by = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimalViewIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onTopIcon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationIcon)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // form_title
            // 
            this.form_title.AutoSize = true;
            this.form_title.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_title.ForeColor = System.Drawing.Color.White;
            this.form_title.Location = new System.Drawing.Point(15, 15);
            this.form_title.Name = "form_title";
            this.form_title.Size = new System.Drawing.Size(158, 50);
            this.form_title.TabIndex = 0;
            this.form_title.Text = "Settings";
            // 
            // form_message
            // 
            this.form_message.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_message.Location = new System.Drawing.Point(19, 82);
            this.form_message.Name = "form_message";
            this.form_message.Size = new System.Drawing.Size(383, 50);
            this.form_message.TabIndex = 1;
            this.form_message.Text = "Taskbar Folder is a quick application which boost your productivity. ";
            // 
            // form_message2
            // 
            this.form_message2.AutoSize = true;
            this.form_message2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_message2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_message2.Location = new System.Drawing.Point(19, 132);
            this.form_message2.Name = "form_message2";
            this.form_message2.Size = new System.Drawing.Size(95, 25);
            this.form_message2.TabIndex = 2;
            this.form_message2.Text = "Made with";
            // 
            // form_link
            // 
            this.form_link.AutoSize = true;
            this.form_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.form_link.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.form_link.Location = new System.Drawing.Point(152, 132);
            this.form_link.Name = "form_link";
            this.form_link.Size = new System.Drawing.Size(101, 25);
            this.form_link.TabIndex = 3;
            this.form_link.Text = "DanRotaru";
            this.form_link.Click += new System.EventHandler(this.me_link_Click);
            // 
            // form_menu
            // 
            this.form_menu.AutoSize = true;
            this.form_menu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_menu.ForeColor = System.Drawing.Color.White;
            this.form_menu.Location = new System.Drawing.Point(19, 169);
            this.form_menu.Name = "form_menu";
            this.form_menu.Size = new System.Drawing.Size(225, 25);
            this.form_menu.TabIndex = 4;
            this.form_menu.Text = "Appearance && behaviour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.form_settings_theme1);
            this.panel1.Controls.Add(this.themeLight);
            this.panel1.Controls.Add(this.themeDark);
            this.panel1.Controls.Add(this.form_settings_theme);
            this.panel1.Controls.Add(this.themeIcon);
            this.panel1.Location = new System.Drawing.Point(24, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 80);
            this.panel1.TabIndex = 5;
            // 
            // form_settings_theme1
            // 
            this.form_settings_theme1.AutoSize = true;
            this.form_settings_theme1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_theme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_settings_theme1.Location = new System.Drawing.Point(59, 39);
            this.form_settings_theme1.Name = "form_settings_theme1";
            this.form_settings_theme1.Size = new System.Drawing.Size(219, 20);
            this.form_settings_theme1.TabIndex = 10;
            this.form_settings_theme1.Text = "Choose application appearance";
            // 
            // themeLight
            // 
            this.themeLight.AutoSize = true;
            this.themeLight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.themeLight.Location = new System.Drawing.Point(293, 13);
            this.themeLight.Name = "themeLight";
            this.themeLight.Size = new System.Drawing.Size(69, 27);
            this.themeLight.TabIndex = 9;
            this.themeLight.Text = "Light";
            this.themeLight.UseVisualStyleBackColor = true;
            this.themeLight.Click += new System.EventHandler(this.themeLight_Click);
            // 
            // themeDark
            // 
            this.themeDark.AutoSize = true;
            this.themeDark.Checked = true;
            this.themeDark.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeDark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.themeDark.Location = new System.Drawing.Point(293, 40);
            this.themeDark.Name = "themeDark";
            this.themeDark.Size = new System.Drawing.Size(66, 27);
            this.themeDark.TabIndex = 8;
            this.themeDark.TabStop = true;
            this.themeDark.Text = "Dark";
            this.themeDark.UseVisualStyleBackColor = true;
            this.themeDark.Click += new System.EventHandler(this.themeDark_Click);
            // 
            // form_settings_theme
            // 
            this.form_settings_theme.AutoSize = true;
            this.form_settings_theme.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_theme.ForeColor = System.Drawing.Color.White;
            this.form_settings_theme.Location = new System.Drawing.Point(59, 14);
            this.form_settings_theme.Name = "form_settings_theme";
            this.form_settings_theme.Size = new System.Drawing.Size(101, 25);
            this.form_settings_theme.TabIndex = 7;
            this.form_settings_theme.Text = "App theme";
            // 
            // themeIcon
            // 
            this.themeIcon.Image = ((System.Drawing.Image)(resources.GetObject("themeIcon.Image")));
            this.themeIcon.Location = new System.Drawing.Point(15, 20);
            this.themeIcon.Name = "themeIcon";
            this.themeIcon.Size = new System.Drawing.Size(35, 35);
            this.themeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.themeIcon.TabIndex = 6;
            this.themeIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.minimalView);
            this.panel2.Controls.Add(this.form_settings_view1);
            this.panel2.Controls.Add(this.form_settings_view);
            this.panel2.Controls.Add(this.minimalViewIcon);
            this.panel2.Location = new System.Drawing.Point(24, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 80);
            this.panel2.TabIndex = 7;
            // 
            // minimalView
            // 
            this.minimalView.AutoSize = true;
            this.minimalView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimalView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minimalView.Location = new System.Drawing.Point(293, 26);
            this.minimalView.Name = "minimalView";
            this.minimalView.Size = new System.Drawing.Size(56, 27);
            this.minimalView.TabIndex = 11;
            this.minimalView.Text = "Yes";
            this.minimalView.UseVisualStyleBackColor = true;
            this.minimalView.CheckedChanged += new System.EventHandler(this.minimalView_CheckedChanged);
            // 
            // form_settings_view1
            // 
            this.form_settings_view1.AutoSize = true;
            this.form_settings_view1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_view1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_settings_view1.Location = new System.Drawing.Point(59, 39);
            this.form_settings_view1.Name = "form_settings_view1";
            this.form_settings_view1.Size = new System.Drawing.Size(217, 20);
            this.form_settings_view1.TabIndex = 10;
            this.form_settings_view1.Text = "Hide settings and close buttons";
            // 
            // form_settings_view
            // 
            this.form_settings_view.AutoSize = true;
            this.form_settings_view.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_view.ForeColor = System.Drawing.Color.White;
            this.form_settings_view.Location = new System.Drawing.Point(59, 14);
            this.form_settings_view.Name = "form_settings_view";
            this.form_settings_view.Size = new System.Drawing.Size(115, 25);
            this.form_settings_view.TabIndex = 7;
            this.form_settings_view.Text = "Minimal view";
            // 
            // minimalViewIcon
            // 
            this.minimalViewIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimalViewIcon.Image")));
            this.minimalViewIcon.Location = new System.Drawing.Point(15, 20);
            this.minimalViewIcon.Name = "minimalViewIcon";
            this.minimalViewIcon.Size = new System.Drawing.Size(35, 35);
            this.minimalViewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimalViewIcon.TabIndex = 6;
            this.minimalViewIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.onTopCheck);
            this.panel3.Controls.Add(this.form_settings_ontop1);
            this.panel3.Controls.Add(this.form_settings_ontop);
            this.panel3.Controls.Add(this.onTopIcon);
            this.panel3.Location = new System.Drawing.Point(24, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 80);
            this.panel3.TabIndex = 12;
            // 
            // onTopCheck
            // 
            this.onTopCheck.AutoSize = true;
            this.onTopCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onTopCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.onTopCheck.Location = new System.Drawing.Point(293, 26);
            this.onTopCheck.Name = "onTopCheck";
            this.onTopCheck.Size = new System.Drawing.Size(56, 27);
            this.onTopCheck.TabIndex = 11;
            this.onTopCheck.Text = "Yes";
            this.onTopCheck.UseVisualStyleBackColor = true;
            this.onTopCheck.CheckedChanged += new System.EventHandler(this.ontop_CheckedChanged);
            // 
            // form_settings_ontop1
            // 
            this.form_settings_ontop1.AutoSize = true;
            this.form_settings_ontop1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_ontop1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_settings_ontop1.Location = new System.Drawing.Point(59, 39);
            this.form_settings_ontop1.Name = "form_settings_ontop1";
            this.form_settings_ontop1.Size = new System.Drawing.Size(182, 20);
            this.form_settings_ontop1.TabIndex = 10;
            this.form_settings_ontop1.Text = "Application will be on top";
            // 
            // form_settings_ontop
            // 
            this.form_settings_ontop.AutoSize = true;
            this.form_settings_ontop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_ontop.ForeColor = System.Drawing.Color.White;
            this.form_settings_ontop.Location = new System.Drawing.Point(59, 14);
            this.form_settings_ontop.Name = "form_settings_ontop";
            this.form_settings_ontop.Size = new System.Drawing.Size(104, 25);
            this.form_settings_ontop.TabIndex = 7;
            this.form_settings_ontop.Text = "Stay on top";
            // 
            // onTopIcon
            // 
            this.onTopIcon.Image = ((System.Drawing.Image)(resources.GetObject("onTopIcon.Image")));
            this.onTopIcon.Location = new System.Drawing.Point(15, 20);
            this.onTopIcon.Name = "onTopIcon";
            this.onTopIcon.Size = new System.Drawing.Size(35, 35);
            this.onTopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onTopIcon.TabIndex = 6;
            this.onTopIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.location_y_val);
            this.panel4.Controls.Add(this.location_x_val);
            this.panel4.Controls.Add(this.saveLocationCheck);
            this.panel4.Controls.Add(this.form_settings_location1);
            this.panel4.Controls.Add(this.form_settings_location);
            this.panel4.Controls.Add(this.locationIcon);
            this.panel4.Controls.Add(this.textBoxPadding1);
            this.panel4.Controls.Add(this.textBoxPadding2);
            this.panel4.Location = new System.Drawing.Point(24, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 121);
            this.panel4.TabIndex = 13;
            // 
            // location_y_val
            // 
            this.location_y_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.location_y_val.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location_y_val.Enabled = false;
            this.location_y_val.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.location_y_val.ForeColor = System.Drawing.Color.White;
            this.location_y_val.Location = new System.Drawing.Point(182, 74);
            this.location_y_val.Margin = new System.Windows.Forms.Padding(5);
            this.location_y_val.MaxLength = 5;
            this.location_y_val.Name = "location_y_val";
            this.location_y_val.Size = new System.Drawing.Size(70, 24);
            this.location_y_val.TabIndex = 13;
            this.location_y_val.Text = "0";
            this.location_y_val.TextChanged += new System.EventHandler(this.location_y_val_TextChanged);
            this.location_y_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // location_x_val
            // 
            this.location_x_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.location_x_val.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location_x_val.Enabled = false;
            this.location_x_val.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.location_x_val.ForeColor = System.Drawing.Color.White;
            this.location_x_val.Location = new System.Drawing.Point(74, 74);
            this.location_x_val.Margin = new System.Windows.Forms.Padding(5);
            this.location_x_val.MaxLength = 5;
            this.location_x_val.Name = "location_x_val";
            this.location_x_val.Size = new System.Drawing.Size(70, 24);
            this.location_x_val.TabIndex = 12;
            this.location_x_val.Text = "0";
            this.location_x_val.TextChanged += new System.EventHandler(this.location_x_val_TextChanged);
            this.location_x_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // saveLocationCheck
            // 
            this.saveLocationCheck.AutoSize = true;
            this.saveLocationCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocationCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.saveLocationCheck.Location = new System.Drawing.Point(293, 26);
            this.saveLocationCheck.Name = "saveLocationCheck";
            this.saveLocationCheck.Size = new System.Drawing.Size(56, 27);
            this.saveLocationCheck.TabIndex = 11;
            this.saveLocationCheck.Text = "Yes";
            this.saveLocationCheck.UseVisualStyleBackColor = true;
            this.saveLocationCheck.CheckedChanged += new System.EventHandler(this.saveLocationCheck_CheckedChanged);
            // 
            // form_settings_location1
            // 
            this.form_settings_location1.AutoSize = true;
            this.form_settings_location1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_location1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_settings_location1.Location = new System.Drawing.Point(59, 39);
            this.form_settings_location1.Name = "form_settings_location1";
            this.form_settings_location1.Size = new System.Drawing.Size(212, 20);
            this.form_settings_location1.TabIndex = 10;
            this.form_settings_location1.Text = "Save application location (x, y)";
            // 
            // form_settings_location
            // 
            this.form_settings_location.AutoSize = true;
            this.form_settings_location.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_settings_location.ForeColor = System.Drawing.Color.White;
            this.form_settings_location.Location = new System.Drawing.Point(59, 14);
            this.form_settings_location.Name = "form_settings_location";
            this.form_settings_location.Size = new System.Drawing.Size(153, 25);
            this.form_settings_location.TabIndex = 7;
            this.form_settings_location.Text = "Save app location";
            // 
            // locationIcon
            // 
            this.locationIcon.Image = ((System.Drawing.Image)(resources.GetObject("locationIcon.Image")));
            this.locationIcon.Location = new System.Drawing.Point(15, 20);
            this.locationIcon.Name = "locationIcon";
            this.locationIcon.Size = new System.Drawing.Size(35, 35);
            this.locationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locationIcon.TabIndex = 6;
            this.locationIcon.TabStop = false;
            // 
            // textBoxPadding1
            // 
            this.textBoxPadding1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxPadding1.Location = new System.Drawing.Point(64, 69);
            this.textBoxPadding1.Name = "textBoxPadding1";
            this.textBoxPadding1.Size = new System.Drawing.Size(100, 37);
            this.textBoxPadding1.TabIndex = 14;
            // 
            // textBoxPadding2
            // 
            this.textBoxPadding2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxPadding2.Location = new System.Drawing.Point(171, 69);
            this.textBoxPadding2.Name = "textBoxPadding2";
            this.textBoxPadding2.Size = new System.Drawing.Size(100, 37);
            this.textBoxPadding2.TabIndex = 15;
            // 
            // form_menu_msg
            // 
            this.form_menu_msg.AutoSize = true;
            this.form_menu_msg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_menu_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.form_menu_msg.Location = new System.Drawing.Point(20, 196);
            this.form_menu_msg.Name = "form_menu_msg";
            this.form_menu_msg.Size = new System.Drawing.Size(315, 20);
            this.form_menu_msg.TabIndex = 14;
            this.form_menu_msg.Text = "Settings will be applied on application restart!";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel7.Controls.Add(this.columns);
            this.panel7.Controls.Add(this.useColumnsIndex);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.textBoxPadding3);
            this.panel7.Location = new System.Drawing.Point(24, 612);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 99);
            this.panel7.TabIndex = 16;
            // 
            // columns
            // 
            this.columns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.columns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.columns.Enabled = false;
            this.columns.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columns.ForeColor = System.Drawing.Color.White;
            this.columns.Location = new System.Drawing.Point(279, 50);
            this.columns.Margin = new System.Windows.Forms.Padding(5);
            this.columns.MaxLength = 5;
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(70, 24);
            this.columns.TabIndex = 12;
            this.columns.Text = "5";
            this.columns.TextChanged += new System.EventHandler(this.columns_TextChanged);
            // 
            // useColumnsIndex
            // 
            this.useColumnsIndex.AutoSize = true;
            this.useColumnsIndex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useColumnsIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.useColumnsIndex.Location = new System.Drawing.Point(293, 12);
            this.useColumnsIndex.Name = "useColumnsIndex";
            this.useColumnsIndex.Size = new System.Drawing.Size(56, 27);
            this.useColumnsIndex.TabIndex = 11;
            this.useColumnsIndex.Text = "Yes";
            this.useColumnsIndex.UseVisualStyleBackColor = true;
            this.useColumnsIndex.CheckedChanged += new System.EventHandler(this.columns_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Instead showing all apps in a \r\nsingle row, use multiple rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Use grid view";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskbarFolder.Properties.Resources.location;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPadding3
            // 
            this.textBoxPadding3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxPadding3.Location = new System.Drawing.Point(269, 45);
            this.textBoxPadding3.Name = "textBoxPadding3";
            this.textBoxPadding3.Size = new System.Drawing.Size(100, 37);
            this.textBoxPadding3.TabIndex = 14;
            // 
            // heart_icon
            // 
            this.heart_icon.AutoSize = true;
            this.heart_icon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heart_icon.ForeColor = System.Drawing.Color.Red;
            this.heart_icon.Location = new System.Drawing.Point(108, 132);
            this.heart_icon.Name = "heart_icon";
            this.heart_icon.Size = new System.Drawing.Size(24, 25);
            this.heart_icon.TabIndex = 17;
            this.heart_icon.Text = "♥";
            // 
            // label_by
            // 
            this.label_by.AutoSize = true;
            this.label_by.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_by.Location = new System.Drawing.Point(125, 132);
            this.label_by.Name = "label_by";
            this.label_by.Size = new System.Drawing.Size(32, 25);
            this.label_by.TabIndex = 18;
            this.label_by.Text = "by";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(422, 746);
            this.Controls.Add(this.label_by);
            this.Controls.Add(this.heart_icon);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.form_menu_msg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.form_menu);
            this.Controls.Add(this.form_link);
            this.Controls.Add(this.form_message2);
            this.Controls.Add(this.form_message);
            this.Controls.Add(this.form_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Taskbar Folder - Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimalViewIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onTopIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationIcon)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_title;
        private System.Windows.Forms.Label form_message;
        private System.Windows.Forms.Label form_message2;
        private System.Windows.Forms.Label form_link;
        private System.Windows.Forms.Label form_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox themeIcon;
        private System.Windows.Forms.RadioButton themeLight;
        private System.Windows.Forms.RadioButton themeDark;
        private System.Windows.Forms.Label form_settings_theme;
        private System.Windows.Forms.Label form_settings_theme1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox minimalView;
        private System.Windows.Forms.Label form_settings_view1;
        private System.Windows.Forms.Label form_settings_view;
        private System.Windows.Forms.PictureBox minimalViewIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox onTopCheck;
        private System.Windows.Forms.Label form_settings_ontop1;
        private System.Windows.Forms.Label form_settings_ontop;
        private System.Windows.Forms.PictureBox onTopIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox saveLocationCheck;
        private System.Windows.Forms.Label form_settings_location1;
        private System.Windows.Forms.Label form_settings_location;
        private System.Windows.Forms.PictureBox locationIcon;
        private System.Windows.Forms.TextBox location_x_val;
        private System.Windows.Forms.TextBox location_y_val;
        private System.Windows.Forms.Panel textBoxPadding1;
        private System.Windows.Forms.Panel textBoxPadding2;
        private System.Windows.Forms.Label form_menu_msg;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox columns;
        private System.Windows.Forms.CheckBox useColumnsIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel textBoxPadding3;
        private System.Windows.Forms.Label heart_icon;
        private System.Windows.Forms.Label label_by;
    }
}