using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.model;
using Serilog;

namespace MediaTek86.dal
{
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// </summary>
        /// Récupération de la table personnel
        /// </summary>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> LesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as nomservice ";
                req += "from personnel p join service s on (p.idservice = s.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("PersonnelAccess.GetLesPersonnels nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                           /// Log.Debug("PersonnelAccess.GetLesPersonnels Profil : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("Personnel.GetLesPersonnels Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} idservice={5} nomservice={6} ", record[0], record[1], record[2], record[3], record[4], record[5], record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], (int)record[5], (string)record[6]);
                            LesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.GetLesPersonnels catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return LesPersonnels;
        }
    }
}
