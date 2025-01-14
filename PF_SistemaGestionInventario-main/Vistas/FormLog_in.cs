using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form_full;

namespace Windows_Form_full.Vistas
{
    public partial class FormLog_in : Form
    {
        //public class Database
        //{
        //    private string dbPath = $"Data Source=Inventario.db;Version=3;";

        //    public void InitializeDatabase()
        //    {
        //        if (!File.Exists(dbPath))
        //        {
        //            SQLiteConnection.CreateFile(dbPath);
        //        }

        //        using (var connection = new SQLiteConnection(dbPath))
        //        {
        //            connection.Open();
        //            // Usuarios
        //            string query;
        //            query = "CREATE TABLE IF NOT EXISTS User (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT UNIQUE, Password TEXT);";
        //            using (var command = new SQLiteCommand(query, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //            // Ingresar admin
        //            query = "INSERT OR IGNORE INTO User (Username, Password) VALUES ('admin', '1234');";
        //            using (var command = new SQLiteCommand(query, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //            // Proveedor
        //            query = "CREATE TABLE IF NOT EXISTS Proveedor (idProveedor INTEGER PRIMARY KEY AUTOINCREMENT, nombreEmpresa TEXT UNIQUE NOT NULL, direccion TEXT, telefono INTEGER);";
        //            using (var command = new SQLiteCommand(query, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //            // Categoria
        //            query = "CREATE TABLE IF NOT EXISTS Categoria (idCategoria INTEGER PRIMARY KEY AUTOINCREMENT, nombreCategoria TEXT UNIQUE NOT NULL, descripcion TEXT);";
        //            using (var command = new SQLiteCommand(query, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //            // Producto
        //            query = "CREATE TABLE IF NOT EXISTS Producto (idProducto INTEGER PRIMARY KEY AUTOINCREMENT, nombreProducto TEXT, idCategoria INTEGER, precioProducto REAL, cantidadProducto INTEGER, idProveedor INTEGER, FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria), FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor));";
        //            using (var command = new SQLiteCommand(query, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }

        // public bool InsertUser(string username, string password)
        //{
        /* using (var connection = new SQLiteConnection(dbPath))
         {
             connection.Open();
             string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password);";
             using (var command = new SQLiteCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@username", username);
                 command.Parameters.AddWithValue("@password", password);
                 try
                 {
                     command.ExecuteNonQuery();
                     return true;
                 }
                 catch
                 {
                     return false;
                 }
             }
         }
     }*/

        //  public bool ValidateUser(string username, string password)
        // {
        /*  using (var connection = new SQLiteConnection(dbPath))
          {
              connection.Open();
              string query = "SELECT COUNT(*) FROM User WHERE Username = @username AND Password = @password;";
              using (var command = new SQLiteCommand(query, connection))
              {
                  command.Parameters.AddWithValue("@username", username);
                  command.Parameters.AddWithValue("@password", password);
                  int count = Convert.ToInt32(command.ExecuteScalar());
                  return count > 0;
              }
          }
      }
  }

 Database db = new Database();}*/
        public FormLog_in()
        {
            InitializeComponent();
            //db.InitializeDatabase();
        }
        private void user_input_TextChanged(object sender, EventArgs e)
        {

        }


            private void button_Click_1(object sender, EventArgs e)
            {
                //if (db.ValidateUser(inUsuario.Text, pIPassword.Text))
                //    {
                //MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí podrías abrir otro formulario
                FormProductos formProductos = new FormProductos();
                formProductos.ShowDialog();
            }
            /* else
             {
                 MessageBox.Show("Credenciales inválidas.");
             }*/


            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void pIPassword_TextChanged(object sender, EventArgs e)
            {

            }
         }
}



 