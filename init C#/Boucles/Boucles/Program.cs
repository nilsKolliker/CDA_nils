﻿using System;

namespace Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1
            //1 ça affiche 6, 15 (1+2+3+4+5)
            //int a = 1, b = 0, n = 5;
            //while (a <= n)
            //    b += a++;
            //Console.WriteLine(a + " , " + b);

            //2 ça affiche 3 (m), 4 (n), 18 (6*3), 6 (0+1+2+3)
            //int a = 0, b = 0, c = 0, d = 3, m = 3, n = 4;
            //for (a = 0; a < m; a++)//3tours
            //{
            //    d = 0;
            //    for (b = 0; b < n; b++)//4tours
            //        d += b;
            //    c += d;
            //}
            //Console.WriteLine(a + " , " + b + " , " + c + " , " + d + " . ");

            //3
            //int a, b, c, d;
            //a = 1; b = 2;
            //c = a / b;//c=0
            //d = (a == b) ? 3 : 4;//d=4
            //Console.WriteLine(c + " , " + d + " . ");
            //a = ++b;//a=b=3
            //b %= 3;//b=0
            //Console.WriteLine(a + " , " + b + " . ");
            //b = 1;
            //for (a = 0; a <= 10; a++)//11tours
            //    c = ++b;//c=b=12
            //Console.WriteLine(a + " , " + b + " , " + c + " , " + d + " . ");//11,12,12,4

            //4.2
            //4
            //int saisie;
            //Console.WriteLine("saisir un entier positif");
            //saisie = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            ////pour
            //for (int i = 0; i <= saisie; i++)
            //{
            //    Console.WriteLine(saisie - i);
            //}

            //Console.WriteLine();
            ////tant que
            //int j;
            //j = 0;
            //while (j<=saisie)
            //{
            //    Console.WriteLine(saisie - j);
            //    j++;
            //}
            //Console.WriteLine();
            ////jusqu'à
            //int k;
            //k = 0;
            //do
            //{
            //    Console.WriteLine(saisie - k);
            //    k++;
            //} while (k<=saisie);

            //5
            //int saisie;
            //int resultat;
            //Console.WriteLine("saisir un entier positif");
            //saisie = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //resultat = 1;
            ////pour
            //for (int i = 1; i <= saisie; i++)
            //{
            //    resultat *= i;
            //}
            //Console.WriteLine(resultat);

            //Console.WriteLine();
            ////tant que
            //int j;
            //j = 1;
            //resultat = 1;
            //while (j <= saisie)
            //{
            //    resultat *= j;
            //    j++;
            //}
            //Console.WriteLine(resultat);

            //Console.WriteLine();
            ////jusqu'à
            //int k;
            //k = 1;
            //resultat = 1;
            //do
            //{
            //    resultat *= k;
            //    k++;
            //} while (k <= saisie);
            //Console.WriteLine(resultat);

            //4.3
            //6
            //int saisie;
            //Console.WriteLine("saisir un entier positif");
            //saisie = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(saisie+" x "+i+" = "+saisie*i);
            //}

            //7
            //Console.Write("   ");
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i<10)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(i+" ");
            //}
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.Write("\n");
            //    if (i < 10)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(i+" ");
            //    for (int j = 0; j < 11; j++)
            //    {
            //        if (i * j < 10)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write((i*j) + " ");
            //    }
            //}

            //8
            //int b;
            //int n;
            //int resultat;
            //resultat=1;
            //Console.WriteLine("saisir un entier");
            //b=int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("saisir un entier positif");
            //    n= int.Parse(Console.ReadLine());
            //} while (n<0);
            //for (int i = 0; i < n; i++)
            //{
            //    resultat *= b;
            //}
            //Console.WriteLine(resultat);

            //9
            //int cote;
            //do
            //{
            //    Console.Write("saisir un entier positif : ");
            //    cote = int.Parse(Console.ReadLine());
            //} while (cote < 0);
            //for (int i = 0; i < cote; i++)
            //{
            //    for (int j = 0; j < cote; j++)
            //    {
            //        Console.Write("X");
            //    }
            //    Console.Write("\n");
            //}

            //10
            //double a, b;
            //string op;
            //bool erreur, calculeEnCour;
            //calculeEnCour = true;
            //do
            //{
            //    Console.WriteLine("1er nombre :");
            //    erreur = !double.TryParse(Console.ReadLine(), out a);
            //} while (erreur);
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("opérateur :");
            //        op = Console.ReadLine();
            //        switch (op)
            //        {
            //            case "=":
            //                calculeEnCour = false;
            //                erreur = false;
            //                break;
            //            case "+":
            //                do
            //                {
            //                    Console.WriteLine("nombre suivant:");//vivement les fonctions !
            //                    erreur = !double.TryParse(Console.ReadLine(), out b);
            //                } while (erreur);
            //                a = a + b;
            //                break;
            //            case "-":
            //                do
            //                {
            //                    Console.WriteLine("nombre suivant:");//vivement les fonctions !
            //                    erreur = !double.TryParse(Console.ReadLine(), out b);
            //                } while (erreur);
            //                a -= b;
            //                break;
            //            case "*":
            //                do
            //                {
            //                    Console.WriteLine("nombre suivant:");//vivement les fonctions !
            //                    erreur = !double.TryParse(Console.ReadLine(), out b);
            //                } while (erreur);
            //                a *= b;
            //                break;
            //            case "/":
            //                do
            //                {
            //                    Console.WriteLine("nombre suivant:");//vivement les fonctions !
            //                    erreur = !double.TryParse(Console.ReadLine(), out b);
            //                } while (erreur || b == 0);
            //                a /= b;
            //                break;
            //            case "$":
            //                do
            //                {
            //                    Console.WriteLine("nombre suivant:");//vivement les fonctions !
            //                    erreur = !double.TryParse(Console.ReadLine(), out b);
            //                } while (erreur || b < 0 || b != (int)b);
            //                double resultat;
            //                resultat = 1;
            //                for (int i = 0; i < b; i++)
            //                {
            //                    resultat *= a;
            //                }
            //                a = resultat;
            //                break;
            //            case "sqrt":
            //                a = Math.Sqrt(a);
            //                break;
            //            case "!":
            //                if (a == (int)a && a >= 0)
            //                {
            //                    int facto;
            //                    facto = 1;
            //                    for (int i = 1; i <= a; i++)
            //                    {
            //                        facto *= i;
            //                    }
            //                    a = facto;
            //                }
            //                else
            //                {
            //                    erreur = true;
            //                }
            //                break;
            //            default:
            //                erreur = true;
            //                break;
            //        }
            //    } while (erreur);
            //    Console.WriteLine("Le résultat est :\n" + a);
            //} while (calculeEnCour);

            //10 avec fonctions

            //static int dessineMoiUnEntierPositif()
            //{
            //    int entierPositif;
            //    bool cEstEntier;
            //    do
            //    {
            //        Console.WriteLine("saisir un entier positif:");
            //        cEstEntier = int.TryParse(Console.ReadLine(), out entierPositif);
            //    } while (!cEstEntier||entierPositif<=0);
            //    return entierPositif;
            //}
            //static double dessineMoiUnDouble()
            //{
            //    double nombreAVirgule;
            //    bool cEstAVirgule;
            //    do
            //    {
            //        Console.WriteLine("saisir un nombre:");
            //        cEstAVirgule = double.TryParse(Console.ReadLine(), out nombreAVirgule);
            //    } while (!cEstAVirgule);
            //    return nombreAVirgule;
            //}
            //static double dessineMoiUnDoubleNonNull()
            //{
            //    double nombreAVirgule;
            //    bool cEstAVirgule;
            //    do
            //    {
            //        Console.WriteLine("saisir un nombre:");
            //        cEstAVirgule = double.TryParse(Console.ReadLine(), out nombreAVirgule);
            //    } while (!cEstAVirgule|| nombreAVirgule == 0);
            //    return nombreAVirgule;
            //}
            //static string dessineMoiUnOperateur(double nombre)
            //{
            //    string operateur;
            //    bool ilExiste;
            //    do
            //    {
            //        Console.WriteLine("saisir un operateur:");
            //        operateur = Console.ReadLine();
            //        switch (operateur)
            //        {
            //            case "=":
            //            case "+":
            //            case "-":
            //            case "*":
            //            case "/":
            //            case "$":
            //                ilExiste = true;
            //                break;
            //            case "sqrt":
            //                ilExiste = nombre < 0 ? false : true;
            //                break;
            //            case "!":
            //                ilExiste = nombre == (int)nombre ? true : false;
            //                break;
            //            default:
            //                ilExiste = false;
            //                break;
            //        }
            //    } while (!ilExiste);
            //    return operateur;
            //}
            //static double calculUnaire(double valeur, string operateur)
            //{
            //    double resultat=1;//initialisé ici si pb ds swich
            //    switch (operateur)
            //    {
            //        case "!":
            //            for (int i = 1; i <= valeur; i++)
            //            {
            //                resultat *= i;
            //            }
            //            break;
            //        case "sqrt":
            //            resultat= Math.Sqrt(valeur);
            //            break;
            //    }
            //    return resultat;
            //}
            //static double calcul(double valeur1, double valeur2, string operateur)
            //{
            //    double resultat = 1;//initialisé ici si pb ds swich
            //    switch (operateur)
            //    {
            //        case "+":
            //            resultat = valeur1 + valeur2;
            //            break;
            //        case "-":
            //            resultat = valeur1 - valeur2;
            //            break;
            //        case "*":
            //            resultat = valeur1 * valeur2;
            //            break;
            //        case "/":
            //            resultat = valeur1 / valeur2;
            //            break;
            //        case "$":
            //            for (int i = 0; i < valeur2; i++)
            //            {
            //            resultat *= valeur1;
            //            }
            //            break;
            //    }
            //    return resultat;
            //}
            //bool calculeEnCour = true;
            //double a,b;
            //string operateur;
            //a=dessineMoiUnDouble();
            //do
            //{
            //    operateur = dessineMoiUnOperateur(a);
            //    if (operateur=="=")
            //    {
            //        calculeEnCour = false;
            //    }
            //    else
            //    {
            //        switch (operateur)
            //        {
            //            case "+":
            //            case "-":
            //            case "*":
            //                b = dessineMoiUnDouble();
            //                a = calcul(a, b, operateur);
            //                break;
            //            case "/":
            //                b = dessineMoiUnDoubleNonNull();
            //                a = calcul(a, b, operateur);
            //                break;
            //            case "$":
            //                b = dessineMoiUnEntierPositif();
            //                a= calcul(a, b, operateur);
            //                break;
            //            case "sqrt":
            //            case "!":
            //                a = calculUnaire(a, operateur);
            //                break;
            //        }
            //        Console.WriteLine(a);
            //    }
            //} while (calculeEnCour);

            //10 version corrigée

            static int demanderEntierPositif(string texte)
            {
                int valeur;
                bool conversionReussie;
                do
                {
                    Console.WriteLine(texte);
                    conversionReussie = int.TryParse(Console.ReadLine(), out valeur);

                } while (!conversionReussie || valeur < 0);
                return valeur;
            }

            static double demanderDouble(string texte)
            {
                double nb;
                bool ok;
                do
                {
                    Console.Write(texte);
                    ok = double.TryParse(Console.ReadLine(), out nb);
                } while (!ok);
                return nb;
            }

            static double demanderDoubleNonNull(string texte)
            {
                double n;
                bool conversionReussie;
                do
                {
                    Console.WriteLine(texte);
                    conversionReussie = double.TryParse(Console.ReadLine(), out n);
                } while (!conversionReussie || n != 0);
                return n;
            }

            static char demanderOperateur()
            {
                bool ok = true;
                char op;
                bool condition;

                do
                {
                    Console.Write("Entrez un opérateur +,-,*,/,$,!,V : ");
                    ok = char.TryParse(Console.ReadLine(), out op);
                    condition = !ok || (op != '+' && op != '-' && op != '*' && op != '/' && op != '$' && op != '!' && op != 'V' && op != 'v');
                    if (condition)
                        Console.WriteLine("Saisie incorrecte.");

                } while (condition);
                return char.ToUpper(op);
            }

            static double calculSimple(double valeur1, double valeur2, char operateur)
            {
                double resultat = 0;
                switch (operateur)
                {
                    case '+':
                        resultat = valeur1 + valeur2;
                        break;
                    case '-':
                        resultat = valeur1 - valeur2;
                        break;
                    case '*':
                        resultat = valeur1 * valeur2;
                        break;
                    case '/':
                        resultat = valeur1 / valeur2;
                        break;
                    case '$':
                        resultat = Math.Pow(valeur1, valeur2);
                        break;
                    default:
                        break;
                }
                return resultat;
            }

            static double calcul(double valeur, char operateur)
            {
                double result;
                result = 1;

                switch (operateur)
                {
                    case 'V':
                        result = Math.Sqrt(valeur);
                        break;

                    case '!':
                        result = Math.Round(valeur);
                        for (int i = 1; i <= valeur; i++)
                        {
                            result *= i;
                        }
                        break;
                    default:
                        break;
                }
                return result;
            }

            double value1, value2;
            char operateur;

            value1 = demanderDouble("saisir la 1ere valeur");
            do
            {
                operateur = demanderOperateur();
                switch (operateur)
                {
                    case '-':
                    case '+':
                    case '*':
                        value2 = demanderDouble("saisir la 2eme valeur");
                        value1 = calculSimple(value1, value2, operateur);
                        break;
                    case '/':
                        value2 = demanderDoubleNonNull("saisir la 2eme valeur");
                        value1 = calculSimple(value1, value2, operateur);
                        break;
                    case '$':
                        value2 = demanderEntierPositif("saisir la 2eme valeur");
                        value1 = calculSimple(value1, value2, operateur);
                        break;
                    case '!':
                        if (value1 % 1 == 0 && value1 > 0) // On vérifie que value1 est un Entier et qu'il est positif.
                        {
                            value1 = calcul(value1, operateur);
                        }
                        else
                        {
                            Console.WriteLine("Calcul impossible !");
                        }
                        break;
                    case 'V':
                        if (value1 > 0) // On vérifie que value1 est positif.
                        {
                            value1 = calcul(value1, operateur);
                        }
                        else
                        {
                            Console.WriteLine("Calcul impossible !");
                        }
                        break;
                    case '=':
                        break;
                    default:
                        Console.WriteLine("Opérateur incorrect.");
                        break;
                }

                Console.WriteLine("Résultat = " + value1);
                if (operateur == '=')
                {
                    Console.WriteLine("Merci d'avoir utiliser cette calculatrice made in AFPA.");
                }
            } while (operateur != '=');
        }
    }
}
