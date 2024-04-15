using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;


using System;
namespace _5TTI_ludoBechet_AdresseIP
{
    using System;

    class Program
    {
        const int MaxAddresses = 20;//nombre max d'adresse
        const int OctetsPerAddress = 4;//nombre max d'octet

        static bool LireOctet(out int octet)//boolein lireOctet
        {
            bool isValid = false;
            octet = 0;

            while (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Green;//mettre de la couleur
                Console.Write("Entrez un nombre entre 0 et 255 : ");//phrase 
                Console.ResetColor();//reset la couleur
                if (int.TryParse(Console.ReadLine(), out octet) && octet >= 0 && octet <= 255)//verifie les nombre entrées
                {
                    isValid = true;
                }
                else//si invalide 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nombre invalide. Veuillez réessayer.");//si invalide
                    Console.ResetColor();
                }
            }

            return isValid;
        }

        static void LireAdresseIP(int[] adresse)//fonction qui lis l'adresse encodé
        {
            for (int i = 0; i < OctetsPerAddress; i++)
            {
                LireOctet(out adresse[i]);
            }
        }

        static bool AjouteAdresseIP(int[][] matrix, int[] adresse, ref int adresseCount)//fonction qui ajoute des adresse ip
        {
            if (adresseCount < MaxAddresses)
            {
                for (int i = 0; i < OctetsPerAddress; i++)
                {
                    matrix[adresseCount][i] = adresse[i];
                }
                adresseCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool AjouteNom(string[] noms, ref int nomCount)//fonction pour ajouter un nom
        {
            if (nomCount < MaxAddresses)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//pour la couleur
                Console.Write("Entrez le nom : ");
                noms[nomCount] = Console.ReadLine();
                nomCount++;
                return true;
                Console.ResetColor();
            }
            else
            {
                return false;
            }
        }

        static string ConcateneAdresse(int[] adresse)//fonction qui concatene une adresse
        {
            return $"{adresse[0]}.{adresse[1]}.{adresse[2]}.{adresse[3]}";
        }

        static string ConcateneTout(int[][] matrix, string[] noms, int adresseCount)//fonction qui concatene tout
        {
            string result = "";
            for (int i = 0; i < adresseCount; i++)
            {
                result += $"{noms[i]} : {ConcateneAdresse(matrix[i])}\n";
            }
            return result;
        }

        static void Main(string[] args)
        {
            
            int[][] addresses = new int[MaxAddresses][];// Définition d'un tableau pour stocker les adresses IP sous forme d'octets
            for (int i = 0; i < MaxAddresses; i++)
            {
                addresses[i] = new int[OctetsPerAddress];
            }

            
            string[] names = new string[MaxAddresses];// Définition d'un tableau pour stocker les noms associés aux adresses IP
            int addressCount = 0; // Compteur pour le nombre d'adresses IP ajoutées
            int nameCount = 0; // Compteur pour le nombre de noms ajoutés

            
            string stopKeyword = "stop";// Mot-clé pour arrêter la saisie des adresses IP
            string input = "";

           
            while (input != stopKeyword && addressCount < MaxAddresses) // Boucle de saisie des adresses IP
            {
                Console.WriteLine($"Adresse {addressCount + 1} :");
                int[] tempAddress = new int[OctetsPerAddress];
                LireAdresseIP(tempAddress); // Fonction pour lire une adresse IP depuis la console

                
                if (AjouteAdresseIP(addresses, tempAddress, ref addressCount))// Ajoute l'adresse IP et vérifie si elle a été ajoutée avec succès
                {
                    
                    if (AjouteNom(names, ref nameCount))// Si l'adresse IP a été ajoutée avec succès, demande et ajoute le nom associé
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Adresse ajoutée avec succès.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Le nombre maximal d'adresses a été atteint.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Le nombre maximal d'adresses a été atteint.");
                    Console.ResetColor();
                }

                
                Console.Write("Entrez 'stop' pour arrêter ou appuyez sur Entrée pour continuer : ");// Demande à l'utilisateur s'il veut continuer à ajouter des adresses IP
                input = Console.ReadLine();
            }

            
            Console.WriteLine("\nListe des adresses IP :");// Affiche la liste des adresses IP et leurs noms associés
            Console.WriteLine(ConcateneTout(addresses, names, addressCount)); // Fonction pour concaténer les adresses IP et les noms
        }

    }

}
