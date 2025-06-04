using MediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;

namespace MediaTek86.controller
{
    public class FrmSupPersController
    {
        private readonly ServiceAccess serviceAccess;

        private readonly PersonnelAccess personnelAccess;

        public FrmSupPersController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère les personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Supprime les personnels
        /// </summary>
        /// <param name="personnel"></param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            personnelAccess.SupprimerPersonnel(personnel);
        }
    }
}
