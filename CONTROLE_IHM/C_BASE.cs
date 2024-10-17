using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.Json;

namespace CONTROLE_IHM
{
  public class C_BASE
  {
    const string MON_FICHIER = "MonFichier_IHM.json";

    public List<C_CREATURE> Les_Creatures { get; set; }

    public List<int> Les_ID = new List<int>();
    public List<string> Les_Types = new List<string>();
    public List<int> Les_Couleurs = new List<int>();
    public List<string> Les_Noms = new List<string>();
    public List<int> Les_ID_Groupe = new List<int>();


    //..........................

    public void Charge_Data()
    {
      string Data_Json = File.ReadAllText(MON_FICHIER);

      Les_Creatures = JsonSerializer.Deserialize<List<C_CREATURE>>(Data_Json);

      for (int Index = 0; Index < Les_Creatures.Count; Index++) {
        Les_ID.Add(Les_Creatures[Index].ID);
        Les_Types.Add(Les_Creatures[Index].Type);
        Les_Couleurs.Add(Les_Creatures[Index].Couleur);
        Les_Noms.Add(Les_Creatures[Index].Nom);
        Les_ID_Groupe.Add(Les_Creatures[Index].ID_Groupe);
      }
    }

    public void Sauvegarde()
    {
      string Data_A_Save = JsonSerializer.Serialize(Les_Creatures);
      File.WriteAllText(MON_FICHIER, Data_A_Save);
    }

    public void Ajoute_Creature(C_CREATURE P_Creature)
    {
      Les_Creatures.Add(P_Creature);
    }

    public void Supprime_Creature(C_CREATURE P_Creature)
    {
      Les_Creatures.Remove(P_Creature);
    }
  }
}
