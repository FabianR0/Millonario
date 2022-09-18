namespace Millo
{
    public partial class Form1 : Form
    {
        Form2 Millona;
        public Form1()
        {
            InitializeComponent();
            Millona = new Form2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Password = textBox2.Text;
            
            DateTime fecha = DateTime.Today;
            if (Usuario == "fabiancho" && Password == "2230")
            {
                Millona.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}