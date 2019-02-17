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
                case 3: //se compara para saber que telefono es y asi mostrar la imagen 
                pictureBox1.Image = Properties.Resources.P20lite;
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
                        Size = new Size(730, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara
                    };
                    imagen5.Show();
                    break;
                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(690, 450),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.Iluminacionp20
                    };
                    imagen8.Show();
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
                
                case 3:
                Form imagen8 = new Form
                {
                    Size = new Size(766, 402),
                    MinimizeBox = false,
                    MaximizeBox = false,
                    BackgroundImage = Properties.Resources.pilap20
                };
                imagen8.Show();
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
                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(620, 450),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara1
                    };
                    imagen8.Show();
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

                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(700, 402),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.ProcesamientoP20
                    };
                    imagen8.Show();
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

                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(700, 450),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.camara2
                    };
                    imagen8.Show();
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

                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(700, 450),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.AsistenteCom
                    };
                    imagen8.Show();
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
                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(650, 570),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.InteligenciaFo
                    };
                    imagen8.Show();
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
                case 3:
                    Form imagen8 = new Form
                    {
                        Size = new Size(700, 450),
                        MinimizeBox = false,
                        MaximizeBox = false,
                        BackgroundImage = Properties.Resources.Juegos
                    };
                    imagen8.Show();
                    break;
            }
        }
    }
}