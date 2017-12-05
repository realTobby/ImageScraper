namespace _ImageScraper
{
    partial class MainFormImageScraper
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.label_progress = new System.Windows.Forms.Label();
            this.Duration1 = new System.Windows.Forms.Label();
            this.textBox_url = new MetroFramework.Controls.MetroTextBox();
            this.button_startDump = new MetroFramework.Controls.MetroButton();
            this.textBox_filter = new MetroFramework.Controls.MetroTextBox();
            this.button_addFilter = new MetroFramework.Controls.MetroButton();
            this.progessBar_dump = new MetroFramework.Controls.MetroProgressBar();
            this.button_saveDump = new MetroFramework.Controls.MetroButton();
            this.button_archiveDump = new MetroFramework.Controls.MetroButton();
            this.button_clearDump = new MetroFramework.Controls.MetroButton();
            this.button_openDump = new MetroFramework.Controls.MetroButton();
            this.check_openDirectory = new MetroFramework.Controls.MetroCheckBox();
            this.check_duplicates = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_log = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_preview_left = new MetroFramework.Controls.MetroButton();
            this.button_preview_clear = new MetroFramework.Controls.MetroButton();
            this.button_preview_random = new MetroFramework.Controls.MetroButton();
            this.button_preview_save = new MetroFramework.Controls.MetroButton();
            this.button_preview_right = new MetroFramework.Controls.MetroButton();
            this.toggle_lightDark = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_preview.Location = new System.Drawing.Point(350, 52);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(279, 246);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 11;
            this.pictureBox_preview.TabStop = false;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(124, 130);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(24, 13);
            this.label_progress.TabIndex = 21;
            this.label_progress.Text = "0/0";
            // 
            // Duration1
            // 
            this.Duration1.AutoSize = true;
            this.Duration1.Location = new System.Drawing.Point(281, 130);
            this.Duration1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Duration1.Name = "Duration1";
            this.Duration1.Size = new System.Drawing.Size(0, 13);
            this.Duration1.TabIndex = 23;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(23, 63);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(321, 23);
            this.textBox_url.TabIndex = 25;
            this.textBox_url.Text = "(url here)";
            this.textBox_url.UseStyleColors = true;
            // 
            // button_startDump
            // 
            this.button_startDump.Location = new System.Drawing.Point(23, 92);
            this.button_startDump.Name = "button_startDump";
            this.button_startDump.Size = new System.Drawing.Size(75, 23);
            this.button_startDump.TabIndex = 26;
            this.button_startDump.Text = "Dump";
            this.button_startDump.Click += new System.EventHandler(this.Dump_Click);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(166, 92);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(97, 23);
            this.textBox_filter.TabIndex = 27;
            // 
            // button_addFilter
            // 
            this.button_addFilter.Location = new System.Drawing.Point(269, 92);
            this.button_addFilter.Name = "button_addFilter";
            this.button_addFilter.Size = new System.Drawing.Size(75, 23);
            this.button_addFilter.TabIndex = 28;
            this.button_addFilter.Text = "Add Filter";
            this.button_addFilter.Click += new System.EventHandler(this.button_addFilter_Click);
            // 
            // progessBar_dump
            // 
            this.progessBar_dump.Location = new System.Drawing.Point(23, 120);
            this.progessBar_dump.Name = "progessBar_dump";
            this.progessBar_dump.Size = new System.Drawing.Size(239, 23);
            this.progessBar_dump.TabIndex = 29;
            // 
            // button_saveDump
            // 
            this.button_saveDump.Location = new System.Drawing.Point(23, 149);
            this.button_saveDump.Name = "button_saveDump";
            this.button_saveDump.Size = new System.Drawing.Size(75, 23);
            this.button_saveDump.TabIndex = 30;
            this.button_saveDump.Text = "Save Dump";
            this.button_saveDump.Click += new System.EventHandler(this.SaveDump_Click);
            // 
            // button_archiveDump
            // 
            this.button_archiveDump.Location = new System.Drawing.Point(104, 149);
            this.button_archiveDump.Name = "button_archiveDump";
            this.button_archiveDump.Size = new System.Drawing.Size(75, 23);
            this.button_archiveDump.TabIndex = 31;
            this.button_archiveDump.Text = "Archive Dump";
            this.button_archiveDump.Click += new System.EventHandler(this.ArchiveDump_Click);
            // 
            // button_clearDump
            // 
            this.button_clearDump.Location = new System.Drawing.Point(185, 149);
            this.button_clearDump.Name = "button_clearDump";
            this.button_clearDump.Size = new System.Drawing.Size(75, 23);
            this.button_clearDump.TabIndex = 32;
            this.button_clearDump.Text = "Clear Dump";
            this.button_clearDump.Click += new System.EventHandler(this.ClearDump_Click);
            // 
            // button_openDump
            // 
            this.button_openDump.Location = new System.Drawing.Point(266, 149);
            this.button_openDump.Name = "button_openDump";
            this.button_openDump.Size = new System.Drawing.Size(75, 23);
            this.button_openDump.TabIndex = 33;
            this.button_openDump.Text = "Open Dump";
            this.button_openDump.Click += new System.EventHandler(this.OpenDump_Click);
            // 
            // check_openDirectory
            // 
            this.check_openDirectory.AutoSize = true;
            this.check_openDirectory.BackColor = System.Drawing.Color.Transparent;
            this.check_openDirectory.Location = new System.Drawing.Point(23, 179);
            this.check_openDirectory.Name = "check_openDirectory";
            this.check_openDirectory.Size = new System.Drawing.Size(166, 15);
            this.check_openDirectory.TabIndex = 34;
            this.check_openDirectory.Text = "Open Directory after Dump";
            this.check_openDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.check_openDirectory.UseStyleColors = true;
            this.check_openDirectory.UseVisualStyleBackColor = false;
            // 
            // check_duplicates
            // 
            this.check_duplicates.AutoSize = true;
            this.check_duplicates.BackColor = System.Drawing.Color.Black;
            this.check_duplicates.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.check_duplicates.Location = new System.Drawing.Point(225, 179);
            this.check_duplicates.Name = "check_duplicates";
            this.check_duplicates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_duplicates.Size = new System.Drawing.Size(101, 15);
            this.check_duplicates.TabIndex = 35;
            this.check_duplicates.Text = "skip duplicates";
            this.check_duplicates.Theme = MetroFramework.MetroThemeStyle.Light;
            this.check_duplicates.UseStyleColors = true;
            this.check_duplicates.UseVisualStyleBackColor = false;
            this.check_duplicates.UseWaitCursor = true;
            this.check_duplicates.CheckedChanged += new System.EventHandler(this.check_duplicates_CheckedChanged);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(23, 201);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(321, 176);
            this.textBox_log.TabIndex = 36;
            this.textBox_log.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(306, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Preview Dump:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // button_preview_left
            // 
            this.button_preview_left.Location = new System.Drawing.Point(350, 304);
            this.button_preview_left.Name = "button_preview_left";
            this.button_preview_left.Size = new System.Drawing.Size(53, 23);
            this.button_preview_left.TabIndex = 38;
            this.button_preview_left.Text = "<-";
            this.button_preview_left.Click += new System.EventHandler(this.NewPreview_Left_Click);
            // 
            // button_preview_clear
            // 
            this.button_preview_clear.Location = new System.Drawing.Point(407, 304);
            this.button_preview_clear.Name = "button_preview_clear";
            this.button_preview_clear.Size = new System.Drawing.Size(51, 23);
            this.button_preview_clear.TabIndex = 39;
            this.button_preview_clear.Text = "Clear";
            this.button_preview_clear.Click += new System.EventHandler(this.Peview_Clean_Click);
            // 
            // button_preview_random
            // 
            this.button_preview_random.Location = new System.Drawing.Point(464, 304);
            this.button_preview_random.Name = "button_preview_random";
            this.button_preview_random.Size = new System.Drawing.Size(51, 23);
            this.button_preview_random.TabIndex = 40;
            this.button_preview_random.Text = "Random";
            this.button_preview_random.Click += new System.EventHandler(this.NewPreview_Random_Click);
            // 
            // button_preview_save
            // 
            this.button_preview_save.Location = new System.Drawing.Point(521, 304);
            this.button_preview_save.Name = "button_preview_save";
            this.button_preview_save.Size = new System.Drawing.Size(49, 23);
            this.button_preview_save.TabIndex = 41;
            this.button_preview_save.Text = "Save";
            this.button_preview_save.Click += new System.EventHandler(this.Preview_Save_Click);
            // 
            // button_preview_right
            // 
            this.button_preview_right.Location = new System.Drawing.Point(576, 304);
            this.button_preview_right.Name = "button_preview_right";
            this.button_preview_right.Size = new System.Drawing.Size(53, 23);
            this.button_preview_right.TabIndex = 42;
            this.button_preview_right.Text = "->";
            this.button_preview_right.Click += new System.EventHandler(this.NewPreview_Right_Click);
            // 
            // toggle_lightDark
            // 
            this.toggle_lightDark.AutoSize = true;
            this.toggle_lightDark.Location = new System.Drawing.Point(547, 360);
            this.toggle_lightDark.Name = "toggle_lightDark";
            this.toggle_lightDark.Size = new System.Drawing.Size(80, 17);
            this.toggle_lightDark.TabIndex = 43;
            this.toggle_lightDark.Text = "Off";
            this.toggle_lightDark.UseVisualStyleBackColor = true;
            this.toggle_lightDark.CheckedChanged += new System.EventHandler(this.toggle_lightDark_CheckedChanged);
            // 
            // MainFormImageScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.toggle_lightDark);
            this.Controls.Add(this.button_preview_right);
            this.Controls.Add(this.button_preview_save);
            this.Controls.Add(this.button_preview_random);
            this.Controls.Add(this.button_preview_clear);
            this.Controls.Add(this.button_preview_left);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.check_duplicates);
            this.Controls.Add(this.check_openDirectory);
            this.Controls.Add(this.button_openDump);
            this.Controls.Add(this.button_clearDump);
            this.Controls.Add(this.button_archiveDump);
            this.Controls.Add(this.button_saveDump);
            this.Controls.Add(this.progessBar_dump);
            this.Controls.Add(this.button_addFilter);
            this.Controls.Add(this.textBox_filter);
            this.Controls.Add(this.button_startDump);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.Duration1);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.pictureBox_preview);
            this.Name = "MainFormImageScraper";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Image Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Label Duration1;
        private MetroFramework.Controls.MetroTextBox textBox_url;
        private MetroFramework.Controls.MetroButton button_startDump;
        private MetroFramework.Controls.MetroTextBox textBox_filter;
        private MetroFramework.Controls.MetroButton button_addFilter;
        private MetroFramework.Controls.MetroProgressBar progessBar_dump;
        private MetroFramework.Controls.MetroButton button_saveDump;
        private MetroFramework.Controls.MetroButton button_archiveDump;
        private MetroFramework.Controls.MetroButton button_clearDump;
        private MetroFramework.Controls.MetroButton button_openDump;
        private MetroFramework.Controls.MetroCheckBox check_openDirectory;
        private MetroFramework.Controls.MetroCheckBox check_duplicates;
        private MetroFramework.Controls.MetroTextBox textBox_log;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton button_preview_left;
        private MetroFramework.Controls.MetroButton button_preview_clear;
        private MetroFramework.Controls.MetroButton button_preview_random;
        private MetroFramework.Controls.MetroButton button_preview_save;
        private MetroFramework.Controls.MetroButton button_preview_right;
        private MetroFramework.Controls.MetroToggle toggle_lightDark;
    }
}

