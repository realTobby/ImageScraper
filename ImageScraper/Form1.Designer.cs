namespace _4chanDumper
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
            this.button_startDump = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.button_clearDump = new System.Windows.Forms.Button();
            this.progessBar_dump = new System.Windows.Forms.ProgressBar();
            this.button_archiveDump = new System.Windows.Forms.Button();
            this.button_openDump = new System.Windows.Forms.Button();
            this.check_openDirectory = new System.Windows.Forms.CheckBox();
            this.check_FilterPNG = new System.Windows.Forms.CheckBox();
            this.check_FitlerJPG = new System.Windows.Forms.CheckBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.button_preview_left = new System.Windows.Forms.Button();
            this.button_preview_right = new System.Windows.Forms.Button();
            this.label_preview = new System.Windows.Forms.Label();
            this.button_saveDump = new System.Windows.Forms.Button();
            this.button_preview_save = new System.Windows.Forms.Button();
            this.button_preview_random = new System.Windows.Forms.Button();
            this.button_preview_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // button_startDump
            // 
            this.button_startDump.Location = new System.Drawing.Point(12, 7);
            this.button_startDump.Name = "button_startDump";
            this.button_startDump.Size = new System.Drawing.Size(73, 23);
            this.button_startDump.TabIndex = 0;
            this.button_startDump.Text = "Dump";
            this.button_startDump.UseVisualStyleBackColor = true;
            this.button_startDump.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log.Location = new System.Drawing.Point(12, 88);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(304, 240);
            this.textBox_log.TabIndex = 1;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 36);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(546, 20);
            this.textBox_url.TabIndex = 2;
            this.textBox_url.Text = "(url here)";
            // 
            // button_clearDump
            // 
            this.button_clearDump.Location = new System.Drawing.Point(468, 7);
            this.button_clearDump.Name = "button_clearDump";
            this.button_clearDump.Size = new System.Drawing.Size(90, 23);
            this.button_clearDump.TabIndex = 3;
            this.button_clearDump.Text = "Clear Dump";
            this.button_clearDump.UseVisualStyleBackColor = true;
            this.button_clearDump.Click += new System.EventHandler(this.button2_Click);
            this.button_clearDump.Enter += new System.EventHandler(this.button2_Enter);
            // 
            // progessBar_dump
            // 
            this.progessBar_dump.Location = new System.Drawing.Point(12, 59);
            this.progessBar_dump.Name = "progessBar_dump";
            this.progessBar_dump.Size = new System.Drawing.Size(627, 23);
            this.progessBar_dump.TabIndex = 4;
            // 
            // button_archiveDump
            // 
            this.button_archiveDump.Location = new System.Drawing.Point(377, 7);
            this.button_archiveDump.Name = "button_archiveDump";
            this.button_archiveDump.Size = new System.Drawing.Size(85, 23);
            this.button_archiveDump.TabIndex = 5;
            this.button_archiveDump.Text = "Archive Dump";
            this.button_archiveDump.UseVisualStyleBackColor = true;
            this.button_archiveDump.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_openDump
            // 
            this.button_openDump.Location = new System.Drawing.Point(564, 7);
            this.button_openDump.Name = "button_openDump";
            this.button_openDump.Size = new System.Drawing.Size(75, 23);
            this.button_openDump.TabIndex = 6;
            this.button_openDump.Text = "Open Dump";
            this.button_openDump.UseVisualStyleBackColor = true;
            this.button_openDump.Click += new System.EventHandler(this.button4_Click);
            // 
            // check_openDirectory
            // 
            this.check_openDirectory.AutoSize = true;
            this.check_openDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_openDirectory.Location = new System.Drawing.Point(107, 10);
            this.check_openDirectory.Name = "check_openDirectory";
            this.check_openDirectory.Size = new System.Drawing.Size(152, 17);
            this.check_openDirectory.TabIndex = 8;
            this.check_openDirectory.Text = "Open Directory after Dump";
            this.check_openDirectory.UseVisualStyleBackColor = true;
            // 
            // check_FilterPNG
            // 
            this.check_FilterPNG.AutoSize = true;
            this.check_FilterPNG.Location = new System.Drawing.Point(266, 11);
            this.check_FilterPNG.Name = "check_FilterPNG";
            this.check_FilterPNG.Size = new System.Drawing.Size(49, 17);
            this.check_FilterPNG.TabIndex = 9;
            this.check_FilterPNG.Text = "PNG";
            this.check_FilterPNG.UseVisualStyleBackColor = true;
            // 
            // check_FitlerJPG
            // 
            this.check_FitlerJPG.AutoSize = true;
            this.check_FitlerJPG.Location = new System.Drawing.Point(322, 10);
            this.check_FitlerJPG.Name = "check_FitlerJPG";
            this.check_FitlerJPG.Size = new System.Drawing.Size(46, 17);
            this.check_FitlerJPG.TabIndex = 10;
            this.check_FitlerJPG.Text = "JPG";
            this.check_FitlerJPG.UseVisualStyleBackColor = true;
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(325, 117);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(318, 220);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 11;
            this.pictureBox_preview.TabStop = false;
            // 
            // button_preview_left
            // 
            this.button_preview_left.Location = new System.Drawing.Point(418, 88);
            this.button_preview_left.Name = "button_preview_left";
            this.button_preview_left.Size = new System.Drawing.Size(28, 23);
            this.button_preview_left.TabIndex = 12;
            this.button_preview_left.Text = "<-";
            this.button_preview_left.UseVisualStyleBackColor = true;
            this.button_preview_left.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_preview_right
            // 
            this.button_preview_right.Location = new System.Drawing.Point(608, 88);
            this.button_preview_right.Name = "button_preview_right";
            this.button_preview_right.Size = new System.Drawing.Size(31, 23);
            this.button_preview_right.TabIndex = 13;
            this.button_preview_right.Text = "->";
            this.button_preview_right.UseVisualStyleBackColor = true;
            this.button_preview_right.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_preview
            // 
            this.label_preview.AutoSize = true;
            this.label_preview.Location = new System.Drawing.Point(321, 93);
            this.label_preview.Name = "label_preview";
            this.label_preview.Size = new System.Drawing.Size(91, 13);
            this.label_preview.TabIndex = 14;
            this.label_preview.Text = "Preview of Dump:";
            // 
            // button_saveDump
            // 
            this.button_saveDump.Location = new System.Drawing.Point(564, 33);
            this.button_saveDump.Name = "button_saveDump";
            this.button_saveDump.Size = new System.Drawing.Size(75, 23);
            this.button_saveDump.TabIndex = 15;
            this.button_saveDump.Text = "Save";
            this.button_saveDump.UseVisualStyleBackColor = true;
            this.button_saveDump.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_preview_save
            // 
            this.button_preview_save.Location = new System.Drawing.Point(563, 88);
            this.button_preview_save.Name = "button_preview_save";
            this.button_preview_save.Size = new System.Drawing.Size(43, 23);
            this.button_preview_save.TabIndex = 16;
            this.button_preview_save.Text = "Save";
            this.button_preview_save.UseVisualStyleBackColor = true;
            this.button_preview_save.Click += new System.EventHandler(this.button8_Click);
            // 
            // button_preview_random
            // 
            this.button_preview_random.Location = new System.Drawing.Point(498, 88);
            this.button_preview_random.Name = "button_preview_random";
            this.button_preview_random.Size = new System.Drawing.Size(59, 23);
            this.button_preview_random.TabIndex = 17;
            this.button_preview_random.Text = "Random";
            this.button_preview_random.UseVisualStyleBackColor = true;
            this.button_preview_random.Click += new System.EventHandler(this.button9_Click);
            // 
            // button_preview_clear
            // 
            this.button_preview_clear.Location = new System.Drawing.Point(452, 88);
            this.button_preview_clear.Name = "button_preview_clear";
            this.button_preview_clear.Size = new System.Drawing.Size(40, 23);
            this.button_preview_clear.TabIndex = 18;
            this.button_preview_clear.Text = "Clear";
            this.button_preview_clear.UseVisualStyleBackColor = true;
            this.button_preview_clear.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainFormImageScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 340);
            this.Controls.Add(this.button_preview_clear);
            this.Controls.Add(this.button_preview_random);
            this.Controls.Add(this.button_preview_save);
            this.Controls.Add(this.button_saveDump);
            this.Controls.Add(this.label_preview);
            this.Controls.Add(this.button_preview_right);
            this.Controls.Add(this.button_preview_left);
            this.Controls.Add(this.pictureBox_preview);
            this.Controls.Add(this.check_FitlerJPG);
            this.Controls.Add(this.check_FilterPNG);
            this.Controls.Add(this.check_openDirectory);
            this.Controls.Add(this.button_openDump);
            this.Controls.Add(this.button_archiveDump);
            this.Controls.Add(this.progessBar_dump);
            this.Controls.Add(this.button_clearDump);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_startDump);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFormImageScraper";
            this.Text = "Image Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startDump;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Button button_clearDump;
        private System.Windows.Forms.ProgressBar progessBar_dump;
        private System.Windows.Forms.Button button_archiveDump;
        private System.Windows.Forms.Button button_openDump;
        private System.Windows.Forms.CheckBox check_openDirectory;
        private System.Windows.Forms.CheckBox check_FilterPNG;
        private System.Windows.Forms.CheckBox check_FitlerJPG;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Button button_preview_left;
        private System.Windows.Forms.Button button_preview_right;
        private System.Windows.Forms.Label label_preview;
        private System.Windows.Forms.Button button_saveDump;
        private System.Windows.Forms.Button button_preview_save;
        private System.Windows.Forms.Button button_preview_random;
        private System.Windows.Forms.Button button_preview_clear;
    }
}

