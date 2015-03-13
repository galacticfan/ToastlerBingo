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

                // temp
                try
                {
                    string[] listOfStrings = generateRandom();
                    string list = String.Empty;
                    for (int i = 0; i < listOfStrings.Length; i++)
                    {
                        list += listOfStrings[i] + Environment.NewLine;
                    }
                    MessageBox.Show(list);    
                    //MessageBox.Show(listOfStrings[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private string[] generateRandom()
        {
            // Reference strings
            string one = "\"This is for your notes\"";
            string two = "\"Don\'t write this down\"";
            string three = "\"Does everyone agree?\"";
            string four = "Hands out hand-outs really quickly";
            string five = "Starts writing at the top of the board";
            string six = "\"File paper please\"";
            string seven = "Starts talking about son";
            string eight = "Mentions her bad memory";
            string nine = "Finishes lessons 5 minutes late";
            string ten = "Forgets names";
            string eleven = "Uses colour rings";
            string twelve = "Uses the ruler on the board";
            string thirteen = "Talks to Randles";
            string fourteen = "Gives you hand out as you walk in the lesson";

            Random rnd = new Random();
            int rndNum = 0;
            int counter = 0;

            string[] currentList = new string[9];

            while (arrayCounter(currentList) < 9)
            {
                rndNum = rnd.Next(1, 15);
                switch(rndNum)
                {
                    case 1:
                        if (alreadyUsed(currentList, one) == false)
                        {
                            currentList[counter] = one;
                            counter += 1;
                        }
                        break;
                    case 2:
                        if (alreadyUsed(currentList, two) == false)
                        {
                            currentList[counter] = two;
                            counter += 1;
                        }
                        break;
                    case 3:
                        if (alreadyUsed(currentList, three) == false)
                        {
                            currentList[counter] = three;
                            counter += 1;
                        }
                        break;
                    case 4:
                        if (alreadyUsed(currentList, four) == false)
                        {
                            currentList[counter] = four;
                            counter += 1;
                        }
                        break;
                    case 5:
                        if (alreadyUsed(currentList, five) == false)
                        {
                            currentList[counter] = five;
                            counter += 1;
                        }
                        break;
                    case 6:
                        if (alreadyUsed(currentList, six) == false)
                        {
                            currentList[counter] = six;
                            counter += 1;
                        }
                        break;
                    case 7:
                        if (alreadyUsed(currentList, seven) == false)
                        {
                            currentList[counter] = seven;
                            counter += 1;
                        }
                        break;
                    case 8:
                        if (alreadyUsed(currentList, eight) == false)
                        {
                            currentList[counter] = eight;
                            counter += 1;
                        }
                        break;
                    case 9:
                        if (alreadyUsed(currentList, nine) == false)
                        {
                            currentList[counter] = nine;
                            counter += 1;
                        }
                        break;
                    case 10:
                        if (alreadyUsed(currentList, ten) == false)
                        {
                            currentList[counter] = ten;
                            counter += 1;
                        }
                        break;
                    case 11:
                        if (alreadyUsed(currentList, eleven) == false)
                        {
                            currentList[counter] = eleven;
                            counter += 1;
                        }
                        break;
                    case 12:
                        if (alreadyUsed(currentList, twelve) == false)
                        {
                            currentList[counter] = twelve;
                            counter += 1;
                        }
                        break;
                    case 13:
                        if (alreadyUsed(currentList, thirteen) == false)
                        {
                            currentList[counter] = thirteen;
                            counter += 1;
                        }
                        break;
                    case 14:
                        if (alreadyUsed(currentList, fourteen) == false)
                        {
                            currentList[counter] = fourteen;
                            counter += 1;
                        }
                        break;
                }
            }

            return currentList;
        }

        private bool alreadyUsed(string[] inputArray, string phrase)
        {
            bool hasBeenUsed = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == phrase)
                {
                    hasBeenUsed = true;
                    break;
                }
            }

            return hasBeenUsed;
        }

        private int arrayCounter(string[] inputArray)
        {
            int length = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == null)
                    break;
                else
                    length += 1;
            }
            return length;
        }
    }
}
