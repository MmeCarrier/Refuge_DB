using RefugeManagerShared.SharedEntities;
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
            return new Benevole((string)record["Prenom"],
                                (string)record["Nom"],
                                (string)record["Tel"],
                                (string)record["Adresse"],
                                (bool)record["EstResponsable"],
                                (bool)record["FormeFerme"],
                                (bool)record["FormeReptile"],
                                (bool)record["FormeContrat"],
                                (int)record["SecteurId"],
                                (int)record["FaId"]);
             }
        internal static Animal ToAnimal(this IDataRecord record)
        {
               return new Animal((string)record["Nom"],
                                (string)record["Espece"],
                                (string)record["Age"],
                                (bool)record["MF"],
                                (bool)record["Sterilise"],
                                (bool)record["PrimoVaccin"],
                                (bool)record["Vaccincomplet"],
                                (string)record["Provenance"],
                                (string)record["LieuProvenance"],
                                (string)record["Localisation"],
                                (string)record["Remarque"],
                                (int)record["SecteurId"],
                                (int)record["FaId"]);
        }
    }
}
