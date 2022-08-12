namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model;

public class Programme
{
    private int idProgramme;
    private string titreProgramme;
    private DateTime dateCreation;
    private int nombreDeCredit;
    private int dureeProgrammeEnMois;

    private HashSet<Cours> listeCours;

    private static int nombreTotalProgramme = 0;

    public Programme()
    {
        nombreTotalProgramme++;
    }

    public Programme(int idProgramme, string titreProgramme, DateTime dateCreation, int nombreDeCredit, int dureeProgrammeEnMois)
    {
        this.idProgramme = idProgramme;
        this.titreProgramme = titreProgramme;
        this.dateCreation = dateCreation;
        this.nombreDeCredit = nombreDeCredit;
        this.dureeProgrammeEnMois = dureeProgrammeEnMois;
        this.listeCours = new HashSet<Cours>();
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

    public void afficherProgramme()
    {
        Console.WriteLine($"ID du programme: {IdProgramme}");
        Console.WriteLine($"Nom du programme: {TitreProgramme}");
        Console.WriteLine($"Date de création: {DateCreation}");
        Console.WriteLine($"Nombre de crédit: {NombreDeCredit}");
        Console.WriteLine($"Durée du programme en mois: {DureeProgrammeEnMois}");
    }

    public void afficherNombreTotal()
    {
        Console.WriteLine($"Nombre total de programme: {NombreTotalProgramme}");
    }

    public HashSet<Cours> ListeCours => listeCours;

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