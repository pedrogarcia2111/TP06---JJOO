public class Deportista
{
    public int IdDeportista {get; set;}
    public string Apellido {get; set;}
    public string Nombre {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Foto {get; set;}
    public int IdPais{get; set;}
    public int IdDeporte{get; set;}


    public Deportista(int iddeportista, string apellido, string nombre, DateTime fechanacimiento, string foto, int idpais, int iddeporte){
        IdDeportista=iddeportista;
        Apellido=apellido;
        Nombre=nombre;
        FechaNacimiento=fechanacimiento;
        Foto=foto;
        IdPais=idpais;
        IdDeporte=iddeporte;
        
    }
    public Deportista()
    {

    }

}