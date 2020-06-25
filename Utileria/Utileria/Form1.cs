using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Utileria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        daoAlumno dao = new daoAlumno();
        List<Alumno> ln;

        private void btnBuscar_Click(object sender, EventArgs e)
        {            
            if (dao.descomprimir(txtRuta.Text,txtNombre.Text))
            {
                btnBuscar.Enabled = false;
                btnMostrar.Enabled = true;
            }
            else {
                MessageBox.Show("El archivo ya existe");
                btnMostrar.Enabled = true;
                btnBuscar.Enabled = false;
            }                      
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ln=dao.LeerArchivo(txtRuta.Text, txtExcel.Text);
            for (int i = 0; i < ln.Count; i++)
            {
                lblResultado.Items.Add("Archivo: " + ln[i].Archivo + "    Estatus: " + ln[i].Estatus + "     Descripción: " + ln[i].Descripcion + "      FolioControl: " + ln[i].FolioControl);
            }
            btnEstatus1.Enabled = true;
            btnEstatus2.Enabled = true;
            btnEstatusD.Enabled = true;
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            lstObjetos.Items.Clear();
            List<Alumno> ls = new List<Alumno>();            
            ls= dao.EstatusUno(ln);    
            for (int i = 0; i < ls.Count; i++) {
                lstObjetos.Items.Add("ARCHIVO: "+ls[i].Archivo.ToString() + "       ESTATUS: "+ls[i].Estatus.ToString() + "     DESCRIPCION: "+ls[i].Descripcion.ToString() + "     FOLIO CONTROL: "+ls[i].FolioControl.ToString());
            }
        }

        private void btnEstatus2_Click(object sender, EventArgs e)
        {
            lstObjetos.Items.Clear();
            List<Alumno> ls = new List<Alumno>();
            ls = dao.EstatusDos(ln);
            for (int i = 0; i < ls.Count; i++)
            {
                lstObjetos.Items.Add("ARCHIVO: " + ls[i].Archivo.ToString() + "     ESTATUS: " + ls[i].Estatus.ToString() + "       DESCRIPCION: " + ls[i].Descripcion.ToString() + "       FOLIO CONTROL: " + ls[i].FolioControl.ToString());
            }
        }

        private void btnEstatusD_Click(object sender, EventArgs e)
        {
            lstObjetos.Items.Clear();
            List<Alumno> ls = new List<Alumno>();
            ls = dao.EstatusDiferenteUno(ln);
            for (int i = 0; i < ls.Count; i++)
            {
                lstObjetos.Items.Add("ARCHIVO: " + ls[i].Archivo.ToString() + "     ESTATUS: " + ls[i].Estatus.ToString() + "       DESCRIPCION: " + ls[i].Descripcion.ToString() + "       FOLIO CONTROL: " + ls[i].FolioControl.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lstObjetos.Items.Clear();
            lblResultado.Items.Clear();
            btnEstatus1.Enabled = false;
            btnEstatus2.Enabled = false;
            btnEstatusD.Enabled = false;
            btnMostrar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void txtExcel_TextChanged(object sender, EventArgs e)
        {
            lstObjetos.Items.Clear();
            lblResultado.Items.Clear();
            btnEstatus1.Enabled = false;
            btnEstatus2.Enabled = false;
            btnEstatusD.Enabled = false;
            btnBuscar.Enabled = true;
        }
    }
}
