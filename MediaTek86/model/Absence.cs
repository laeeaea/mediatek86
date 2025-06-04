using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Absence
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdPersonnel { get; set; }
        public int IdMotif { get; set; }

        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            this.IdPersonnel = idPersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.IdMotif = idMotif;

        }


    }
}
