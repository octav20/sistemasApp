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
    public class EmpleadoRepository: BaseRepository, IEmpleadoRepository
    {
        //Constructor
        public EmpleadoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Add(EmpleadoModel empleadoModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into empleado values (@name, @lastName, @email, @phone, @address, @lat, @lon)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = empleadoModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = empleadoModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = empleadoModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = empleadoModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = empleadoModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = empleadoModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = empleadoModel.Longitud;
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
                command.CommandText = "delete from Empleado where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(EmpleadoModel empleadoModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update empleado set Nombre = @name, Apellido= @lastName, Email= @email,Telefono =  @phone, Direccion= @address, Latitud=@lat, Longitud=@lon where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = empleadoModel.Nombre;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = empleadoModel.Apellido;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = empleadoModel.Email;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = empleadoModel.Telefono;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = empleadoModel.Direccion;
                command.Parameters.Add("@lat", SqlDbType.NVarChar).Value = empleadoModel.Latitud;
                command.Parameters.Add("@lon", SqlDbType.NVarChar).Value = empleadoModel.Longitud;
                command.Parameters.Add("@id", SqlDbType.Int).Value = empleadoModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EmpleadoModel> GetAll()
        {
            var empleadosList = new List<EmpleadoModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Empleado order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var empleadoModel = new EmpleadoModel();
                        empleadoModel.Id = (int)reader[0];
                        empleadoModel.Nombre = reader[1].ToString();
                        empleadoModel.Apellido = reader[2].ToString();
                        empleadoModel.Email = reader[3].ToString();
                        empleadoModel.Telefono = reader[4].ToString();
                        empleadoModel.Direccion = reader[5].ToString();
                        empleadoModel.Latitud = reader[6].ToString();
                        empleadoModel.Longitud = reader[7].ToString();
                        empleadosList.Add(empleadoModel);
                    }
                }
            }
            return empleadosList;
        }

        public IEnumerable<EmpleadoModel> GetByValue(string value)
        {
            var empleadosList = new List<EmpleadoModel>();
            int empleadoId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string empleadoName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from empleado where Id = @id or Nombre like @name+'%' order by Id desc ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = empleadoId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = empleadoName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var empleadoModel = new EmpleadoModel();
                        empleadoModel.Id = (int)reader[0];
                        empleadoModel.Nombre = reader[1].ToString();
                        empleadoModel.Apellido = reader[2].ToString();
                        empleadoModel.Email = reader[3].ToString();
                        empleadoModel.Telefono = reader[4].ToString();
                        empleadoModel.Direccion = reader[5].ToString();
                        empleadoModel.Latitud = reader[6].ToString();
                        empleadoModel.Longitud = reader[7].ToString();
                        empleadosList.Add(empleadoModel);
                    }
                }
            }
            return empleadosList;
        }
    }
}
