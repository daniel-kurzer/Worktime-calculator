namespace WorkTimeCalculator
{
    partial class FormRechner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechner));
            this.lblBanner = new System.Windows.Forms.Label();
            this.lblBeginn = new System.Windows.Forms.Label();
            this.textBoxBeginn = new System.Windows.Forms.TextBox();
            this.lblPause1 = new System.Windows.Forms.Label();
            this.textBoxPause1 = new System.Windows.Forms.TextBox();
            this.lblPause2 = new System.Windows.Forms.Label();
            this.textBoxPause2 = new System.Windows.Forms.TextBox();
            this.textBoxPause3 = new System.Windows.Forms.TextBox();
            this.lblPause3 = new System.Windows.Forms.Label();
            this.lblEnde = new System.Windows.Forms.Label();
            this.textBoxEnde = new System.Windows.Forms.TextBox();
            this.lblBrutto = new System.Windows.Forms.Label();
            this.lblPauseAll = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.lblBruttoDisplay = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.lblPauseDisplay = new System.Windows.Forms.Label();
            this.lblNettoDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateTimePicker = new System.Windows.Forms.Label();
            this.btnTransmitData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItemForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.Location = new System.Drawing.Point(281, 19);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(320, 36);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Work Time Calculator";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBeginn
            // 
            this.lblBeginn.AutoSize = true;
            this.lblBeginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginn.Location = new System.Drawing.Point(76, 189);
            this.lblBeginn.Name = "lblBeginn";
            this.lblBeginn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBeginn.Size = new System.Drawing.Size(92, 13);
            this.lblBeginn.TabIndex = 1;
            this.lblBeginn.Text = "Arbeitsbeginn :";
            // 
            // textBoxBeginn
            // 
            this.textBoxBeginn.Location = new System.Drawing.Point(253, 186);
            this.textBoxBeginn.MaxLength = 5;
            this.textBoxBeginn.Name = "textBoxBeginn";
            this.textBoxBeginn.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeginn.TabIndex = 2;
            // 
            // lblPause1
            // 
            this.lblPause1.AutoSize = true;
            this.lblPause1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause1.Location = new System.Drawing.Point(76, 265);
            this.lblPause1.Name = "lblPause1";
            this.lblPause1.Size = new System.Drawing.Size(61, 13);
            this.lblPause1.TabIndex = 3;
            this.lblPause1.Text = "Pause 1 :";
            // 
            // textBoxPause1
            // 
            this.textBoxPause1.Location = new System.Drawing.Point(253, 262);
            this.textBoxPause1.MaxLength = 2;
            this.textBoxPause1.Name = "textBoxPause1";
            this.textBoxPause1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPause1.TabIndex = 4;
            // 
            // lblPause2
            // 
            this.lblPause2.AutoSize = true;
            this.lblPause2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause2.Location = new System.Drawing.Point(76, 346);
            this.lblPause2.Name = "lblPause2";
            this.lblPause2.Size = new System.Drawing.Size(61, 13);
            this.lblPause2.TabIndex = 5;
            this.lblPause2.Text = "Pause 2 :";
            // 
            // textBoxPause2
            // 
            this.textBoxPause2.Location = new System.Drawing.Point(253, 343);
            this.textBoxPause2.MaxLength = 2;
            this.textBoxPause2.Name = "textBoxPause2";
            this.textBoxPause2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPause2.TabIndex = 6;
            // 
            // textBoxPause3
            // 
            this.textBoxPause3.Location = new System.Drawing.Point(253, 429);
            this.textBoxPause3.MaxLength = 2;
            this.textBoxPause3.Name = "textBoxPause3";
            this.textBoxPause3.Size = new System.Drawing.Size(100, 20);
            this.textBoxPause3.TabIndex = 7;
            // 
            // lblPause3
            // 
            this.lblPause3.AutoSize = true;
            this.lblPause3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause3.Location = new System.Drawing.Point(76, 432);
            this.lblPause3.Name = "lblPause3";
            this.lblPause3.Size = new System.Drawing.Size(61, 13);
            this.lblPause3.TabIndex = 8;
            this.lblPause3.Text = "Pause 3 :";
            // 
            // lblEnde
            // 
            this.lblEnde.AutoSize = true;
            this.lblEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnde.Location = new System.Drawing.Point(76, 516);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(82, 13);
            this.lblEnde.TabIndex = 9;
            this.lblEnde.Text = "Arbeitsende :";
            // 
            // textBoxEnde
            // 
            this.textBoxEnde.Location = new System.Drawing.Point(253, 513);
            this.textBoxEnde.MaxLength = 5;
            this.textBoxEnde.Name = "textBoxEnde";
            this.textBoxEnde.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnde.TabIndex = 10;
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrutto.Location = new System.Drawing.Point(494, 189);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(107, 13);
            this.lblBrutto.TabIndex = 11;
            this.lblBrutto.Text = "Bruttoarbeitszeit :";
            // 
            // lblPauseAll
            // 
            this.lblPauseAll.AutoSize = true;
            this.lblPauseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseAll.Location = new System.Drawing.Point(494, 265);
            this.lblPauseAll.Name = "lblPauseAll";
            this.lblPauseAll.Size = new System.Drawing.Size(104, 13);
            this.lblPauseAll.TabIndex = 12;
            this.lblPauseAll.Text = "Pause ingesamt :";
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetto.Location = new System.Drawing.Point(494, 346);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(104, 13);
            this.lblNetto.TabIndex = 13;
            this.lblNetto.Text = "Nettoarbeitszeit :";
            // 
            // lblBruttoDisplay
            // 
            this.lblBruttoDisplay.AutoSize = true;
            this.lblBruttoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruttoDisplay.Location = new System.Drawing.Point(657, 189);
            this.lblBruttoDisplay.Name = "lblBruttoDisplay";
            this.lblBruttoDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblBruttoDisplay.TabIndex = 14;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.Location = new System.Drawing.Point(526, 405);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(221, 55);
            this.btnBerechnen.TabIndex = 15;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            // 
            // lblPauseDisplay
            // 
            this.lblPauseDisplay.AutoSize = true;
            this.lblPauseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseDisplay.Location = new System.Drawing.Point(657, 265);
            this.lblPauseDisplay.Name = "lblPauseDisplay";
            this.lblPauseDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblPauseDisplay.TabIndex = 16;
            // 
            // lblNettoDisplay
            // 
            this.lblNettoDisplay.AutoSize = true;
            this.lblNettoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNettoDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblNettoDisplay.Location = new System.Drawing.Point(657, 346);
            this.lblNettoDisplay.Name = "lblNettoDisplay";
            this.lblNettoDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblNettoDisplay.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 189);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Uhrzeit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 516);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Uhrzeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 265);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Minuten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 346);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Minuten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 432);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Minuten";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 8, 0, 0, 0, 0);
            // 
            // lblDateTimePicker
            // 
            this.lblDateTimePicker.AutoSize = true;
            this.lblDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimePicker.Location = new System.Drawing.Point(76, 113);
            this.lblDateTimePicker.Name = "lblDateTimePicker";
            this.lblDateTimePicker.Size = new System.Drawing.Size(51, 13);
            this.lblDateTimePicker.TabIndex = 24;
            this.lblDateTimePicker.Text = "Datum :";
            // 
            // btnTransmitData
            // 
            this.btnTransmitData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransmitData.Location = new System.Drawing.Point(526, 489);
            this.btnTransmitData.Name = "btnTransmitData";
            this.btnTransmitData.Size = new System.Drawing.Size(221, 55);
            this.btnTransmitData.TabIndex = 25;
            this.btnTransmitData.Text = "Daten übermitteln";
            this.btnTransmitData.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItemForm2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItemForm2
            // 
            this.menüToolStripMenuItemForm2.Name = "menüToolStripMenuItemForm2";
            this.menüToolStripMenuItemForm2.Size = new System.Drawing.Size(146, 20);
            this.menüToolStripMenuItemForm2.Text = "Arbeitszeiten bearbeiten";
            // 
            // FormRechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 581);
            this.Controls.Add(this.btnTransmitData);
            this.Controls.Add(this.lblDateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNettoDisplay);
            this.Controls.Add(this.lblPauseDisplay);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.lblBruttoDisplay);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.lblPauseAll);
            this.Controls.Add(this.lblBrutto);
            this.Controls.Add(this.textBoxEnde);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.lblPause3);
            this.Controls.Add(this.textBoxPause3);
            this.Controls.Add(this.textBoxPause2);
            this.Controls.Add(this.lblPause2);
            this.Controls.Add(this.textBoxPause1);
            this.Controls.Add(this.lblPause1);
            this.Controls.Add(this.textBoxBeginn);
            this.Controls.Add(this.lblBeginn);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRechner";
            this.Text = "Work Time Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lblBeginn;
        private System.Windows.Forms.TextBox textBoxBeginn;
        private System.Windows.Forms.Label lblPause1;
        private System.Windows.Forms.TextBox textBoxPause1;
        private System.Windows.Forms.Label lblPause2;
        private System.Windows.Forms.TextBox textBoxPause2;
        private System.Windows.Forms.TextBox textBoxPause3;
        private System.Windows.Forms.Label lblPause3;
        private System.Windows.Forms.Label lblEnde;
        private System.Windows.Forms.TextBox textBoxEnde;
        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.Label lblPauseAll;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.Label lblBruttoDisplay;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label lblPauseDisplay;
        private System.Windows.Forms.Label lblNettoDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateTimePicker;
        private System.Windows.Forms.Button btnTransmitData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItemForm2;
    }
}