using System;
using System.IO;
using ArraySort.Lib;

namespace ArraySort.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayUtils test = new ArrayUtils();
            test.MaxSort();
            test.WriteToConsole();
            test.WriteToFile(@"..\..\test.txt");
            
            
            //"random" ist der Generator für die Zufallszahlen
            Random random = new Random();
            //"MAX_NUMBER" speichert die maximale Zahl, die wir generieren wollen
            const int MAX_NUMBER = 999;
            //in "numberInArray" merken wir uns eine Zahl des Arrays, nach der wir später suchen
            int numberInArray = -1;
            //in "numberNotInArray" speichern wir eine Zahl, die nicht im Array vorhanden ist
            int numberNotInArray = -1;
            //in "path" schreiben wir den Dateinamen für unsere Ausgaben
            string path = @"..\..\numbers.txt";
            //wir beschränken den Programmablauf auf die Funktionen, die wir in Aufgabenstellung 4 implementiert haben
            const bool MORE = false;
            
            // wenn bereits eine Datei "path" existiert, löschen wir diese.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // nun fragen wir den Bediener nach der Anzahl der Zahlen
            Console.Write("Bitte geben Sie die Anzahl der zu sortierenden Zahlen ein: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            //wir legen das Array an
            ArrayUtils numbersArray = new ArrayUtils();

            //und befüllen es
            numbersArray.Fill(MAX_NUMBER);

            //wir speichern nur "kleine" Arrays in der Datei ab
            if (arraySize <= 20)
            {
                numbersArray.WriteToFile(path);
            }

            //nun suchen wir eine Zahl, die im Array vorhanden ist und eine, die nicht im Array vorhanden ist
            while ((numberInArray == -1) || (numberNotInArray == -1))
            {
                int number = random.Next(MAX_NUMBER) + 1;
                if (!numbersArray.SearchInUnsorted(number).NumberFound)
                {
                    numberNotInArray = number;
                }
                else
                {
                    numberInArray = number;
                }
            }

            //wir wenden das Sortierverfahren MinimumSort an
            if (!numbersArray.Sorted)
            {
                numbersArray.MaxSort();
                //wir speichern nun das sortierte Array in der Datei ab
                if (arraySize <= 20)
                {
                    numbersArray.WriteToFile(path);
                }

            }

            //nun suchen wir im sortierten Array und vergleichen lineare und binäre Suche
            if (numbersArray.Sorted)
            {
                Console.WriteLine("Lineares Suchen:");
                SearchResult searchInfo = numbersArray.SearchLinear(numberInArray);
                Console.WriteLine(searchInfo.GetInfo());
                searchInfo = numbersArray.SearchLinear(numberNotInArray);
                Console.WriteLine(searchInfo.GetInfo());
                searchInfo = numbersArray.SearchLinear(MAX_NUMBER + 1);
                Console.WriteLine(searchInfo.GetInfo());

                Console.WriteLine("Binäres Suchen:");
                searchInfo = numbersArray.SearchBinary(numberInArray);
                Console.WriteLine(searchInfo.GetInfo());
                searchInfo = numbersArray.SearchBinary(numberNotInArray);
                Console.WriteLine(searchInfo.GetInfo());
                searchInfo = numbersArray.SearchBinary(MAX_NUMBER + 1);
                Console.WriteLine(searchInfo.GetInfo());
            }

            #region zukünftige Aufgabenstellung
            if (MORE)
            {
                if (numbersArray.BogoSort())
                {
                    Console.WriteLine("BogoSort successfull");
                }
                else
                {
                    Console.WriteLine("BogoSort unsuccessfull - Now doing bubble sort");
                    numbersArray.BubbleSort();
                }
                numbersArray.WriteToConsole();
            }
            #endregion

            Console.WriteLine("\nPROGRAMMENDE - Bitte beliebige Taste drücken!");

            Console.ReadKey();
        }
    }
}
