using MediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;

namespace MediaTek86.controller
{
    public class FrmAjModPersController
    {
        private readonly ServiceAccess serviceAccess;

        private readonly PersonnelAccess personnelAccess;

        public FrmAjModPersController()
        {
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAccess();
        }

        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        public void AjouterPersonnel(Personnel personnel)
        {
            personnelAccess.AjouterPersonnel(personnel);
        }

        public void ModifierPersonnel(Personnel personnel)
        {
            personnelAccess.ModifierPersonnel(personnel);
        }
    }
}
