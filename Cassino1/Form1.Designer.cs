namespace Cassino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrSpin = new System.Windows.Forms.Timer(this.components);
            this.BtnSpin = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lbxUltimos = new System.Windows.Forms.ListBox();
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tmrSpin
            // 
            this.tmrSpin.Tick += new System.EventHandler(this.tmrSpin_Tick);
            // 
            // BtnSpin
            // 
            this.BtnSpin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpin.Location = new System.Drawing.Point(12, 259);
            this.BtnSpin.Name = "BtnSpin";
            this.BtnSpin.Size = new System.Drawing.Size(312, 87);
            this.BtnSpin.TabIndex = 0;
            this.BtnSpin.Text = "Girar";
            this.BtnSpin.UseVisualStyleBackColor = true;
            this.BtnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // lblN1
            // 
            this.lblN1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.ForeColor = System.Drawing.Color.Black;
            this.lblN1.Location = new System.Drawing.Point(12, 84);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(100, 100);
            this.lblN1.TabIndex = 3;
            this.lblN1.Text = "0";
            this.lblN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN2
            // 
            this.lblN2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.ForeColor = System.Drawing.Color.Black;
            this.lblN2.Location = new System.Drawing.Point(118, 84);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(100, 100);
            this.lblN2.TabIndex = 4;
            this.lblN2.Text = "0";
            this.lblN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN3
            // 
            this.lblN3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.ForeColor = System.Drawing.Color.Black;
            this.lblN3.Location = new System.Drawing.Point(224, 84);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(100, 100);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "0";
            this.lblN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxUltimos
            // 
            this.lbxUltimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUltimos.FormattingEnabled = true;
            this.lbxUltimos.ItemHeight = 25;
            this.lbxUltimos.Location = new System.Drawing.Point(30, 352);
            this.lbxUltimos.Name = "lbxUltimos";
            this.lbxUltimos.Size = new System.Drawing.Size(272, 154);
            this.lbxUltimos.TabIndex = 4;
            // 
            // chbVitorias
            // 
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVitorias.ForeColor = System.Drawing.Color.White;
            this.chbVitorias.Location = new System.Drawing.Point(90, 515);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(160, 28);
            this.chbVitorias.TabIndex = 5;
            this.chbVitorias.Text = "Apenas Vitórias";
            this.chbVitorias.UseVisualStyleBackColor = true;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(336, 555);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.lbxUltimos);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.BtnSpin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpin;
        private System.Windows.Forms.Button BtnSpin;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.ListBox lbxUltimos;
        private System.Windows.Forms.CheckBox chbVitorias;
    }
}
