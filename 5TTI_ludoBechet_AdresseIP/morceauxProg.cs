using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_LoukaConstant_adresseIP
{
    public struct fctProcedure
    {
        public void LireAdresseIP(out int[] adresseIP)
        {
            int i;
            int octetAdresse = 4;
            adresseIP = new int[octetAdresse];
            for (i = 0; i <= octetAdresse - 1; i++)
            {
                LireOctet(out adresseIP[i]);
            }
        }

        public bool LireOctet(out int nUser) 
        {
            bool check = false;
            nUser = 0;
            while (!check)
            {
                Console.WriteLine("Veuillez entrer un nombre entre 0 et 255");
                if (int.TryParse(Console.ReadLine(), out nUser) && nUser >= 0 && nUser <= 255)
                {
                    check = true;
                }

                else
                {
                    Console.WriteLine("Votre nombre n'est pas compris entre 0 et 255 ! Veuillez recommencer !");
                }
            }

            return check;
        }

        public bool ajouteAdresseIP(ref int[,] matriceAdresse, ref int[] adresseIP, ref int place)
        {
            place = 0;
            bool addAdresseIP = true;
            int i;

            if (place <= 20)
            {
                for (i = 0; i <= 3; i++)
                {
                    matriceAdresse[place, i] = adresseIP[i];
                }
                place += 1;
            }

            else
            {
                addAdresseIP = false;
            }

            return addAdresseIP;
        }

        public bool ajouteNom(ref int place, ref string[] tableauNoms)
        {
            bool addNom = false;

            if (place != tableauNoms.Length)
            {
                tableauNoms[place] = lireString("Quelle est le nom que vous voulez entrer ?");
                addNom = true;
                place++;
            }
            return addNom;
        }


        public string ConcateneAdresse(int[,] tabAdresses, int ligne) //outil
        {
            string message = "";
            for (int i = 0; i <= 3; i++)
            {
                message += tabAdresses[ligne, i];

                if (i < 3)
                {
                    message += ".";
                }
            }
            return message;
        }
        public string ConcateneTout(int[,] tabAdresses, string[] tabNoms, int nbNoms)
        {
            string message = "";
            for (int i = 0; i < nbNoms; i++)
            {
                message += tabNoms[i] + " : " + ConcateneAdresse(tabAdresses, i);
                if (i != nbNoms)
                {
                    message += "\n";
                }
            }
            return message;
        }


        public string lireString(string question)
        {
            string rep;
            Console.WriteLine(question);
            rep = Console.ReadLine();
            while (rep == "")
            {
                Console.WriteLine("La réponse envoyée n'est pas bonnne, veuillez répéter la question !");
                Console.WriteLine(question);
                rep = Console.ReadLine();
            }
            return rep;
        }

    }
}
