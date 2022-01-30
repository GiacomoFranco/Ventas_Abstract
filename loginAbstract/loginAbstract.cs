using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginAbstract
{
    public partial class LoginAbstract : Form
    {

        public LoginAbstract()
        {


            InitializeComponent();

            string query = "SELECT * FROM RECORDAR";
            SqlCommand comando = new SqlCommand(query, databaseConnect.Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows[0]["REGISTRO"].ToString() == "YES")
            {
                txt_usuario.Text = table.Rows[0]["USER"].ToString();
                txt_password.Text = table.Rows[0]["PASSWORD"].ToString();
                button3.BackgroundImage = global::loginAbstract.Properties.Resources.rememberMeChecked;
            }
        }




        int count = 0;



        private void BtnRecuerdame(object sender, EventArgs e)
        {
            databaseConnect conectarLogin = new databaseConnect();

            string query = "SELECT * FROM RECORDAR";
            SqlCommand comando = new SqlCommand(query, databaseConnect.Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);

         



            if (table.Rows[0]["REGISTRO"].ToString() == "YES")
            {
                count = 1;   
            }

            count = ++count;

            if (count == 2)
            {
                count = 0;
            }

            if (count % 2 != 0 && count != 0)
            {
                button3.BackgroundImage = global::loginAbstract.Properties.Resources.rememberMeChecked;

                string rememberChecked = "UPDATE RECORDAR SET REGISTRO = 'YES' WHERE ID = '1'";

                SqlCommand cmd = new SqlCommand(rememberChecked, databaseConnect.Conexion);
                conectarLogin.AbrirConexion();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    // Cierro la Conexión.
                    conectarLogin.CerrarConexion();
                }
            }
            else
            {
                button3.BackgroundImage = global::loginAbstract.Properties.Resources.rememberMeUnchecked;

                string rememberChecked = "UPDATE RECORDAR SET REGISTRO = 'NO' WHERE ID = '1'";

                SqlCommand cmd = new SqlCommand(rememberChecked, databaseConnect.Conexion);
                conectarLogin.AbrirConexion();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    // Cierro la Conexión.
                    conectarLogin.CerrarConexion();
                }
            }
        }



        private void BtnIngresar(object sender, EventArgs e)
        {
            databaseConnect conectarLogin = new databaseConnect();

            string query = "SELECT * FROM RECORDAR";
            SqlCommand comando = new SqlCommand(query, databaseConnect.Conexion);

            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);

            try
            {

                conectarLogin.AbrirConexion();

                SqlCommand verifuser = new SqlCommand("SELECT [USER], PASSWORD FROM LOGIN WHERE [USER]='" + txt_usuario.Text + "' AND PASSWORD='" + txt_password.Text + "'", databaseConnect.Conexion);

                SqlDataReader dr = verifuser.ExecuteReader();

              

                if (dr.Read()) //REVISIÓN DEL USUARIO EN LA BASE DE DATOS :)))

                {
                    conectarLogin.CerrarConexion();


                    string udpateuser = "UPDATE RECORDAR SET [USER] = '" + txt_usuario.Text + "'WHERE ID = '1'";
                    string udpatepassword = "UPDATE RECORDAR SET PASSWORD = '" + txt_password.Text + "'WHERE ID = '1'";

                    conectarLogin.AbrirConexion();

                        if (table.Rows[0]["REGISTRO"].ToString() == "YES")
                        {

                            SqlCommand cmd = new SqlCommand(udpateuser, databaseConnect.Conexion);
                            SqlCommand cmd2 = new SqlCommand(udpatepassword, databaseConnect.Conexion);
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                int a = cmd2.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.ToString());
                            }
                                finally
                                {
                                    conectarLogin.CerrarConexion();
                                }

                        }


                    this.Hide();
                    newPurchaseAbstract openNewPurchaseAbstract = new newPurchaseAbstract();
                    openNewPurchaseAbstract.Show();

                }
                else
                {
                    MessageBox.Show("Los datos que registraste son erroneos", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                conectarLogin.CerrarConexion();
            }


      



        }
    }
}
