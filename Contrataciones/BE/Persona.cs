namespace BE
{
    public class Persona
    {
		public int NumeroPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public Nacionalidad Nacionalidad { get; set; }
        public Profesion Profesion { get; set; }
    }
}
