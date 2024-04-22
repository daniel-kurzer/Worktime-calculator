namespace WorkTimeCalculator
{
    partial class FormBearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBearbeiten));
            this.btnLöschen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.mySqlDataReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataReaderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(593, 508);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(238, 61);
            this.btnLöschen.TabIndex = 1;
            this.btnLöschen.Text = "Werte löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBearbeiten.Location = new System.Drawing.Point(312, 508);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(238, 61);
            this.btnBearbeiten.TabIndex = 2;
            this.btnBearbeiten.Text = "Bearbeitung übermitteln";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisieren.Location = new System.Drawing.Point(31, 508);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(238, 61);
            this.btnAktualisieren.TabIndex = 4;
            this.btnAktualisieren.Text = "Datenbank aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            // 
            // mySqlDataReaderBindingSource
            // 
            this.mySqlDataReaderBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlDataReader);
            // 
            // mySqlDataReaderBindingSource1
            // 
            this.mySqlDataReaderBindingSource1.DataSource = typeof(MySql.Data.MySqlClient.MySqlDataReader);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 490);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnLöschen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBearbeiten";
            this.Text = "eingetragene Arbeitszeiten";
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.BindingSource mySqlDataReaderBindingSource1;
        private System.Windows.Forms.BindingSource mySqlDataReaderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}