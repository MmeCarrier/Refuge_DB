using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Epidemie
    {
        public Epidemie(
            string maladie,
            DateTime dateDeclaration,            
            string especeConcernee,
            string especesVulnerables,
            int? secteurId)
        {
            Maladie = maladie;
            DateDeclaration = dateDeclaration;            
            EspeceConcernee = especeConcernee;
            EspecesVulnerables = especesVulnerables;
            SecteurId = secteurId;
        }

        public int EpidemieId { get; private set; }
        public string Maladie { get; set; }
        public DateTime DateDeclaration { get; set; }        
        public string EspeceConcernee { get; set; }
        public string EspecesVulnerables { get; set; }
        public int? SecteurId { get; set; }
        public Secteur? Secteur { get; set; }
    }


}
