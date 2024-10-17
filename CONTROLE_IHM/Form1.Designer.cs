namespace CONTROLE_IHM
{
    partial class C_CADRE_PRINCIPALE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
      this.GB_1 = new System.Windows.Forms.GroupBox();
      this.LST_Creatures = new System.Windows.Forms.ListBox();
      this.TXT_Type = new System.Windows.Forms.TextBox();
      this.TXT_Nom = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.BTN_Ajouter = new System.Windows.Forms.Button();
      this.BTN_Sauvegarde = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.SM_Fichier = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.SM_Quitter = new System.Windows.Forms.ToolStripMenuItem();
      this.BTN_Supprimer = new System.Windows.Forms.Button();
      this.BTN_Modifier = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.TXT_ID = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.TXT_ID_Groupe = new System.Windows.Forms.TextBox();
      this.GB_1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // GB_1
      // 
      this.GB_1.Controls.Add(this.LST_Creatures);
      this.GB_1.Location = new System.Drawing.Point(39, 36);
      this.GB_1.Name = "GB_1";
      this.GB_1.Size = new System.Drawing.Size(229, 407);
      this.GB_1.TabIndex = 0;
      this.GB_1.TabStop = false;
      this.GB_1.Text = "Créatures";
      // 
      // LST_Creatures
      // 
      this.LST_Creatures.FormattingEnabled = true;
      this.LST_Creatures.Location = new System.Drawing.Point(6, 33);
      this.LST_Creatures.Name = "LST_Creatures";
      this.LST_Creatures.Size = new System.Drawing.Size(217, 368);
      this.LST_Creatures.TabIndex = 0;
      // 
      // TXT_Type
      // 
      this.TXT_Type.Location = new System.Drawing.Point(415, 116);
      this.TXT_Type.Name = "TXT_Type";
      this.TXT_Type.Size = new System.Drawing.Size(100, 20);
      this.TXT_Type.TabIndex = 1;
      // 
      // TXT_Nom
      // 
      this.TXT_Nom.Location = new System.Drawing.Point(415, 142);
      this.TXT_Nom.Name = "TXT_Nom";
      this.TXT_Nom.Size = new System.Drawing.Size(100, 20);
      this.TXT_Nom.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.Location = new System.Drawing.Point(358, 116);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Type :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(359, 142);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "Nom :";
      // 
      // BTN_Ajouter
      // 
      this.BTN_Ajouter.Location = new System.Drawing.Point(440, 208);
      this.BTN_Ajouter.Name = "BTN_Ajouter";
      this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
      this.BTN_Ajouter.TabIndex = 8;
      this.BTN_Ajouter.Text = "Ajouter";
      this.BTN_Ajouter.UseVisualStyleBackColor = true;
      this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
      // 
      // BTN_Sauvegarde
      // 
      this.BTN_Sauvegarde.Location = new System.Drawing.Point(545, 430);
      this.BTN_Sauvegarde.Name = "BTN_Sauvegarde";
      this.BTN_Sauvegarde.Size = new System.Drawing.Size(97, 36);
      this.BTN_Sauvegarde.TabIndex = 9;
      this.BTN_Sauvegarde.Text = "Sauvegarder";
      this.BTN_Sauvegarde.UseVisualStyleBackColor = true;
      this.BTN_Sauvegarde.Click += new System.EventHandler(this.BTN_Sauvegarde_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_Fichier});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(663, 24);
      this.menuStrip1.TabIndex = 10;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // SM_Fichier
      // 
      this.SM_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.SM_Quitter});
      this.SM_Fichier.Name = "SM_Fichier";
      this.SM_Fichier.Size = new System.Drawing.Size(54, 20);
      this.SM_Fichier.Text = "&Fichier";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
      // 
      // SM_Quitter
      // 
      this.SM_Quitter.Name = "SM_Quitter";
      this.SM_Quitter.Size = new System.Drawing.Size(111, 22);
      this.SM_Quitter.Text = "&Quitter";
      this.SM_Quitter.Click += new System.EventHandler(this.SM_Quitter_Click);
      // 
      // BTN_Supprimer
      // 
      this.BTN_Supprimer.Location = new System.Drawing.Point(193, 443);
      this.BTN_Supprimer.Name = "BTN_Supprimer";
      this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
      this.BTN_Supprimer.TabIndex = 11;
      this.BTN_Supprimer.Text = "Supprimer";
      this.BTN_Supprimer.UseVisualStyleBackColor = true;
      this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
      // 
      // BTN_Modifier
      // 
      this.BTN_Modifier.Location = new System.Drawing.Point(39, 443);
      this.BTN_Modifier.Name = "BTN_Modifier";
      this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
      this.BTN_Modifier.TabIndex = 12;
      this.BTN_Modifier.Text = "Modifier";
      this.BTN_Modifier.UseVisualStyleBackColor = true;
      this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(359, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 20);
      this.label3.TabIndex = 14;
      this.label3.Text = "ID :";
      // 
      // TXT_ID
      // 
      this.TXT_ID.Location = new System.Drawing.Point(415, 90);
      this.TXT_ID.Name = "TXT_ID";
      this.TXT_ID.Size = new System.Drawing.Size(100, 20);
      this.TXT_ID.TabIndex = 13;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(317, 168);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 20);
      this.label4.TabIndex = 17;
      this.label4.Text = "ID Groupe :";
      // 
      // TXT_ID_Groupe
      // 
      this.TXT_ID_Groupe.Location = new System.Drawing.Point(415, 168);
      this.TXT_ID_Groupe.Name = "TXT_ID_Groupe";
      this.TXT_ID_Groupe.Size = new System.Drawing.Size(100, 20);
      this.TXT_ID_Groupe.TabIndex = 16;
      // 
      // C_CADRE_PRINCIPALE
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 485);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.TXT_ID_Groupe);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TXT_ID);
      this.Controls.Add(this.BTN_Modifier);
      this.Controls.Add(this.BTN_Supprimer);
      this.Controls.Add(this.BTN_Sauvegarde);
      this.Controls.Add(this.BTN_Ajouter);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TXT_Nom);
      this.Controls.Add(this.TXT_Type);
      this.Controls.Add(this.GB_1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "C_CADRE_PRINCIPALE";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Parties 1, 2 et 3";
      this.GB_1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.ListBox LST_Creatures;
        private System.Windows.Forms.TextBox TXT_Type;
        private System.Windows.Forms.TextBox TXT_Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Sauvegarde;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SM_Fichier;
        private System.Windows.Forms.ToolStripMenuItem SM_Quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_ID_Groupe;
    }
}

