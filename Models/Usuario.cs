public class Usuario
{

    public int Documento { get; set; }
    public string NombreUsuario { get; set; }
    public string ApellidoUsuario { get; set; }
    public byte EdadUsuario { get; set; }
    public bool Activo { get; set; }

    public Usuario()
    {
        Activo = true;
    }

    public Usuario(int documento, string nombreUsuario, string apellidoUsuario, byte edadUsuario)
    {
        Documento = documento;
        NombreUsuario = nombreUsuario;
        ApellidoUsuario = apellidoUsuario;
        EdadUsuario = edadUsuario;
        Activo = true;
    }

    public string ResumenCorto()
    {
        return $@"
        === Resumen Corto ===
        Nombre del usuario: {NombreUsuario} 
        Apellido del usuario: {ApellidoUsuario}
        ";
    }

    public string DetalleCompleto()
    {

        string EstadoUsuario = Activo ? "Sí" : "No";

        return $@"
        === Detalles Completos ===
        Nombre del usuario: {NombreUsuario} 
        Apellido del usuario: {ApellidoUsuario}
        Edad: {EdadUsuario}
        Estado Activo: {EstadoUsuario}
        ";
    }

    public override string ToString()
    {
        return ResumenCorto();
    }

}