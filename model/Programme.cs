namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model;

public class Programme
{
    private int idProgramme;
    private string titreProgramme;
    private DateTime dateCreation;
    private int nombreDeCredit;
    private int dureeProgrammeEnMois;

    private static int nombreTotalProgramme = 0;

    public Programme()
    {
    }

    public Programme(int idProgramme, string titreProgramme, DateTime dateCreation, int nombreDeCredit, int dureeProgrammeEnMois)
    {
        this.idProgramme = idProgramme;
        this.titreProgramme = titreProgramme;
        this.dateCreation = dateCreation;
        this.nombreDeCredit = nombreDeCredit;
        this.dureeProgrammeEnMois = dureeProgrammeEnMois;
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
}