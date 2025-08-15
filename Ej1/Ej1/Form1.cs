using Ej1.Models;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //Ortoedro objeto = new Ortoedro(7, 7, 21);
            //tbx1.Text = objeto.Describir();

            //Cubo objeto = new Cubo(2);
            //tbx1.Text = objeto1.Describir();

            Cilindro objeto = new Cilindro(2,2);
            tbx1.Text=objeto.Describir();
        }
    }
}
