using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text.Json;

namespace CONTROLE_IHM
{
  public partial class C_CADRE_PRINCIPALE : Form
  {
    C_BASE La_Base;
    public C_CADRE_PRINCIPALE()
    {
      InitializeComponent();

      La_Base = new C_BASE();
      La_Base.Charge_Data();

      LST_Creatures.DisplayMember = "Nom";

      MAJ_LST_Creatures();
    }

    private void MAJ_LST_Creatures()
    {
      LST_Creatures.Items.Clear();

      for (int Index = 0; Index < La_Base.Les_Creatures.Count; Index++) {
        C_CREATURE Son_Nom = La_Base.Les_Creatures[Index];
        LST_Creatures.Items.Add(Son_Nom);
      }
    }

    private void BTN_Ajouter_Click(object sender, EventArgs e)
    {
      if (TXT_ID != null && TXT_Type != null && TXT_Nom != null && TXT_ID_Groupe != null) {
        C_CREATURE Nouvelle_Creature = new C_CREATURE() { ID = Convert.ToInt32(TXT_ID.Text), Type = TXT_Type.Text, Nom = TXT_Nom.Text, ID_Groupe = Convert.ToInt32(TXT_ID_Groupe.Text) };
        La_Base.Ajoute_Creature(Nouvelle_Creature);
        TXT_ID.Clear();
        TXT_Type.Clear();
        TXT_Nom.Clear();
        TXT_ID_Groupe.Clear();
        La_Base.Sauvegarde();
        MAJ_LST_Creatures();
      }
    }

    private void BTN_Sauvegarde_Click(object sender, EventArgs e)
    {
      La_Base.Sauvegarde();
    }

    private void BTN_Supprimer_Click(object sender, EventArgs e)
    {
      if (LST_Creatures.SelectedItem != null) {
        C_CREATURE Creature_Select = (C_CREATURE)LST_Creatures.SelectedItem;
        La_Base.Supprime_Creature(Creature_Select);
        La_Base.Sauvegarde();
        MAJ_LST_Creatures();
      }
    }

    private void BTN_Modifier_Click(object sender, EventArgs e)
    {
      if (LST_Creatures.SelectedItem != null) {
        C_CREATURE Creature_Select = (C_CREATURE)LST_Creatures.SelectedItem;
        C_CADRE_MODIFIER Cadre_Modifier = new C_CADRE_MODIFIER(Creature_Select);
        Cadre_Modifier.ShowDialog();
      }
    }

    private void SM_Quitter_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
