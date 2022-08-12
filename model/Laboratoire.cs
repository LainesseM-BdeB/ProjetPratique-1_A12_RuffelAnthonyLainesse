using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model
{


    public enum typeSystemExploitation { WINDOWS, MACOS, LINUX };

    internal class Laboratoire : Cours
    {

        private typeSystemExploitation typeSystemExploitation;

        public Laboratoire( string nomCours, string categorieCours, typeSalle typeSalleCours, Programme programme, typeSystemExploitation systemExploitation):  base(nomCours, categorieCours, typeSalleCours, programme) 
        {

            this.typeSystemExploitation = systemExploitation;
        }

        public typeSystemExploitation TypeSystemExploitation
        {
            get => typeSystemExploitation;
            set => typeSystemExploitation = value;
        }

        public void AfficherSystemExploitation()
        {

            while (typeSystemExploitation != null)
            {

                Console.WriteLine(typeSystemExploitation);

            }


        }


      
    }
}



