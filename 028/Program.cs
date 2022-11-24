//28. Определить количество цифр в числе. Сделать подпрограмму.

int N=Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);
int count=0;
if (N==0) count=1;
while (N>0)
{
    N=N/10;
    count++;
}

System.Console.WriteLine(count);
