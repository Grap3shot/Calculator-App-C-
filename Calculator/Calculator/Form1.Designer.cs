namespace Calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.tusgeri = new System.Windows.Forms.Button();
            this.tusCE = new System.Windows.Forms.Button();
            this.tusC = new System.Windows.Forms.Button();
            this.tusartieksi = new System.Windows.Forms.Button();
            this.tusarti = new System.Windows.Forms.Button();
            this.tus9 = new System.Windows.Forms.Button();
            this.tus8 = new System.Windows.Forms.Button();
            this.tus7 = new System.Windows.Forms.Button();
            this.tuseksi = new System.Windows.Forms.Button();
            this.tus6 = new System.Windows.Forms.Button();
            this.tus5 = new System.Windows.Forms.Button();
            this.tus4 = new System.Windows.Forms.Button();
            this.tuscarpi = new System.Windows.Forms.Button();
            this.tus3 = new System.Windows.Forms.Button();
            this.tus2 = new System.Windows.Forms.Button();
            this.tus1 = new System.Windows.Forms.Button();
            this.tusbolu = new System.Windows.Forms.Button();
            this.tusesittir = new System.Windows.Forms.Button();
            this.tusnokta = new System.Windows.Forms.Button();
            this.tus0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(13, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(314, 52);
            this.textBox.TabIndex = 1;
            this.textBox.TabStop = false;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tusgeri
            // 
            this.tusgeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusgeri.Location = new System.Drawing.Point(12, 86);
            this.tusgeri.Name = "tusgeri";
            this.tusgeri.Size = new System.Drawing.Size(74, 54);
            this.tusgeri.TabIndex = 1;
            this.tusgeri.Text = "⇦";
            this.tusgeri.UseVisualStyleBackColor = true;
            this.tusgeri.Click += new System.EventHandler(this.tusgeri_Click);
            // 
            // tusCE
            // 
            this.tusCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusCE.Location = new System.Drawing.Point(92, 86);
            this.tusCE.Name = "tusCE";
            this.tusCE.Size = new System.Drawing.Size(74, 54);
            this.tusCE.TabIndex = 2;
            this.tusCE.Text = "CE";
            this.tusCE.UseVisualStyleBackColor = true;
            this.tusCE.Click += new System.EventHandler(this.tusCE_Click);
            // 
            // tusC
            // 
            this.tusC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusC.Location = new System.Drawing.Point(172, 86);
            this.tusC.Name = "tusC";
            this.tusC.Size = new System.Drawing.Size(74, 54);
            this.tusC.TabIndex = 3;
            this.tusC.Text = "C";
            this.tusC.UseVisualStyleBackColor = true;
            this.tusC.Click += new System.EventHandler(this.tusC_Click);
            // 
            // tusartieksi
            // 
            this.tusartieksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusartieksi.Location = new System.Drawing.Point(252, 86);
            this.tusartieksi.Name = "tusartieksi";
            this.tusartieksi.Size = new System.Drawing.Size(74, 54);
            this.tusartieksi.TabIndex = 4;
            this.tusartieksi.Text = "±";
            this.tusartieksi.UseVisualStyleBackColor = true;
            this.tusartieksi.Click += new System.EventHandler(this.tusartieksi_Click);
            // 
            // tusarti
            // 
            this.tusarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusarti.Location = new System.Drawing.Point(253, 146);
            this.tusarti.Name = "tusarti";
            this.tusarti.Size = new System.Drawing.Size(74, 54);
            this.tusarti.TabIndex = 8;
            this.tusarti.Text = "+";
            this.tusarti.UseVisualStyleBackColor = true;
            this.tusarti.Click += new System.EventHandler(this.islemYap);
            // 
            // tus9
            // 
            this.tus9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus9.Location = new System.Drawing.Point(173, 146);
            this.tus9.Name = "tus9";
            this.tus9.Size = new System.Drawing.Size(74, 54);
            this.tus9.TabIndex = 7;
            this.tus9.Text = "9";
            this.tus9.UseVisualStyleBackColor = true;
            this.tus9.Click += new System.EventHandler(this.degerGir);
            // 
            // tus8
            // 
            this.tus8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus8.Location = new System.Drawing.Point(93, 146);
            this.tus8.Name = "tus8";
            this.tus8.Size = new System.Drawing.Size(74, 54);
            this.tus8.TabIndex = 6;
            this.tus8.Text = "8";
            this.tus8.UseVisualStyleBackColor = true;
            this.tus8.Click += new System.EventHandler(this.degerGir);
            // 
            // tus7
            // 
            this.tus7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus7.Location = new System.Drawing.Point(13, 146);
            this.tus7.Name = "tus7";
            this.tus7.Size = new System.Drawing.Size(74, 54);
            this.tus7.TabIndex = 5;
            this.tus7.Text = "7";
            this.tus7.UseVisualStyleBackColor = true;
            this.tus7.Click += new System.EventHandler(this.degerGir);
            // 
            // tuseksi
            // 
            this.tuseksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuseksi.Location = new System.Drawing.Point(253, 206);
            this.tuseksi.Name = "tuseksi";
            this.tuseksi.Size = new System.Drawing.Size(74, 54);
            this.tuseksi.TabIndex = 12;
            this.tuseksi.Text = "-";
            this.tuseksi.UseVisualStyleBackColor = true;
            this.tuseksi.Click += new System.EventHandler(this.islemYap);
            // 
            // tus6
            // 
            this.tus6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus6.Location = new System.Drawing.Point(173, 206);
            this.tus6.Name = "tus6";
            this.tus6.Size = new System.Drawing.Size(74, 54);
            this.tus6.TabIndex = 11;
            this.tus6.Text = "6";
            this.tus6.UseVisualStyleBackColor = true;
            this.tus6.Click += new System.EventHandler(this.degerGir);
            // 
            // tus5
            // 
            this.tus5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus5.Location = new System.Drawing.Point(93, 206);
            this.tus5.Name = "tus5";
            this.tus5.Size = new System.Drawing.Size(74, 54);
            this.tus5.TabIndex = 10;
            this.tus5.Text = "5";
            this.tus5.UseVisualStyleBackColor = true;
            this.tus5.Click += new System.EventHandler(this.degerGir);
            // 
            // tus4
            // 
            this.tus4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus4.Location = new System.Drawing.Point(13, 206);
            this.tus4.Name = "tus4";
            this.tus4.Size = new System.Drawing.Size(74, 54);
            this.tus4.TabIndex = 9;
            this.tus4.Text = "4";
            this.tus4.UseVisualStyleBackColor = true;
            this.tus4.Click += new System.EventHandler(this.degerGir);
            // 
            // tuscarpi
            // 
            this.tuscarpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuscarpi.Location = new System.Drawing.Point(253, 266);
            this.tuscarpi.Name = "tuscarpi";
            this.tuscarpi.Size = new System.Drawing.Size(74, 54);
            this.tuscarpi.TabIndex = 16;
            this.tuscarpi.Text = "*";
            this.tuscarpi.UseVisualStyleBackColor = true;
            this.tuscarpi.Click += new System.EventHandler(this.islemYap);
            // 
            // tus3
            // 
            this.tus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus3.Location = new System.Drawing.Point(173, 266);
            this.tus3.Name = "tus3";
            this.tus3.Size = new System.Drawing.Size(74, 54);
            this.tus3.TabIndex = 15;
            this.tus3.Text = "3";
            this.tus3.UseVisualStyleBackColor = true;
            this.tus3.Click += new System.EventHandler(this.degerGir);
            // 
            // tus2
            // 
            this.tus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus2.Location = new System.Drawing.Point(93, 266);
            this.tus2.Name = "tus2";
            this.tus2.Size = new System.Drawing.Size(74, 54);
            this.tus2.TabIndex = 14;
            this.tus2.Text = "2";
            this.tus2.UseVisualStyleBackColor = true;
            this.tus2.Click += new System.EventHandler(this.degerGir);
            // 
            // tus1
            // 
            this.tus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus1.Location = new System.Drawing.Point(13, 266);
            this.tus1.Name = "tus1";
            this.tus1.Size = new System.Drawing.Size(74, 54);
            this.tus1.TabIndex = 13;
            this.tus1.Text = "1";
            this.tus1.UseVisualStyleBackColor = true;
            this.tus1.Click += new System.EventHandler(this.degerGir);
            // 
            // tusbolu
            // 
            this.tusbolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusbolu.Location = new System.Drawing.Point(253, 326);
            this.tusbolu.Name = "tusbolu";
            this.tusbolu.Size = new System.Drawing.Size(74, 54);
            this.tusbolu.TabIndex = 20;
            this.tusbolu.Text = "/";
            this.tusbolu.UseVisualStyleBackColor = true;
            this.tusbolu.Click += new System.EventHandler(this.islemYap);
            // 
            // tusesittir
            // 
            this.tusesittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusesittir.Location = new System.Drawing.Point(173, 326);
            this.tusesittir.Name = "tusesittir";
            this.tusesittir.Size = new System.Drawing.Size(74, 54);
            this.tusesittir.TabIndex = 19;
            this.tusesittir.Text = "=";
            this.tusesittir.UseVisualStyleBackColor = true;
            this.tusesittir.Click += new System.EventHandler(this.esittir);
            // 
            // tusnokta
            // 
            this.tusnokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusnokta.Location = new System.Drawing.Point(93, 326);
            this.tusnokta.Name = "tusnokta";
            this.tusnokta.Size = new System.Drawing.Size(74, 54);
            this.tusnokta.TabIndex = 18;
            this.tusnokta.Text = ",";
            this.tusnokta.UseVisualStyleBackColor = true;
            this.tusnokta.Click += new System.EventHandler(this.degerGir);
            // 
            // tus0
            // 
            this.tus0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tus0.Location = new System.Drawing.Point(13, 326);
            this.tus0.Name = "tus0";
            this.tus0.Size = new System.Drawing.Size(74, 54);
            this.tus0.TabIndex = 17;
            this.tus0.Text = "0";
            this.tus0.UseVisualStyleBackColor = true;
            this.tus0.Click += new System.EventHandler(this.degerGir);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 400);
            this.Controls.Add(this.tusbolu);
            this.Controls.Add(this.tusesittir);
            this.Controls.Add(this.tusnokta);
            this.Controls.Add(this.tus0);
            this.Controls.Add(this.tuscarpi);
            this.Controls.Add(this.tus3);
            this.Controls.Add(this.tus2);
            this.Controls.Add(this.tus1);
            this.Controls.Add(this.tuseksi);
            this.Controls.Add(this.tus6);
            this.Controls.Add(this.tus5);
            this.Controls.Add(this.tus4);
            this.Controls.Add(this.tusarti);
            this.Controls.Add(this.tus9);
            this.Controls.Add(this.tus8);
            this.Controls.Add(this.tus7);
            this.Controls.Add(this.tusartieksi);
            this.Controls.Add(this.tusC);
            this.Controls.Add(this.tusCE);
            this.Controls.Add(this.tusgeri);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button tusgeri;
        private System.Windows.Forms.Button tusCE;
        private System.Windows.Forms.Button tusC;
        private System.Windows.Forms.Button tusartieksi;
        private System.Windows.Forms.Button tusarti;
        private System.Windows.Forms.Button tus9;
        private System.Windows.Forms.Button tus8;
        private System.Windows.Forms.Button tus7;
        private System.Windows.Forms.Button tuseksi;
        private System.Windows.Forms.Button tus6;
        private System.Windows.Forms.Button tus5;
        private System.Windows.Forms.Button tus4;
        private System.Windows.Forms.Button tuscarpi;
        private System.Windows.Forms.Button tus3;
        private System.Windows.Forms.Button tus2;
        private System.Windows.Forms.Button tus1;
        private System.Windows.Forms.Button tusbolu;
        private System.Windows.Forms.Button tusesittir;
        private System.Windows.Forms.Button tusnokta;
        private System.Windows.Forms.Button tus0;
    }
}

