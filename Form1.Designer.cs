﻿
namespace TP_25_Afficheur_proj
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name = "disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ButtonAfficher = new System.Windows.Forms.Button();
            this.textBoxTextAfficher = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // ButtonAfficher
            // 
            this.ButtonAfficher.Location = new System.Drawing.Point(302, 111);
            this.ButtonAfficher.Name = "ButtonAfficher";
            this.ButtonAfficher.Size = new System.Drawing.Size(75, 23);
            this.ButtonAfficher.TabIndex = 0;
            this.ButtonAfficher.Text = "Afficher";
            this.ButtonAfficher.UseVisualStyleBackColor = true;
            this.ButtonAfficher.Click += new System.EventHandler(this.ButtonAfficher_Click);
            // 
            // textBoxTextAfficher
            // 
            this.textBoxTextAfficher.Location = new System.Drawing.Point(151, 111);
            this.textBoxTextAfficher.Name = "textBoxTextAfficher";
            this.textBoxTextAfficher.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextAfficher.TabIndex = 1;
            this.textBoxTextAfficher.TextChanged += new System.EventHandler(this.textBoxTextAfficher_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k"});
            this.listBox.Location = new System.Drawing.Point(151, 166);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxTextAfficher);
            this.Controls.Add(this.ButtonAfficher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ButtonAfficher;
        private System.Windows.Forms.TextBox textBoxTextAfficher;
        private System.Windows.Forms.ListBox listBox;
    }
}

