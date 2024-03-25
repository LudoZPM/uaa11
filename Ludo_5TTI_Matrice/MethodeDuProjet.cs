using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_5TTI_Matrice
{
    public struct MethodeMatrices
    {
        public int[,] GenMatrice(int lignes, int colonnes)
        {
            Random random = new Random();
            int[,] Matrice = new int[lignes, colonnes];

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    Matrice[i, j] = random.Next(1, 11);
                }
            }

            return Matrice;
        }

        public void AfficherMatrice(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void AdditionnerMatrices(int[,] Matrice1, int[,] Matrice2)
        {
            int lignes = Matrice1.GetLength(0);
            int colonnes = Matrice1.GetLength(1);

            int[,] resultat = new int[lignes, colonnes];
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    resultat[i, j] = Matrice1[i, j] + Matrice2[i, j];
                    Console.Write(resultat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void MultiplierMatrices(int[,] Matrice1, int[,] Matrice2)
        {
            int lignes1 = Matrice1.GetLength(0);
            int colonnes1 = Matrice1.GetLength(1);
            int lignes2 = Matrice2.GetLength(0);
            int colonnes2 = Matrice2.GetLength(1);

            if (colonnes1 != lignes2)
            {
                Console.WriteLine("Impossible de multiplier les matrices");
                return;
            }

            int[,] resultat = new int[lignes1, colonnes2];
            for (int i = 0; i < lignes1; i++)
            {
                for (int j = 0; j < colonnes2; j++)
                {
                    for (int k = 0; k < colonnes1; k++)
                    {
                        resultat[i, j] += Matrice1[i, k] * Matrice2[k, j];
                    }
                    Console.Write(resultat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}


