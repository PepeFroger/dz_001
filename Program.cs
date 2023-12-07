using System;
Random rnd = new Random();
int N = 5;
int M = 5;
int[,] mas = new int[N,M];
for (int i=0; i<N;i++){
    for(int j=0;j<M;j++){
        mas[i,j] = rnd.Next(-100,100);
        Console.Write($"{mas[i,j]}\t");
    }
    Console.WriteLine();
}
Console.Write("Введите номер столбика: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n Значение элемента: {mas[num_1-1,num_2-1]}");

