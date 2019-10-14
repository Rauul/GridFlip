using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace gridflip
{
    public partial class Form1 : Form
    {
        public class Driver
        {
            public string Name;
            public int Position;
            public float BestLap;

            public Driver(string name, int position, float bestLap)
            {
                Name = name;
                Position = position;
                BestLap = bestLap;
            }
        }

        List<Driver> drivers = new List<Driver>();
        string workdir;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            listBox1.Items.Clear();
            drivers.Clear();

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var filePath = new StreamReader(s[0]);
            workdir = Path.GetDirectoryName(s[0]);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(s[0]);
            XmlNodeList xnlist = xmldoc.SelectNodes("/rFactorXML/RaceResults/Race/Driver");

            foreach (XmlNode node in xnlist)
            {
                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";

                string name = node.SelectSingleNode("Name").InnerText;
                int position = Convert.ToInt32(node.SelectSingleNode("Position").InnerText);
                float bestLap = float.Parse(node.SelectSingleNode("BestLapTime").InnerText, NumberStyles.Any, ci);

                Driver driver = new Driver(name, position, bestLap);
                drivers.Add(driver);
            }

            SortList();            
        }

        void SortList()
        {
            if (comboBox1.SelectedItem.ToString() == "Position")
                drivers = drivers.OrderBy(o => o.Position).ToList();
            else if (comboBox1.SelectedItem.ToString() == "Best Lap")
                drivers = drivers.OrderBy(o => o.BestLap).ToList();

            listBox1.Items.Clear();

            foreach (Driver drv in drivers)
            {
                listBox1.Items.Add(drv.Name);
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
                return;

            Random rnd = new Random();
            int random = rnd.Next((int)lowerNumericUpDown.Value, (int)UpperNumericUpDown.Value + 1);
            string[] lines = listBox1.Items.OfType<string>().ToArray();

            if (random > lines.Length) random = lines.Length;
            Array.Reverse(lines, 0, random);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(lines);
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(workdir, "out.ini")))
            {
                int i = 1;
                foreach (string driver in listBox1.Items)
                {
                    outputFile.WriteLine("/editgrid " + i + " " + driver);
                    i++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortList();
        }
    }
}