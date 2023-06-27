class UsuarioView
{
    // Método para mostrar los detalles del usuario en la pantalla
    public void MostrarDetallesUsuario(UsuarioModel usuario)
    {
        // Imprimir encabezado
        Console.WriteLine("Detalles del usuario:");
        
        // Imprimir el ID del usuario
        Console.WriteLine("ID: " + usuario.Id);
        
        // Imprimir el nombre del usuario
        Console.WriteLine("Nombre: " + usuario.Nombre);
        
        // Imprimir el email del usuario
        Console.WriteLine("Email: " + usuario.Email);
    }
}
