﻿namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model;

public class Programme
{
    private int idProgramme;
    private string titreProgramme;
    private DateTime dateCreation;
    private int nombreDeCredit;
    private int dureeProgrammeEnMois;

    private HashSet<Cours> listeCours; //Set de cours pour satisfaire le lien 1 à 1..* du diagramme de classe.

    private static int nombreTotalProgramme = 0;
    
    //Le constructeur oblige la présence d'un cours pour satisfaire l'exigence 1..* du lien entre Programme et Cours.
    public Programme(int idProgramme, string titreProgramme, DateTime dateCreation, int nombreDeCredit, int dureeProgrammeEnMois, string nomCours, string categorieCours, typeSalle typeSalleCours)
    {
        this.idProgramme = idProgramme;
        this.titreProgramme = titreProgramme;
        this.dateCreation = dateCreation;
        this.nombreDeCredit = nombreDeCredit;
        this.dureeProgrammeEnMois = dureeProgrammeEnMois;
        this.listeCours = new HashSet<Cours>();
        Cours cours = new Cours(nomCours, categorieCours, typeSalleCours, this);
        this.listeCours.Add(cours);
        nombreTotalProgramme++;
    }

    public int IdProgramme
    {
        get => idProgramme;
        set => idProgramme = value;
    }

    public string TitreProgramme
    {
        get => titreProgramme;
        set => titreProgramme = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime DateCreation
    {
        get => dateCreation;
        set => dateCreation = value;
    }

    public int NombreDeCredit
    {
        get => nombreDeCredit;
        set => nombreDeCredit = value;
    }

    public int DureeProgrammeEnMois
    {
        get => dureeProgrammeEnMois;
        set => dureeProgrammeEnMois = value;
    }

    public static int NombreTotalProgramme => nombreTotalProgramme;

    //Fonction pour afficher les détails du programme. Pour la liste des cours seuelement le nom est affiché.
    public void afficherProgramme()
    {
        Console.WriteLine("\n################################################");
        Console.WriteLine($"ID du programme: {IdProgramme}");
        Console.WriteLine($"Nom du programme: {TitreProgramme}");
        Console.WriteLine($"Date de création: {DateCreation}");
        Console.WriteLine($"Nombre de crédit: {NombreDeCredit}");
        Console.WriteLine($"Durée du programme en mois: {DureeProgrammeEnMois}");
        Console.WriteLine($"Les cours du programme sont: {String.Join(", ", extraireNomCours())}");
        Console.WriteLine("################################################\n");
    }

    public void afficherNombreTotal()
    {
        Console.WriteLine($"Nombre total de programme: {NombreTotalProgramme}");
    }

    public HashSet<Cours> ListeCours => listeCours;

    //Fonction pour extraire les nom de cours qui seront utilisés dans la function afficherProgramme
    private List<string> extraireNomCours()
    {
        List<string> listeNomCours = new List<string>();
        foreach (Cours cours in ListeCours)
        {
            listeNomCours.Add(cours.NomCours);
        }
        return listeNomCours;
    }
    
    //Fonction pour ajouter un cours au programme.
    public Boolean ajouterCours(Cours cours)
    {
        if (ListeCours.Contains(cours))
        {
            Console.WriteLine("Le cours est déjà dans la liste des cours du programme.");
            return false;
        }
        else
        {
            ListeCours.Add(cours);
            return true;
        }
    }
}