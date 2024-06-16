using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA11_23_24_LoukaConstant
{
    public struct mesMorceaux
    {
       public string preparationChaine(string chaineDepart) //Fonction PreparationChaine qui crée une nouvelle chaîne de caractères à partir d’une chaîne donnée en retirant les espaces que celle-ci contient et remplace les W par des V.
        {
            string chainePropre;
            chainePropre = "";

            for (int i = 0; i < chaineDepart.Length - 1;i++)
            {
                if (chaineDepart[i] == 'W')
                {
                    chainePropre += 'V';
                }

                else if (chaineDepart[i] != ' ')
                {
                    chainePropre+= chaineDepart[i];
                }
            }
            return chainePropre;

        }

        public bool RechercheCarDansChaine(char x,string chaine) //Fonction booléenne RechercheCarDansChaine qui vérifie si une lettre est présente dans une chaîne.
        {
            bool trouve = false;
            int i = 0;

            while (i < chaine.Length && !trouve)
            {
                if (chaine[i] == x)
                {
                    trouve = true;
                    i += 1;
                }
            }

            return trouve;
        }

        public string CreeMotSSDoublon(string mot) // Fonction CreeMotSSDoublon qui fabrique et renvoie une chaîne de caractères reprenant toutes les lettres d'un mot sans doublon : par exemple, la procédure reçoit la chaîne “DIFFICILE” et renvoie la chaîne “DIFCLE. Celle-ci doit utiliser la fonction numéro 2.
        {
            bool trouve = false;
            string motSimpl = mot[0];  //??????
            int placeDAnsMotSimpl;

            for (int i = 0; i < mot.Length - 1; i++)
            {
                placeDAnsMotSimpl = 0;
                trouve = false;

                while (placeDAnsMotSimpl < motSimpl.Length && !trouve)
                {
                    if (mot[i] == motSimpl[placeDAnsMotSimpl])
                    {
                        trouve = true;
                        placeDAnsMotSimpl += 1;
                    }
                }

                if (!trouve)
                {
                    motSimpl += mot[i];
                }
            }

            return motSimpl;

        }

        public string CreeAlphabetOrdonne(string motCle) //Fonction CreeAlphabetOrdonne, reçoit la première clé, fabrique et renvoie une chaîne de caractères commençant par le mot épuré obtenu par appel de  la fonction 3 et le complète par toutes les lettres de l’alphabet non encore utilisées en ignorant W.
        {
            char[] alphabet = new char[25];
            string alphabetOrdonne;
            int i;

            alphabetOrdonne = motCle;
            alphabetOrdonne = CreeMotSSDoublon(motCle);

            for (i = 0; i < alphabet.Length; i++)
            {
                if (!RechercheCarDansChaine(alphabet[i], motCle))
                {
                    alphabetOrdonne += alphabet[i];
                }
            }
            return alphabetOrdonne;
        }

        public void CreeEtRemplitMatriceAlphabet(ref string motCle, out char[,] matAlphabet) //Procédure CreeEtRemplitMatriceAlphabet qui construit la première matrice en utilisant les fonctions 3 et 4.
        {
            int k;
            string alphabet;
            int lignes;
            int colonnes;

            k = 0;
            matAlphabet = new char[5,5];
            alphabet = CreeAlphabetOrdonne(motCle);

            for (lignes = 0; lignes < 4; lignes++)
            {
                for (colonnes = 0; colonnes < 4; colonnes++)
                {
                    matAlphabet[lignes, colonnes] = alphabet[k];
                    k += 1;
                }
            }


        }

        public byte code(char lettre, char[,] matAlphabet)
        {
            int lignes;
            int colonne;
            string codeLettre;
            bool trouve;
            byte codeFinal;

            lignes = 0;
            colonne = 0;
            trouve = false;
            codeLettre = "";

            while (lignes <= 4 && !trouve)
            {
                colonne = 0;

                while (colonne <= 4 && !trouve)
                {
                    if (matAlphabet[lignes, colonne] == lettre)
                    {
                        trouve = true;
                        colonne += 1;
                    }
                }
                lignes += 1;
            }

            codeLettre = lignes.ToString() + colonne.ToString();
            codeFinal = byte.Parse(codeLettre);
            return codeFinal;
        }

        public void CreeEtRemplitMatriceCodes(char[,] matAlphabet, string cle2, string phrase, out byte[,] matCodes)
        {
            int k;
            int codeTemp;
            int colonne;

            k = 0;
            matCodes = new byte[3, phrase.Length];

            for (colonne = 0; colonne <= phrase.Length - 1; colonne++)
            {
                matCodes[0, colonne] = code(phrase[colonne], matAlphabet);
                matCodes[1, colonne] = code(cle2[k], matAlphabet);

                if (k < cle2.Length)
                {
                    k += 1;
                }

                else
                {
                    k = 0;
                }

                codeTemp = matCodes[0, colonne] + matCodes[1, colonne];

                if (codeTemp >= 100)
                {
                    codeTemp = codeTemp - 100;
                }
                matCodes[2, colonne] = (byte)codeTemp;
            }
        }

        public string CreePhraseCodee(byte[,] matriceCode)
        {
            int comptebloc = 0;
            string chaineCodee = "";
            int i;

            for (i = 0; i < matriceCode.GetLength(1); i++)
            {
                chaineCodee += matriceCode[2, i];

                if (matriceCode[2, i] < 10)
                {
                    chaineCodee += "0" + matriceCode[2, i].ToString();
                }

                else
                {
                    chaineCodee += matriceCode[2, i].ToString();
                }

                comptebloc += 1;

                if (comptebloc == 3)
                {
                    chaineCodee += ' ';
                    comptebloc = 0;
                }
            }

            return chaineCodee;
        }
    }
}
