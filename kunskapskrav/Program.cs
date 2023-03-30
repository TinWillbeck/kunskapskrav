bool running = true;

while (running == true)
{
    Console.WriteLine("Skriv ett tal");
    Console.WriteLine("Talet kommer adderas med fem");
    string numTxt = Console.ReadLine();
    float   numFloat;
    bool attempt = float.TryParse(numTxt, out numFloat);

    if (attempt == true){
        Console.WriteLine("Bra jobbat, du skrev ett tal!");
        Console.WriteLine($"Du skrev talet {numFloat}");
        float addition = numFloat + 5;
        Console.WriteLine($"{numFloat}+5={addition}");
        Console.WriteLine("Klicka enter för att avsluta");
        Console.ReadLine();
        running = false;
    }
    else{
        Console.WriteLine("Det där var inte ett tal, försök igen!");
    }
}