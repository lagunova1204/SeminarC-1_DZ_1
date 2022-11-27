Console.WriteLine("Введите 2 числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine(" Max "+ numberA);
    Console.WriteLine(" Min "+ numberB);
}
else
{
    Console.WriteLine(" Max "+numberB);
    Console.WriteLine(" Min "+numberA); 
}
