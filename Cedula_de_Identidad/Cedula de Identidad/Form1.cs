using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cedula_de_Identidad
{
    public partial class Form1 : Form
    {
        List<Usuario> Usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gbCedula_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now.AddYears(10);
            textExpiracion.Text = Convert.ToString(Fecha);

            Guid ID = Guid.NewGuid();
            textID.Text = Convert.ToString(ID);

            buttonCrear.Enabled = false;
            buttonCancelar.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonIngresar.Enabled = true;
            gbCedula.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            var usuario = new Usuario
            {
                ID = textID.Text,
                Nombre = textNombre.Text,
                Lugar_de_Nacimiento = textLugar.Text,
                Sexo = buttM.Checked ? "Masculino" : "Femenino",
                Fecha_de_Nacimiento = dtNacimiento.Value,
                Sangre = textSangre.Text,
                Nacionalidad = textNacionalidad.Text,
                Estado_Civil = comboEstado.Text,
                Ocupación = textOcupacion.Text,
                Fecha_de_Expiracion = textExpiracion.Text,
            };

            Usuarios.Add(usuario);
            MessageBox.Show("El usuario ha guardado sucesivamente");

            clear();

            buttonCrear.Enabled = true;
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonIngresar.Enabled = false;
            gbCedula.Enabled = false;

            getUser();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void getUser()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = Usuarios;
        }

        private void clear()
        {
            boxFoto.Image = null;
            dtNacimiento.Value = DateTime.Now;

            foreach (Control c in gbCedula.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }

            buttF = null;
            buttM = null;

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                boxFoto.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Usuario
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Lugar_de_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_de_Nacimiento { get; set; }
        public string Sangre { get; set; }
        public string Nacionalidad { get; set; }
        public string Estado_Civil { get; set; }
        public string Ocupación { get; set; }
        public DateTime Fecha_Creada { get; set; }
        public string Fecha_de_Expiracion { get; set; }
        

    }
}
