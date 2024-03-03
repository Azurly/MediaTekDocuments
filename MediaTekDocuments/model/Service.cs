using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Service
    {
        public string id { get; }
        public string libelle { get; set; }

        ///<param name="idservice"></param>
        ///<param name="libelleService"></param>
        public Service(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
