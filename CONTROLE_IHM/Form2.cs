using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLE_IHM
{
    public partial class C_CADRE_MODIFIER : Form
    {
        C_CREATURE La_Creature = null;
        public C_CADRE_MODIFIER(C_CREATURE P_Creature_Select)
        {
            La_Creature = P_Creature_Select;
            InitializeComponent();
            TXT_Type.Text = La_Creature.Type;
            TXT_ID_Group.Text = La_Creature.ID_Groupe.ToString(); ;
        }

        private void BTN_Confirmer_Modifier_Click(object sender, EventArgs e)
        {
            La_Creature.Type = TXT_Type.Text;
            La_Creature.ID_Groupe = Convert.ToInt32(TXT_ID_Group.Text);
            Close();
        }

        private void BTN_Annuler_Modification_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
