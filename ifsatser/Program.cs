/*
if (6 >= 3)
{
    Console.WriteLine("Hello World!");
    Console.ReadLine();
}

*/

/*

Console.Write("Write your name!");

String name = Console.ReadLine();
String namelow = name.ToLower();

Console.WriteLine("Please enter password!");
String password = Console.ReadLine();

if (namelow == "kalleanka" && password == "12345") {
    Console.WriteLine("Welcome!");
    Console.ReadLine();
}
else {
    Console.WriteLine("Wrong username or password!");
    Console.ReadLine();
}

*/

/*

int num = 1;
while (num <= 32) {
    Console.WriteLine("Hello World!");
    num++;
}

Console.ReadLine();

*/

/*

String password = "YesYes";

Console.WriteLine("Please enter password!");
String attempt = Console.ReadLine();

while (password != attempt) {
    Console.WriteLine("Wrong password! Try again!");
    attempt = Console.ReadLine();
}

*/

/*

for (int i = 0; i < 5; i++) {
    Console.Write("Skriv in ett tal: ");

    int.TryParse(Console.ReadLine(), out int tal);
            
    if (tal > 5) {
        Console.WriteLine("högre än 5!");
    }
}

*/

/*

while (true) {
    String input = Console.ReadLine();

    if (int.TryParse(input, out int result)) {
        break;
    }
}

*/

/*
var random = new Random();
int targetNumber = random.Next(1, 101);

int guess = 0;

Console.WriteLine("Välkommen till 'Gissa siffran'-spelet!");
Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Försök att gissa vilket!");

while (guess != targetNumber)
{
    Console.Write("Skriv in din gissning: ");

    // Försök konvertera användarens inmatning till ett heltal
    if (int.TryParse(Console.ReadLine(), out guess))
    {
        if (guess < targetNumber)
        {
            Console.WriteLine("För lågt! Försök igen.");
        }
        else if (guess > targetNumber)
        {
            Console.WriteLine("För högt! Försök igen.");
        }
        else
        {
            Console.WriteLine("Exakt rätt! Du gissade talet!");
        }
    }
    else
    {
        Console.WriteLine("Ogiltig inmatning, försök igen med ett heltal.");
    }
}

*/