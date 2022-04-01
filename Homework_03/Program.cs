using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int picturesTotal = 52;
        int picturesInRow = 3;
        int picturesRows = picturesTotal / picturesInRow;
        int picturesRemainder = picturesTotal % picturesInRow;
        Console.WriteLine($"Картинок в ряду: {picturesRows}. Остаток: {picturesRemainder}.");
    }
}