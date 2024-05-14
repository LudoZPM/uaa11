using System.Numerics;

namespace _5T24_LudoBechet_adresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AdresseIP!");
            int[] adresseIP;
            Adresse[] totalAdressesIP = new Adresse[20]; 

            for (int i = 0; i < 20; i++)
            {
                totalAdressesIP[i] = new Adresse();
            }

            int places = 0; 
            string nom = "";
            bool fini = false;
            string nUser;
            string message;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {
                do
                {
                    Console.WriteLine("Entrez un nom :");
                    nom = Console.ReadLine();

                    Console.WriteLine("Entrez l'adresse IP :");
                    morceauxProg.LireAdresseIP(out adresseIP);
                    morceauxProg.ajouteAdresseIP(ref totalAdressesIP, ref adresseIP, ref places, nom);

                    Console.WriteLine("\nVoulez-vous encoder une autre adresse ? 'o' = oui, 'n' = non");
                    nUser = Console.ReadLine();

                } while (places < 20 && nUser.ToLower() == "o");

                
               

            } while (!fini && nUser == "o");

         
            
                Console.WriteLine("Voici les adresses encodées :");
                Console.WriteLine(morceauxProg.ConcateneTout(totalAdressesIP,places));
            
        }
    }
}
