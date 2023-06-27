internal class Program
{
    public static void Main(string[] args)
    {
        // Crear el modelo
        UsuarioModel usuario = new UsuarioModel();
        usuario.Id = 1;
        usuario.Nombre = "John Doe";
        usuario.Email = "johndoe@example.com";

        // Crear la vista
        UsuarioView vista = new UsuarioView();

        // Crear el controlador
        UsuarioController controlador = new UsuarioController(usuario, vista);

        // Mostrar los detalles del usuario
        controlador.MostrarDetallesUsuario();

        // Actualizar los detalles del usuario
        controlador.ActualizarDetallesUsuario(2,"Jane Smith", "janesmith@example.com");

        // Mostrar los detalles actualizados del usuario
        controlador.MostrarDetallesUsuario();
    }
}
