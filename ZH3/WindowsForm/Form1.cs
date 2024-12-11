using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztos, hogy ki szeretn�l l�pni?", "Kil�p�s meger�s�t�se", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ezzel megakad�lyozzuk a form bez�r�s�t
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl1());
        }

        private void LoadUserControl(UserControl control)
        {
            panel1.Controls.Clear();  // El�z� UserControl elt�vol�t�sa
            control.Dock = DockStyle.Fill;  // Kit�lti a Panel-t
            panel1.Controls.Add(control);  // Hozz�adjuk a Panel-hez
        }
    }
}