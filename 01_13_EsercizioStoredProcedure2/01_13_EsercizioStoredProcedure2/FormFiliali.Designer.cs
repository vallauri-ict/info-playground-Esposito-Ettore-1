namespace _01_13_EsercizioStoredProcedure2
{
    partial class FormFiliali
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBanca = new System.Windows.Forms.TextBox();
            this.txtComune = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnVedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome banca:";
            // 
            // txtBanca
            // 
            this.txtBanca.Location = new System.Drawing.Point(90, 10);
            this.txtBanca.Name = "txtBanca";
            this.txtBanca.Size = new System.Drawing.Size(100, 20);
            this.txtBanca.TabIndex = 1;
            // 
            // txtComune
            // 
            this.txtComune.Location = new System.Drawing.Point(277, 10);
            this.txtComune.Name = "txtComune";
            this.txtComune.Size = new System.Drawing.Size(100, 20);
            this.txtComune.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comune filiale:";
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(16, 36);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(75, 23);
            this.btnConta.TabIndex = 4;
            this.btnConta.Text = "Conta filiali";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnVedi
            // 
            this.btnVedi.Location = new System.Drawing.Point(97, 36);
            this.btnVedi.Name = "btnVedi";
            this.btnVedi.Size = new System.Drawing.Size(75, 23);
            this.btnVedi.TabIndex = 5;
            this.btnVedi.Text = "Vedi filiali";
            this.btnVedi.UseVisualStyleBackColor = true;
            this.btnVedi.Click += new System.EventHandler(this.btnVedi_Click);
            // 
            // FormFiliali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 68);
            this.Controls.Add(this.btnVedi);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.txtComune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanca);
            this.Controls.Add(this.label1);
            this.Name = "FormFiliali";
            this.Text = "Filiali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanca;
        private System.Windows.Forms.TextBox txtComune;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnVedi;
    }
}

