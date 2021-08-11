using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace FinalProj_ParallelMergeSort
{
    public partial class MainForm : Form
    {
        private delegate void displayTextboxDelegate(string aname);
        private bool sorted = false;
        private string[] nameArray;

        public string[] NamesList   // property
        {
            get { 
                return nameArray;
            }
            set { 
                nameArray = value; 
            }
        }

        public MainForm()
        {
            InitializeComponent();
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void parButton_Click(object sender, EventArgs e)
        {
            //create string array with names
            string[] names = readInNames();

            MergeSort namesList = new MergeSort();

           
            Stopwatch par_stopwatch = Stopwatch.StartNew();

            namesList.parrallelSort(names, 0, names.Length - 1);

            par_stopwatch.Stop();

            timerLabel.Text = "Parrallel code took " + par_stopwatch.ElapsedMilliseconds +" milliseconds to execute";

            sorted = true;
            nameArray = names;


        }

        private void seqButton_Click(object sender, EventArgs e)
        {

            //create string array with names
            string[] names = readInNames();

            MergeSort namesList = new MergeSort();

            Stopwatch seq_stopwatch = Stopwatch.StartNew();

            namesList.sort(names, 0, names.Length - 1);

            seq_stopwatch.Stop();

            timerLabel.Text = "Sequential code took " + seq_stopwatch.ElapsedMilliseconds + " milliseconds to execute";

            sorted = true;
            nameArray = names;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            namesRichText.Clear();

            var thread = new Thread(populateTextbox);
            thread.IsBackground = true;
            thread.Start();
            if (thread.IsAlive == true)
                viewButton.Enabled = false;
            else
                viewButton.Enabled = true;

        }

        private void populateTextbox()
        {
            

            if (sorted == true)
            {


                foreach (string aname in nameArray)
                {
                    namesRichText.Invoke(new displayTextboxDelegate(displayTextbox), aname);

                }

            }

            else
            {
                //create string array with names
               string[] names = readInNames();

                foreach (string aname in names)
                {
                    namesRichText.Invoke(new displayTextboxDelegate(displayTextbox), aname);

                }
            }

        }
        private string[] readInNames()
        {
            string[] names = System.IO.File.ReadAllLines(@"names.txt");
            return names;
        }

        private void displayTextbox(string aname)
        {
            namesRichText.AppendText(aname + '\n');
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string[] names = readInNames();
            nameArray = names;
            timerLabel.Text = "Execution Time";
        }
    }

    public class MergeSort
    {

        internal void sort(string[] names, int left, int right)
        {
            if (left < right)
            {
                //find the middle point of the array in order to split it
                int middle = (left + right) / 2;
                //Console.WriteLine("middle is {0}", middle);

                //sort first and second halves

                sort(names, left, middle);
                sort(names, middle + 1, right);

                //merge the halves
                merge(names, left, middle, right);

            }
        }

       internal void parrallelSort(string[] names, int left, int right)
        {
            if (left < right)
            {
                //find the middle point of the array in order to split it
                int middle = (left + right) / 2;
                //Console.WriteLine("middle is {0}", middle);

                //sort first and second halves
                Parallel.Invoke(() =>
                {
                    parrallelSort(names, left, middle);
                },
                () =>
                {
                    parrallelSort(names, middle + 1, right);
                }
                );

                //merge the halves
                merge(names, left, middle, right);

            }
        }

        //function that merges the two sorted halves
        void merge(string[] names, int left, int middle, int right)
        {
            //find size of two arrays to be merged
            int sizeLeft = middle - left + 1;
            int sizeRight = right - middle;

            //create temporary arrays
            string[] leftNames = new string[sizeLeft];
            string[] rightNames = new string[sizeRight];

            //copy data to temporary arrays
            for (int i = 0; i < sizeLeft; ++i)
                leftNames[i] = names[left + i];
            for (int j = 0; j < sizeRight; ++j)
                rightNames[j] = names[middle + 1 + j];

            //merge the temporary arrays

            //create starting indexes for the two arrays
            int iterator = 0;
            int jterator = 0;

            int k = left;
            while (iterator < sizeLeft && jterator < sizeRight)
            {
                string[] leftFullName = leftNames[iterator].Split(' ');
                string[] rightFullName = rightNames[jterator].Split(' ');
                //Console.WriteLine("Left last name {0}", leftFullName[1]);

                if (String.Compare(leftFullName[1].ToUpper(), rightFullName[1].ToUpper()) == 0)
                {
                    if (String.Compare(leftFullName[0].ToUpper(), rightFullName[0].ToUpper()) < 0)
                    {
                        names[k] = leftNames[iterator];
                        iterator++;
                    }
                    else
                    {
                        names[k] = rightNames[jterator];
                        jterator++;
                    }
                }
                else
                {

                    if (String.Compare(leftFullName[1].ToUpper(), rightFullName[1].ToUpper()) < 0)
                    {
                        names[k] = leftNames[iterator];
                        iterator++;
                    }
                    else
                    {
                        names[k] = rightNames[jterator];
                        jterator++;
                    }
                }
                k++;
            }

            //Copy remaining elements of the left array, if any
            while (iterator < sizeLeft)
            {
                names[k] = leftNames[iterator];
                iterator++;
                k++;
            }

            //Copy remaining elements of the right array, if any
            while (jterator < sizeRight)
            {
                names[k] = rightNames[jterator];
                jterator++;
                k++;
            }


        }

        static void printNames(string[] names)
        {
            int n = names.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(names[i]);
            Console.WriteLine();
        }

        
    }
}
