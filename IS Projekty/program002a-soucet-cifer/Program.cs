        string again = "a";                  // chci, aby se program opakoval po stisku klávesy "a"
        while(again == "a") {                // == je porovnávání, = je přiřazení hodnoty
            Console.Clear(); 
            Console.WriteLine("********************************************");
            Console.WriteLine("********** Součet a součin cifer ***********");
            Console.WriteLine("********************************************");
            Console.WriteLine("***************Eliška Holubová**************");
            Console.WriteLine("******************************************\n");
            Console.WriteLine();            // prázdný řádek takto a nebo pomocí \n za poslední řádek nad tímto
            
      
            // logika pro výpis řady - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu celé číslo: ");
            }

            // Výpis vstupní hodnoty
            Console.WriteLine("===========================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("===========================\n\n");       //n jako 'new line'

            int suma = 0;   //součet
            int multi = 1;
            int numberBackup = number;  //původní číslo
            int digit;  //zbytek


            // pokud je číslo záporné, mínus odstraníme
            if(number < 0){
                number = - number;
            }


            while(number >= 10) {
                digit = number % 10;                //% je operátor modulo - určení zbytku po dělení nějakým číslem
                number = (number - digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * digit;
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            multi = multi * number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma); //0 a 1 specifikují pořadí proměnných (nejdříve numberBackup, poté jako 2. suma)
            Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}", numberBackup, multi); 






            // opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }
