using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string resultado1 = await PrepararPocao("Semente dos Deuses");
        Console.WriteLine("Recebi: " + resultado1);

        string resultado2 = await PrepararPocao("Pó de Fogo");
        Console.WriteLine("Recebi: " + resultado2);
    }

    static async Task<string> PrepararPocao(string ingrediente)
    {
        Console.WriteLine("Misturando " + ingrediente + "...");
        await Task.Delay(1500);

        if (ingrediente == "Semente dos Deuses")
        {
            return "Poção de Cura";
        }
        
        if (ingrediente == "Pó de Fogo")
        {
            return "Poção de Força";
        }

        return "Poção Falha";
    }
}