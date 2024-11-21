
        //program se začne opakovat po stisku klávesy "a"
        string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("************ Intervaly ************");
            Console.WriteLine("***********************************");
            Console.WriteLine("******* Eliška Holubová ***********");
            Console.WriteLine("***********************************n\n");
            Console.WriteLine();

         Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }
            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");
            // deklarace pole
            int[] myArray = new int[n];
            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();
            Console.WriteLine("Náhodná čísla: ");
            int interval_01=0;
            int interval_02=0;
            int interval_03=0;
            int interval_04=0;
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
                if(myArray[i] <= (0.25 * hm)) {
                    interval_01++;
                }
                else if(myArray[i] <= (0.5 * hm)) {
                    interval_02++;
                }
                else if(myArray[i] <= (0.75 * hm)) {
                    interval_03++;
                }
                else
                    interval_04++; 
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nInterval <{0};{1}>: {2}", dm, 0.25*hm, interval_01);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.25*hm+1, 0.5 * hm, interval_02);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.5*hm+1, 0.75 * hm, interval_03);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Interval <{0};{1}>: {2}", 0.75*hm+1, hm, interval_04);
            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }