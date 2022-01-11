
namespace DisHekimligiOto
{
    partial class RandevuAL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxRandevu = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDogum = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textSikayet = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTEL = new System.Windows.Forms.MaskedTextBox();
            this.textTC = new System.Windows.Forms.MaskedTextBox();
            this.textAdres = new System.Windows.Forms.RichTextBox();
            this.textEposta = new System.Windows.Forms.TextBox();
            this.textMeslek = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.maskedTextBoxRandevu);
            this.groupBox1.Controls.Add(this.maskedTextBoxDogum);
            this.groupBox1.Controls.Add(this.comboBoxCinsiyet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textSikayet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textTEL);
            this.groupBox1.Controls.Add(this.textTC);
            this.groupBox1.Controls.Add(this.textAdres);
            this.groupBox1.Controls.Add(this.textEposta);
            this.groupBox1.Controls.Add(this.textMeslek);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // maskedTextBoxRandevu
            // 
            this.maskedTextBoxRandevu.Location = new System.Drawing.Point(642, 148);
            this.maskedTextBoxRandevu.Mask = "00/00/0000";
            this.maskedTextBoxRandevu.Name = "maskedTextBoxRandevu";
            this.maskedTextBoxRandevu.Size = new System.Drawing.Size(273, 21);
            this.maskedTextBoxRandevu.TabIndex = 26;
            this.maskedTextBoxRandevu.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDogum
            // 
            this.maskedTextBoxDogum.Location = new System.Drawing.Point(157, 187);
            this.maskedTextBoxDogum.Mask = "00/00/0000";
            this.maskedTextBoxDogum.Name = "maskedTextBoxDogum";
            this.maskedTextBoxDogum.Size = new System.Drawing.Size(273, 21);
            this.maskedTextBoxDogum.TabIndex = 25;
            this.maskedTextBoxDogum.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(642, 36);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(273, 26);
            this.comboBoxCinsiyet.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(508, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "CİNSİYET";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(366, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSikayet
            // 
            this.textSikayet.BackColor = System.Drawing.SystemColors.Info;
            this.textSikayet.Location = new System.Drawing.Point(511, 257);
            this.textSikayet.Name = "textSikayet";
            this.textSikayet.Size = new System.Drawing.Size(404, 177);
            this.textSikayet.TabIndex = 19;
            this.textSikayet.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(508, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "ŞİKAYET";
            // 
            // textTEL
            // 
            this.textTEL.BackColor = System.Drawing.SystemColors.Info;
            this.textTEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTEL.Location = new System.Drawing.Point(157, 148);
            this.textTEL.Mask = "(999) 000-0000";
            this.textTEL.Name = "textTEL";
            this.textTEL.Size = new System.Drawing.Size(273, 24);
            this.textTEL.TabIndex = 17;
            // 
            // textTC
            // 
            this.textTC.BackColor = System.Drawing.SystemColors.Info;
            this.textTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTC.Location = new System.Drawing.Point(157, 109);
            this.textTC.Mask = "00000000000";
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(273, 24);
            this.textTC.TabIndex = 16;
            this.textTC.ValidatingType = typeof(int);
            // 
            // textAdres
            // 
            this.textAdres.BackColor = System.Drawing.SystemColors.Info;
            this.textAdres.Location = new System.Drawing.Point(26, 257);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(404, 177);
            this.textAdres.TabIndex = 15;
            this.textAdres.Text = "";
            // 
            // textEposta
            // 
            this.textEposta.BackColor = System.Drawing.SystemColors.Info;
            this.textEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEposta.Location = new System.Drawing.Point(642, 75);
            this.textEposta.Name = "textEposta";
            this.textEposta.Size = new System.Drawing.Size(273, 24);
            this.textEposta.TabIndex = 14;
            // 
            // textMeslek
            // 
            this.textMeslek.BackColor = System.Drawing.SystemColors.Info;
            this.textMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMeslek.Location = new System.Drawing.Point(642, 110);
            this.textMeslek.Name = "textMeslek";
            this.textMeslek.Size = new System.Drawing.Size(273, 24);
            this.textMeslek.TabIndex = 13;
            // 
            // textSoyad
            // 
            this.textSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.textSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(157, 68);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(273, 24);
            this.textSoyad.TabIndex = 12;
            // 
            // textAd
            // 
            this.textAd.BackColor = System.Drawing.SystemColors.Info;
            this.textAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(157, 34);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(273, 24);
            this.textAd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "DOĞUM TARİHİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(508, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "RANDEVU TARİHİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(508, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "MESLEK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(508, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "EPOSTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC KİMLİK NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // RandevuAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 515);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "RandevuAL";
            this.Text = "RandevuAL";
            this.Load += new System.EventHandler(this.RandevuAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textAdres;
        private System.Windows.Forms.TextBox textEposta;
        private System.Windows.Forms.TextBox textMeslek;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.RichTextBox textSikayet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox textTEL;
        private System.Windows.Forms.MaskedTextBox textTC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRandevu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDogum;
    }
}