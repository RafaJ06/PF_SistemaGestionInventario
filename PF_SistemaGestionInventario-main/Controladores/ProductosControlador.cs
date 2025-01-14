using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ProductosControlador
    {
        //private string dbPath = "db/inventario.db";
        private string connectionString = $"Data Source=Inventario.db;Version=3;";

        public void AgregarProducto(Producto producto)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Producto (nombreProducto, idCategoria, precioProducto, cantidadProducto, idProveedor) VALUES (@nombreProducto, @idCategoria, @precioProducto, @cantidadProducto, @idProveedor)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                    //command.Parameters.AddWithValue("@idProducto", producto.idProducto);
                    command.Parameters.AddWithValue("@idCategoria", producto.idCategoria);
                    command.Parameters.AddWithValue("@precioProducto", producto.precioProducto);
                    command.Parameters.AddWithValue("@cantidadProducto", producto.cantidadProducto);
                    command.Parameters.AddWithValue("@idProveedor", producto.idProveedor);

                command.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Producto";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            idProducto = Convert.ToInt32(reader["idProducto"]),
                            //nombreProducto = reader["nombreProducto"].ToString(),
                            idCategoria = Convert.ToInt32(reader["idCategoria"]),
                            idProveedor = Convert.ToInt32(reader["idProveedor"]),
                            precioProducto = Convert.ToDouble(reader["precioProducto"]),
                            cantidadProducto = Convert.ToInt32(reader["cantidadProducto"])
                        });
                    }
                }
            }
            return productos;
        }
    }
