﻿using System;
using System.Collections.Generic;
using PrimerParcial.UI.Registros;
using PrimerParcial.UI.Consultas;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PrimerParcial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registro().Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            new Consultar().Show();

        }
    }
}
