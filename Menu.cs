class Menu {

public static void Start() {

//test 
    Console.WriteLine("Welcome to my RPG GAME \n");
    Console.ReadLine();

    Console.WriteLine("Options:\n 1. Create New Character\n 2. Info\n");  
    string StartOption = Console.ReadLine();

    if(StartOption.ToUpper() is "1" or "one" or "first" ) {

        CharacterCreation();

    }

    if(StartOption.ToUpper() is "2" or "two" or "second") {

        Console.WriteLine("info");

    }

} 

public static void CharacterCreation() {

    Console.WriteLine("How would you like your character to be called? : "); // Add random names
    string name = Console.ReadLine();

}
}