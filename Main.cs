// See https://aka.ms/new-console-template for more information

using ProjetPratique_1_A12_RuffelAnthonyLainesse.model;


//TEST pour valider le bon fonctionnement

//Création d'un programme avec un cours Laboratoire
Programme analysteProgrammeur = new Programme(
    1
    , "Analyste-Programmeur"
    , DateTime.Now
    , 6
    , 24,
    "Programmation Objet",
    "Programmation",
    typeSalle.LABORATOIRE,
    typeSystemExploitation.LINUX
    );

//Test de l'affichage des information d'un programme
analysteProgrammeur.afficherProgramme();
Console.WriteLine();
analysteProgrammeur.afficherNombreTotal();
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");


////Création d'un programme avec un cours Théorique
Programme cyberSecurite = new Programme(
    2
    , "Cyber Sécurité"
    , DateTime.Now
    , 8
    , 33,
    "Linux 101",
    "Informatique",
    typeSalle.LABORATOIRE,
    2
);

//Tester la création des deux types de cours
Laboratoire test2 = new Laboratoire("White Hat", "Testing", typeSalle.LABORATOIRE, cyberSecurite, typeSystemExploitation.WINDOWS);
Theorique test3 = new Theorique("AI", "Programmation", typeSalle.AUDITOIRE, cyberSecurite, 3);

//Tester l'affichage des cours Théorique et Laboratoire
test2.afficherDetailCours();
test3.afficherDetailCours();

//Tester l'ajout des cours dans l'affichage
cyberSecurite.afficherProgramme();
//Tester l'incrémentation du nombre total des Programmes
cyberSecurite.afficherNombreTotal();

//FIN TEST pour valider le bon fonctionnement