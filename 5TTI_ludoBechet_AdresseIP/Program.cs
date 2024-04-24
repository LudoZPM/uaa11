using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;


using System;
using _5T24_LoukaConstant_adresseIP;
namespace _5TTI_ludoBechet_AdresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--noms et d'adresses IP--");
            int[] adresseIP;
            string[] tableauNoms = new string[20];
            int[,] MatriceAdresses = new int[20, 4];
            int addNoms = 0;
            int places = 0;
            bool fini = false;
            string nUser;
            string message;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {

                if (!morceauxProg.ajouteNom(ref addNoms, ref tableauNoms))
                {
                    Console.WriteLine("donnée remplie !");
                    fini = true;
                }

                else
                {
                    Console.WriteLine("Encodez l'adresseIP :");
                    morceauxProg.LireAdresseIP(out adresseIP);
                    morceauxProg.ajouteAdresseIP(ref MatriceAdresses, ref adresseIP, ref places);
                }

                Console.WriteLine("\n Voulez - vous ajouter une autre adresse ? 'o' = oui, 'n' = non");
                nUser = Console.ReadLine();




            } while (!fini && nUser == "o");



            Console.WriteLine("Voici les adresses et les noms :");
            Console.WriteLine(morceauxProg.ConcateneTout(MatriceAdresses, tableauNoms, addNoms));

        }
    }

}





