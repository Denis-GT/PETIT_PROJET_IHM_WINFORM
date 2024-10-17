using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.Json;

namespace CONTROLE_CMD
{
    internal class Program
    {
        public class C_BASE
        {
            const string MON_FICHIER = "MonFichier.json";

            public List<C_Creature> Les_Creatures { get; set; }

            public List<int> Les_ID = new List<int>();
            public List<string> Les_Types = new List<string>();
            public List<int> Les_Couleurs = new List<int>();
            public List<string> Les_Noms = new List<string>();
            public List<int> Les_ID_Groupe = new List<int>();


            //..........................

            public void Charge_Data()
            {
                string Data_Json = File.ReadAllText(MON_FICHIER);

                Les_Creatures = JsonSerializer.Deserialize<List<C_Creature>>(Data_Json);

                for (int Index = 0; Index < Les_Creatures.Count; Index++) {
                    Les_ID.Add(Les_Creatures[Index].ID);
                    Les_Types.Add(Les_Creatures[Index].Type);
                    Les_Couleurs.Add(Les_Creatures[Index].Couleur);
                    Les_Noms.Add(Les_Creatures[Index].Nom);
                    Les_ID_Groupe.Add(Les_Creatures[Index].ID_Groupe);
                }
            }

            public List<C_Creature> Get_All_Creatures()
            {
                return Les_Creatures;
            }

        }

        //==================================

        public class C_Creature
        {
            public int ID { get; set; }
            public string Type { get; set; }
            public int Couleur { get; set; }
            public string Nom { get; set; }
            public int ID_Groupe { get; set; }

            //......................................

            public void Affiche_Toi()
            {
                Console.WriteLine($"{ID} / {Type} / {Couleur} / {Nom} / {ID_Groupe}");
            }
        }

        //#############################################

        static void Main(/*string[] args*/)
        {
            C_BASE La_Base = new C_BASE();
            La_Base.Charge_Data();

            List<C_Creature> Mes_Creatures = La_Base.Get_All_Creatures();

            for (int Index = 0; Index < Mes_Creatures.Count; Index++) {
                Mes_Creatures[Index].Affiche_Toi();
            }
        }
    }
}
