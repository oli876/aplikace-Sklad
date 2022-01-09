namespace Sklad001
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evidencniCisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velikostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahaKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetObsazenychPolicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnozstviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proJakaAutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sloupecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodavatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Sklad001.Database1DataSet();
            this.dilTableAdapter = new Sklad001.Database1DataSetTableAdapters.DilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evidencniCisloDataGridViewTextBoxColumn,
            this.nazevDataGridViewTextBoxColumn,
            this.velikostDataGridViewTextBoxColumn,
            this.vahaKgDataGridViewTextBoxColumn,
            this.popisDataGridViewTextBoxColumn,
            this.pocetObsazenychPolicDataGridViewTextBoxColumn,
            this.mnozstviDataGridViewTextBoxColumn,
            this.proJakaAutaDataGridViewTextBoxColumn,
            this.policeDataGridViewTextBoxColumn,
            this.sloupecDataGridViewTextBoxColumn,
            this.regalDataGridViewTextBoxColumn,
            this.dodavatelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // evidencniCisloDataGridViewTextBoxColumn
            // 
            this.evidencniCisloDataGridViewTextBoxColumn.DataPropertyName = "EvidencniCislo";
            this.evidencniCisloDataGridViewTextBoxColumn.HeaderText = "EvidencniCislo";
            this.evidencniCisloDataGridViewTextBoxColumn.Name = "evidencniCisloDataGridViewTextBoxColumn";
            this.evidencniCisloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazevDataGridViewTextBoxColumn
            // 
            this.nazevDataGridViewTextBoxColumn.DataPropertyName = "Nazev";
            this.nazevDataGridViewTextBoxColumn.HeaderText = "Nazev";
            this.nazevDataGridViewTextBoxColumn.Name = "nazevDataGridViewTextBoxColumn";
            // 
            // velikostDataGridViewTextBoxColumn
            // 
            this.velikostDataGridViewTextBoxColumn.DataPropertyName = "Velikost";
            this.velikostDataGridViewTextBoxColumn.HeaderText = "Velikost";
            this.velikostDataGridViewTextBoxColumn.Name = "velikostDataGridViewTextBoxColumn";
            // 
            // vahaKgDataGridViewTextBoxColumn
            // 
            this.vahaKgDataGridViewTextBoxColumn.DataPropertyName = "Vaha(Kg)";
            this.vahaKgDataGridViewTextBoxColumn.HeaderText = "Vaha(Kg)";
            this.vahaKgDataGridViewTextBoxColumn.Name = "vahaKgDataGridViewTextBoxColumn";
            // 
            // popisDataGridViewTextBoxColumn
            // 
            this.popisDataGridViewTextBoxColumn.DataPropertyName = "Popis";
            this.popisDataGridViewTextBoxColumn.HeaderText = "Popis";
            this.popisDataGridViewTextBoxColumn.Name = "popisDataGridViewTextBoxColumn";
            // 
            // pocetObsazenychPolicDataGridViewTextBoxColumn
            // 
            this.pocetObsazenychPolicDataGridViewTextBoxColumn.DataPropertyName = "PocetObsazenychPolic";
            this.pocetObsazenychPolicDataGridViewTextBoxColumn.HeaderText = "PocetObsazenychPolic";
            this.pocetObsazenychPolicDataGridViewTextBoxColumn.Name = "pocetObsazenychPolicDataGridViewTextBoxColumn";
            // 
            // mnozstviDataGridViewTextBoxColumn
            // 
            this.mnozstviDataGridViewTextBoxColumn.DataPropertyName = "Mnozstvi";
            this.mnozstviDataGridViewTextBoxColumn.HeaderText = "Mnozstvi";
            this.mnozstviDataGridViewTextBoxColumn.Name = "mnozstviDataGridViewTextBoxColumn";
            // 
            // proJakaAutaDataGridViewTextBoxColumn
            // 
            this.proJakaAutaDataGridViewTextBoxColumn.DataPropertyName = "ProJakaAuta";
            this.proJakaAutaDataGridViewTextBoxColumn.HeaderText = "ProJakaAuta";
            this.proJakaAutaDataGridViewTextBoxColumn.Name = "proJakaAutaDataGridViewTextBoxColumn";
            // 
            // policeDataGridViewTextBoxColumn
            // 
            this.policeDataGridViewTextBoxColumn.DataPropertyName = "Police";
            this.policeDataGridViewTextBoxColumn.HeaderText = "Police";
            this.policeDataGridViewTextBoxColumn.Name = "policeDataGridViewTextBoxColumn";
            // 
            // sloupecDataGridViewTextBoxColumn
            // 
            this.sloupecDataGridViewTextBoxColumn.DataPropertyName = "Sloupec";
            this.sloupecDataGridViewTextBoxColumn.HeaderText = "Sloupec";
            this.sloupecDataGridViewTextBoxColumn.Name = "sloupecDataGridViewTextBoxColumn";
            // 
            // regalDataGridViewTextBoxColumn
            // 
            this.regalDataGridViewTextBoxColumn.DataPropertyName = "Regal";
            this.regalDataGridViewTextBoxColumn.HeaderText = "Regal";
            this.regalDataGridViewTextBoxColumn.Name = "regalDataGridViewTextBoxColumn";
            // 
            // dodavatelDataGridViewTextBoxColumn
            // 
            this.dodavatelDataGridViewTextBoxColumn.DataPropertyName = "Dodavatel";
            this.dodavatelDataGridViewTextBoxColumn.HeaderText = "Dodavatel";
            this.dodavatelDataGridViewTextBoxColumn.Name = "dodavatelDataGridViewTextBoxColumn";
            // 
            // dilBindingSource
            // 
            this.dilBindingSource.DataMember = "Dil";
            this.dilBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dilTableAdapter
            // 
            this.dilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(338, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabulka dílů";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource dilBindingSource;
        private Database1DataSetTableAdapters.DilTableAdapter dilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencniCisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velikostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahaKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetObsazenychPolicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnozstviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proJakaAutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sloupecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodavatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

