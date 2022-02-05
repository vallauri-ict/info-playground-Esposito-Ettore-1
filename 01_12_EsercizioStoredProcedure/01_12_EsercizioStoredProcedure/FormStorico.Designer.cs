namespace _01_12_EsercizioStoredProcedure
{
    partial class FormStorico
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
            this.dgvAgg = new System.Windows.Forms.DataGridView();
            this.btnVisAgg = new System.Windows.Forms.Button();
            this.lblAgg = new System.Windows.Forms.Label();
            this.txtDataAgg = new System.Windows.Forms.DateTimePicker();
            this.txtDataCan = new System.Windows.Forms.DateTimePicker();
            this.lblCan = new System.Windows.Forms.Label();
            this.btnVisCan = new System.Windows.Forms.Button();
            this.dgvCan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgg
            // 
            this.dgvAgg.AllowUserToAddRows = false;
            this.dgvAgg.AllowUserToDeleteRows = false;
            this.dgvAgg.AllowUserToResizeRows = false;
            this.dgvAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgg.Location = new System.Drawing.Point(12, 25);
            this.dgvAgg.Name = "dgvAgg";
            this.dgvAgg.RowHeadersVisible = false;
            this.dgvAgg.Size = new System.Drawing.Size(385, 362);
            this.dgvAgg.TabIndex = 0;
            // 
            // btnVisAgg
            // 
            this.btnVisAgg.Location = new System.Drawing.Point(322, 393);
            this.btnVisAgg.Name = "btnVisAgg";
            this.btnVisAgg.Size = new System.Drawing.Size(75, 23);
            this.btnVisAgg.TabIndex = 1;
            this.btnVisAgg.Text = "Visualizza";
            this.btnVisAgg.UseVisualStyleBackColor = true;
            this.btnVisAgg.Click += new System.EventHandler(this.btnVisAgg_Click);
            // 
            // lblAgg
            // 
            this.lblAgg.AutoSize = true;
            this.lblAgg.Location = new System.Drawing.Point(12, 9);
            this.lblAgg.Name = "lblAgg";
            this.lblAgg.Size = new System.Drawing.Size(74, 13);
            this.lblAgg.TabIndex = 2;
            this.lblAgg.Text = "Aggiornamenti";
            // 
            // txtDataAgg
            // 
            this.txtDataAgg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataAgg.Location = new System.Drawing.Point(157, 395);
            this.txtDataAgg.Name = "txtDataAgg";
            this.txtDataAgg.Size = new System.Drawing.Size(159, 20);
            this.txtDataAgg.TabIndex = 3;
            this.txtDataAgg.Value = new System.DateTime(2022, 1, 30, 0, 0, 0, 0);
            // 
            // txtDataCan
            // 
            this.txtDataCan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCan.Location = new System.Drawing.Point(548, 395);
            this.txtDataCan.Name = "txtDataCan";
            this.txtDataCan.Size = new System.Drawing.Size(159, 20);
            this.txtDataCan.TabIndex = 7;
            this.txtDataCan.Value = new System.DateTime(2022, 1, 30, 0, 0, 0, 0);
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(548, 9);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(69, 13);
            this.lblCan.TabIndex = 6;
            this.lblCan.Text = "Cancellazioni";
            // 
            // btnVisCan
            // 
            this.btnVisCan.Location = new System.Drawing.Point(713, 393);
            this.btnVisCan.Name = "btnVisCan";
            this.btnVisCan.Size = new System.Drawing.Size(75, 23);
            this.btnVisCan.TabIndex = 5;
            this.btnVisCan.Text = "Visualizza";
            this.btnVisCan.UseVisualStyleBackColor = true;
            this.btnVisCan.Click += new System.EventHandler(this.btnVisCan_Click);
            // 
            // dgvCan
            // 
            this.dgvCan.AllowUserToAddRows = false;
            this.dgvCan.AllowUserToDeleteRows = false;
            this.dgvCan.AllowUserToResizeRows = false;
            this.dgvCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCan.Location = new System.Drawing.Point(403, 25);
            this.dgvCan.Name = "dgvCan";
            this.dgvCan.RowHeadersVisible = false;
            this.dgvCan.Size = new System.Drawing.Size(385, 362);
            this.dgvCan.TabIndex = 4;
            // 
            // FormStorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDataCan);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.btnVisCan);
            this.Controls.Add(this.dgvCan);
            this.Controls.Add(this.txtDataAgg);
            this.Controls.Add(this.lblAgg);
            this.Controls.Add(this.btnVisAgg);
            this.Controls.Add(this.dgvAgg);
            this.Name = "FormStorico";
            this.Text = "Storico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgg;
        private System.Windows.Forms.Button btnVisAgg;
        private System.Windows.Forms.Label lblAgg;
        private System.Windows.Forms.DateTimePicker txtDataAgg;
        private System.Windows.Forms.DateTimePicker txtDataCan;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Button btnVisCan;
        private System.Windows.Forms.DataGridView dgvCan;
    }
}

