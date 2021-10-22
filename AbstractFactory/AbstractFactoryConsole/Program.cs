using System;
using System.Collections.Generic;

namespace AbstractFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Ferrari XT", Porte.Pequeno),
                VeiculoCreator.Criar("Monza Classic", Porte.Medio),
                VeiculoCreator.Criar("BMW CT7", Porte.Grande)
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());

        }
    }
}
