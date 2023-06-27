using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniI_IEFI
{
    internal class clsCodigo
    {
        OleDbConnection cone;
        OleDbCommand cmd;
        OleDbDataReader rdr;

        public void RegistrarSocio(string nombre, string apellido, string lugarNacimiento, int edad, bool sexo, decimal ingreso, int puntaje)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb;Persist Security Info=False;";


            string consultaSql = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) " +
                     "VALUES (@nombre, @apellido, @lugarNacimiento, @edad, @sexo, @ingreso, @puntaje)";
            try
            {
                cone = new OleDbConnection(conexion);
                cmd = new OleDbCommand();
                cmd.Connection = cone;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consultaSql;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@lugarNacimiento", lugarNacimiento);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@ingreso", ingreso);
                cmd.Parameters.AddWithValue("@puntaje", puntaje);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        public void CargarPaises(ComboBox cmbPais)
        {
            //string conexion y query sql
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb;Persist Security Info=False;";
            string sql = "SELECT DISTINCT Pais from PAISES";



            try
            {
                //llamo los objetos conexion y command para manipular la base de datos, y el readear para leer los datos que contiene
                cone = new OleDbConnection(conexion);
                cmd = new OleDbCommand();
                cmd.Connection = cone;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //agrego los paises de la tabla en el combo box
                    cmbPais.Items.Add(rdr["Pais"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }

        }


        //evento para registrar nuevos paises en la base de datos
        public void RegistrarPais(int CodPais, string Pais)
        {
            //string conexion y query sql
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb;Persist Security Info=False";
            string consultaSql = "INSERT INTO PAISES (Cod_Pais, Pais) VALUES (@codPais, @Pais)";

            try
            {
                //llamo los objetos conexion y command para escribir la base de datos
                cone = new OleDbConnection(conexion);
                cmd = new OleDbCommand();
                cmd.Connection = cone;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;


                // verificar si el pais ya existe en la tabla
                string verificacionSql = "SELECT COUNT(*) FROM PAISES WHERE Pais = @Pais";
                cmd.CommandText = verificacionSql;
                cmd.Parameters.AddWithValue("@Pais", Pais);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("El país ya existe en la tabla.", "", MessageBoxButtons.OK);
                }
                else
                {
                    // insertar el pais en la tabla
                    cmd.CommandText = consultaSql;
                    cmd.Parameters.Clear(); // limpiar los parametros previos
                    cmd.Parameters.AddWithValue("@codPais", CodPais);
                    cmd.Parameters.AddWithValue("@Pais", Pais);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pais registrado!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);
            }

        }
    }

}

