Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int getDigitSum(int num)
{
    int Sum = 0;
    for (int i = 0; num > 0; i++)
        {
            int lastDigit = num%10;
            Sum+=lastDigit ; 
            num = num/10;
        }
    return Sum;    
}
Console.WriteLine(getDigitSum(number));