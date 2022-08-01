Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int getDigit(int num)
{
    if (num == 0) return 1;
    int count = 0;
    for (int i = 0; num != 0; i++)
        {
            num = num/10;
            count+=1; 
        }
        return count;    
}
Console.WriteLine(getDigit(number));