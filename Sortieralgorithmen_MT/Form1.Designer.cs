namespace Sortieralgorithmen_MT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ausführen = new Button();
            Auswahl = new ComboBox();
            Eingabe = new TextBox();
            Ausgabe = new Label();
            Randomgen = new Button();
            openFileDialog1 = new OpenFileDialog();
            Einlesen = new Button();
            Time = new Label();
            Testus = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // Ausführen
            // 
            Ausführen.Location = new Point(466, 129);
            Ausführen.Name = "Ausführen";
            Ausführen.Size = new Size(75, 23);
            Ausführen.TabIndex = 1;
            Ausführen.Text = "Ausführen";
            Ausführen.UseVisualStyleBackColor = true;
            Ausführen.Click += Ausführen_Click;
            // 
            // Auswahl
            // 
            Auswahl.AllowDrop = true;
            Auswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            Auswahl.FormattingEnabled = true;
            Auswahl.Items.AddRange(new object[] { "Bubblesort", "Insertionsort", "Selektionsort", "Quicksort", "Sort" });
            Auswahl.Location = new Point(321, 129);
            Auswahl.Name = "Auswahl";
            Auswahl.Size = new Size(121, 23);
            Auswahl.TabIndex = 2;
            // 
            // Eingabe
            // 
            Eingabe.Location = new Point(72, 176);
            Eingabe.Name = "Eingabe";
            Eingabe.Size = new Size(652, 23);
            Eingabe.TabIndex = 3;
            Eingabe.Text = "Eingabe";
            // 
            // Ausgabe
            // 
            Ausgabe.Enabled = false;
            Ausgabe.Location = new Point(72, 212);
            Ausgabe.Name = "Ausgabe";
            Ausgabe.Size = new Size(452, 120);
            Ausgabe.TabIndex = 4;
            Ausgabe.Text = "Ausgabe";
            // 
            // Randomgen
            // 
            Randomgen.Location = new Point(219, 128);
            Randomgen.Name = "Randomgen";
            Randomgen.Size = new Size(75, 23);
            Randomgen.TabIndex = 5;
            Randomgen.Text = "Random";
            Randomgen.UseVisualStyleBackColor = true;
            Randomgen.Click += Randomgen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Einlesen
            // 
            Einlesen.Location = new Point(72, 117);
            Einlesen.Name = "Einlesen";
            Einlesen.Size = new Size(126, 34);
            Einlesen.TabIndex = 6;
            Einlesen.Text = "Datei einlesen";
            Einlesen.UseVisualStyleBackColor = true;
            Einlesen.Click += Einlesen_Click;
            // 
            // Time
            // 
            Time.Location = new Point(74, 34);
            Time.Name = "Time";
            Time.Size = new Size(650, 55);
            Time.TabIndex = 7;
            Time.Text = "Time";
            // 
            // Testus
            // 
            Testus.Location = new Point(575, 288);
            Testus.Name = "Testus";
            Testus.Size = new Size(75, 23);
            Testus.TabIndex = 8;
            Testus.Text = "testus";
            Testus.UseVisualStyleBackColor = true;
            Testus.Click += Testus_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(683, 288);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(584, 418);
            formsPlot1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 747);
            Controls.Add(formsPlot1);
            Controls.Add(Testus);
            Controls.Add(Time);
            Controls.Add(Einlesen);
            Controls.Add(Randomgen);
            Controls.Add(Ausgabe);
            Controls.Add(Eingabe);
            Controls.Add(Auswahl);
            Controls.Add(Ausführen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button Ausführen;
        private ComboBox Auswahl;
        private TextBox Eingabe;
        private Label Ausgabe;
        private Button Randomgen;
        private OpenFileDialog openFileDialog1;
        private Button Einlesen;
        private Label Time;
        private Button Testus;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
