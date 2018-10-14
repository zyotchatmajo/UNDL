using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5
{
    public partial class Form1 : Form
    {
        List<String> Nombres = new List<String>();
        int nom = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void Alta()
        {
            Nombres.Add(Campo.Text);
        }

        public void Cambios()
        {
            if(button2.Text == "Buscar")
            {
                Console.WriteLine(Nombres.BinarySearch(Campo.Text));
                nom = Nombres.BinarySearch(Campo.Text);
                if (nom >= 0)
                {
                    label2.Text = "Se encontro el nombre :" + Campo.Text + " Introduce un nuevo nombre";
                    button2.Text = "Editar";
                }
                else
                {
                    label2.Text = "No se encontro";
                }
            }
            else
            {
                Nombres[nom] = Campo.Text;
                button2.Text = "Buscar";
                label2.Text = "Se cambio el nombre ! ";
            }
            
            
        }
        public void Baja()
        {
            nom = Nombres.BinarySearch(Campo.Text);
            if (nom >= 0)
            {
                label2.Text = "Se encontro el nombre :" + Campo.Text + " y fue eliminado";
                Nombres.Remove(Campo.Text);
            }
            else
            {
                label2.Text = "No se encontro";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Alta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cambios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var message = string.Join(Environment.NewLine, Nombres);
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baja();
        }
    }
}
