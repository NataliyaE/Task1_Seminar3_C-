Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int temp1 = 0;
int temp2 = 0;
int temp3 = 0;
int temp4 = 0;

if (number <10000 || number >=100000)
{
    Console.WriteLine("введено некорректное число");
}
else
{
    GetPolindrom(number);
    void GetPolindrom(int number)
    {
        temp1 = number / 10000;
        temp2 = number % 10;
        temp3 = (number/1000) % 10;
        temp4 = (number % 100) / 10;
        if (temp1 == temp2 && temp3 == temp4)
        {
            Console.WriteLine($"{number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"{number} не является палиндромом");
        }
    }

}
