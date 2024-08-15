    public class Pais
{
    public int IdPais {get; set;}
    public string Nombre {get; set;}
    public string Bandera {get; set;}
    public DateTime FechaFundacion {get; set;}


    public Pais(int idpais, string nombre, string bandera, DateTime fechafundacion){
        IdPais=idpais;
        Nombre=nombre;
        Bandera=bandera;
        FechaFundacion=fechafundacion;
        
    }
    public Pais()
    {

    }

}