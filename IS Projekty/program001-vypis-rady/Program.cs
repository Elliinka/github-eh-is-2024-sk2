class Program {

    static void Main(){

        string again = "a";                  // chci, aby se program opakoval po stisku klávesy "a"
        while(again == "a") {                // == je porovnávání, = je přiřazení hodnoty
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



            // opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }



    }






}