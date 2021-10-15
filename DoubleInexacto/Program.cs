// DoubleInexacto (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es> 


namespace DoubleInexacto {
    using System;
    
    
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new Empleado( 
                    "Baltasar", 
                    Empleado.Puesto.Jefazo,
                    6500.50 ) );
        }
    }
}
