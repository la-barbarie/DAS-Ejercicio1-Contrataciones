namespace BE
{
    public class Persona
    {
		private int numeroPersona;

		public int NumeroPersona
		{
			get { return numeroPersona; }
			set { numeroPersona = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
        
		private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private  Nacionalidad nacionalidad;

        public Nacionalidad Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        private Profesion profesion;

        public Profesion Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
    }
}
