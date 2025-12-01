using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mappers
{
    internal static class Mapper
    {
        internal static Benevole ToBenevole(this IDataRecord record)
            {
             return new Benevole((int)record["Id"], 
                                 (string)record["Prenom"], 
                                 (string)record["Nom"], 
                                 (string)record["Tel"], 
                                 (string)record["Adresse"], 
                                 (bool)record["EstResponsable"], 
                                 (bool)record["FormeFerme"], 
                                 (bool)record["FormeReptile"], 
                                 (bool)record["FormeContrat"]);
            }
    }
}
