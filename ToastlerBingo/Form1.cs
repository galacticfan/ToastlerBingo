using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
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
                try
                {
                    // Debugging Code
                    //string list = String.Empty;
                    //for (int i = 0; i < listOfStrings.Length; i++)
                    //{
                    //    list += listOfStrings[i] + Environment.NewLine;
                    //}
                    //MessageBox.Show(list);

                    insertTable(document, 3);

                    // Open word
                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "tableToPrint.docx");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertTable(DocX doc, int numberTables)
        {
            int counter = 0;

            while (counter < numberTables)
            {
                string[] wordList = generateRandom();

                Table table = doc.AddTable(3, 3);
                table.Alignment = Alignment.center;

                // Add content to table
                for (int j = 0; j <= 2; j++)
                {
                    table.Rows[0].Cells[j].Paragraphs.First().Append(wordList[j]);
                }
                for (int k = 0; k <= 2; k++)
                {
                    table.Rows[1].Cells[k].Paragraphs.First().Append(wordList[k + 3]);
                }
                for (int m = 0; m <= 2; m++)
                {
                    table.Rows[2].Cells[m].Paragraphs.First().Append(wordList[m + 6]);
                }

                doc.InsertTable(table);
                insertBreak(doc);

                doc.Save();

                counter += 1;
            }
        }

        private void insertBreak(DocX doc)
        {
            Paragraph pBreak = doc.InsertParagraph("\n\n\n\n"); 
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
            string fifteen = "Mentions the importance of setting out your work correctly";
            string sixteen = "Randles interrupts lesson";
            string seventeen = "\"Not sure is not an option\"";
            string eighteen = "Stresses importance of learning material";
            string nineteen = "When you ask her for help and she gives you her undivided attention";
            string twenty = "When you ask her for a question and you don't get the answer you want";
            string twentyone = "Moves quickly and efficiently around the lab corridor";
            string twentytwo = "\"Homework help\"";
            string twentythree = "Reads what she has written on the board";
            string twentyfour = "Refers back to previous homework questions";
            
            // Random generator
            Random rnd = new Random();
            int rndNum = 0;
            int counter = 0;

            string[] currentList = new string[9];

            while (arrayCounter(currentList) < 9)
            {
                rndNum = rnd.Next(1, 25);
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
                    case 15:
                        if (alreadyUsed(currentList, fifteen) == false)
                        {
                            currentList[counter] = fifteen;
                            counter += 1;
                        }
                        break;
                    case 16:
                        if (alreadyUsed(currentList, sixteen) == false)
                        {
                            currentList[counter] = sixteen;
                            counter += 1;
                        }
                        break;
                    case 17:
                        if (alreadyUsed(currentList, seventeen) == false)
                        {
                            currentList[counter] = seventeen;
                            counter += 1;
                        }
                        break;
                    case 18:
                        if (alreadyUsed(currentList, eighteen) == false)
                        {
                            currentList[counter] = eighteen;
                            counter += 1;
                        }
                        break;
                    case 19:
                        if (alreadyUsed(currentList, nineteen) == false)
                        {
                            currentList[counter] = nineteen;
                            counter += 1;
                        }
                        break;
                    case 20:
                        if (alreadyUsed(currentList, twenty) == false)
                        {
                            currentList[counter] = twenty;
                            counter += 1;
                        }
                        break;
                    case 21:
                        if (alreadyUsed(currentList, twentyone) == false)
                        {
                            currentList[counter] = twentyone;
                            counter += 1;
                        }
                        break;
                    case 22:
                        if (alreadyUsed(currentList, twentytwo) == false)
                        {
                            currentList[counter] = twentytwo;
                            counter += 1;
                        }
                        break;
                    case 23:
                        if (alreadyUsed(currentList, twentythree) == false)
                        {
                            currentList[counter] = twentythree;
                            counter += 1;
                        }
                        break;
                    case 24:
                        if (alreadyUsed(currentList, twentyfour) == false)
                        {
                            currentList[counter] = twentyfour;
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
