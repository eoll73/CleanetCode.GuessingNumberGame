using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Добро пожаловать в игру 'Угадай число'");
Console.WriteLine("Как вас зовут ?");
string? userName = Console.ReadLine();
Console.WriteLine(
    $"Привет {userName}. " +
    $"Я загадал число от 0 до 999. " +
    $" Попробуй отгадать");

Random rnd = new Random();
int secretNumber = rnd.Next(0, 999);
bool isWin = false;
int amountOfAttempts = 0;

while (!isWin)
{
    int userNumber = -1;
    bool isIntNumber = false;

    do
    {
        Console.WriteLine("Введи число от 0 до 99");
        string? userInput = Console.ReadLine();
        isIntNumber = int.TryParse(userInput, out userNumber);

        amountOfAttempts++;

        if (!isIntNumber)
        {
            Console.WriteLine($"Вы ввели {userInput}. Нужно ввести число от 0 до 99");
        }
    } while (!isIntNumber);

    if (userNumber > secretNumber)
    {
        Console.WriteLine($"Ваше число ({userNumber}) больше, чем загаданное число");
    }
    
    else if (userNumber < secretNumber)
    {
        Console.WriteLine($"Ваше число ({userNumber}) меньше, чем загаданное число");  
    }
    
    else
    {
        isWin = true;
        Console.WriteLine($"Вы победили !! Количество попыток {amountOfAttempts}");
    }
}

