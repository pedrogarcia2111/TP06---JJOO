using System.Data.SqlClient;
using Dapper;

namespace TP06.Models;

public class BD{

    private static string _connectionString = @"Server=localhost;DataBase=TP06;Trusted_Connection=True;";




    private static void AgregarDeportista(Deportista dep)
{

    string SQL = "INSERT INTO Deportistas(IdDeportista, Apellido, Nombre, FechaNacimiento, Foto, IdPais, IdDeporte) VALUES (@pIdDeportista, @pApellido, @pNombre, @pFechaNacimiento, @pFoto, @pIdPais, @pIdDeporte)";
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        db.Execute(SQL, new {pIdDeportista = dep.IdDeportista, pApellido = dep.Apellido, pNombre = dep.Nombre, pFechaNacimiento = dep.FechaNacimiento, pFoto = dep.Foto, pIdPais = dep.IdPais, pIdDeporte = dep.IdDeporte});
    }

}


public static int EliminarDeportista(int idDeportista){

    int RegistroEliminado = 0;

    string sql = "DELETE FROM Deportistas WHERE IdDeportista = @Id";
    using(SqlConnection db = new SqlConnection(_connectionString)){
        RegistroEliminado = db.Execute(sql, new {Id = idDeportista});    
    }
    return RegistroEliminado;

}

public static Deporte VerInfoDeporte(int idDeporte){
    
    Deporte MiDeporte = null;

    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "SELECT * FROM Deportes WHERE Id = @Id";
        MiDeporte = db.QueryFirstOrDefault<Deporte>(sql, new { Id = idDeporte });
    }
    return MiDeporte;
}


}

/*
public static VerInfoPais(int idPais){}
public static VerInfoDeportista(int idDeportista){}
public static ListarPaises(){}
public static ListarDeportistas(int idDeporte){}
public static ListarDeportistas(int idPais){}
*/