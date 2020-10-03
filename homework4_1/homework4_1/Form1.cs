using System;
using System.Drawing;
using System.Windows.Forms;

namespace homework4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorBox.SelectedIndex = 0;
            depthValueLabel.DataBindings.Add("Text", depthSlider, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            lengthValueLabel.DataBindings.Add("Text", lengthSlider, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void drawButton_Click(object sender, EventArgs e)
            {
            if (graphics == null)
            {
                graphics = this.treePanel.CreateGraphics();
            }
            else
            {
                graphics.Clear(Color.Navy);
                graphics.Dispose();
                graphics = this.treePanel.CreateGraphics();
            }
                drawCayleyTree(depth, treePanel.Width / 2, treePanel.Height , length, -Math.PI / 2);
            }

        private Graphics graphics;
        double th1 = 45 * Math.PI / 180;
        double th2 = 45 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int length = 75;
        int depth = 8;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
            {
                if (n == 0) return;

                double x1 = x0 + leng * Math.Cos(th);
                double y1 = y0 + leng * Math.Sin(th);

                drawLine(x0, y0, x1, y1, depth-n);

                drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
                drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
            }
        void drawLine(double x0, double y0, double x1, double y1, int layer)
            {
                Pen pen1 ;
                if (colorBox.SelectedIndex == 0)
                {
                    pen1 = new Pen(Color.White, (float)(3.0 - layer * 0.3));
                    graphics.DrawLine(
                        pen1,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                }
                else if (colorBox.SelectedIndex == 1)
                {
                    pen1 = new Pen(Color.Cornsilk, (float)(3.0 - layer * 0.3));
                    graphics.DrawLine(
                        pen1,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                }
                else
                {
                    pen1 = new Pen(Color.MediumAquamarine, (float)(3.0 - layer * 0.3));
                    graphics.DrawLine(
                        pen1,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                }
            }
        private void per1Slider_ValueChanged(object sender, EventArgs e)
        {
            double sliderPercentage = Convert.ToDouble(per1Slider.Value) / Convert.ToDouble(100);
            double per1Value = 0.6 + sliderPercentage * 0.3;
            per1 = per1Value;
            per1ValueLabel.Text = per1Value.ToString("0.00");
        }
        private void per2Slider_ValueChanged(object sender, EventArgs e)
        {
            double sliderPercentage = Convert.ToDouble(per2Slider.Value) / Convert.ToDouble(100);
            double per2Value = 0.6 + sliderPercentage * 0.3;
            per2 = per2Value;
            per2ValueLabel.Text = per2Value.ToString("0.00");
        }

        private void th1Slider_ValueChanged(object sender, EventArgs e)
        {
            double sliderPercentage = Convert.ToDouble(th1Slider.Value) / Convert.ToDouble(100);
            int th1Value = Convert.ToInt32(30.0 + sliderPercentage * 30.0);
            th1 = th1Value;
            th1ValueLabel.Text = th1Value.ToString() + "°";
        }

        private void th2Slider_ValueChanged(object sender, EventArgs e)
        {
            double sliderPercentage = Convert.ToDouble(th2Slider.Value) / Convert.ToDouble(100);
            int th2Value = Convert.ToInt32(30.0 + sliderPercentage * 30.0);
            th2 = th2Value;
            th2ValueLabel.Text = th2Value.ToString() + "°";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
 }
