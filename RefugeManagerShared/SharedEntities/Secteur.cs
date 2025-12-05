using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Secteur // obligatoire de créer cette entité pour utiliser entity. obligé d'utiliser entity parce qu'il y a des classes partout avec des fk partout.
    {
        public Secteur(int secteurId, string nomSecteur)
        {
            SecteurId = secteurId;
            NomSecteur = nomSecteur;
        }

        public int SecteurId { get; }
        public string NomSecteur { get; }
    }
}
