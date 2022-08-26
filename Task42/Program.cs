// программу, которая преобразовывает десятичное число в двоичное

// Console.WriteLine("Введите число: ");
// long a = long.Parse(Console.ReadLine()!);
// long Convert (long num)
// {long result = 0;
// long i =1;
// while (num>0)
// {
// result+=num%2*i;
// num/=2;
// i*=10;
// }
// return result;
// }
// long rez = Convert(a);
// Console.WriteLine(rez);
// ----------------------------------Рекурсия------------------
int num =13;
void DecToBin (int num)
{

    if (num==0) return;
    DecToBin(num/2);
    Console.Write(num % 2);
}
DecToBin (num);

