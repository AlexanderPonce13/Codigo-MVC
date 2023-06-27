class UsuarioModel
{
    // Variables para almacenar los datos del usuario
    private int id;
    private string nombre = "";
    private string email = "";

    // Propiedad pública Id para acceder al valor del id del usuario
    public int Id
    {
        get { return id; }  // Devuelve el valor del id
        set { id = value; }  // Establece el valor del id
    }

    // Propiedad pública Nombre para acceder al valor del nombre del usuario
    public string Nombre
    {
        get { return nombre; }  // Devuelve el valor del nombre
        set { nombre = value; }  // Establece el valor del nombre
    }

    // Propiedad pública Email para acceder al valor del email del usuario
    public string Email
    {
        get { return email; }  // Devuelve el valor del email
        set { email = value; }  // Establece el valor del email
    }
}
