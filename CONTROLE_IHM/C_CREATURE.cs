using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.Json;

namespace CONTROLE_IHM
{

    public class C_CREATURE
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Couleur { get; set; }
        public string Nom { get; set; }
        public int ID_Groupe { get; set; }
    }
}
