using System.Data.SqlClient;
using Dapper;

namespace TP06.Models;

public class BD
    {
        private static string _connectionString = "Server=localhost;Database=JJOO;Trusted_Connection=True;";

        public static void AgregarDeportista(Deportista dep)
        {
            string SQL = "INSERT INTO Deportistas(IdDeportista, Apellido, Nombre, FechaNacimiento, Foto, IdPais, IdDeporte) VALUES (@pIdDeportista, @pApellido, @pNombre, @pFechaNacimiento, @pFoto, @pIdPais, @pIdDeporte)";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new { pIdDeportista = dep.IdDeportista, pApellido = dep.Apellido, pNombre = dep.Nombre, pFechaNacimiento = dep.FechaNacimiento, pFoto = dep.Foto, pIdPais = dep.IdPais, pIdDeporte = dep.IdDeporte });
            }
        }

        public static int EliminarDeportista(int idDeportista)
        {
            int RegistroEliminado = 0;
            string sql = "DELETE FROM Deportistas WHERE IdDeportista = @Id";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                RegistroEliminado = db.Execute(sql, new { Id = idDeportista });
            }
            return RegistroEliminado;
        }

        public static Deporte VerInfoDeporte(int idDeporte)
        {
            Deporte MiDeporte = null;
            string sql = "SELECT * FROM Deportes WHERE IdDeporte = @Id";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                MiDeporte = db.QueryFirstOrDefault<Deporte>(sql, new { Id = idDeporte });
            }
            return MiDeporte;
        }

        public static Pais VerInfoPais(int idPais)
        {
            Pais MiPais = null;
            string sql = "SELECT * FROM Paises WHERE IdPais = @Id";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                MiPais = db.QueryFirstOrDefault<Pais>(sql, new { Id = idPais });
            }
            return MiPais;
        }

        public static Deportista VerInfoDeportista(int idDeportista)
        {
            Deportista MiDeportista = null;
            string sql = "SELECT * FROM Deportistas WHERE IdDeportista = @Id";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                MiDeportista = db.QueryFirstOrDefault<Deportista>(sql, new { Id = idDeportista });
            }
            return MiDeportista;
        }

        public static List<Pais> ListarPaises()
        {
            List<Pais> paises = new List<Pais>();
            string sql = "SELECT * FROM Paises";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                paises = db.Query<Pais>(sql).ToList();
            }
            return paises;
        }

        public static List<Deportista> ListarDeportistasxDeporte(int idDeporte)
        {
            List<Deportista> deportistas = new List<Deportista>();
            string sql = "SELECT * FROM Deportistas WHERE IdDeporte = @IdDeporte";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                deportistas = db.Query<Deportista>(sql, new { IdDeporte = idDeporte }).ToList();
            }
            return deportistas;
        }

        public static List<Deportista> ListarDeportistasxPais(int idPais)
        {
            List<Deportista> deportistas = new List<Deportista>();
            string sql = "SELECT * FROM Deportistas WHERE IdPais = @IdPais";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                deportistas = db.Query<Deportista>(sql, new { IdPais = idPais }).ToList();
            }
            return deportistas;
        }

        public static List<Deporte> ListarDeportes()
        {
            List<Deporte> deportes = new List<Deporte>();
            string sql = "SELECT * FROM Deportes";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                deportes = db.Query<Deporte>(sql).ToList();
            }
            return deportes;
        }
    }



