namespace CeUAA11_23_24_LoukaConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre application de cryptage !");
            string chaineDepart = "";
            char x;
            string chaine = ""; // chaine à parcourir
            string[] mot;
            string motCle = "";
            char[,] matAlphabet;
            char lettre;
            string cle2 = "";
            string phrase;
            string repeatProg;
            byte[,] matriceCodes;
            mesMorceaux methode = new mesMorceaux();

            do
            {
                Console.WriteLine("Celle-ci utilise la méthode des 'Nihilistes'\n");
                Console.WriteLine("Vous devez d'abord encoder la phrase que vous voulez crypter en n'utilisant que des lettres non accentuées, pas de chiffres également !\n");
                Console.WriteLine("Quelle est votre phrase");
                phrase = Console.ReadLine();

                Console.WriteLine("Quel est votre premier mot clé ?");
                motCle = Console.ReadLine();

                Console.WriteLine("Quel est votre second mot clé ?");
                cle2 = Console.ReadLine();

                Console.WriteLine("matrice de code alphabétique :");

                methode.preparationChaine(chaineDepart);
                methode.RechercheCarDansChaine(x, chaine);
                methode.CreeAlphabetOrdonne(motCle);
                methode.CreeEtRemplitMatriceAlphabet(ref motCle, out matAlphabet);
                methode.code(lettre, matAlphabet);
                methode.CreeEtRemplitMatriceCodes(matAlphabet, cle2, phrase, out matriceCodes);
                methode.CreePhraseCodee(matriceCodes);





                Console.WriteLine("Voulez-vous recommencer ? 'o' pour oui, 'n' pour non.");
                repeatProg = Console.ReadLine();

            } while (repeatProg == "0");

            

        }
    }
} 