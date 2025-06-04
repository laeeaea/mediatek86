using MediaTek86.model;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// </summary>
        /// Récupération de la table service
        /// </summary>
        public List<Service> GetLesServices()
        {
            List<Service> LesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select idservice, nom from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("ServiceAccess.GetLesServices nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("Service.GetLesServices Service : idservice={0} nom={1} ", record[0], record[1]);
                            Service service = new Service((int)record[0], (string)record[1]);
                            LesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ServiceAccess.GetLesServices catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return LesServices;
        }
    }
}
