/*int Factorial (int n)//в 
{
    if(n==1) return 1;//   1! = 1(возвращает единицу), 0! = 1
    else return n * Factorial(n - 1);

}

Console.WriteLine(Factorial(5));//1*2*3 = 6*/




/*int Factorial (int n)//в 
{
    if(n==1) return 1;//   1! = 1(возвращает единицу), 0! = 1
    else return n * Factorial(n - 1);

}
for (int i = 1; i < 40; i++)
{
//Console.WriteLine(Factorial(i));    // i меняется от 1 до 39
Console.WriteLine($"{i}! = {Factorial(i)}");

}
*/





double Factorial (int n)//в 
{
    if(n==1) return 1;//   1! = 1(возвращает единицу), 0! = 1
    else return n * Factorial(n - 1);

}
for (int i = 1; i < 40; i++)
{
//Console.WriteLine(Factorial(i));    // i меняется от 1 до 39
Console.WriteLine($"{i}! = {Factorial(i)}");

}