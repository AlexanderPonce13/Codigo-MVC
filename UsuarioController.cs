class UsuarioController
{
    private UsuarioModel usuario;
    private UsuarioView vista;

    // Constructor que recibe una instancia del modelo y de la vista
    public UsuarioController(UsuarioModel usuario, UsuarioView vista)
    {
        this.usuario = usuario;  // Asigna la instancia del modelo a la variable de clase 'usuario'
        this.vista = vista;  // Asigna la instancia de la vista a la variable de clase 'vista'
    }

    // Método para actualizar los detalles del usuario con nuevos valores
    public void ActualizarDetallesUsuario(int id, string nombre, string email)
    {
        usuario.Id = id;  // Actualiza el ID del usuario con el valor proporcionado
        usuario.Nombre = nombre;  // Actualiza el nombre del usuario con el valor proporcionado
        usuario.Email = email;  // Actualiza el email del usuario con el valor proporcionado
    }

    // Método para mostrar los detalles del usuario
    public void MostrarDetallesUsuario()
    {
        vista.MostrarDetallesUsuario(usuario);  // Llama al método 'MostrarDetallesUsuario' de la vista, pasando la instancia del modelo
    }
}

