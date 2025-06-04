using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;
using Serilog;


namespace MediaTek86.dal
{
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// </summary>
        /// Récupération de la table absence en fonction du personnel sélectionné
        /// </summary>
      ///  public List<Personnel> GetLesAbsences(int idPersonnel)
      ///  {
      ///      List<Absence> lesAbsences = new List<Absence>();
      ///  }
    }
}
