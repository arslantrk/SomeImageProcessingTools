using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamazanArslantürk_170201025_Sheet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap Source_Image, Destination_Image, Temp_Image;
        void Bubble_Sort(ref int[] v, int N)
        {
            int i, j, temp;
            for (i = 1; i < N; i++)
                for (j = 0; j < N - i; j++)
                    if (v[j] > v[j + 1])
                    {
                        temp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = temp;
                    }
        }
        private void Convolution(Bitmap source_image, ref Bitmap destination_image, double[,] kernel, int window_size)
        {
            int frame = window_size / 2;

            for (int x = frame; x < source_image.Width - frame; x++)
                for (int y = frame; y < source_image.Height - frame; y++)
                {
                    double result_R = 0;
                    double result_G = 0;
                    double result_B = 0;

                    for (int i = 0; i < window_size; i++)
                        for (int j = 0; j < window_size; j++)
                        {
                            result_R += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).R;
                            result_G += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).G;
                            result_B += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).B;
                        }

                    destination_image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }
        }

        private void Convolution(Bitmap source_image, ref Bitmap destination_image, double[,] kernel)
        {
            int window_size = 3;
            int frame = window_size / 2;

            for (int x = frame; x < source_image.Width - frame; x++)
                for (int y = frame; y < source_image.Height - frame; y++)
                {
                    double result_R = 0;
                    double result_G = 0;
                    double result_B = 0;

                    for (int i = 0; i < window_size; i++)
                        for (int j = 0; j < window_size; j++)
                        {
                            result_R += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).R;
                            result_G += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).G;
                            result_B += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).B;
                        }

                    destination_image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }
        }
        private void Convolution2(Bitmap source_image, ref Bitmap destination_image, int[,] kernel, int window_size)
        {
            int frame = window_size / 2;

            for (int x = frame; x < source_image.Width - frame; x++)
                for (int y = frame; y < source_image.Height - frame; y++)
                {
                    double result_R = 0;
                    double result_G = 0;
                    double result_B = 0;

                    for (int i = 0; i < window_size; i++)
                        for (int j = 0; j < window_size; j++)
                        {
                            result_R += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).R;
                            result_G += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).G;
                            result_B += kernel[i, j] * source_image.GetPixel(x + i - frame, y + j - frame).B;
                        }

                    if (result_R > 255) result_R = 255; else if (result_R < 0) result_R = 0;
                    if (result_G > 255) result_G = 255; else if (result_G < 0) result_G = 0;
                    if (result_B > 255) result_B = 255; else if (result_B < 0) result_B = 0;

                    destination_image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }
        }
        private void Load_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string File_Name = openFileDialog1.FileName.Trim();
            try
            {
                if (File_Name != "") pictureBox_Source.Load(File_Name);
                Source_Image = new Bitmap(File_Name);
                Destination_Image = new Bitmap(Source_Image.Width, Source_Image.Height);
                Temp_Image = new Bitmap(Source_Image.Width, Source_Image.Height);
            }
            catch
            {
                MessageBox.Show("Error in File Type");
            }
        }

        private void Replace_btn_Click(object sender, EventArgs e)
        {
            Source_Image = Destination_Image;
            pictureBox_Source.Image = Source_Image;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();
        }

        private void GrayScale_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Source_Image.Width; i++)
                for (int j = 0; j < Source_Image.Height; j++)
                {
                    int RR = Source_Image.GetPixel(i, j).R;
                    int GG = Source_Image.GetPixel(i, j).G;
                    int BB = Source_Image.GetPixel(i, j).B;

                    int Gray = (RR + GG + BB) / 3;
                    Destination_Image.SetPixel(i, j, Color.FromArgb(Gray, Gray, Gray));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void MeanFilter_btn_Click(object sender, EventArgs e)
        {
            //Mean
            int Window_Size = vScrollBar1.Value;
            double[,] Kernel = new double[Window_Size, Window_Size];

            for (int i = 0; i < Window_Size; i++)
                for (int j = 0; j < Window_Size; j++)
                    Kernel[i, j] = 1.0 / (Window_Size * Window_Size);

            Convolution(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;
        }

        private void Gaussian_btn_Click(object sender, EventArgs e)
        {
            //Gaussian
            int Window_Size = vScrollBar1.Value;
            double[,] Kernel = new double[Window_Size, Window_Size];

            for (int i = 0; i < Window_Size; i++)
                for (int j = 0; j < Window_Size; j++)
                {
                    int x = Window_Size / 2 - i;
                    int y = Window_Size / 2 - j;
                    Kernel[i, j] = 1.0 / (2 * Math.PI) * Math.Exp(-(x * x + y * y) / 2.0);
                }

            Convolution(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;
        }

        private void Median_btn_Click(object sender, EventArgs e)
        {
            //Median
            int Window_Size = vScrollBar1.Value;
            int[] Median_Vector_R = new int[Window_Size * Window_Size];
            int[] Median_Vector_G = new int[Window_Size * Window_Size];
            int[] Median_Vector_B = new int[Window_Size * Window_Size];

            int frame = Window_Size / 2;
            int V = 0;

            for (int x = frame; x < Source_Image.Width - frame; x++)
                for (int y = frame; y < Source_Image.Height - frame; y++)
                {
                    V = 0;
                    //1-Get vectors
                    for (int i = 0; i < Window_Size; i++)
                        for (int j = 0; j < Window_Size; j++)
                        {
                            Median_Vector_R[V] = Source_Image.GetPixel(x + i - frame, y + j - frame).R;
                            Median_Vector_G[V] = Source_Image.GetPixel(x + i - frame, y + j - frame).G;
                            Median_Vector_B[V] = Source_Image.GetPixel(x + i - frame, y + j - frame).B;
                            V++;
                        }

                    //2-Sort vectors

                    Bubble_Sort(ref Median_Vector_R, Window_Size * Window_Size);
                    Bubble_Sort(ref Median_Vector_G, Window_Size * Window_Size);
                    Bubble_Sort(ref Median_Vector_B, Window_Size * Window_Size);


                    //3-pic mid point of sorted vector and assign it to DESTINATION_IMAGE
                    int RR = Median_Vector_R[Window_Size * Window_Size / 2 + 1];
                    int GG = Median_Vector_R[Window_Size * Window_Size / 2 + 1];
                    int BB = Median_Vector_R[Window_Size * Window_Size / 2 + 1];

                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)RR, (int)GG, (int)BB));

                }

            //Convolution(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;

        }

        private void Edge_4_btn_Click(object sender, EventArgs e)
        {
            //Edge 4
            int Window_Size = 3;
            int[,] Kernel = new int[Window_Size, Window_Size];
            Kernel[0, 0] = 0; Kernel[0, 1] = -1; Kernel[0, 2] = 0;
            Kernel[1, 0] = -1; Kernel[1, 1] = 4; Kernel[1, 2] = -1;
            Kernel[2, 0] = 0; Kernel[2, 1] = -1; Kernel[2, 2] = 0;

            Convolution2(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;
        }

        private void Edge_8_btn_Click(object sender, EventArgs e)
        {
            //Edge 8
            int Window_Size = 3;
            int[,] Kernel = new int[Window_Size, Window_Size];
            Kernel[0, 0] = -1; Kernel[0, 1] = -1; Kernel[0, 2] = -1;
            Kernel[1, 0] = -1; Kernel[1, 1] = 8; Kernel[1, 2] = -1;
            Kernel[2, 0] = -1; Kernel[2, 1] = -1; Kernel[2, 2] = -1;

            Convolution2(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;
        }

        private void Sharpen_4_btn_Click(object sender, EventArgs e)
        {
            //Sharpen 4
            int Window_Size = 3;
            int[,] Kernel = new int[Window_Size, Window_Size];
            Kernel[0, 0] = 0; Kernel[0, 1] = -1; Kernel[0, 2] = 0;
            Kernel[1, 0] = -1; Kernel[1, 1] = 5; Kernel[1, 2] = -1;
            Kernel[2, 0] = 0; Kernel[2, 1] = -1; Kernel[2, 2] = 0;

            Convolution2(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;

        }

        private void Sharpen_8_btn_Click(object sender, EventArgs e)
        {
            //Sharpen 8
            int Window_Size = 3;
            int[,] Kernel = new int[Window_Size, Window_Size];
            Kernel[0, 0] = -1; Kernel[0, 1] = -1; Kernel[0, 2] = -1;
            Kernel[1, 0] = -1; Kernel[1, 1] = 9; Kernel[1, 2] = -1;
            Kernel[2, 0] = -1; Kernel[2, 1] = -1; Kernel[2, 2] = -1;

            Convolution2(Source_Image, ref Destination_Image, Kernel, Window_Size);

            pictureBox_Destination.Image = Destination_Image;
        }

        private void Brightness_btn_Click(object sender, EventArgs e)
        {
            //Brightness
            int Brigthness_Value = vScrollBar2.Value;
            for (int x = 0; x < Source_Image.Width; x++)
                for (int y = 0; y < Source_Image.Height; y++)
                {
                    int result_R = Source_Image.GetPixel(x, y).R + Brigthness_Value;
                    int result_G = Source_Image.GetPixel(x, y).G + Brigthness_Value;
                    int result_B = Source_Image.GetPixel(x, y).B + Brigthness_Value;

                    if (result_R > 255) result_R = 255; else if (result_R < 0) result_R = 0;
                    if (result_G > 255) result_G = 255; else if (result_G < 0) result_G = 0;
                    if (result_B > 255) result_B = 255; else if (result_B < 0) result_B = 0;

                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }

            pictureBox_Destination.Image = Destination_Image;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = vScrollBar2.Value.ToString();
        }

        private void Contrast_btn_Click(object sender, EventArgs e)
        {
            //Contrast
            int Contrast_Value = vScrollBar3.Value;
            double F = (259 * (Contrast_Value + 255)) / (255 * (259 - Contrast_Value));

            for (int x = 0; x < Source_Image.Width; x++)
                for (int y = 0; y < Source_Image.Height; y++)
                {
                    int result_R = (int)Math.Round(F * (Source_Image.GetPixel(x, y).R - 128) + 128);
                    int result_G = (int)Math.Round(F * (Source_Image.GetPixel(x, y).G - 128) + 128);
                    int result_B = (int)Math.Round(F * (Source_Image.GetPixel(x, y).B - 128) + 128);

                    if (result_R > 255) result_R = 255; else if (result_R < 0) result_R = 0;
                    if (result_G > 255) result_G = 255; else if (result_G < 0) result_G = 0;
                    if (result_B > 255) result_B = 255; else if (result_B < 0) result_B = 0;

                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }

            pictureBox_Destination.Image = Destination_Image;
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = vScrollBar3.Value.ToString();
        }

        private void Gama_btn_Click(object sender, EventArgs e)
        {
            //Gama Correction
            double Gama_Value = vScrollBar4.Value / 10.0;
            for (int x = 0; x < Source_Image.Width; x++)
                for (int y = 0; y < Source_Image.Height; y++)
                {
                    int result_R = (int)Math.Round(255 * Math.Pow(Source_Image.GetPixel(x, y).R / 255.0, 1 / Gama_Value));
                    int result_G = (int)Math.Round(255 * Math.Pow(Source_Image.GetPixel(x, y).G / 255.0, 1 / Gama_Value));
                    int result_B = (int)Math.Round(255 * Math.Pow(Source_Image.GetPixel(x, y).B / 255.0, 1 / Gama_Value));

                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result_R, (int)result_G, (int)result_B));
                }

            pictureBox_Destination.Image = Destination_Image;
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            textBox4.Text = (vScrollBar4.Value / 10.0).ToString();
        }

        private void DownScale_Btn_Click(object sender, EventArgs e)
        {
            Destination_Image.SetResolution(pictureBox_Source.Width / 2, pictureBox_Source.Height / 2);
            for (int x = 1; x < pictureBox_Source.Image.Width - 2; x += 2)
                for (int y = 1; y < pictureBox_Source.Image.Height - 2; y += 2)
                {
                    int RR = (Source_Image.GetPixel(x, y).R + Source_Image.GetPixel(x + 1, y).R +
                        Source_Image.GetPixel(x, y + 1).R + Source_Image.GetPixel(x + 1, y + 1).R) / 4;
                    int GG = (Source_Image.GetPixel(x, y).G + Source_Image.GetPixel(x + 1, y).G +
                        Source_Image.GetPixel(x, y + 1).G + Source_Image.GetPixel(x + 1, y + 1).G) / 4;
                    int BB = (Source_Image.GetPixel(x, y).B + Source_Image.GetPixel(x + 1, y).B +
                        Source_Image.GetPixel(x, y + 1).B + Source_Image.GetPixel(x + 1, y + 1).B) / 4;

                    Destination_Image.SetPixel(x / 2, y / 2, Color.FromArgb(RR, GG, BB));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void UpScaleNN_Btn_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < (pictureBox_Source.Image.Width - 2) / 2; x++)

                for (int y = 1; y < (pictureBox_Source.Image.Height - 2) / 2; y++)
                {
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;

                    Destination_Image.SetPixel(x * 2, y * 2, Color.FromArgb(RR, GG, BB));
                    Destination_Image.SetPixel(x * 2 + 1, y * 2, Color.FromArgb(RR, GG, BB));
                    Destination_Image.SetPixel(x * 2, y * 2 + 1, Color.FromArgb(RR, GG, BB));
                    Destination_Image.SetPixel(x * 2 + 1, y * 2 + 1, Color.FromArgb(RR, GG, BB));

                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void UpScaleLinear_Btn_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < (pictureBox_Source.Image.Width - 2) / 2; x++)
                for (int y = 1; y < (pictureBox_Source.Image.Height - 2) / 2; y++)
                {
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;

                    Temp_Image.SetPixel(x * 2, y * 2, Color.FromArgb(RR, GG, BB));
                    Temp_Image.SetPixel(x * 2 + 1, y * 2, Color.FromArgb(RR, GG, BB));
                    Temp_Image.SetPixel(x * 2, y * 2 + 1, Color.FromArgb(RR, GG, BB));
                    Temp_Image.SetPixel(x * 2 + 1, y * 2 + 1, Color.FromArgb(RR, GG, BB));

                }

            double[,] Kernel = new double[3, 3];
            Kernel[0, 0] = 0.0275; Kernel[0, 1] = 0.1102; Kernel[0, 2] = 0.0275;
            Kernel[1, 0] = 0.1102; Kernel[1, 1] = 0.4421; Kernel[1, 2] = 0.1102;
            Kernel[2, 0] = 0.0275; Kernel[2, 1] = 0.1102; Kernel[2, 2] = 0.0275;

            for (int x = 1; x < pictureBox_Source.Image.Width - 1; x++)
                for (int y = 1; y < pictureBox_Source.Image.Height - 1; y++)
                {
                    double result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)

                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Temp_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                    //Assign to new image
                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result, (int)result, (int)result));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void Rot90_Btn_Click(object sender, EventArgs e)
        {
            Bitmap new_bmp = new Bitmap(pictureBox_Source.Image.Height, pictureBox_Source.Image.Width);
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = y;
                    int y_ = pictureBox_Source.Image.Width - 1 - x;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    new_bmp.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                }
            Destination_Image = new_bmp;
            pictureBox_Destination.Image = Destination_Image;
        }

        private void RotMinus90_Btn_Click(object sender, EventArgs e)
        {
            Bitmap new_bmp = new Bitmap(pictureBox_Source.Image.Height, pictureBox_Source.Image.Width);
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = pictureBox_Source.Image.Height - 1 - y;
                    int y_ = x;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    new_bmp.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                }
            Destination_Image = new_bmp;
            pictureBox_Destination.Image = Destination_Image;
        }

        private void Rot180_Btn_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = pictureBox_Source.Image.Width - 1 - x;
                    int y_ = pictureBox_Source.Image.Height - 1 - y;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    Destination_Image.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void FlipVertical_Btn_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = x;
                    int y_ = pictureBox_Source.Image.Height - 1 - y;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    Destination_Image.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void FlipHorizontal_Btn_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = pictureBox_Source.Image.Width - 1 - x;
                    int y_ = y;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    Destination_Image.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                }
            pictureBox_Destination.Image = Destination_Image;
        }

        private void RotArbitrary_Btn_Click(object sender, EventArgs e)
        {
            double th;
            double.TryParse(textBox5.Text, out th);
            th = th / 180.0 * Math.PI;
            int x0 = pictureBox_Source.Image.Width / 2;
            int y0 = pictureBox_Source.Image.Height / 2;
            for (int x = 0; x < pictureBox_Source.Image.Width; x++)
                for (int y = 0; y < pictureBox_Source.Image.Height; y++)
                {
                    int x_ = (int)Math.Round(Math.Cos(th) * (x - x0) + Math.Sin(th) * (y - y0));
                    int y_ = (int)Math.Round(-Math.Sin(th) * (x - x0) + Math.Cos(th) * (y - y0));
                    x_ = x0 + x_;
                    y_ = y0 + y_;
                    int RR = Source_Image.GetPixel(x, y).R;
                    int GG = Source_Image.GetPixel(x, y).G;
                    int BB = Source_Image.GetPixel(x, y).B;
                    if ((x_ >= 0) && (x_ < Destination_Image.Width) && (y_ >= 0) && (y_ < Destination_Image.Height))
                    {
                        Destination_Image.SetPixel(x_, y_, Color.FromArgb(RR, GG, BB));
                    }

                }
            pictureBox_Destination.Image = Destination_Image;
        }
    }
}
