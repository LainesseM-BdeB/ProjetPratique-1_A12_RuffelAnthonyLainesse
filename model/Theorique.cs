namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model
{

    internal class Theorique:Cours 
    {

        
       private int nombreCredits ;

        public int NombreCredits { get => nombreCredits; set => nombreCredits = value; }

        public Theorique( string nomCours, string categorieCours, typeSalle typeSalleCours, Programme programme, int nombreCredits) : 
                         base(nomCours,categorieCours, typeSalleCours, programme) 
        { 
        
            this.nombreCredits = nombreCredits; 
        
        }
        
        public void AfficherCredits() {

            while (nombreCredits > 0)
            {

                Console.WriteLine("Nombre de crédit pour le cours : " + nombreCredits);

            }

        }

        

    }

    
}