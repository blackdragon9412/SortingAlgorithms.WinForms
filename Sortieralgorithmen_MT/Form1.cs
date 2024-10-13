using ScottPlot;
using System.Diagnostics;

namespace Sortieralgorithmen_MT
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            formsPlot1.Plot.Clear();
            ScottPlot.Plot myPlot = new();
            
            double[] Laufzeiten = { 2966.6, 16060, 18810, 26840, 40966.6 };
            formsPlot1.Plot.Add.Bar(position: 1, value: Laufzeiten[0]);
            formsPlot1.Plot.Add.Bar(position: 2, value: Laufzeiten[1]);
            formsPlot1.Plot.Add.Bar(position: 3, value: Laufzeiten[2]);
            formsPlot1.Plot.Add.Bar(position: 4, value: Laufzeiten[3]);
            formsPlot1.Plot.Add.Bar(position: 5, value: Laufzeiten[4]);

            
            Tick[] ticks =
            {
                        new(1, "Sort"),
                        new(2, "Quicksort"),
                        new(3, "Insertionsort"),
                        new(4, "Selektionsort"),
                        new(5, "Bubblesort")
            };

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.HideGrid();

            ScottPlot.AxisPanels.Experimental.LeftAxisWithSubtitle customAxisY = new()
            {
                LabelText ="Durchsnittliche Laufzeiten in Nanosekunden",
                

            };

            


            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.Axes.Bottom.MinorTickStyle.Length = 0;

            formsPlot1.Plot.Axes.Bottom.FrameLineStyle.Width = 0;
            formsPlot1.Plot.Axes.Right.FrameLineStyle.Width = 0;
            formsPlot1.Plot.Axes.Top.FrameLineStyle.Width = 0;

            formsPlot1.Plot.Axes.Remove(formsPlot1.Plot.Axes.Left);
            formsPlot1.Plot.Axes.AddLeftAxis(customAxisY);



            formsPlot1.Plot.Axes.Margins(bottom: 0);

            
            formsPlot1.Refresh();
            formsPlot1.Plot.SavePng("demo.png", 550, 350);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void print(int[] arr)
        {
            string ausgabe = "";

            for (int i = 0; i < arr.Length; i++)
            {



                ausgabe += arr[i];

                if (i <= arr.Length - 2)
                {
                    ausgabe += ",";
                }
                else
                {

                }


            }

            Ausgabe.Text = ausgabe;
        }

        private void Ausführen_Click(object sender, EventArgs e)
        {
            int[] arr;
            string text = Eingabe.Text;
            arr = new int[text.Length];
            string[] numb = text.Split(',');
            try
            {
                arr = Array.ConvertAll(numb, int.Parse);
            }
            catch
            {
                Form dlg1 = new Form();
                dlg1.ShowDialog();
            }



            if (Auswahl.SelectedItem as string == "Bubblesort")
            {
                Stopwatch sw = Zeit.Watch_Start();
                arr = Algo.Bubblesort(arr);
                print(arr);
                TimeSpan ts = Zeit.Watch_Stop(sw);
                Time.Text = ts.TotalNanoseconds.ToString();
            }

            if (Auswahl.SelectedItem as string == "Insertionsort")
            {
                Stopwatch sw = Zeit.Watch_Start();
                arr = Algo.Insertionsort(arr);
                print(arr);
                TimeSpan ts = Zeit.Watch_Stop(sw);
                Time.Text = ts.TotalNanoseconds.ToString();
            }

            if (Auswahl.SelectedItem as string == "Selektionsort")
            {
                Stopwatch sw = Zeit.Watch_Start();
                arr = Algo.Selectionsort(arr);
                print(arr);
                TimeSpan ts = Zeit.Watch_Stop(sw);
                Time.Text = ts.TotalNanoseconds.ToString();
            }

            if (Auswahl.SelectedItem as string == "Quicksort")
            {
                Stopwatch sw = Zeit.Watch_Start();
                arr = Algo.Quicksort(arr, 0, arr.Length - 1);
                print(arr);
                TimeSpan ts = Zeit.Watch_Stop(sw);
                Time.Text = ts.TotalNanoseconds.ToString();
            }

            if (Auswahl.SelectedItem as string == "Sort")
            {
                Stopwatch sw = Zeit.Watch_Start();
                arr = Algo.Sort(arr);
                print(arr);
                TimeSpan ts = Zeit.Watch_Stop(sw);
                Time.Text = ts.TotalNanoseconds.ToString();
            }

        }

        private void Randomgen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int anzahl = rnd.Next(1000);
            Eingabe.Text = "";

            for (int i = 0; i < anzahl; i++)
            {

                Eingabe.Text += rnd.Next(1000);

                if (i <= anzahl - 2)
                {
                    Eingabe.Text += ",";
                }
                else
                {

                }

            }

        }



        private void Einlesen_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);


                    Eingabe.Text = fileContent;


                }
            }
        }

        private void Testus_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.AutomatischerTest(10);

        }

        
    }
}