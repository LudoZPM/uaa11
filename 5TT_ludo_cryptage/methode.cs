using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5TT_ludo_cryptage
{
    public struct methodeCrypTage
    {

        // Méthode pour retirer les espaces d'une chaîne de caractères
        public string RetireEspaces(string chaine)
        {
            string chaineSSEsp = "";
            for (int i = 0; i < chaine.Length; i++)
            {
                if (chaine[i] != ' ')
                {
                    chaineSSEsp += chaine[i];
                }
            }
            return chaineSSEsp;
        }

        // Méthode pour créer une matrice en fonction de la clé et du texte
        public void CreeMat(string cle, string texte, out char[,] matrice)
        {
            int d1 = (texte.Length / cle.Length) + 2;
            if (texte.Length % cle.Length != 0)
            {
                d1++;
            }
            int d2 = cle.Length;
            matrice = new char[d1, d2];
        }

        // Méthode pour écrire les chaînes de caractères dans la matrice
        public void EcritChainesDansMat(string cle, string texte, ref char[,] matrice)
        {
            // Remplit la première ligne de la matrice avec la clé
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                matrice[0, j] = cle[j];
            }

            // Remplit la matrice avec le texte à partir de la troisième ligne
            int k = 0;
            for (int i = 2; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1) && k < texte.Length; j++)
                {
                    matrice[i, j] = texte[k++];
                }
            }
        }

        // Méthode pour trier la première ligne de la matrice
        public void TriLigne1(ref char[,] matrice)
        {
            bool permut;
            do
            {
                permut = false;
                for (int i = 0; i < matrice.GetLength(1) - 1; i++)
                {
                    if (matrice[0, i] > matrice[0, i + 1])
                    {
                        char x = matrice[0, i];
                        matrice[0, i] = matrice[0, i + 1];
                        matrice[0, i + 1] = x;
                        permut = true;
                    }
                }
            } while (permut);
        }

        // Méthode pour créer une matrice outil utilisée pour le tri
        public void CreeMatriceOutil(string cle, out char[,] matriceTriee)
        {
            int j;
            matriceTriee = new char[3, cle.Length];
            for (j = 0; j < matriceTriee.GetLength(1); j++)
            {
                matriceTriee[0, j] = cle[j];
                matriceTriee[2, j] = '0';
            }

            TriLigne1(ref matriceTriee);

            for (j = 0; j < matriceTriee.GetLength(1); j++)
            {
                matriceTriee[1, j] = (char)(j + 1 + '0'); // Assigne '1', '2', '3', etc.
            }
        }

        // Méthode pour reporter l'ordre de tri dans la matrice principale
        public void ReporteOrdre(ref char[,] mat, ref char[,] matriceOutil)
        {
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                bool trouve = false;
                for (int j = 0; j < matriceOutil.GetLength(1) && !trouve; j++)
                {
                    if (mat[0, i] == matriceOutil[0, j] && matriceOutil[2, j] != '1')
                    {
                        mat[1, i] = matriceOutil[1, j];
                        matriceOutil[2, j] = '1';
                        trouve = true;
                    }
                }
            }
        }

        // Méthode pour construire le texte crypté final
        public string ConstruitCryptage(char[,] mat)
        {
            string chaineCrypt = "";
            for (int i = 1; i < mat.GetLength(1); i++)
            {
                bool trouve = false;
                for (int j = 0; j < mat.GetLength(1) && !trouve; j++)
                {
                    if (char.Parse(i.ToString()) == mat[1, j])
                    {
                        for (int k = 2; k < mat.GetLength(0); k++)
                        {
                            chaineCrypt += mat[k, j];
                        }
                        trouve = true;
                    }
                }
            }
            return chaineCrypt;
        }
    }
}



