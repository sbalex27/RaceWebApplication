namespace RaceWebApplication
{
    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public class Participante
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaHoraInscripcion { get; set; }
    }
}
