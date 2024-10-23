        string again = "a";                  // chci, aby se program opakoval po stisku klávesy "a"
        while(again == "a") {                // == je porovnávání, = je přiřazení hodnoty
            //Console.Clear(); 
            Console.WriteLine("*********************************");
            Console.WriteLine("********* Trojúhelník ***********");
            Console.WriteLine("*********************************");
            Console.WriteLine("******* Eliška Holubová *********");
            Console.WriteLine("*******************************\n\n");
            Console.WriteLine();            // prázdný řádek takto a nebo pomocí \n za poslední řádek nad tímto
            
        
            // Console.Write("Zadejte šířku obrazce (celé číslo): ");
            // int sirka;
            // while(!int.TryParse(Console.ReadLine(), out sirka)) {
            //     Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo): ");
            // }
            

            // výška
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int vyska;
            while(!int.TryParse(Console.ReadLine(), out vyska)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
            }


            // for(int i = 1; i<=10; i++) { //i++ je jako i = i + 1
            //     Console.WriteLine(i);
            // }  

            // int j = 1;
            // while(j <= 10) {
            //     Console.WriteLine(j);
            //     j++;
            // }


            Console.WriteLine();
            for(int i=1; i<=vyska; i++) {
                for(int j=1; j<= i; j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            // opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }

     