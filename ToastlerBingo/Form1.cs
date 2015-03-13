using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;

namespace ToastlerBingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Create("tableToPrint.docx")) // create doc
            {
                Table table = document.AddTable(3, 3);
                table.Alignment = Alignment.center;

                // Add content to table
                table.Rows[0].Cells[0].Paragraphs.First().Append("A");
                table.Rows[0].Cells[1].Paragraphs.First().Append("B");
                table.Rows[0].Cells[2].Paragraphs.First().Append("C");
                table.Rows[1].Cells[0].Paragraphs.First().Append("D");
                table.Rows[1].Cells[1].Paragraphs.First().Append("E");
                table.Rows[1].Cells[2].Paragraphs.First().Append("F");
                table.Rows[2].Cells[0].Paragraphs.First().Append("D");
                table.Rows[2].Cells[1].Paragraphs.First().Append("E");
                table.Rows[2].Cells[2].Paragraphs.First().Append("F");

                document.InsertTable(table);
                document.Save();
            }
        }

        private string generateRandom()
        {

        }
    }
}
