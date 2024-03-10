namespace _23MY03009_odev_no02
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
            this.kilonuz = new System.Windows.Forms.Label();
            this.boyunuz = new System.Windows.Forms.Label();
            this.yasiniz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endeks = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.boyunuzgir = new System.Windows.Forms.TextBox();
            this.yasinizgir = new System.Windows.Forms.TextBox();
            this.kilonuzgir = new System.Windows.Forms.TextBox();
            this.durumunuz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kilonuz
            // 
            this.kilonuz.AutoSize = true;
            this.kilonuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilonuz.Location = new System.Drawing.Point(33, 35);
            this.kilonuz.Name = "kilonuz";
            this.kilonuz.Size = new System.Drawing.Size(164, 25);
            this.kilonuz.TabIndex = 0;
            this.kilonuz.Text = "KİLONUZ (KG) :";
            this.kilonuz.Click += new System.EventHandler(this.label1_Click);
            // 
            // boyunuz
            // 
            this.boyunuz.AutoSize = true;
            this.boyunuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyunuz.Location = new System.Drawing.Point(33, 79);
            this.boyunuz.Name = "boyunuz";
            this.boyunuz.Size = new System.Drawing.Size(180, 25);
            this.boyunuz.TabIndex = 0;
            this.boyunuz.Text = "BOYUNUZ (CM) :";
            // 
            // yasiniz
            // 
            this.yasiniz.AutoSize = true;
            this.yasiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasiniz.Location = new System.Drawing.Point(33, 135);
            this.yasiniz.Name = "yasiniz";
            this.yasiniz.Size = new System.Drawing.Size(105, 25);
            this.yasiniz.TabIndex = 0;
            this.yasiniz.Text = "YAŞINIZ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "VÜCUT KİTLE ENDEKSİNİZ : ";
            // 
            // endeks
            // 
            this.endeks.AutoSize = true;
            this.endeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endeks.Location = new System.Drawing.Point(323, 196);
            this.endeks.Name = "endeks";
            this.endeks.Size = new System.Drawing.Size(72, 25);
            this.endeks.TabIndex = 0;
            this.endeks.Text = "_____";
            this.endeks.Click += new System.EventHandler(this.label5_Click);
            // 
            // hesapla
            // 
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(387, 71);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(126, 40);
            this.hesapla.TabIndex = 1;
            this.hesapla.Text = "HESAPLA";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // boyunuzgir
            // 
            this.boyunuzgir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyunuzgir.Location = new System.Drawing.Point(219, 79);
            this.boyunuzgir.Multiline = true;
            this.boyunuzgir.Name = "boyunuzgir";
            this.boyunuzgir.Size = new System.Drawing.Size(109, 25);
            this.boyunuzgir.TabIndex = 3;
            // 
            // yasinizgir
            // 
            this.yasinizgir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasinizgir.Location = new System.Drawing.Point(144, 135);
            this.yasinizgir.Multiline = true;
            this.yasinizgir.Name = "yasinizgir";
            this.yasinizgir.Size = new System.Drawing.Size(109, 25);
            this.yasinizgir.TabIndex = 3;
            this.yasinizgir.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kilonuzgir
            // 
            this.kilonuzgir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilonuzgir.Location = new System.Drawing.Point(203, 35);
            this.kilonuzgir.Multiline = true;
            this.kilonuzgir.Name = "kilonuzgir";
            this.kilonuzgir.Size = new System.Drawing.Size(109, 25);
            this.kilonuzgir.TabIndex = 3;
            // 
            // durumunuz
            // 
            this.durumunuz.AutoSize = true;
            this.durumunuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumunuz.Location = new System.Drawing.Point(92, 260);
            this.durumunuz.Name = "durumunuz";
            this.durumunuz.Size = new System.Drawing.Size(132, 25);
            this.durumunuz.TabIndex = 4;
            this.durumunuz.Text = "__________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 354);
            this.Controls.Add(this.durumunuz);
            this.Controls.Add(this.kilonuzgir);
            this.Controls.Add(this.yasinizgir);
            this.Controls.Add(this.boyunuzgir);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.endeks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yasiniz);
            this.Controls.Add(this.boyunuz);
            this.Controls.Add(this.kilonuz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kilonuz;
        private System.Windows.Forms.Label boyunuz;
        private System.Windows.Forms.Label yasiniz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label endeks;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox boyunuzgir;
        private System.Windows.Forms.TextBox yasinizgir;
        private System.Windows.Forms.TextBox kilonuzgir;
        private System.Windows.Forms.Label durumunuz;
    }
}

