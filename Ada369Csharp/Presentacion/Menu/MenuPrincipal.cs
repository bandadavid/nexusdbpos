using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.Configuraciones;
using Ada369Csharp.Presentacion.LICENCIAS_MENBRESIAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Menu
{
    public partial class MenuPrincipal : UserControl
    {

        string ResultadoLicencia;
        string FechaFinal;

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void DibujarBotones()
        {
            panelbotones.Controls.Clear();
            var botones = new string[] { "Vender", "SUNAT", "Configuraciones", "Reportes", "Inventarios", "Panel control" };

            foreach (string boton in botones)
            {
                Button btn = new Button();
                btn.Text = boton.ToString();
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackColor = Color.FromArgb(29, 29, 29);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.Size = new Size(168, 69);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Consolas", 13, FontStyle.Bold);
                panelbotones.Controls.Add(btn);
                btn.Click += Btn_Click; ;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string texto = ((Button)sender).Text;
            foreach (Control control in panelbotones.Controls)
            {
                if (control is Button)
                {
                    if (control.Text == texto)
                    {

                        control.BackgroundImage = Properties.Resources.naranja;
                    }
                    else
                    {
                        control.BackgroundImage = null;
                    }

                }
            }
            if (texto == "SUNAT")
            {
                //Sunat();
            }
            else if (texto == "Vender")
            {
                //Vender();
            }
            else if (texto == "Configuraciones")
            {
                Configuraciones();
            }
            else if (texto == "Panel control")
            {
                //Panelcontrol();
            }
            else if (texto == "Reportes")
            {
                //Reportes();
            }
            else if (texto == "Inventarios")
            {
                //Inventarios();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            DibujarBotones();
            validarLicencia();

        }

        private void validarLicencia()
        {
            DLicencias funcion = new DLicencias();
            funcion.ValidarLicencias(ref ResultadoLicencia, ref FechaFinal);
            if (ResultadoLicencia == "?ACTIVO?")
            {
                lblestadoLicencia.Text = "Licencia de Prueba Activada hasta el: " + FechaFinal;
            }
            if (ResultadoLicencia == "?ACTIVADO PRO?")
            {
                lblestadoLicencia.Text = "Licencia PROFESIONAL Activada hasta el: " + FechaFinal;
                btnLicencia.Visible = false;
            }else
            {
                btnLicencia.Visible = true;

            }
            if (ResultadoLicencia == "VENCIDA")
            {
                funcion.EditarMarcanVencidas();
                Dispose();
                LICENCIAS_MENBRESIAS.MembresiasNuevo frm = new LICENCIAS_MENBRESIAS.MembresiasNuevo();
                frm.ShowDialog();
            }



        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            activarLic();
        }

        private void activarLic()
        {
            var ctl = new Licencias();
            ctl.btnCerrar.Visible = true;
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);

            ctl.BringToFront();
        }

        private void Configuraciones()
        {
            panelVisor.Controls.Clear();
            var ctl = new MenuConfig();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }
    }
}
