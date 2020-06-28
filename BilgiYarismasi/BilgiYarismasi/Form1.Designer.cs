namespace BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSoru = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJoker = new System.Windows.Forms.Button();
            this.lblOrnekCumle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrtak = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lkgkgk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSoruSiralama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExtraZaman = new System.Windows.Forms.Button();
            this.lblYuksekPuan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXhak = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.BackColor = System.Drawing.Color.Transparent;
            this.lblSoru.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoru.ForeColor = System.Drawing.Color.Transparent;
            this.lblSoru.Location = new System.Drawing.Point(50, 204);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(623, 127);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Lorem Ipsum Dolor Lorem Ipsum Dolor Lorem Ipsum Dolor Lorem Ipsum Dolor";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Maroon;
            this.btnA.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnA.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnA.Image = global::BilgiYarismasi.Properties.Resources.button1;
            this.btnA.Location = new System.Drawing.Point(34, 376);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(267, 68);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Şık A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Maroon;
            this.btnC.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnC.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.Image = ((System.Drawing.Image)(resources.GetObject("btnC.Image")));
            this.btnC.Location = new System.Drawing.Point(34, 466);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(267, 68);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "Şık C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.Location = new System.Drawing.Point(400, 376);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(267, 68);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "Şık B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnD.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnD.Image = ((System.Drawing.Image)(resources.GetObject("btnD.Image")));
            this.btnD.Location = new System.Drawing.Point(400, 466);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(267, 68);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "Şık D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "A )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(419, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "B )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "C )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(419, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "D )";
            // 
            // btnJoker
            // 
            this.btnJoker.BackColor = System.Drawing.Color.Yellow;
            this.btnJoker.BackgroundImage = global::BilgiYarismasi.Properties.Resources.btnJoker;
            this.btnJoker.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnJoker.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJoker.FlatAppearance.BorderSize = 0;
            this.btnJoker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoker.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJoker.ForeColor = System.Drawing.Color.Yellow;
            this.btnJoker.Location = new System.Drawing.Point(36, 37);
            this.btnJoker.Name = "btnJoker";
            this.btnJoker.Size = new System.Drawing.Size(63, 59);
            this.btnJoker.TabIndex = 3;
            this.btnJoker.Text = "Ç";
            this.btnJoker.UseVisualStyleBackColor = false;
            this.btnJoker.Click += new System.EventHandler(this.btnJoker_Click);
            // 
            // lblOrnekCumle
            // 
            this.lblOrnekCumle.BackColor = System.Drawing.Color.Transparent;
            this.lblOrnekCumle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrnekCumle.ForeColor = System.Drawing.Color.Silver;
            this.lblOrnekCumle.Location = new System.Drawing.Point(30, 331);
            this.lblOrnekCumle.Name = "lblOrnekCumle";
            this.lblOrnekCumle.Size = new System.Drawing.Size(453, 33);
            this.lblOrnekCumle.TabIndex = 4;
            this.lblOrnekCumle.Text = "label6 Lorem Ipsum Lorem Ipsum Lorem Ipsum";
            this.lblOrnekCumle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(609, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tanımı Göster..";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BilgiYarismasi.Properties.Resources.sonraki;
            this.pictureBox1.Location = new System.Drawing.Point(639, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 72);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOrtak
            // 
            this.btnOrtak.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrtak.Image = global::BilgiYarismasi.Properties.Resources.button1;
            this.btnOrtak.Location = new System.Drawing.Point(675, 567);
            this.btnOrtak.Name = "btnOrtak";
            this.btnOrtak.Size = new System.Drawing.Size(10, 10);
            this.btnOrtak.TabIndex = 7;
            this.btnOrtak.Text = "button1";
            this.btnOrtak.UseVisualStyleBackColor = true;
            this.btnOrtak.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(302, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
            this.label7.TabIndex = 11;
            this.label7.Text = "PUAN :";
            // 
            // lkgkgk
            // 
            this.lkgkgk.AutoSize = true;
            this.lkgkgk.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F);
            this.lkgkgk.Location = new System.Drawing.Point(383, 50);
            this.lkgkgk.Name = "lkgkgk";
            this.lkgkgk.Size = new System.Drawing.Size(27, 35);
            this.lkgkgk.TabIndex = 8;
            this.lkgkgk.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(445, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "ZAMAN :";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F);
            this.lblZaman.Location = new System.Drawing.Point(541, 50);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(39, 35);
            this.lblZaman.TabIndex = 12;
            this.lblZaman.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSoruSiralama
            // 
            this.lblSoruSiralama.AutoSize = true;
            this.lblSoruSiralama.BackColor = System.Drawing.Color.Transparent;
            this.lblSoruSiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruSiralama.ForeColor = System.Drawing.Color.Red;
            this.lblSoruSiralama.Location = new System.Drawing.Point(162, 137);
            this.lblSoruSiralama.Name = "lblSoruSiralama";
            this.lblSoruSiralama.Size = new System.Drawing.Size(42, 46);
            this.lblSoruSiralama.TabIndex = 14;
            this.lblSoruSiralama.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(50, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 42);
            this.label9.TabIndex = 15;
            this.label9.Text = "Soru :";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.BackColor = System.Drawing.Color.Orange;
            this.lblHak.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(679, 153);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(20, 25);
            this.lblHak.TabIndex = 16;
            this.lblHak.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(585, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kalan Hak :";
            // 
            // btnExtraZaman
            // 
            this.btnExtraZaman.BackColor = System.Drawing.Color.Yellow;
            this.btnExtraZaman.BackgroundImage = global::BilgiYarismasi.Properties.Resources.btnJoker;
            this.btnExtraZaman.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnExtraZaman.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExtraZaman.FlatAppearance.BorderSize = 0;
            this.btnExtraZaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExtraZaman.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtraZaman.ForeColor = System.Drawing.Color.Yellow;
            this.btnExtraZaman.Location = new System.Drawing.Point(105, 37);
            this.btnExtraZaman.Name = "btnExtraZaman";
            this.btnExtraZaman.Size = new System.Drawing.Size(63, 59);
            this.btnExtraZaman.TabIndex = 3;
            this.btnExtraZaman.Text = "XZ";
            this.btnExtraZaman.UseVisualStyleBackColor = false;
            this.btnExtraZaman.Click += new System.EventHandler(this.btnExtraZaman_Click);
            // 
            // lblYuksekPuan
            // 
            this.lblYuksekPuan.AutoSize = true;
            this.lblYuksekPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblYuksekPuan.ForeColor = System.Drawing.Color.Silver;
            this.lblYuksekPuan.Location = new System.Drawing.Point(661, 9);
            this.lblYuksekPuan.Name = "lblYuksekPuan";
            this.lblYuksekPuan.Size = new System.Drawing.Size(35, 13);
            this.lblYuksekPuan.TabIndex = 17;
            this.lblYuksekPuan.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(609, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rekor : ";
            // 
            // btnXhak
            // 
            this.btnXhak.BackColor = System.Drawing.Color.Yellow;
            this.btnXhak.BackgroundImage = global::BilgiYarismasi.Properties.Resources.btnJoker;
            this.btnXhak.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnXhak.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXhak.FlatAppearance.BorderSize = 0;
            this.btnXhak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXhak.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXhak.ForeColor = System.Drawing.Color.Yellow;
            this.btnXhak.Location = new System.Drawing.Point(174, 37);
            this.btnXhak.Name = "btnXhak";
            this.btnXhak.Size = new System.Drawing.Size(63, 59);
            this.btnXhak.TabIndex = 3;
            this.btnXhak.Text = "XH";
            this.btnXhak.UseVisualStyleBackColor = false;
            this.btnXhak.Visible = false;
            this.btnXhak.Click += new System.EventHandler(this.btnXhak_Click);
            // 
            // timer2
            // 
       
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BilgiYarismasi.Properties.Resources.Başlıksız_1;
            this.ClientSize = new System.Drawing.Size(717, 587);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblYuksekPuan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSoruSiralama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lkgkgk);
            this.Controls.Add(this.btnOrtak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrnekCumle);
            this.Controls.Add(this.btnXhak);
            this.Controls.Add(this.btnExtraZaman);
            this.Controls.Add(this.btnJoker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblSoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Burrow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJoker;
        private System.Windows.Forms.Label lblOrnekCumle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrtak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lkgkgk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSoruSiralama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExtraZaman;
        private System.Windows.Forms.Label lblYuksekPuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXhak;
        private System.Windows.Forms.Timer timer2;
    }
}

