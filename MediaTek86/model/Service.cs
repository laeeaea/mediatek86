using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Service
    {
        public int IdService { get; set; }

        public string Nom { get; set; }

        public Service(int idService, string nom)
        {
            this.IdService = idService;
            this.Nom = nom;

        }
    }
}
