﻿using SolRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proysustiCliente
{
    public partial class MDImenu : Form
    {
        public MDImenu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ProduccionView p = new ProduccionView();
            //  p.MdiParent = this;
            //  p.Show();

            EmpleadoUI em = new EmpleadoUI();
            em.MdiParent = this;
            em.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDImenu_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void verDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DocenteView p = new DocenteView();
            //p.MdiParent = this;
            // p.Show();
            CompPagoUI m = new CompPagoUI();
            m.MdiParent = this;
            m.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompPagoUI n = new CompPagoUI();
            n.MdiParent = this;
            n.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //ActaCompromisoUI s = new ActaCompromisoUI();
            EmpleadoUI p = new EmpleadoUI();
            p.MdiParent = this;
            p.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReporteUI ui = new ReporteUI();
            //ui.MdiParent = this;
            //ui.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //ReporteUI s = new ReporteUI();
            //s.MdiParent = this;
            //s.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActaCompromisoUI c = new ActaCompromisoUI();
            c.MdiParent = this;
            c.Show();

        }
    }
}
