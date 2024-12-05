        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Eliška Holubová ****************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

        /* n, dm, hm */
            
            Console.Write("\nZadejte počet generovaných čísel (celé kladné číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu n: ");
            
            Console.Write("\nZadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm))
                Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu dolní mez: ");

            Console.Write("\nZadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm))
                Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu horní mez: ");    
                            
            Console.WriteLine("\n==============");
            Console.WriteLine("Počet čísel: {0}",n);
            Console.WriteLine("Dolní mez: {0}",dm);
            Console.WriteLine("Horní mez: {0}",hm);
            Console.WriteLine("==============\n");
            
            //deklarace pole
            int[] pole = new int[n];

            //příprava pro generování náhodných čísel
            Random nahodneCislo = new Random();

            Console.WriteLine("\nNáhodná čísla: ");

            for(int i=0; i<n; i++)
            {
                pole[i] = nahodneCislo.Next(dm, hm+1);
                Console.Write("{0}; ",pole[i]);
            }

            Console.WriteLine("\n\n\nPro opakování programu stiskněte klávesu a");
            again=Console.ReadLine(); 
        }