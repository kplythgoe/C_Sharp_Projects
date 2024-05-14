// Creating an instance of the Random Class
Random random = new Random();

// Get a random number between 1 and 10 (including 1 and 10)
int randomNumber = random.Next(1, 11);

bool win = false;

while (!win)
{
    Console.Write("Guess the number: ");
    string inputString = Console.ReadLine();
    int num1 = 0;

    bool isNumber = int.TryParse(inputString, out num1);

    if (isNumber)
    {
        if (num1 == randomNumber)
        {
            Console.WriteLine("You guessed right");
            win = true;
        }
        else
        {
            Console.WriteLine("You guessed wrong, try again\n");
        }
    }
    else
    {
        Console.WriteLine("You must enter a number\n");
    }
}

Console.ReadLine();