using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Secteur // obligatoire de créer cette entité pour utiliser entity. obligé d'utiliser entity parce qu'il y a des classes partout avec des fk partout.
    {
        //public Secteur(int secteurId, string nomSecteur)
        //{
        //    SecteurId = secteurId;
        //    NomSecteur = nomSecteur;
        //}
        [Key]
        public int SecteurId { get; set; }
        public string? NomSecteur { get; set; }
    }
}
