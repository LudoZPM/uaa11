namespace _5TT_ludo_cryptage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeatProg;
            string texte;
            char[,] matrice;
            char[,] matriceOutil;
            methodeCrypTage cryptage = new methodeCrypTage();

            do
            {
                // Demande à l'utilisateur d'entrer une clé (maximum 9 caractères)
                Console.WriteLine("Appli de cryptage, entrez votre mot (max 9 caractères) :");
                string cle = Console.ReadLine();

                // Vérifie que la clé n'excède pas 9 caractères
                while (cle.Length >= 10)
                {
                    Console.WriteLine("Veuillez entrer une clé en dessous de 9 caractères :");
                    cle = Console.ReadLine();
                }

                // Demande à l'utilisateur d'entrer le texte à crypter
                Console.WriteLine("Veuillez entrer ce que vous voulez crypter :");
                texte = Console.ReadLine();

                // Retire les espaces du texte
                texte = cryptage.RetireEspaces(texte);

                // Crée la matrice pour le cryptage
                cryptage.CreeMat(cle, texte, out matrice);
                cryptage.EcritChainesDansMat(cle, texte, ref matrice);
                cryptage.CreeMatriceOutil(cle, out matriceOutil);
                cryptage.ReporteOrdre(ref matrice, ref matriceOutil);

                // Construit le texte crypté final
                string final = cryptage.ConstruitCryptage(matrice);
                Console.WriteLine("\n" + final);

                // Demande à l'utilisateur s'il souhaite recommencer
                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();
            } while (repeatProg == "o");
        }
    }
}