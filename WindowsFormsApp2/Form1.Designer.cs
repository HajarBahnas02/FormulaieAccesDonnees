namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Cbx = new System.Windows.Forms.ComboBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbx
            // 
            this.Cbx.FormattingEnabled = true;
            this.Cbx.Location = new System.Drawing.Point(139, 38);
            this.Cbx.Name = "Cbx";
            this.Cbx.Size = new System.Drawing.Size(319, 28);
            this.Cbx.TabIndex = 0;
            this.Cbx.SelectedIndexChanged += new System.EventHandler(this.Cbx_SelectedIndexChanged);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(35, 275);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(109, 43);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "ADD";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnModifier.Enabled = false;
            this.BtnModifier.Location = new System.Drawing.Point(183, 275);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(109, 43);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "Modify";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnSupprimer.Enabled = false;
            this.BtnSupprimer.Location = new System.Drawing.Point(327, 275);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(109, 43);
            this.BtnSupprimer.TabIndex = 3;
            this.BtnSupprimer.Text = "Delete";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnEnregistrer.Enabled = false;
            this.BtnEnregistrer.Location = new System.Drawing.Point(476, 275);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(109, 43);
            this.BtnEnregistrer.TabIndex = 4;
            this.BtnEnregistrer.Text = "Save";
            this.BtnEnregistrer.UseVisualStyleBackColor = false;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.Location = new System.Drawing.Point(639, 275);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(109, 43);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Cancel";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxNom.Location = new System.Drawing.Point(139, 93);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(212, 26);
            this.txtBoxNom.TabIndex = 6;
            this.txtBoxNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxPrenom.Location = new System.Drawing.Point(139, 137);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(212, 26);
            this.txtBoxPrenom.TabIndex = 7;
            this.txtBoxPrenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "prenom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "nom";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.Cbx);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}