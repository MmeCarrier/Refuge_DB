using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public class GetBySurname
    {
        public string Prenom { get; set; }

        public GetBySurname(string prenom)
        {
            Prenom = prenom;
        }
    }
}