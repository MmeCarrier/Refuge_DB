using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.EpidemieCommand
{

        public class AjoutEpidemie : ICommandDefinition // Création de la commande pour ajouter une épidémie
        {
            public AjoutEpidemie(string maladie, DateTime dateDeclaration, string especeConcernee, string especesVulnerables, int secteurId)
            {
                Maladie = maladie;
                DateDeclaration = dateDeclaration;                
                EspeceConcernee = especeConcernee;
                EspecesVulnerables = especesVulnerables;
                SecteurId = secteurId;
            }

            public string Maladie { get; } // Nom de la maladie
            public DateTime DateDeclaration { get; } // Date de la déclaration de l'épidémie            
            public string EspeceConcernee { get; } // Espèce concernée par l'épidémie
            public string EspecesVulnerables { get; } // Espèces vulnérables dans ce secteur
            public int SecteurId { get; } // Clé étrangère pour la référence au secteur
        }
    

}
