using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace Millo
{
    public partial class Form2 : Form
    {
       

        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUESTION #5:\n" + "¿Cuál es el planeta más cercano al sol?: \n"
                +"\na)Tierra                            b)Marte  "
                +"\nc)Mercurio--                        d)Venus  "
                );
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUESTION #1:\n" + "¿Cuánto dura un momento?: \n"
               +"\n a)60 segundos                     b)90 segundos--"
               +"\n c)120 segundos                    d)180 segundos"
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUESTION #2:\n" + 
               "¿Alrededor de cuántas papilas gustativas tiene la lengua humana de promedio? c: \n"
              + "\n a)100                    b)1.000"
              + "\n c)10.000--               d)100.000"
                );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUESTION #3:\n" +
                " ¿Qué significa el término “piano”?: \n"
                + "\n a)A un ritmo rapido      b)Para tocar suavemente--"
                + "\n c)Moderadamente lento    d)A un ritmo rápido"
                );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUESTION #4:\n" + " ¿De qué sustancia están hechas las uñas?: \n"
                + "\n a)Serotonina      b)Epidermis"
                + "\n c)Melanina        d)Queratina--"
                );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
