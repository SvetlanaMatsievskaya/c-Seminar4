Console.WriteLine("Введите число A: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int pow = int.Parse(Console.ReadLine());
int GetPow(int a, int b)
{
    int i = 0;
    int prod = 1;
    while ( i < pow)
{
        if (a ==0 && b == 0) return 1;
        prod = number*prod;
        i++;
    
}
return prod;

}

Console.WriteLine(GetPow(number, pow));
