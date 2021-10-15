// DoubleInexacto (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es> 


namespace TestEmpleado {
    using DoubleInexacto;
    
    using NUnit.Framework;

    
    public class TestSueldo
    {
        [SetUp]
        public void Setup()
        {
            this.empleado = new Empleado( "Baltasar", Empleado.Puesto.Jefazo, 6500.50 );
        }

        [Test]
        public void TestIncremento()
        {
            const double Incremento = 100.01;
            
            this.empleado.Sueldo += Incremento;
            this.empleado.Sueldo += Incremento;
            this.empleado.Sueldo += Incremento;

            Assert.AreEqual( 6800.53, this.empleado.Sueldo );
        }
        
        [Test]
        public void TestIncremento2()
        {
            const double Incremento = 100.01;

            this.empleado.Sueldo2 = 6500.50;
            this.empleado.Sueldo2 += Incremento;
            this.empleado.Sueldo2 += Incremento;
            this.empleado.Sueldo2 += Incremento;

            Assert.AreEqual( 6800.53, this.empleado.Sueldo2 );
        }

        Empleado empleado;
    }
}
