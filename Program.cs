using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Factory */
            var bloqueFactory = new GameboyBloqueFactory();
            var monedaFactory = new NintendoDSMonedaFactory();

            // Se pueden crear objetos de diferentes tipos, no se controla que sean dependientes, es decir, no se tienen en cuenta las familias
            var bloque1 = bloqueFactory.CreateItem();
            var moneda1 = monedaFactory.CreateItem();

            /* Abstract Factory */
            Fabrica fabrica = new Fabrica(new GameboyFactory());

            // Podemos cambiar toda la familia de objetos, siemplemente cambiando nuestra inyección de factory
            fabrica = new Fabrica(new NintendoDSFactory());
            
            // Los dos objetos son de la misma familia y no se conoce su clase concreta, se trabaja mucho el polimorfismo
            IMoneda moneda = fabrica.CrearMoneda();
            IBloqueInterrogante bloque = fabrica.CrearBloqueInterrogante();
        }
    }

    public class Fabrica
    {
        private readonly IAbstractFactory _factory;
        public Fabrica(IAbstractFactory factory)
        {
            _factory = factory;
        }

        public IMoneda CrearMoneda()
        {
            return _factory.CrearMoneda();
        }

        public IBloqueInterrogante CrearBloqueInterrogante()
        {
            return _factory.CrearBloqueInterrogante();
        }
    }
}
