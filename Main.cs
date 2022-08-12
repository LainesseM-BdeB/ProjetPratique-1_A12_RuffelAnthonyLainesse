// See https://aka.ms/new-console-template for more information

using ProjetPratique_1_A12_RuffelAnthonyLainesse.model;


//TEST pour valider le bon fonctionnement de la classe Programme
Programme analysteProgrammeur = new Programme(
    1
    , "Analyste-Programmeur"
    , DateTime.Now
    , 6
    , 24,
    "Test1",
    "Test1",
    typeSalle.LABORATOIRE
    );

analysteProgrammeur.afficherProgramme();
analysteProgrammeur.afficherNombreTotal();


Programme cyberSecurite = new Programme(
    2
    , "Cyber Sécurité"
    , DateTime.Now
    , 8
    , 36,
    "Test1",
    "Test1",
    typeSalle.LABORATOIRE
);

Cours test2 = new Cours("Test2", "Test2", typeSalle.LABORATOIRE, cyberSecurite);
cyberSecurite.ajouterCours(test2);

cyberSecurite.afficherProgramme();
cyberSecurite.afficherNombreTotal();

cyberSecurite.enleverCours(test2);
cyberSecurite.afficherProgramme();
//FIN TEST pour valider le bon fonctionnement de la classe Programme