namespace BilgiYarismasi
{
    partial class KelimeGecis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeGecis));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBasla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBasla.BackgroundImage")));
            this.btnBasla.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBasla.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.Color.Black;
            this.btnBasla.Location = new System.Drawing.Point(135, 53);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(145, 77);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // KelimeGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(417, 182);
            this.ControlBox = false;
            this.Controls.Add(this.btnBasla);
            this.Name = "KelimeGecis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KelimeGecis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
    }
}