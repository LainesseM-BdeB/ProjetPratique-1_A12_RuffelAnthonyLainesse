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



    public Cours(string nomCours, string categorieCours, typeSalle typeSalleCours, Programme programme)
    {
        this.sigleCours = GenererSigleCours(nomCours, programme);
        this.nomCours = nomCours;
        this.categorieCours = categorieCours;
        this.typeSalleCours = typeSalleCours;
        programme.ListeCours.Add(this);
    }

    private string GenererSigleCours(String nomCours, Programme programme)
    {
        string sigle;
        if (nomCours.Length < 3)
        {
            sigle = nomCours;
            for (int i = 0; i < 3 - nomCours.Length; i++)
            {
                sigle += "X";
            }
        }
        else
        {
            sigle = nomCours.Substring(0, 2) + nomCours.Substring(nomCours.Length-1);
        }

        string month = DateTime.Now.Month.ToString();
        string pair = (programme.DureeProgrammeEnMois % 2) == 0 ? "P" : "I";
        return sigle + "-" + month + "-" + pair;
    }

    public string SigleCours
    {
        get => sigleCours;
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
        Console.WriteLine($"Sigle du cours: {this.SigleCours}");
        Console.WriteLine($"Nom du cours: {this.NomCours}");
        Console.WriteLine($"Categorie du cours: {this.CategorieCours}");
        Console.WriteLine($"Type de salle: {this.TypeSalleCours}");
    }
}