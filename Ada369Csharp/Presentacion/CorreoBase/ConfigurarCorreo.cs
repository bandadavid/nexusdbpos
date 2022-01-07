using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
namespace Ada369Csharp.Presentacion.CorreoBase
{
    public partial class ConfigurarCorreo : Form
    {
        public ConfigurarCorreo()
        {
            InitializeComponent();
        }

        private void btnsincronizar_Click(object sender, EventArgs e)
        {
            bool estado;
            estado= Bases.enviarCorreo(TXTCORREO.Text, txtpass.Text, "Sincronizacion con NexusDBPOS creada Correctamente", "Sincronizacion con NexusDBPOS",TXTCORREO.Text, "");
            if (estado ==true)
            {
                editarCorreo();
                MessageBox.Show("Sincronizacion Creada Correctamente", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Dispose();
            }
            else
            {
                MessageBox.Show("Sincronizacion Fallida, revisa el Video de Nuevo", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void editarCorreo()
        {
            Lcorreo parametros = new Lcorreo();
            Editar_datos funcion = new Editar_datos();
            parametros.Correo = Bases.Encriptar ( TXTCORREO.Text);
            parametros.Password = Bases.Encriptar(txtpass.Text);
            parametros.Estado = Bases.Encriptar("Sincronizado");
            funcion.editarCorreobase(parametros);
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=HuZCS2OQ84g");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tver_Click(object sender, EventArgs e)
        {
            
             txtpass.PasswordChar = '\0';
             tocultar.Visible = true;
             tver.Visible = false;
        }

        private void tocultar_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
            tocultar.Visible = false;
            tver.Visible = true;
        }
    }
}
