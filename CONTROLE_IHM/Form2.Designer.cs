namespace CONTROLE_IHM
{
    partial class C_CADRE_MODIFIER
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
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_ID_Group = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Type = new System.Windows.Forms.TextBox();
            this.BTN_Confirmer_Modifier = new System.Windows.Forms.Button();
            this.BTN_Annuler_Modification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID Groupe :";
            // 
            // TXT_ID_Group
            // 
            this.TXT_ID_Group.Location = new System.Drawing.Point(167, 115);
            this.TXT_ID_Group.Name = "TXT_ID_Group";
            this.TXT_ID_Group.Size = new System.Drawing.Size(100, 20);
            this.TXT_ID_Group.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(110, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type :";
            // 
            // TXT_Type
            // 
            this.TXT_Type.Location = new System.Drawing.Point(167, 78);
            this.TXT_Type.Name = "TXT_Type";
            this.TXT_Type.Size = new System.Drawing.Size(100, 20);
            this.TXT_Type.TabIndex = 18;
            // 
            // BTN_Confirmer_Modifier
            // 
            this.BTN_Confirmer_Modifier.Location = new System.Drawing.Point(275, 212);
            this.BTN_Confirmer_Modifier.Name = "BTN_Confirmer_Modifier";
            this.BTN_Confirmer_Modifier.Size = new System.Drawing.Size(90, 30);
            this.BTN_Confirmer_Modifier.TabIndex = 26;
            this.BTN_Confirmer_Modifier.Text = "Confirmer";
            this.BTN_Confirmer_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Confirmer_Modifier.Click += new System.EventHandler(this.BTN_Confirmer_Modifier_Click);
            // 
            // BTN_Annuler_Modification
            // 
            this.BTN_Annuler_Modification.Location = new System.Drawing.Point(12, 212);
            this.BTN_Annuler_Modification.Name = "BTN_Annuler_Modification";
            this.BTN_Annuler_Modification.Size = new System.Drawing.Size(90, 30);
            this.BTN_Annuler_Modification.TabIndex = 27;
            this.BTN_Annuler_Modification.Text = "Annuler";
            this.BTN_Annuler_Modification.UseVisualStyleBackColor = true;
            this.BTN_Annuler_Modification.Click += new System.EventHandler(this.BTN_Annuler_Modification_Click);
            // 
            // C_CADRE_MODIFIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 254);
            this.Controls.Add(this.BTN_Annuler_Modification);
            this.Controls.Add(this.BTN_Confirmer_Modifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_ID_Group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Type);
            this.Name = "C_CADRE_MODIFIER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_ID_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Type;
        private System.Windows.Forms.Button BTN_Confirmer_Modifier;
        private System.Windows.Forms.Button BTN_Annuler_Modification;
    }
}