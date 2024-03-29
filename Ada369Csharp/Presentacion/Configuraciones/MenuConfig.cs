﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class MenuConfig : UserControl
    {
        public MenuConfig()
        {
            InitializeComponent();
        }

        private void Logo_empresa_Click(object sender, EventArgs e)
        {
            var ctl = new Empresaconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label47_Click(object sender, EventArgs e)
        {
            var ctl = new Empresaconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            var ctl = new Usuariosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label26_Click(object sender, EventArgs e)
        {
            var ctl = new Usuariosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var ctl = new Cajasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label27_Click(object sender, EventArgs e)
        {
            var ctl = new Cajasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var ctl = new Serializacionconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label29_Click(object sender, EventArgs e)
        {
            var ctl = new Serializacionconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var ctl = new Productosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            var ctl = new Productosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var ctl = new Clientesconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            var ctl = new Clientesconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            var ctl = new Proveedoresconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            var ctl = new Proveedoresconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btndiseñador_Click(object sender, EventArgs e)
        {
            var ctl = new Diseñoticket();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label31_Click(object sender, EventArgs e)
        {
            var ctl = new Diseñoticket();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnimpresoras_Click(object sender, EventArgs e)
        {
            var ctl = new Impresorasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            var ctl = new Impresorasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnBalanza_Click(object sender, EventArgs e)
        {
            var ctl = new Balanzaconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            var ctl = new Balanzaconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btncorreo_Click(object sender, EventArgs e)
        {
            var ctl = new Correoconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            var ctl = new Correoconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            var ctl = new Respaldosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            var ctl = new Respaldosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }
    }
}
