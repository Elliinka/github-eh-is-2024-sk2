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
            Console.WriteLine("*******************************");
            Console.WriteLine();            // prázdný řádek takto a nebo pomocí \n za poslední řádek nad tímto
            
            // vstup od uživatele - TO-DO
            // logika pro výpis řady - TO-DO
            // opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }



    }






}