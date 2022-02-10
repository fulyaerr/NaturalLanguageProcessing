using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace NaturalLanguageProcessing
{
    public partial class Form1 : Form
    {
        Dictionary<char, char> characterList = new Dictionary<char, char>();
        public Form1()
        {
            InitializeComponent();
            characterList = new Dictionary<char, char>() { { 'b', 'p' }, { 'c', 'ç' }, { 'd', 't' }, { 'g', 'k' }, { 'ğ', 'k' } };
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string data = string.Empty;

            Regex rgx = new Regex(@"[^\w\d]");

            data = rgx.Replace(textBox1.Text, " ");
            while (data.Contains("  "))
            {
                data = data.Replace("  ", " ");
            }

            textBox1.Text = data.ToLower();
            textBox1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
        }

        private void buttonTokenize_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(' ');
            txtTokenize.Lines = words.ToArray();
        }

        private void btnFindRoot_Click(object sender, EventArgs e)
        {
            List<RowDetail> rowList = new List<RowDetail>();
            List<StemDetail> stemList = new List<StemDetail>();
            int flag = 0;
            string searched_word = string.Empty;
            string variant = string.Empty;
            int stemCount = 1;

            for (int k = 0; k < dataGridView1.Columns["Key"].DataGridView.Rows.Count - 1; k++)
            {
                rowList.Add(
                    new RowDetail
                    {
                        key = dataGridView1.Rows[k].Cells["Key"].Value.ToString(),
                        tag = dataGridView1.Rows[k].Cells["Tag"].Value.ToString()
                    });
            }

            for (int i = 0; i < txtTokenize.Lines.Length; i++)
            {
                flag = 0;
                searched_word = txtTokenize.Lines[i];
                string stem = string.Empty;
                string key = string.Empty;
                while ((flag == 0) && searched_word.Length > 1)
                {
                    variant = string.Empty;
                    var endOfWord = searched_word.ToCharArray();
                    var lastCharacter = endOfWord[endOfWord.Length - 1];

                    if (characterList.Keys.Contains(lastCharacter))
                    {
                        characterList.TryGetValue(lastCharacter, out lastCharacter);
                    }

                    variant = searched_word.Substring(0, searched_word.Length - 1) + lastCharacter;

                    if (rowList.Where(x => x.key == variant.Trim()).Any() || rowList.Where(x => x.key == searched_word.Trim()).Any())
                    {
                        key = rowList.Where(x => x.key == variant.Trim()).Any() ? variant.Trim() : searched_word.Trim();
                        stem = rowList.Find(x => x.key == key).tag;
                        if (!stemList.Where(x => x.stem == key).Any())
                        {
                            stemList.Add(new StemDetail
                            {
                                id = stemCount,
                                stem = key,
                                stem_type = stem
                            });

                            stemCount++;
                        }
                        flag = 1;
                    }
                    else
                    {
                        searched_word = searched_word.Substring(0, searched_word.Length - 1);
                    }
                }

                if (flag == 1)
                {
                    textBox3.Text = textBox3.Text + (" " + key + "[" + stem + "] ");
                }
                else
                {
                    textBox3.Text = textBox3.Text + " " + txtTokenize.Lines[i];
                }
            }
        }
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            string DosyaYolu;
            string DosyaAdi;
            DataTable dt;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                DosyaAdi = file.SafeFileName;
                ExcelApp.Application excelApp = new ExcelApp.Application();
                if (excelApp == null)
                { 
                    MessageBox.Show("Excel yüklü değil.");
                    return;
                }
                ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                ExcelApp.Range excelRange = excelSheet.UsedRange;
                int satirSayisi = excelRange.Rows.Count; 
                int sutunSayisi = excelRange.Columns.Count;
                dt = ToDataTable(excelRange, satirSayisi, sutunSayisi);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            else
            {
                MessageBox.Show("Dosya Seçilemedi.");
            }
        }
        public DataTable ToDataTable(ExcelApp.Range range, int rows, int cols)
        {
            DataTable table = new DataTable();
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                { 
                    for (int j = 1; j <= cols; j++)
                    {
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            table.Columns.Add(range.Cells[i, j].Value2.ToString());
                        else
                            table.Columns.Add(j.ToString() + ".Sütun");
                    }
                    continue;
                }
               
                var yeniSatir = table.NewRow();
                for (int j = 1; j <= cols; j++)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                    else
                        yeniSatir[j - 1] = String.Empty;
                }
                table.Rows.Add(yeniSatir);
            }
            return table;
        }
        public class StemDetail
        {
            public int id { get; set; }
            public string stem { get; set; }
            public string stem_type { get; set; }
        }

        public class RowDetail
        {
            public string key { get; set; }
            public string tag { get; set; }
        }

    }
}
