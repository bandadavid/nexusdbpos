using System;
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
    }
}
