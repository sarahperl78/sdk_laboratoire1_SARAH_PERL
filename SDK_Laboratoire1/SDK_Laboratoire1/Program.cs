using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Quel type de conversion souhaitez-vous faire ?");
            Console.WriteLine("1. NOTE (Alphabétique vers note)");
            Console.WriteLine("2. ALPHABETE (Note vers alphabétique)");
            Console.WriteLine("Pour quitter, appuyez sur CTRL + C.");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    ConversionAlphabetiqueVersNote();
                    break;
                case "2":
                    ConversionNoteVersAlphabetique();
                    break;
                default:
                    Console.WriteLine("ce choix n'est pas valide. Veuillez réessayer.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    public static void ConversionAlphabetiqueVersNote()
    {
        while (true)
        {
            Console.WriteLine("Veuillez entrer une note alphabétique (A, B, C, D, E, F, G) :");
            string noteAlphabetique = Console.ReadLine();

            string noteMusicale = Transformer(noteAlphabetique);
            Console.WriteLine("La note syllabe correspondante est : " + noteMusicale);
            Console.WriteLine();
        }
    }

    public static void ConversionNoteVersAlphabetique()
    {
        while (true)
        {
            Console.WriteLine("Veuillez entrer une note syllabe (DO, RÉ, MI, FA, SOL, LA, SI) :");
            string noteSyllabe = Console.ReadLine();

            string noteAlphabetique = Transformer(noteSyllabe);
            Console.WriteLine("La note alphabétique qui corespond  est : " + noteAlphabetique);
            Console.WriteLine();
        }
    }

    public static string Transformer(string note)
    {
        switch (note.ToUpper())
        {
            case "A":
                return "DO";
            case "B":
                return "RÉ";
            case "C":
                return "MI";
            case "D":
                return "FA";
            case "E":
                return "SOL";
            case "F":
                return "LA";
            case "G":
                return "SI";
            case "DO":
                return "A";
            case "RÉ":
                return "B";
            case "MI":
                return "C";
            case "FA":
                return "D";
            case "SOL":
                return "E";
            case "LA":
                return "F";
            case "SI":
                return "G";
            default:
                return "La note n'existe pas.";
        }
    }
}
