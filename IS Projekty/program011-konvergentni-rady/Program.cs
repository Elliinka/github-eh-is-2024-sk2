class Program {

    static void Main() {
        
        //program se začne opakovat po stisku klávesy "a"
        string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("************ Generátor pseudonáhoných čísel ************");
            Console.WriteLine("********************************************************");
            Console.WriteLine("******************** Eliška Holubová *******************");
            Console.WriteLine("********************************************************n\n");
            Console.WriteLine();

            // Vstup od uživatele TO-DO - správná verze
            Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude.): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste reálné číslo. Zadejte znovu reálné číslo: ");
            }     

//CISLO PIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII

            double i = 1;
            double znamenko = 1;
            double piCtvrt = 1;

            while ((1/i)>=presnost){
                i = i + 2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1/i);

                if (znamenko==1) { 
                    Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota pi = {1}", i, piCtvrt*4);
                }
                else
                    Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota pi = {1}", i, piCtvrt*4);
                

                }


            Console.WriteLine("\n\nHodnota čísla PI = {0}", piCtvrt*4);


            Console.WriteLine("\nHodnota proměnné přesnost: {0}",presnost);
            Console.WriteLine("\n======================================");

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }

}