using System;

class Program
{
    static void Main()
    {
        bool continuer = true;
        while (continuer)
        {
            Console.WriteLine("Sélectionnez un exemple:");
            Console.WriteLine("1. Affectation");
            Console.WriteLine("2. Alternative");
            Console.WriteLine("3. Boucle");
            Console.WriteLine("4. Tableau à une dimension");
            Console.WriteLine("5. Tableau à deux dimensions");
            Console.WriteLine("6. Structure publique");
            Console.WriteLine("7. Concaténer des chaînes de caractères");
            Console.WriteLine("8. Accumuler des valeurs");
            Console.WriteLine("9. Méthode de tri");
            Console.WriteLine("10. Parcourir un tableau à une dimension");
            Console.WriteLine("11. Parcourir un tableau à deux dimensions");
            Console.WriteLine("12. Procédures et fonctions");
            Console.WriteLine("13. Relancer le programme");
            Console.WriteLine("14. Vérifier la validité des encodages");
            Console.WriteLine("15. Changement de type");
            Console.WriteLine("0. Quitter");

            int choix;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choix) || choix < 0 || choix > 15)
            {
                Console.WriteLine("Choix invalide. Veuillez réessayer.");
                continue;
            }

            switch (choix)
            {
                case 1:
                    ExempleAffectation();
                    break;
                case 2:
                    ExempleAlternative();
                    break;
                case 3:
                    ExempleBoucle();
                    break;
                case 4:
                    ExempleTableau1D();
                    break;
                case 5:
                    ExempleTableau2D();
                    break;
                case 6:
                    ExempleStructurePublique();
                    break;
                case 7:
                    ExempleConcatenerChaines();
                    break;
                case 8:
                    ExempleAccumuler();
                    break;
                case 9:
                    ExempleTri();
                    break;
                case 10:
                    ExempleParcourirTableau1D();
                    break;
                case 11:
                    ExempleParcourirTableau2D();
                    break;
                case 12:
                    ExempleProceduresFonctions();
                    break;
                case 13:
                    ExempleRelancerProgramme();
                    break;
                case 14:
                    ExempleValidationEncodage();
                    break;
                case 15:
                    ExempleChangementType();
                    break;
                case 0:
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

            if (choix != 0)
            {
                Console.WriteLine("\nVoulez-vous voir un autre exemple? (o/n)");
                string reponse = Console.ReadLine();
                if (reponse.ToLower() != "o")
                {
                    continuer = false;
                }
            }
        }
    }

    static void ExempleAffectation()
    {
        Console.WriteLine("Exemple d'affectation:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int a = 10;");
        Console.WriteLine("double b = 20.5;");
        Console.WriteLine("string message = \"Bonjour\";");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleAlternative()
    {
        Console.WriteLine("Exemple d'alternative:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int age = 18;");
        Console.WriteLine("if (age >= 18)");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Vous êtes majeur.\");");
        Console.WriteLine("}");
        Console.WriteLine("else");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Vous êtes mineur.\");");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleBoucle()
    {
        Console.WriteLine("Exemple de boucle:");
        Console.WriteLine("```csharp");
        Console.WriteLine("for (int i = 0; i < 5; i++)");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"i vaut : \" + i);");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleTableau1D()
    {
        Console.WriteLine("Exemple de tableau à une dimension:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int[] tableau = new int[5] { 1, 2, 3, 4, 5 };");
        Console.WriteLine("Console.WriteLine(string.Join(\", \", tableau));");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleTableau2D()
    {
        Console.WriteLine("Exemple de tableau à deux dimensions:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int[,] tableau2D = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };");
        Console.WriteLine("for (int i = 0; i < tableau2D.GetLength(0); i++)");
        Console.WriteLine("{");
        Console.WriteLine("    for (int j = 0; j < tableau2D.GetLength(1); j++)");
        Console.WriteLine("    {");
        Console.WriteLine("        Console.Write(tableau2D[i, j] + \" \");");
        Console.WriteLine("    }");
        Console.WriteLine("    Console.WriteLine();");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleStructurePublique()
    {
        Console.WriteLine("Exemple de structure publique:");
        Console.WriteLine("```csharp");
        Console.WriteLine("public class Programme");
        Console.WriteLine("{");
        Console.WriteLine("    public void AfficherMessage(string message)");
        Console.WriteLine("    {");
        Console.WriteLine("        Console.WriteLine(message);");
        Console.WriteLine("    }");
        Console.WriteLine("}");
        Console.WriteLine("");
        Console.WriteLine("// Dans le programme principal");
        Console.WriteLine("Programme programme = new Programme();");
        Console.WriteLine("programme.AfficherMessage(\"Bonjour\");");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleConcatenerChaines()
    {
        Console.WriteLine("Exemple de concaténation de chaînes de caractères:");
        Console.WriteLine("```csharp");
        Console.WriteLine("string part1 = \"Bonjour\";");
        Console.WriteLine("string part2 = \"le monde\";");
        Console.WriteLine("string fullMessage = part1 + \" \" + part2;");
        Console.WriteLine("Console.WriteLine(fullMessage);");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleAccumuler()
    {
        Console.WriteLine("Exemple d'accumulation de valeurs:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int somme = 0;");
        Console.WriteLine("for (int i = 1; i <= 5; i++)");
        Console.WriteLine("{");
        Console.WriteLine("    somme += i;");
        Console.WriteLine("}");
        Console.WriteLine("Console.WriteLine(\"Somme: \" + somme);");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleTri()
    {
        Console.WriteLine("Exemple de méthode de tri:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int[] nombres = { 5, 3, 8, 1, 2 };");
        Console.WriteLine("Array.Sort(nombres);");
        Console.WriteLine("Console.WriteLine(string.Join(\", \", nombres));");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleParcourirTableau1D()
    {
        Console.WriteLine("Exemple de parcours d'un tableau à une dimension:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int[] tableau = { 1, 2, 3, 4, 5 };");
        Console.WriteLine("foreach (int valeur in tableau)");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(valeur);");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleParcourirTableau2D()
    {
        Console.WriteLine("Exemple de parcours d'un tableau à deux dimensions:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int[,] tableau2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };");
        Console.WriteLine("for (int i = 0; i < tableau2D.GetLength(0); i++)");
        Console.WriteLine("{");
        Console.WriteLine("    for (int j = 0; j < tableau2D.GetLength(1); j++)");
        Console.WriteLine("    {");
        Console.WriteLine("        Console.WriteLine(tableau2D[i, j]);");
        Console.WriteLine("    }");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleProceduresFonctions()
    {
        Console.WriteLine("Exemple de procédures et fonctions:");
        Console.WriteLine("```csharp");
        Console.WriteLine("public void AfficherMessage(string message)");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(message);");
        Console.WriteLine("}");
        Console.WriteLine("");
        Console.WriteLine("public int Additionner(int a, int b)");
        Console.WriteLine("{");
        Console.WriteLine("    return a + b;");
        Console.WriteLine("}");
        Console.WriteLine("");
        Console.WriteLine("// Utilisation");
        Console.WriteLine("AfficherMessage(\"Bonjour\");");
        Console.WriteLine("int resultat = Additionner(3, 4);");
        Console.WriteLine("Console.WriteLine(resultat);");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleRelancerProgramme()
    {
        Console.WriteLine("Exemple de programme relançable:");
        Console.WriteLine("```csharp");
        Console.WriteLine("bool continuer = true;");
        Console.WriteLine("while (continuer)");
        Console.WriteLine("{");
        Console.WriteLine("    // Logique du programme");
        Console.WriteLine("    Console.WriteLine(\"Exécuter le programme...\");");
        Console.WriteLine("    ");
        Console.WriteLine("    Console.WriteLine(\"Voulez-vous relancer le programme ? (o/n)\");");
        Console.WriteLine("    string reponse = Console.ReadLine();");
        Console.WriteLine("    if (reponse.ToLower() != \"o\")");
        Console.WriteLine("    {");
        Console.WriteLine("        continuer = false;");
        Console.WriteLine("    }");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleValidationEncodage()
    {
        Console.WriteLine("Exemple de validation d'encodage:");
        Console.WriteLine("```csharp");
        Console.WriteLine("Console.WriteLine(\"Entrez un nombre:\");");
        Console.WriteLine("string input = Console.ReadLine();");
        Console.WriteLine("if (int.TryParse(input, out int nombre))");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Vous avez entré: \" + nombre);");
        Console.WriteLine("}");
        Console.WriteLine("else");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Entrée invalide.\");");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }

    static void ExempleChangementType()
    {
        Console.WriteLine("Exemple de changement de type:");
        Console.WriteLine("```csharp");
        Console.WriteLine("int nombre = 42;");
        Console.WriteLine("string texte = nombre.ToString();");
        Console.WriteLine("// Conversion d'un entier en chaîne de caractères");
        Console.WriteLine("");
        Console.WriteLine("string texteNombre = \"123\";");
        Console.WriteLine("if (int.TryParse(texteNombre, out int nombreConverti))");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Conversion réussie: \" + nombreConverti);");
        Console.WriteLine("}");
        Console.WriteLine("else");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Conversion échouée.\");");
        Console.WriteLine("}");
        Console.WriteLine("```");
        Console.WriteLine("Voici un exemple.");
    }
}

class Programme
{
    public void AfficherMessage(string message)
    {
        Console.WriteLine(message);
    }
}
