using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------
using MySql.Data.MySqlClient;

namespace catalogo2018_consola
{
    class DAOMySQL : IDAO
    {
        public MySqlConnection conexion;

        public bool Conectar(string srv, string port, string db, string user, string pwd)
        {
            string cadenaConexion = string.Format("server={0};port={1};database={2};uid={3};pwd={4};", srv, port, db, user, pwd);

            // Instanciamos un objeto MySQLConnection
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open(); // Abrimos la sesión mySQL
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0: throw new Exception("Error de conexión." + e.ErrorCode);
                    case 1045: throw new Exception("Usuario o contraseña incorrectos");
                    default: throw;
                }
            }
        }

        public void Desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public bool Conectado()
        {
            if (conexion != null)
                return conexion.State == System.Data.ConnectionState.Open;
            else
                return false;
        }

        public List<Dvd> SeleccionarPA(string codigo)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable SeleccionarTB(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Dvd> Seleccionar(string codigo)
        {
            throw new NotImplementedException();
        }

        public int Borrar(string codigo)
        {
            throw new NotImplementedException();
        }

        public Pais SeleccionarPais(string iso2)
        {
            throw new NotImplementedException();
        }

        public int Actualizar(Dvd unDVD)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Dvd unDVD)
        {
            throw new NotImplementedException();
        }
    }
}
