using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await TentarConjurar();
    }

    static async Task TentarConjurar()
    {
        try
        {
            Console.WriteLine("Iniciando ritual...");
            await Task.Delay(1000);

            Random dado = new Random();
            int chance = dado.Next(1, 11);

            if (chance <= 3)
            {
                throw new Exception("A magia explodiu na sua mão!");
            }

            Console.WriteLine("Magia de Gelo lançada!");
        }
        catch (Exception erro)
        {
            Console.WriteLine("Ocorreu um erro: " + erro.Message);
        }
    }
}