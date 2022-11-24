//31. Сгенерировать 10 случайных чисел. Показать кубы чисел, которые заканчиваются на четную цифру

Random random=new Random(10);
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=a;
    if (b%2==0)
    System.Console.WriteLine($"{a}, {b}");
}
    
