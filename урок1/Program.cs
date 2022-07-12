/*string [,] table = new string[2, 5];
table[1,2] = "слово";

for(int rows = 0; rows<2; rows++)//счетчик/строки
{
    for(int columns = 0; columns<5; columns++)//счетчик/столбцы
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}*/





//двумерный массив с числами


void PrintArray(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)//счетчик/строки//конструкция замена числа строк на этот элемент
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)//счетчик/столбцы//замена
        {
            Console.Write($"{matrix[rows, columns]} ");//пробежались по всем столбцам в строке
        }
    Console.WriteLine();//переход на новую строку
    }
}

void FillArray(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)//счетчик/строки//конструкция замена числа строк на этот элемент
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)//счетчик/столбцы//замена
        {
            matrix[rows, columns]= new Random().Next(1, 10);
        }
    }  
}     
int[,] matrix = new int[3,4];
PrintArray(matrix);//инициализируем- убедимся что у нас нули
FillArray(matrix);//в качестве аргумента передадим массив и снова распечатаем
Console.WriteLine();//пустая строка
PrintArray(matrix);//