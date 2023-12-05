using sistemasApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasApp.Repositories
{
    internal class ProveedorRepository: BaseRepository, IProveedorRepository
    {
        //Constructor
        public ProveedorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Add(ProveedorModel proveedorModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into proveedor values (@name, @lastName, @email, @phone, @address, @lat, @lon)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = proveedorModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = proveedorModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = proveedorModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = proveedorModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = proveedorModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = proveedorModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = proveedorModel.Longitud;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from proveedor where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProveedorModel proveedorModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update proveedor set Nombre = @name, Apellido= @lastName, Email= @email,Telefono =  @phone, Direccion= @address, Latitud=@lat, Longitud=@lon where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = proveedorModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = proveedorModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = proveedorModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = proveedorModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = proveedorModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = proveedorModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = proveedorModel.Longitud;
                command.Parameters.Add("@id", SqlDbType.Int).Value = proveedorModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProveedorModel> GetAll()
        {
            var proveedoresList = new List<ProveedorModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Proveedor order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var proveedorModel = new ProveedorModel();
                        proveedorModel.Id = (int)reader[0];
                        proveedorModel.Nombre = reader[1].ToString();
                        proveedorModel.Apellido = reader[2].ToString();
                        proveedorModel.Email = reader[3].ToString();
                        proveedorModel.Telefono = reader[4].ToString();
                        proveedorModel.Direccion = reader[5].ToString();
                        proveedorModel.Latitud = reader[6].ToString();
                        proveedorModel.Longitud = reader[7].ToString();
                        proveedoresList.Add(proveedorModel);
                    }
                }
            }
            return proveedoresList;
        }

        public IEnumerable<ProveedorModel> GetByValue(string value)
        {
            var proveedoresList = new List<ProveedorModel>();
            int proveedorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string proveedorName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from proveedor where Id = @id or Nombre like @name+'%' order by Id desc ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = proveedorId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = proveedorName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var proveedorModel = new ProveedorModel();
                        proveedorModel.Id = (int)reader[0];
                        proveedorModel.Nombre = reader[1].ToString();
                        proveedorModel.Apellido = reader[2].ToString();
                        proveedorModel.Email = reader[3].ToString();
                        proveedorModel.Telefono = reader[4].ToString();
                        proveedorModel.Direccion = reader[5].ToString();
                        proveedorModel.Latitud = reader[6].ToString();
                        proveedorModel.Longitud = reader[7].ToString();
                        proveedoresList.Add(proveedorModel);
                    }
                }
            }
            return proveedoresList;
        }
    }
}
