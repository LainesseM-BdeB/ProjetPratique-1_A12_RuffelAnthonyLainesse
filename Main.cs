// See https://aka.ms/new-console-template for more information

using ProjetPratique_1_A12_RuffelAnthonyLainesse.model;

Programme analysteProgrammeur = new Programme(
    1
    , "Analyste-Programmeur"
    , DateTime.Now
    , 6
    , 24
    );

analysteProgrammeur.afficherProgramme();
analysteProgrammeur.afficherNombreTotal();


Programme cyberSecurite = new Programme(
    2
    , "Cyber Sécurité"
    , DateTime.Now
    , 8
    , 36
);

cyberSecurite.afficherProgramme();
cyberSecurite.afficherNombreTotal();
