﻿class Program {

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
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
            }

            //HORNÍ  MEZ GENEROVANÝCH ČÍSEL
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
            }

            Console.WriteLine("\n\n======================================");
            Console.WriteLine("Uživatelský vstup");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("\n\n======================================\n\n");

            // opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }

    }


}