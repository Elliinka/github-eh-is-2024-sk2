using System;

class Program {

    static void Main(){

        string again = "a";       // chci, aby se program opakoval po stisku klávesy "a"
        while(again == "a") {       // == je porovnávání, = je přiřazení hodnoty
            Console.Clear(); 
            Console.WriteLine("*******************************");
            Console.WriteLine("**********Výpis řady***********");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******Eliška Holubová*********");
            Console.WriteLine("*******************************\n");
            Console.WriteLine();            // prázdný řádek takto a nebo pomocí \n za poslední řádek nad tímto
            
            // vstup od uživatele - špatná varianta
            // Console.Write("Zadejte první číslo řady: ");
            // int first = int.Parse(Console.ReadLine());


            // logika pro výpis řady - lepší varianta
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

              Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celé číslo): ");
            }

              Console.Write("Zadejte třetí číslo řady (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diferenci (celé číslo): ");
            }


            // výpis uživatelského vstupu
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference {0}", step);
            Console.WriteLine();
            Console.WriteLine();




            // logika pro výpis řady - TO-DO

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }



    }






}