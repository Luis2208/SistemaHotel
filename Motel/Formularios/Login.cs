using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Motel.Formularios
{
    public partial class Login : Form
    {

        int i_cuenta = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxPass.Checked)
            {
                txtBxPass.PasswordChar = '\0';
            }
            else
                txtBxPass.PasswordChar = '+';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i_cuenta = 0;
            Conexion.Conexion.obtenerConexion();
            MySqlCommand cmd = Conexion.Conexion.obtenerConexion().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM prueba WHERE idUsuario='"+txtBxUsuario.Text+"' AND password='"+txtBxPass.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i_cuenta = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i_cuenta == 0)
            {
                label3.Text = "Has ingresado mal el usuario y contraseña";
            }
            else
            {
                this.Hide();
                Principal fm = new Principal();
                fm.Show();
            }

            Conexion.Conexion.obtenerConexion().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("¿Desea salir de la aplicación?", "title", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Close();
        }
    }
 
}
