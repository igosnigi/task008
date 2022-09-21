Console.Clear();

Console.WriteLine("введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int i = 2;

for (i = 2; i<= number;)
{
    Console.Write($"{i}, ");
    i=i+2;
}
