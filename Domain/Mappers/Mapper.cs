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
        internal static Animal ToAnimal(this IDataRecord record)
        {
            return new Animal((int)record["AnimalId"],
                               (string)record["Nom"],
                                (string)record["Espece"],
                                (string)record["Age"],
                                (bool)record["MF"],
                                (bool)record["Sterilise"],
                                (bool)record["PrimoVAccin"],
                                (bool)record["Vaccincomplet"],
                                (string)record["Provenance"],
                                (string)record["LieuProvenance"],
                                (string)record["Localisation"],
                                (string)record["Remarque"]);
        }
    }
}
