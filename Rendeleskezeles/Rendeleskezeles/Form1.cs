using Microsoft.EntityFrameworkCore;
using Rendeleskezeles.Models;
using System.Xml.Linq;

namespace Rendeleskezeles
{
    public partial class Form1 : Form
    {
        public ReceptContext context = new ReceptContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nyersanyaglistazas();
            FogasokListazas();

            comboBoxStatus.DataSource = nyersanyagokBindingSource;


        }

        private void Nyersanyaglistazas()
        {
            var hv = from x in context.Nyersanyagok
                     where x.NyersanyagNev.Contains(textBoxAnyagszuro.Text)
                     select x;

            nyersanyagokBindingSource.DataSource = hv.ToList();
        }

        private void FogasokListazas()
        {
            var fog = from x in context.Fogasok
                      where x.FogasNev.Contains(textBoxNafogasszures.Text)
                      select x;

            fogasokBindingSource.DataSource = fog.ToList();
        }

        private void textBoxAnyagszuro_TextChanged(object sender, EventArgs e)
        {
            Nyersanyaglistazas();
        }

        private void textBoxNafogasszures_TextChanged(object sender, EventArgs e)
        {
            FogasokListazas();

        }

        private void listBoxAnyagfuhasiskoko_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var kivalasztott = (Nyersanyagok)listBoxAnyagfuhasiskoko.SelectedItem;

                var mennyiseg = (from x in context.MennyisegiEgysegek
                                 where x.MennyisegiEgysegId == kivalasztott.MennyisegiEgysegId
                                 select x).FirstOrDefault();

                labelMennyiseg.Text = mennyiseg.EgysegNev;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HozzavaloListazas()
        {
            var id = ((Fogasok)listBoxNyaFogas.SelectedItem).FogasId;
            var hozzavalok = from x in context.Receptek
                             where x.FogasId == id
                             select new Hozzavalo
                             {
                                 ReceptID = x.ReceptId,
                                 FogasID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            hozzavaloBindingSource.DataSource = hozzavalok.ToList();
        }


        private void listBoxNyaFogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzavaloListazas();
        }

        private void buttonTetelHozzaadas_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)listBoxAnyagfuhasiskoko.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)listBoxNyaFogas.SelectedItem).FogasId;
            double m;
            if (!double.TryParse(textBoxMennyiseg.Text, out m)) return;
            r.Mennyiseg4fo = m;
            context.Receptek.Add(r);
            context.SaveChanges();
            HozzavaloListazas();
        }

        private void buttonTeteltorles_Click(object sender, EventArgs e)
        {
            var torlendo = (Hozzavalo)hozzavaloBindingSource.Current;
            var torles = (from x in context.Receptek
                          where x.ReceptId == torlendo.ReceptID
                          select x).FirstOrDefault();
            context.Receptek.Remove(torles);
            context.SaveChanges();
            HozzavaloListazas();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("BiztosKilép?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonMentesExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Hozzávalók listájának lekérdezése
                var hozzavalok = (
                    from x in context.Receptek
                    select new
                    {
                        ReceptId = x.ReceptId,
                        FogasNev = x.Fogas.FogasNev,
                        NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                        Mennyiseg_4fo = x.Mennyiseg4fo,
                        EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                        Ar = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                    }).ToList();

                // XML dokumentum létrehozása
                XElement root = new XElement("Hozzavalok");

                foreach (var h in hozzavalok)
                {
                    XElement hozzavaloElem = new XElement("Hozzavalo",
                        new XElement("ReceptId", h.ReceptId),
                        new XElement("FogasNev", h.FogasNev),
                        new XElement("NyersanyagNev", h.NyersanyagNev),
                        new XElement("Mennyiseg_4fo", h.Mennyiseg_4fo),
                        new XElement("EgysegNev", h.EgysegNev),
                        new XElement("Ar", h.Ar)
                    );

                    root.Add(hozzavaloElem);
                }

                XDocument xdoc = new XDocument(root);

                // XML mentése fájlba
                string filePath = "hozzavalok.xml";
                xdoc.Save(filePath);

                MessageBox.Show($"Az XML fájl sikeresen mentve: {filePath}", "Mentés sikeres", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az XML mentésekor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}