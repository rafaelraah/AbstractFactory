using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole
{
    //Fabrica de fábricas
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();

        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);

    }
}
