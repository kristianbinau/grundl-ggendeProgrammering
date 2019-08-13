using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string firstName;
            string lastName;
            int age;

            string gender;
            char charGender = ' ';

            int oldAge;
            int ageToOld;

            //User-input
            Console.Write("Hvad er dit Fornavn: ");
            firstName = Console.ReadLine();

            Console.Write("Hvad er dit efternavn: ");
            lastName = Console.ReadLine();

            Console.Write("Hvad er din alder: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Hvad er dit køn: ");
            gender = Console.ReadLine();


            //Correcting formatting
            switch(gender)
                {
                case "mand":
                    charGender = 'm';
                    gender = "Mand";
                    break;
                case "Mand":
                    charGender = 'm';
                    break;
                case "Kvinde":
                    charGender = 'k';
                    break;
                case "kvinde":
                    charGender = 'k';
                    gender = "Kvinde";
                    break;
                case "m":
                    gender = "Mand";
                    charGender = 'm';
                    break;
                case "M":
                    gender = "Mand";
                    charGender = 'm';
                    break;
                case "k":
                    gender = "Kvinde";
                    charGender = 'k';
                    break;
                case "K":
                    gender = "Kvinde";
                    charGender = 'k';
                    break;
            }

            //Debug
            /*
                        Console.WriteLine("Debug:");
                        Console.WriteLine(firstName);
                        Console.WriteLine(lastName);
                        Console.WriteLine(age);
                        Console.WriteLine(gender);
                        Console.WriteLine(charGender);
            */

            //User-input
            Console.Write("Hvor gammel mener du man skal være for man er gammel? ");
            oldAge = int.Parse(Console.ReadLine());

            if (oldAge > age)
            {
                ageToOld = oldAge - age;
                Console.WriteLine("Der går " + ageToOld + " år til at du bliver gammel. ");
            }
            else if (oldAge <= age)
            {
                Console.WriteLine("Du ER en gammel " + gender + "!");
            }
        }
    }
}
/*
Lav et konsol program, der indsamler data om en bruger.
• Vi ønsker at kende flg. om en bruger
– Fornavn
– Efternavn
– Alder
– Køn (Skal angives med et m=mand, k=kvinde)
• Programmet skal spørge efter de relevante informationer og gemme dem i variabler med
den korrekte datatype til den ønskede værdi.
• Køn skal vælges med datatypen char (karakter) k = kvinde, m = mand.
• Programmet skal spørge brugeren, hvor gammel brugeren mener man skal være, før man
er gammel (eks. 60 år).
• Hvis brugeren er yngre end den angivne ”gammel-alder”, skal programmet fortælle, hvor
mange år der er tilbage før han/hun bliver en gammel mand/kvinde og i hvilket år han/hun
bliver gammel. Hvis brugeren er ældre eller har den samme alder som ”gammel-alder”, skal
programmet fortælle brugeren, at han/hun ER en gammel mand/kvinde. 
*/
