using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Service
{
    public class AccesoDatos
    {
        // Atributos
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        // Constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server = .\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");
            comando = new SqlCommand();

        }
        // Property
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // Metodos
        
        public void SetearConsulta(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       
        public void CerrarConexion()
        {
            conexion.Close();
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
