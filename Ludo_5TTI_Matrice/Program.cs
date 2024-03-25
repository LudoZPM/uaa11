using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;

namespace Ludo_5TTI_Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nUser; // condition pour l'utilisateur
            string repeatProg; // condition pour recommencer

            MethodeMatrices matrices = new MethodeMatrices();

            do // boucle recommencer
            {
                Console.WriteLine("Bienvenue dans le monde des matrices"); // menu pour matrice
                Console.WriteLine("Choisissez une opération:\n tapez 1 pour additionner \n tapez 2 pour les multiplier"); // choix de l'opération
                nUser = Console.ReadLine();

                int lignes; // nombre de lignes 
                int colonnes; // nombre de colonnes

                Console.ForegroundColor = ConsoleColor.Cyan; // pour mettre le text en cyan

                Console.WriteLine("Entrez le nombre de lignes pour les matrices : ");
                lignes = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de colonnes pour les matrices : ");
                colonnes = int.Parse(Console.ReadLine());

                int[,] Matrice1 = matrices.GenMatrice(lignes, colonnes);
                int[,] Matrice2 = matrices.GenMatrice(lignes, colonnes);

                if (nUser == "1") // choix numéros 1
                {

                    Console.ForegroundColor = ConsoleColor.Yellow; // pour mettre le text en jaune
                    Console.WriteLine("Vous avez choisi l'addition de 2 matrices");

                    matrices.AfficherMatrice(Matrice1); // affiche matrice 1
                    Console.WriteLine(" + ");
                    matrices.AfficherMatrice(Matrice2); // affiche matrice 2
                    Console.WriteLine(" = ");
                    matrices.AdditionnerMatrices(Matrice1, Matrice2); // affiche matrice additioner
                    Console.ResetColor(); // retire la couleur
                }
                else if (nUser == "2") // choix numéros 2
                {
                    Console.ForegroundColor = ConsoleColor.Green; // pour mettre le text en vert
                    Console.WriteLine("Vous avez choisi la multiplication de 2 matrices");
                    matrices.AfficherMatrice(Matrice1); // affiche matrice 1
                    Console.WriteLine(" * ");
                    matrices.AfficherMatrice(Matrice2); // affiche matrice 2
                    Console.WriteLine(" = ");
                    matrices.MultiplierMatrices(Matrice1, Matrice2); // affiche matrice multiplier
                    Console.ResetColor(); // retire la couleur
                }
                else // si un nombre autre que 1 et 2 est choisie 
                {
                    Console.ForegroundColor = ConsoleColor.Red; // pour mettre le text rouge
                    Console.WriteLine("Option invalide. Veuillez choisir une option valide.");
                    Console.ResetColor(); // retire la couleur
                }

                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non"); // condition redémarré
                repeatProg = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("bonne journée");
                Console.ResetColor(); // retire la couleur



            } while (repeatProg == "o"); // boucle while pour recommencer si=o
        }
    }
}


