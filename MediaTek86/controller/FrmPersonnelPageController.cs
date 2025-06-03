using MediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;

namespace MediaTek86.controller
{
    public class FrmPersonnelPageController
    {
        private readonly PersonnelAccess personnelAccess;

        public FrmPersonnelPageController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// </summary>
        /// On récupère la liste de tous les personnels
        /// </summary>
        /// <returns>Liste de Personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();

        }
    }
}
