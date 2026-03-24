using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Random r = new Random();

        Task bau1 = Task.Delay(r.Next(1000, 5000));
        Task bau2 = Task.Delay(r.Next(1000, 5000));
        Task bau3 = Task.Delay(r.Next(1000, 5000));

        Console.WriteLine("Aventureiros começaram a abrir os baús...");

        await Task.WhenAll(bau1, bau2, bau3);

        Console.WriteLine("Saque finalizado! Todos os baús abertos.");
    }
}