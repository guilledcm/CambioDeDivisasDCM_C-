using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PracticaDivisasGuillermoDeCarlos

{
    public partial class Divisas : Form
    {
        private string rutaHistorial = "historial.txt";

        public Divisas()
        {
            InitializeComponent();
            customInit();
        }
        private void customInit()
        {
            comboBox1.Items.Add(new Moneda("EUROS", 1.05));
            comboBox1.Items.Add(new Moneda("DOLLARS", 1));
            comboBox1.Items.Add(new Moneda("LIBRAS", 1.30));

            comboBox2.Items.Add(new Moneda("EUROS", 1.05));
            comboBox2.Items.Add(new Moneda("DOLLARS", 1));
            comboBox2.Items.Add(new Moneda("LIBRAS", 1.30));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombreMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void Divisas_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.SelectedIndex = 0;
            comboBox2.SelectedItem = comboBox2.SelectedIndex = 1;

            if (File.Exists(rutaHistorial))
            {
                string[] historial = File.ReadAllLines(rutaHistorial);
                historialListBox.Items.AddRange(historial);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void imagenFlechas_Click(object sender, EventArgs e)
        {
            int textoSeleccionado1 = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = textoSeleccionado1;




        }

        private void importeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(importeTextBox.Text, @"^[0-9,]*$"))
            {
                MessageBox.Show("Solo se admiten números y comas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                importeTextBox.Text = importeTextBox.Text.Remove(importeTextBox.Text.Length - 1);
            }
        }

        private void Cambiobutton_Click(object sender, EventArgs e)
        {
            double tasaEurosADolares = 1.05;
            double tasaLibrasADolares = 1.30;

            string divisaOrigen = comboBox1.SelectedItem.ToString();
            string divisaDestino = comboBox2.SelectedItem.ToString();

            if (double.TryParse(importeTextBox.Text, out double importe))
            {
                double resultado = 0.0;

                Moneda Moneda1 = comboBox1.SelectedItem as Moneda;
                Moneda Moneda2 = comboBox2.SelectedItem as Moneda;

                resultado = ((Double.Parse(importeTextBox.Text)) * Moneda1.valor) / Moneda2.valor;


                string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string historialEntry = $"{fecha}: {importe} {divisaOrigen} cambiados a {resultado} {divisaDestino}";
                historialListBox.Items.Add(historialEntry);

                File.AppendAllText(rutaHistorial, historialEntry + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Ingresa un importe válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
