using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Геодезия
{
    public partial class Form1 : Form
    {
        Measurements inputedMeasures = new Measurements();
        Measurements loadedMeasures = new Measurements();
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt, *.doc, *.docx)|*.txt; *.doc; *.docx;";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string str;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Measurements));

                    XmlReader reader = XmlReader.Create(openFileDialog1.OpenFile());
                    this.loadedMeasures = (Measurements)ser.Deserialize(reader);
                    MessageBox.Show("Измерения успешно загружены из файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить данные из файла");
                }
            }
        }

        private void AddPointBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(XTtextBox.Text) || String.IsNullOrEmpty(YTextBox.Text) || string.IsNullOrEmpty(SecondsTextBox.Text))
            {
                ShowError();
                return;
            }
            try
            {
                double x = double.Parse(XTtextBox.Text);
                double y = double.Parse(YTextBox.Text);
                double seconds = double.Parse(SecondsTextBox.Text);
                inputedMeasures.points.Add(new EmitPoint { X = x, Y = y, Seconds = seconds });
                label2.Text = "Points added: " + inputedMeasures.points.Count;
                WritePointsToFileBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введены измерения");
            }




        }
        async private void ShowError()
        {
            //Task<string> t = new Task<string>.Run();
            Task<bool> t = Task.Run(() =>
            {
                Thread.Sleep(1500);
                return false;
            });
            Label lbl = new Label { Text = "Не заполнены все поля" };
            lbl.AutoSize = true;
            lbl.BringToFront();
            lbl.Visible = true;
            lbl.Location = new Point(XTtextBox.Location.X, 113);
            lbl.ForeColor = Color.Red;
            lbl.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.Controls.Add(lbl);
            lbl.Visible = await t;
        }

        private void WritePointsToFileBtn_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Measurements));

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    ser.Serialize(writer, this.inputedMeasures);
                }
                MessageBox.Show("Данные были успешно записаны в файл");
            }
        }
        public class Measurements
        {
            public List<EmitPoint> points = new List<EmitPoint>();
        }
        public class EmitPoint
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Seconds { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.loadedMeasures == null)
            {
                MessageBox.Show("Не загружены данные из файла");
                return;
            }
            if (this.loadedMeasures.points.Count == 1)
            {
                MessageBox.Show("1-ого измерения недостаточно для расчётов");
                return;
            }
            var deltaX = Math.Sqrt(Math.Pow(this.loadedMeasures.points[0].X - this.loadedMeasures.points[1].X, 2) + Math.Pow(this.loadedMeasures.points[0].Y - this.loadedMeasures.points[1].Y, 2));
            var r1 = DistanceFromSignalTime(3000000D,this.loadedMeasures.points[0].Seconds);
            var r2 = DistanceFromSignalTime(3000000D, this.loadedMeasures.points[1].Seconds);

            var angleAlpha = Math.Acos((Math.Pow(deltaX, 2) + Math.Pow(r1, 2) - Math.Pow(r2, 2)) / (2 * deltaX * r1));
            //Вектор направления от т. А до т. C
            var Vx = Math.Cos(angleAlpha);
            var Vy = -Math.Sin(angleAlpha);
            
            var Cx = r1 * Vx + this.loadedMeasures.points[0].X;
            var Cy = r1 * Vy + this.loadedMeasures.points[0].Y;
            label5.Visible = true;
            label5.Text = "Координаты скважины:\nX: " + Cx + "\nY:" + Cy;
        }
        private double DistanceFromSignalTime(double lightSpeed, double seconds)
        {
            return lightSpeed*seconds/2;
        }
    }
}
