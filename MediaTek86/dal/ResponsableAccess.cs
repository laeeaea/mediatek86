using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using MediaTek86.model;

namespace MediaTek86.dal
{
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login et mot de passe)
        /// </summary>
        /// <param name="responsable">objet Responsable avec login et mot de passe</param>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable r ";
                req += "where r.login=@login and password=SHA2(@password, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object> 
                {
                    { "@login", responsable.Login },
                    { "@password", responsable.Password }
                };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}
