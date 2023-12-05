using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using sistemasApp.Models;

namespace sistemasApp.Repositories
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        //Constructor
        public ClienteRepository(string connectionString) {
        this.connectionString = connectionString;
        }

        //Methods
        public void Add(ClienteModel clienteModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into cliente values (@name, @lastName, @email, @phone, @address, @lat, @lon)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = clienteModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = clienteModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = clienteModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = clienteModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = clienteModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = clienteModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = clienteModel.Longitud;
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
                command.CommandText = "delete from Cliente where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ClienteModel clienteModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update cliente set Nombre = @name, Apellido= @lastName, Email= @email,Telefono =  @phone, Direccion= @address, Latitud=@lat, Longitud=@lon where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = clienteModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = clienteModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = clienteModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = clienteModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = clienteModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = clienteModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = clienteModel.Longitud;
                command.Parameters.Add("@id", SqlDbType.Int).Value = clienteModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            var clientesList = new List<ClienteModel>();
            using (var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Cliente order by Id desc";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id = (int)reader[0];
                        clienteModel.Nombre = reader[1].ToString();
                        clienteModel.Apellido = reader[2].ToString();
                        clienteModel.Email = reader[3].ToString();
                        clienteModel.Telefono = reader[4].ToString();
                        clienteModel.Direccion = reader[5].ToString();
                        clienteModel.Latitud = reader[6].ToString();
                        clienteModel.Longitud = reader[7].ToString();
                        clientesList.Add(clienteModel);
                    }
                }
            }
            return clientesList;
        }

        public IEnumerable<ClienteModel> GetByValue(string value)
        {
            var clientesList = new List<ClienteModel>();
            int clienteId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string clienteName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Cliente where Id = @id or Nombre like @name+'%' order by Id desc ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = clienteId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = clienteName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id = (int)reader[0];
                        clienteModel.Nombre = reader[1].ToString();
                        clienteModel.Apellido = reader[2].ToString();
                        clienteModel.Email = reader[3].ToString();
                        clienteModel.Telefono = reader[4].ToString();
                        clienteModel.Direccion = reader[5].ToString();
                        clienteModel.Latitud = reader[6].ToString();
                        clienteModel.Longitud = reader[7].ToString();
                        clientesList.Add(clienteModel);
                    }
                }
            }
            return clientesList;
        }
    }
}
