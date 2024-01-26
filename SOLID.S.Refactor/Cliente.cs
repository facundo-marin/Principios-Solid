namespace SOLID.S.Refactor
{
    public class Cliente
    {
        public Cliente(string apellido, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}
