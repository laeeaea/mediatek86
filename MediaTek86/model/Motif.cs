using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    internal class Motif
    {
        public int IdMotif { get; set;}
        public string Libelle { get; set; }

        public Motif(int idMotif, string libelle)
        {
            this.IdMotif = idMotif;
            this.Libelle = libelle;
        }
    }
}
