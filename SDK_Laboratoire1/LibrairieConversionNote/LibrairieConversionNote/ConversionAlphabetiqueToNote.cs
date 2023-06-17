using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("svp Veuillez inserer une note alphabétique parmis celles ci (A, B, C, D, E, F, G) :");
            string noteAlphabetique = Console.ReadLine();

            string noteMusicale = Transformer(noteAlphabetique);
            Console.WriteLine(noteMusicale);
            Console.WriteLine();
        }
    }

    public static string Transformer(string noteAlphabetique)
    {
        switch (noteAlphabetique.ToUpper())
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
            default:
                return "cette note n'existe pas.";
        }
    }
}
