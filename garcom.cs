using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("O garçom chegou!");
        await PedirHidromel();
    }

    static async Task PedirHidromel()
    {
        Console.WriteLine("Anotando pedido de Hidromel...");
        
        Task preparo = Task.Delay(2000);

        while (!preparo.IsCompleted)
        {
            Console.WriteLine("Limpando a mesa...");
            await Task.Delay(500);
        }

        await preparo;
        Console.WriteLine("Hidromel entregue!");
    }
}