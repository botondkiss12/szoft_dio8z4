using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Models;

namespace WindowsForm
{

    public partial class UserControl1 : UserControl
    {
        QuizDatabaseContext context = new QuizDatabaseContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Loadadat();
        }

        private void Loadadat()
        {

            riddleBindingSource.DataSource = context.Riddles.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                riddleBindingSource.EndEdit();
                var uj = (Riddle)riddleBindingSource.Current;
                context.Riddles.Add(uj);
                context.SaveChanges();
                Loadadat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba:" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                riddleBindingSource.EndEdit();
                context.SaveChanges();
                Loadadat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba:" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                riddleBindingSource.EndEdit();
                var uj = (Riddle)riddleBindingSource.Current;
                context.Riddles.Remove(uj);
                context.SaveChanges();
                Loadadat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba:" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Példa: Lekérjük az adatokat az adatbázisból
            using (var context = new QuizDatabaseContext())
            {
                var riddles = context.Riddles
                    .Select(r => new
                    {
                        r.RiddleId,
                        r.QuestionText,
                        r.CorrectAnswer,
                        r.WrongAnswer1,
                        r.WrongAnswer2,
                        r.WrongAnswer3
                    })
                    .ToList();

                // Új Excel munkafüzet létrehozása
                using (var workbook = new XLWorkbook())
                {
                    // Új munkalap létrehozása "Riddles" néven
                    var worksheet = workbook.Worksheets.Add("Riddles");

                    // Fejléc sor beállítása
                    worksheet.Cell(1, 1).Value = "RiddleId";
                    worksheet.Cell(1, 2).Value = "QuestionText";
                    worksheet.Cell(1, 3).Value = "CorrectAnswer";
                    worksheet.Cell(1, 4).Value = "WrongAnswer1";
                    worksheet.Cell(1, 5).Value = "WrongAnswer2";
                    worksheet.Cell(1, 6).Value = "WrongAnswer3";

                    // Adatok beírása a cellákba
                    int currentRow = 2;
                    foreach (var riddle in riddles)
                    {
                        worksheet.Cell(currentRow, 1).Value = riddle.RiddleId;
                        worksheet.Cell(currentRow, 2).Value = riddle.QuestionText;
                        worksheet.Cell(currentRow, 3).Value = riddle.CorrectAnswer;
                        worksheet.Cell(currentRow, 4).Value = riddle.WrongAnswer1;
                        worksheet.Cell(currentRow, 5).Value = riddle.WrongAnswer2;
                        worksheet.Cell(currentRow, 6).Value = riddle.WrongAnswer3;
                        currentRow++;
                    }

                    // Oszlopok automatikus szélesség beállítása
                    worksheet.Columns().AdjustToContents();

                    // Formázás: fejléc sor félkövér és háttérszín
                    var headerRange = worksheet.Range("A1:F1");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                    headerRange.Style.Font.FontColor = XLColor.White;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Tartalom igazítása
                    var usedRange = worksheet.RangeUsed();
                    usedRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Fájl mentése
                    var saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel Workbook|*.xlsx";
                    saveDialog.Title = "Save Excel File";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Excel file successfully created and formatted!");
                    }
                }
            }
        }
    }
}
