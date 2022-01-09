namespace Sklad001
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new Sklad001.Database1DataSet1();
            this.dodavatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodavatelTableAdapter = new Sklad001.Database1DataSet1TableAdapters.DodavatelTableAdapter();
            this.idDodavateleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDodavateleDataGridViewTextBoxColumn,
            this.nazevFirmyDataGridViewTextBoxColumn,
            this.iCODataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dodavatelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodavatelBindingSource
            // 
            this.dodavatelBindingSource.DataMember = "Dodavatel";
            this.dodavatelBindingSource.DataSource = this.database1DataSet1;
            // 
            // dodavatelTableAdapter
            // 
            this.dodavatelTableAdapter.ClearBeforeFill = true;
            // 
            // idDodavateleDataGridViewTextBoxColumn
            // 
            this.idDodavateleDataGridViewTextBoxColumn.DataPropertyName = "IdDodavatele";
            this.idDodavateleDataGridViewTextBoxColumn.HeaderText = "IdDodavatele";
            this.idDodavateleDataGridViewTextBoxColumn.Name = "idDodavateleDataGridViewTextBoxColumn";
            // 
            // nazevFirmyDataGridViewTextBoxColumn
            // 
            this.nazevFirmyDataGridViewTextBoxColumn.DataPropertyName = "NazevFirmy";
            this.nazevFirmyDataGridViewTextBoxColumn.HeaderText = "NazevFirmy";
            this.nazevFirmyDataGridViewTextBoxColumn.Name = "nazevFirmyDataGridViewTextBoxColumn";
            // 
            // iCODataGridViewTextBoxColumn
            // 
            this.iCODataGridViewTextBoxColumn.DataPropertyName = "ICO";
            this.iCODataGridViewTextBoxColumn.HeaderText = "ICO";
            this.iCODataGridViewTextBoxColumn.Name = "iCODataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(275, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabulka dodavatelů";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource dodavatelBindingSource;
        private Database1DataSet1TableAdapters.DodavatelTableAdapter dodavatelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDodavateleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevFirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}