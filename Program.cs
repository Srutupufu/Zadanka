using System.Numerics;

namespace Zadania_GPT
{
    internal class Program
    {
        /*Zadanie 2: Stwórz program, który oblicza pole prostokąta. 
         * Użytkownik powinien wprowadzić 
         * długości boków, a program wyświetli wynik.*/
        static void Main(string[] args)
        {
            //int firstSide;
            //int secondSide;
            //Console.WriteLine("Obliczymy teraz pole prostokonta");
            //Console.WriteLine("Podaj Pierwszy Bok");
            //firstSide = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj drugi bok");
            //secondSide = int.Parse(Console.ReadLine());
            //int areaofarectangle = firstSide * secondSide;
            //Console.WriteLine($"Pole prostokonta to:{areaofarectangle}");

            /*
             Zadanie 2: Stwórz program, który oblicza pole koła. 
            Użytkownik podaje promień, a program oblicza pole, 
            używając wzoru π * r * r. Możesz skorzystać z Math.PI.*/
            //Console.WriteLine("Obliczamy pole koła");

            //Console.WriteLine("Podaj promień swojego koła:");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int radius);

            //if (isParsed && radius > 0)
            //{
            //    double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            //    Console.WriteLine($"Pole twojego koła to: {areaOfCircle:F2}");  // Zaokrąglenie do 2 miejsc po przecinku
            //}
            //else
            //{
            //    Console.WriteLine("Wprowadzono nieprawidłową wartość. Proszę podać liczbę całkowitą większą od zera.");
            //}

            //Zadanie 2: Napisz program, który wyświetla liczby od 1 do 10 przy użyciu pętli while.

            //int number = 1;
            //while (number <= 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            /*Zadanie 3: Stwórz program, który pyta o hasło i daje użytkownikowi trzy próby. Jeśli hasło będzie poprawne 
             * (np. "tajnehaslo"), wyświetla komunikat o sukcesie; w przeciwnym razie po 
             * trzech próbach wyświetla komunikat o blokadzie. */

            //string password = "secret";
            //Console.WriteLine("Podaj hasło, masz 3 próby");

            //string userPassword;
            //int userTry = 0;
            //bool isAuthenticated = false;

            //do
            //{
            //    Console.Write("Wpisz hasło: ");
            //    userPassword = Console.ReadLine();
            //    userTry++;

            //    if (userPassword == password)
            //    {
            //        Console.WriteLine("Hasło poprawne, dostęp przyznany.");
            //        isAuthenticated = true;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Hasło niepoprawne. Próba {userTry} z 3.");
            //    }

            //} while (userTry < 3);

            //if (!isAuthenticated)
            //{
            //    Console.WriteLine("Przekroczono limit prób. Dostęp zablokowany.");
            //}

            /*Zadanie 2: Utwórz tablicę imion, a następnie wypisz wszystkie imiona na ekranie w osobnych liniach.*/

            //string[] firstNames = { "Adam", "Marta", "Szymon", "Damian", "Norbert", "Zosia" };

            //foreach (string name in firstNames)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] liczby = { 16, 2, 3, 4, 5 };
            //int suma = 0;
            //foreach (int liczba in liczby)
            //{
            //    suma += liczba;
            //}
            //Console.WriteLine("Suma liczb to: " + suma);

            /*Zadanie 2: Poproś użytkownika o podanie pięciu imion, zapisz je w tablicy, 
             a potem wypisz wszystkie imiona w jednej linii, oddzielone przecinkami.*/

            //Console.WriteLine("Podaj pięć imion:");
            //string[] names = new string[5];

            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Oto twoje imiona:");
            //Console.WriteLine(string.Join(", ", names));  // Użycie string.Join, aby połączyć imiona z przecinkiem

            /*Zadanie 3: Utwórz tablicę 7 liczb całkowitych, a następnie znajdź największą liczbę w tej tablicy, korzystając z foreach.*/

            //Console.WriteLine("Podaj 7 liczb");
            //int[] ints = new int[7];
            //int j = 0;
            //do
            //{
            //    bool isParsed = int.TryParse(Console.ReadLine(), out ints[j]);
            //    if (isParsed)
            //    {
            //        Console.WriteLine($"wprowadzono liczbę {ints[j]}");
            //        j++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Podaj liczbę całkowitą");
            //    }

            //}while (j < ints.Length);

            //int biggestInt = ints[0];

            //foreach (int i in ints)
            //{
            //    if (i > biggestInt)
            //    {
            //        biggestInt = i;
            //    }
            //}

            //Console.WriteLine($"Twoja największa liczba to {biggestInt}");

            //int biggestIntLINQ = ints.Max();

            //Console.WriteLine($"Największa liczba znaleziona metodą LINQ: {biggestIntLINQ}");

            /*Zadanie 2: Stwórz program, który używa List<T> do zbierania danych. Program powinien:
            Pozwolić użytkownikowi na dodawanie liczb.
            Wyświetlać wszystkie liczby po zakończeniu dodawania.*/

            List<int> userNumbers = new List<int>();
            Console.WriteLine("Podaj pierwszą liczbę do zbioru liczb które zostaną dodane");
            bool userWantsToStop = false;
            do
            {
                bool isUserNumberParsed = int.TryParse(Console.ReadLine(), out int userNumber);
                if (isUserNumberParsed)
                {
                    Console.WriteLine($"Dodano liczbę {userNumber} do zbioru liczb");
                    userNumbers.Add(userNumber);
                    if (userNumbers.Count < 2)
                    { 
                        Console.WriteLine("Podaj jeszcze przynajmniej jedną liczbę");
                    }
                    else
                    {
                        Console.WriteLine("Czy chcesz dodać więcej Liczb? Y/N");
                        bool userSaidYOrN = false;
                        do
                        {
                            string? userWantsToAddMoreNumbers = Console.ReadLine()?.ToUpper();

                            if (userWantsToAddMoreNumbers == "Y" || userWantsToAddMoreNumbers == "N")
                            {
                                if (userWantsToAddMoreNumbers == "Y")
                                {
                                    Console.WriteLine("W takim razie podaj kolejną liczbę:");
                                    userSaidYOrN = true;
                                }
                                else if (userWantsToAddMoreNumbers == "N")
                                {
                                    Console.WriteLine("Teraz twoje liczby zostaną dodane");
                                    userSaidYOrN = true;
                                    userWantsToStop = true;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Podaj proszę swoją opcje Tak - Y, Nie - N");
                            }
                        } while (!userSaidYOrN);

                    }
                }
                else
                {
                    Console.WriteLine("Podaj prawidłową liczbę całkowitą");
                }
            } while (userWantsToStop == false);

            int sumOfNumbersInList = 0;

            foreach (int number in userNumbers)
            {
                sumOfNumbersInList += number;
            }

            Console.WriteLine($"Suma twoich liczb to: {sumOfNumbersInList} ");
        }
    }
}
