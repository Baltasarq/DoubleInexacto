// DoubleInexacto (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es> 


namespace DoubleInexacto {
    public class Empleado {
        public enum Puesto { Currito, Jefazo }

        /// <summary>
        /// Crea un nuevo empleado.
        /// </summary>
        /// <param name="n">El nombre, como string.</param>
        /// <param name="p">El <see cref="Puesto"/> del empleado.</param>
        /// <param name="s">El sueldo, como double.</param>
        public Empleado(string n, Puesto p, double s)
        {
            this.Nombre = n;
            this.Escalafon = p;
            this.Sueldo = s;
        }

        public string Nombre { get; set; }
        public Puesto Escalafon { get; set; }
        
        /// <summary>El sueldo, como double.</summary>
        public double Sueldo { get; set; }

        /// <summary>
        /// El sueldo, con una propiedad que acepta doubles.
        /// </summary>
        public double Sueldo2 {
            get => sueldo / 100.0;
            set => this.sueldo = (int) ( value * 100 );
        }

        public override string ToString()
        {
            return $"{Nombre} ({Escalafon}): {Sueldo}";
        }

        int sueldo;
    }
}
