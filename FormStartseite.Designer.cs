using System;
using System.Windows.Forms;

namespace WorkTimeCalculator
{
    partial class FormStartseite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartseite));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worktimecalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fensterMinimierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fensterStandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fensterMaximierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.optionenToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worktimecalculatorToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menüToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            resources.ApplyResources(this.menüToolStripMenuItem, "menüToolStripMenuItem");
            // 
            // worktimecalculatorToolStripMenuItem
            // 
            this.worktimecalculatorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.worktimecalculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.worktimecalculatorToolStripMenuItem.Name = "worktimecalculatorToolStripMenuItem";
            resources.ApplyResources(this.worktimecalculatorToolStripMenuItem, "worktimecalculatorToolStripMenuItem");
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            resources.ApplyResources(this.beendenToolStripMenuItem, "beendenToolStripMenuItem");
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterMinimierenToolStripMenuItem,
            this.fensterStandartToolStripMenuItem,
            this.fensterMaximierenToolStripMenuItem});
            this.optionenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            resources.ApplyResources(this.optionenToolStripMenuItem, "optionenToolStripMenuItem");
            // 
            // fensterMinimierenToolStripMenuItem
            // 
            this.fensterMinimierenToolStripMenuItem.Name = "fensterMinimierenToolStripMenuItem";
            resources.ApplyResources(this.fensterMinimierenToolStripMenuItem, "fensterMinimierenToolStripMenuItem");
            // 
            // fensterStandartToolStripMenuItem
            // 
            this.fensterStandartToolStripMenuItem.Name = "fensterStandartToolStripMenuItem";
            resources.ApplyResources(this.fensterStandartToolStripMenuItem, "fensterStandartToolStripMenuItem");
            // 
            // fensterMaximierenToolStripMenuItem
            // 
            this.fensterMaximierenToolStripMenuItem.Name = "fensterMaximierenToolStripMenuItem";
            resources.ApplyResources(this.fensterMaximierenToolStripMenuItem, "fensterMaximierenToolStripMenuItem");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormStartseite
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStartseite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worktimecalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fensterMinimierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fensterStandartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fensterMaximierenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

