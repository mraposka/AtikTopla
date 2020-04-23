namespace AtikApp
{
    partial class Form1
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
            this.organikBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.organikBoxEkle = new System.Windows.Forms.Button();
            this.organikBoxBosalt = new System.Windows.Forms.Button();
            this.kagitBoxBosalt = new System.Windows.Forms.Button();
            this.kagitBoxEkle = new System.Windows.Forms.Button();
            this.kagitBox = new System.Windows.Forms.ListBox();
            this.camBoxBosalt = new System.Windows.Forms.Button();
            this.camBoxEkle = new System.Windows.Forms.Button();
            this.camBox = new System.Windows.Forms.ListBox();
            this.metalBoxBosalt = new System.Windows.Forms.Button();
            this.metalBoxEkle = new System.Windows.Forms.Button();
            this.metalBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.puanTxt = new System.Windows.Forms.Label();
            this.puanKontrolTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.sureTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarAnimasyonTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sureTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // organikBox
            // 
            this.organikBox.BackColor = System.Drawing.Color.PeachPuff;
            this.organikBox.FormattingEnabled = true;
            this.organikBox.Location = new System.Drawing.Point(21, 39);
            this.organikBox.Name = "organikBox";
            this.organikBox.Size = new System.Drawing.Size(120, 95);
            this.organikBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // organikBoxEkle
            // 
            this.organikBoxEkle.Location = new System.Drawing.Point(21, 3);
            this.organikBoxEkle.Name = "organikBoxEkle";
            this.organikBoxEkle.Size = new System.Drawing.Size(120, 30);
            this.organikBoxEkle.TabIndex = 2;
            this.organikBoxEkle.Text = "ORGANİK ATIK";
            this.organikBoxEkle.UseVisualStyleBackColor = true;
            this.organikBoxEkle.Click += new System.EventHandler(this.OrganikEkle);
            // 
            // organikBoxBosalt
            // 
            this.organikBoxBosalt.Location = new System.Drawing.Point(21, 169);
            this.organikBoxBosalt.Name = "organikBoxBosalt";
            this.organikBoxBosalt.Size = new System.Drawing.Size(120, 30);
            this.organikBoxBosalt.TabIndex = 3;
            this.organikBoxBosalt.Text = "BOŞALT";
            this.organikBoxBosalt.UseVisualStyleBackColor = true;
            this.organikBoxBosalt.Click += new System.EventHandler(this.OrganikBosalt);
            // 
            // kagitBoxBosalt
            // 
            this.kagitBoxBosalt.Location = new System.Drawing.Point(16, 171);
            this.kagitBoxBosalt.Name = "kagitBoxBosalt";
            this.kagitBoxBosalt.Size = new System.Drawing.Size(120, 30);
            this.kagitBoxBosalt.TabIndex = 6;
            this.kagitBoxBosalt.Text = "BOŞALT";
            this.kagitBoxBosalt.UseVisualStyleBackColor = true;
            this.kagitBoxBosalt.Click += new System.EventHandler(this.KagitBosalt);
            // 
            // kagitBoxEkle
            // 
            this.kagitBoxEkle.Location = new System.Drawing.Point(16, 3);
            this.kagitBoxEkle.Name = "kagitBoxEkle";
            this.kagitBoxEkle.Size = new System.Drawing.Size(120, 30);
            this.kagitBoxEkle.TabIndex = 5;
            this.kagitBoxEkle.Text = "KAĞIT";
            this.kagitBoxEkle.UseVisualStyleBackColor = true;
            this.kagitBoxEkle.Click += new System.EventHandler(this.KagitEkle);
            // 
            // kagitBox
            // 
            this.kagitBox.BackColor = System.Drawing.Color.PeachPuff;
            this.kagitBox.FormattingEnabled = true;
            this.kagitBox.Location = new System.Drawing.Point(16, 39);
            this.kagitBox.Name = "kagitBox";
            this.kagitBox.Size = new System.Drawing.Size(120, 95);
            this.kagitBox.TabIndex = 4;
            // 
            // camBoxBosalt
            // 
            this.camBoxBosalt.Location = new System.Drawing.Point(17, 171);
            this.camBoxBosalt.Name = "camBoxBosalt";
            this.camBoxBosalt.Size = new System.Drawing.Size(120, 30);
            this.camBoxBosalt.TabIndex = 9;
            this.camBoxBosalt.Text = "BOŞALT";
            this.camBoxBosalt.UseVisualStyleBackColor = true;
            this.camBoxBosalt.Click += new System.EventHandler(this.CamBosalt);
            // 
            // camBoxEkle
            // 
            this.camBoxEkle.Location = new System.Drawing.Point(17, 3);
            this.camBoxEkle.Name = "camBoxEkle";
            this.camBoxEkle.Size = new System.Drawing.Size(120, 30);
            this.camBoxEkle.TabIndex = 8;
            this.camBoxEkle.Text = "CAM";
            this.camBoxEkle.UseVisualStyleBackColor = true;
            this.camBoxEkle.Click += new System.EventHandler(this.CamEkle);
            // 
            // camBox
            // 
            this.camBox.BackColor = System.Drawing.Color.PeachPuff;
            this.camBox.FormattingEnabled = true;
            this.camBox.Location = new System.Drawing.Point(17, 39);
            this.camBox.Name = "camBox";
            this.camBox.Size = new System.Drawing.Size(120, 95);
            this.camBox.TabIndex = 7;
            // 
            // metalBoxBosalt
            // 
            this.metalBoxBosalt.Location = new System.Drawing.Point(17, 171);
            this.metalBoxBosalt.Name = "metalBoxBosalt";
            this.metalBoxBosalt.Size = new System.Drawing.Size(118, 30);
            this.metalBoxBosalt.TabIndex = 12;
            this.metalBoxBosalt.Text = "BOŞALT";
            this.metalBoxBosalt.UseVisualStyleBackColor = true;
            this.metalBoxBosalt.Click += new System.EventHandler(this.MetalBosalt);
            // 
            // metalBoxEkle
            // 
            this.metalBoxEkle.Location = new System.Drawing.Point(17, 5);
            this.metalBoxEkle.Name = "metalBoxEkle";
            this.metalBoxEkle.Size = new System.Drawing.Size(118, 30);
            this.metalBoxEkle.TabIndex = 11;
            this.metalBoxEkle.Text = "METAL";
            this.metalBoxEkle.UseVisualStyleBackColor = true;
            this.metalBoxEkle.Click += new System.EventHandler(this.MetalEkle);
            // 
            // metalBox
            // 
            this.metalBox.BackColor = System.Drawing.Color.PeachPuff;
            this.metalBox.FormattingEnabled = true;
            this.metalBox.Location = new System.Drawing.Point(17, 41);
            this.metalBox.Name = "metalBox";
            this.metalBox.Size = new System.Drawing.Size(118, 95);
            this.metalBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yeni Oyun";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Yeni);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cikis);
            // 
            // puanTxt
            // 
            this.puanTxt.AutoSize = true;
            this.puanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanTxt.Location = new System.Drawing.Point(39, 43);
            this.puanTxt.Name = "puanTxt";
            this.puanTxt.Size = new System.Drawing.Size(29, 31);
            this.puanTxt.TabIndex = 15;
            this.puanTxt.Text = "0";
            // 
            // puanKontrolTimer
            // 
            this.puanKontrolTimer.Tick += new System.EventHandler(this.PuanKontrol_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(16, 142);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(120, 23);
            this.progressBar2.TabIndex = 17;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(17, 140);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(120, 23);
            this.progressBar3.TabIndex = 18;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(17, 142);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(118, 23);
            this.progressBar4.TabIndex = 19;
            // 
            // sureTxt
            // 
            this.sureTxt.AutoSize = true;
            this.sureTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureTxt.Location = new System.Drawing.Point(49, 40);
            this.sureTxt.Name = "sureTxt";
            this.sureTxt.Size = new System.Drawing.Size(29, 31);
            this.sureTxt.TabIndex = 21;
            this.sureTxt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "ATIK KUTULARI";
            // 
            // progressBarAnimasyonTimer
            // 
            this.progressBarAnimasyonTimer.Tick += new System.EventHandler(this.ProgressBarAnimasyon_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(187, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 534);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(26, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 37);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.kagitBoxBosalt);
            this.panel3.Controls.Add(this.kagitBox);
            this.panel3.Controls.Add(this.kagitBoxEkle);
            this.panel3.Location = new System.Drawing.Point(170, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 208);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.organikBoxBosalt);
            this.panel4.Controls.Add(this.organikBox);
            this.panel4.Controls.Add(this.organikBoxEkle);
            this.panel4.Location = new System.Drawing.Point(9, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 208);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.camBoxEkle);
            this.panel6.Controls.Add(this.progressBar3);
            this.panel6.Controls.Add(this.camBox);
            this.panel6.Controls.Add(this.camBoxBosalt);
            this.panel6.Location = new System.Drawing.Point(9, 295);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 211);
            this.panel6.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.metalBoxEkle);
            this.panel1.Controls.Add(this.metalBox);
            this.panel1.Controls.Add(this.metalBoxBosalt);
            this.panel1.Controls.Add(this.progressBar4);
            this.panel1.Location = new System.Drawing.Point(170, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 209);
            this.panel1.TabIndex = 20;
            // 
            // sureTimer
            // 
            this.sureTimer.Interval = 1000;
            this.sureTimer.Tick += new System.EventHandler(this.SureTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 188);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 351);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.White;
            this.groupBox12.Controls.Add(this.puanTxt);
            this.groupBox12.Controls.Add(this.panel7);
            this.groupBox12.Location = new System.Drawing.Point(13, 201);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(138, 97);
            this.groupBox12.TabIndex = 33;
            this.groupBox12.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 29);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "PUAN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(12, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 27);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "SÜRE";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.sureTxt);
            this.groupBox11.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox11.Location = new System.Drawing.Point(12, 97);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(141, 98);
            this.groupBox11.TabIndex = 32;
            this.groupBox11.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(542, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox organikBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button organikBoxEkle;
        private System.Windows.Forms.Button organikBoxBosalt;
        private System.Windows.Forms.Button kagitBoxBosalt;
        private System.Windows.Forms.Button kagitBoxEkle;
        private System.Windows.Forms.ListBox kagitBox;
        private System.Windows.Forms.Button camBoxBosalt;
        private System.Windows.Forms.Button camBoxEkle;
        private System.Windows.Forms.ListBox camBox;
        private System.Windows.Forms.Button metalBoxBosalt;
        private System.Windows.Forms.Button metalBoxEkle;
        private System.Windows.Forms.ListBox metalBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label puanTxt;
        private System.Windows.Forms.Timer puanKontrolTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label sureTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer progressBarAnimasyonTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer sureTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}

