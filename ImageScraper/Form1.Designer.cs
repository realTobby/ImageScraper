namespace _4chanDumper
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.check_open = new System.Windows.Forms.CheckBox();
            this.check_png = new System.Windows.Forms.CheckBox();
            this.check_jpg = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(304, 240);
            this.textBox1.TabIndex = 1;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 36);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(546, 20);
            this.txt_url.TabIndex = 2;
            this.txt_url.Text = "(url here)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Dump";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(627, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Archive Dump";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Open Dump";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // check_open
            // 
            this.check_open.AutoSize = true;
            this.check_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_open.Location = new System.Drawing.Point(107, 10);
            this.check_open.Name = "check_open";
            this.check_open.Size = new System.Drawing.Size(152, 17);
            this.check_open.TabIndex = 8;
            this.check_open.Text = "Open Directory after Dump";
            this.check_open.UseVisualStyleBackColor = true;
            // 
            // check_png
            // 
            this.check_png.AutoSize = true;
            this.check_png.Location = new System.Drawing.Point(266, 11);
            this.check_png.Name = "check_png";
            this.check_png.Size = new System.Drawing.Size(49, 17);
            this.check_png.TabIndex = 9;
            this.check_png.Text = "PNG";
            this.check_png.UseVisualStyleBackColor = true;
            // 
            // check_jpg
            // 
            this.check_jpg.AutoSize = true;
            this.check_jpg.Location = new System.Drawing.Point(322, 10);
            this.check_jpg.Name = "check_jpg";
            this.check_jpg.Size = new System.Drawing.Size(46, 17);
            this.check_jpg.TabIndex = 10;
            this.check_jpg.Text = "JPG";
            this.check_jpg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(325, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(418, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "<-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(608, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "->";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preview of Dump:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(564, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(563, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(498, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "Random";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(452, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 340);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_jpg);
            this.Controls.Add(this.check_png);
            this.Controls.Add(this.check_open);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Image Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox check_open;
        private System.Windows.Forms.CheckBox check_png;
        private System.Windows.Forms.CheckBox check_jpg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

