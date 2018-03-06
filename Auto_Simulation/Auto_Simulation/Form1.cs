using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto_Simulation
{
    public partial class Form1 : Form
    {
        string info = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Auto_erstellen_Click(object sender, EventArgs e)
        {
            Auto A1 = new Auto(Marke.Text, Farbe.Text, Int32.Parse(PS.Text), Int32.Parse(Tankgröße.Text), Int32.Parse(Verbrauch.Text));
            InfoBox.Text = A1.Info(info);
        }

        private void Tanken_Click(object sender, EventArgs e)
        {

        }

        private void Fahren_Click(object sender, EventArgs e)
        {

        }
    }

    class Auto
    {
        private string marke, farbe;
        private int ps, tankgr, verbrauch, km;

        public Auto(string Marke, string Farbe, int PS, int Tankgr, int Verbrauch)
        {
            this.marke = Marke;
            this.farbe = Farbe;
            this.ps = PS;
            this.tankgr = Tankgr;
            this.verbrauch = Verbrauch;
        }

        public string Info(string Info)
        {
            Info = "Marke: " + this.marke + "\n";
            Info += "gefahren: " + km + "\n";
            Info += "Farbe: " + this.farbe + "\n";
            Info += "PS: " + this.ps + "\n";
            //Info += "Tankinhalt: " +  + "\n";
            //Info += "Reichweite: " +  + "\n";
            return Info;
        }

        public void gefahren(int Km)
        {
            km += Km;
        }
    }
}