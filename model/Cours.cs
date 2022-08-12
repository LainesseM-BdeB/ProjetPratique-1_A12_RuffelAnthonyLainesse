namespace ProjetPratique_1_A12_RuffelAnthonyLainesse.model;

public enum typeSalle
{
    LABORATOIRE,
    AUDITOIRE,
    AMPHITHEATRE
}
public class Cours
{
    private string sigleCours;
    private string nomCours;
    private string categorieCours;
    private typeSalle typeSalleCours;


    public Cours()
    {
    }

    public Cours(string sigleCours, string nomCours, string categorieCours, typeSalle typeSalleCours)
    {
        this.sigleCours = sigleCours;
        this.nomCours = nomCours;
        this.categorieCours = categorieCours;
        this.typeSalleCours = typeSalleCours;
    }

    

    public string SigleCours
    {
        get => sigleCours;
        set => sigleCours = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string NomCours
    {
        get => nomCours;
        set => nomCours = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string CategorieCours
    {
        get => categorieCours;
        set => categorieCours = value ?? throw new ArgumentNullException(nameof(value));
    }

    public typeSalle TypeSalleCours
    {
        get => typeSalleCours;
        set => typeSalleCours = value;
    }

    public void afficherDetailCours()
    {
        Console.WriteLine(this.SigleCours);
        Console.WriteLine(this.NomCours);
        Console.WriteLine(this.CategorieCours);
        Console.WriteLine(this.TypeSalleCours);
    }
}