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
            DialogResult result = MessageBox.Show("Biztos, hogy ki szeretnél lépni?", "Kilépés megerõsítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ezzel megakadályozzuk a form bezárását
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl1());
        }

        private void LoadUserControl(UserControl control)
        {
            panel1.Controls.Clear();  // Elõzõ UserControl eltávolítása
            control.Dock = DockStyle.Fill;  // Kitölti a Panel-t
            panel1.Controls.Add(control);  // Hozzáadjuk a Panel-hez
        }
    }
}