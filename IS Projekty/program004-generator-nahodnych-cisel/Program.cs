class Program {

    static void Main() {
        
        string again = "a";                  // chci, aby se program opakoval po stisku klávesy "a"
        while(again == "a") {                // == je porovnávání, = je přiřazení hodnoty
            //Console.Clear(); 
            Console.WriteLine("*******************************");
            Console.WriteLine("**********Generátor************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******Eliška Holubová*********");
            Console.WriteLine("*******************************\n");
            Console.WriteLine();            
            
        
            //POČET GENEROVANÝCH ČÍSEL
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            //DOLNÍ MEZ GENEROVANÝCH ČÍSEL
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            //HORNÍ  MEZ GENEROVANÝCH ČÍSEL
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            //DEKLARACE POLE
            int[] myArray = new int[n];

            //PŘÍPRAVA PRO GENEROVÁNÍ NÁHODNÝCH ČÍSEL
            Random randomNumber = new Random();

            //SLEDUJEME, ZDA JSOU ČÍSLA KLADNÁ, ZÁPORNÁ NEBO NULY
            int kladna = 0;
            int zaporna = 0;
            int nuly = 0;


            Console.WriteLine("Náhodná čísla: ");
            for(int i=0; i<n; i++){
                 myArray[i] = randomNumber.Next(dm, hm+1);              //Metoda next generuje náhodná čísla, potřebuje k tomu ale dm a hm
                Console.Write("{0}; ", myArray[i]);
            


            if(myArray[i]>0)
                kladna++;
            else if(myArray[i]<0)
                zaporna++;
            else
                nuly++;
            }
            
            Console.WriteLine("\n\nPočet kladných čísel: {0}", kladna);
            Console.WriteLine("Počet záporných čísel: {0}", zaporna);
            Console.WriteLine("Počet nul: {0}", nuly);
           
            

            //OPAKOVÁNÍ PROGRAMU
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }

    }


}