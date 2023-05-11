// Bool som håller igång programmet
bool running = true;

// Själva programmet
while (running == true)
{
    // Ger intruktioner, provat konvertera input till float
    Console.WriteLine("Skriv ett tal med siffror");
    Console.WriteLine("Talet kommer adderas med fem");
    string numTxt = Console.ReadLine();
    float numFloat;
    bool attempt = float.TryParse(numTxt, out numFloat);

    // Om konverteringen fungerade, skriv ut talet samt talet + 5
    if (attempt == true){
        Console.WriteLine("Bra jobbat, du skrev ett tal!");
        Console.WriteLine($"Du skrev talet {numFloat}");
        float addition = numFloat + 5;
        Console.WriteLine($"{numFloat}+5={addition}");
        Console.WriteLine("Klicka enter för att avsluta");
        Console.ReadLine();
        running = false;
    }
    // Om konverteringen inte fungerade, be spelaren skriva in ett tal
    else{
        Console.WriteLine("Det där var inte ett tal, försök igen!");
    }
}