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
            this.lblN1 = new System.Windows.Forms.Label();
            this.btGirar = new System.Windows.Forms.Button();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbxUltimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(13, 9);
            this.lblN1.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblN1.MinimumSize = new System.Drawing.Size(100, 100);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(100, 100);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "0";
            // 
            // btGirar
            // 
            this.btGirar.Location = new System.Drawing.Point(12, 112);
            this.btGirar.Name = "btGirar";
            this.btGirar.Size = new System.Drawing.Size(297, 74);
            this.btGirar.TabIndex = 3;
            this.btGirar.Text = "&GIRAR";
            this.btGirar.UseVisualStyleBackColor = true;
            this.btGirar.Click += new System.EventHandler(this.btGirar_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(119, 9);
            this.lblN2.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblN2.MinimumSize = new System.Drawing.Size(100, 100);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(100, 100);
            this.lblN2.TabIndex = 4;
            this.lblN2.Text = "0";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(225, 9);
            this.lblN3.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblN3.MinimumSize = new System.Drawing.Size(100, 100);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(100, 100);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "0";
            // 
            // chbVitorias
            // 
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.Location = new System.Drawing.Point(12, 401);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(129, 24);
            this.chbVitorias.TabIndex = 6;
            this.chbVitorias.Text = "Só as &vitórias";
            this.chbVitorias.UseVisualStyleBackColor = true;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbxUltimos
            // 
            this.lbxUltimos.FormattingEnabled = true;
            this.lbxUltimos.ItemHeight = 20;
            this.lbxUltimos.Location = new System.Drawing.Point(12, 191);
            this.lbxUltimos.Name = "lbxUltimos";
            this.lbxUltimos.Size = new System.Drawing.Size(297, 204);
            this.lbxUltimos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 428);
            this.Controls.Add(this.lbxUltimos);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.btGirar);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Button btGirar;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.CheckBox chbVitorias;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox lbxUltimos;
    }
}

