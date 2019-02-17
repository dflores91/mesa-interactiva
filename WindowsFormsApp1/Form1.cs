using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false; //se ocultan los botones para que no marquen nada
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex; //se toma el valor de la opcion del combobox
            if (p != null)
            {
                button1.Visible = true; //se hacen visibles los botones para mostrar la informacion 
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
            }

            switch(p)
            {
                case 0: //se compara para saber que telefono es y asi mostrar la imagen 
                    pictureBox1.Image = Properties.Resources.moto_g5;
                break;

                case 1:
                    pictureBox1.Image = Properties.Resources.galaxy2;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(732, 710),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.intelig
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.bateria
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(660, 235),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.bateriag
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.procesador
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(850, 180),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.procesadorg
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(509, 630),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.seguridad
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(1000, 350),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camarag
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.pantalla
                    };
                    imagen5.Show();
                    break;
                case 1:
                    Form imagen6 = new Form
                    {
                        Size = new Size(940, 300),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.pantallag
                    };
                    imagen6.Show();
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int p = comboBox1.SelectedIndex;
            switch (p)
            {
                case 0:
                    Form imagen5 = new Form
                    {
                        Size = new Size(766, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
            }
        }
    }
}