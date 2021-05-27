
namespace RamazanArslantürk_170201025_Sheet6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Replace_btn = new System.Windows.Forms.Button();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gama_btn = new System.Windows.Forms.Button();
            this.Contrast_btn = new System.Windows.Forms.Button();
            this.Brightness_btn = new System.Windows.Forms.Button();
            this.Sharpen_8_btn = new System.Windows.Forms.Button();
            this.Sharpen_4_btn = new System.Windows.Forms.Button();
            this.Edge_8_btn = new System.Windows.Forms.Button();
            this.Edge_4_btn = new System.Windows.Forms.Button();
            this.Median_btn = new System.Windows.Forms.Button();
            this.Gaussian_btn = new System.Windows.Forms.Button();
            this.MeanFilter_btn = new System.Windows.Forms.Button();
            this.GrayScale_btn = new System.Windows.Forms.Button();
            this.Load_btn = new System.Windows.Forms.Button();
            this.pictureBox_Destination = new System.Windows.Forms.PictureBox();
            this.pictureBox_Source = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RotArbitrary_Btn = new System.Windows.Forms.Button();
            this.FlipHorizontal_Btn = new System.Windows.Forms.Button();
            this.FlipVertical_Btn = new System.Windows.Forms.Button();
            this.Rot180_Btn = new System.Windows.Forms.Button();
            this.RotMinus90_Btn = new System.Windows.Forms.Button();
            this.Rot90_Btn = new System.Windows.Forms.Button();
            this.UpScaleLinear_Btn = new System.Windows.Forms.Button();
            this.UpScaleNN_Btn = new System.Windows.Forms.Button();
            this.DownScale_Btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.LargeChange = 7;
            this.vScrollBar4.Location = new System.Drawing.Point(640, 456);
            this.vScrollBar4.Maximum = 30;
            this.vScrollBar4.Minimum = 1;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar4.TabIndex = 71;
            this.vScrollBar4.Value = 10;
            this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar4_Scroll);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(600, 455);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 29);
            this.textBox4.TabIndex = 70;
            this.textBox4.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Kernel Windows Size :";
            // 
            // Replace_btn
            // 
            this.Replace_btn.Location = new System.Drawing.Point(453, 182);
            this.Replace_btn.Name = "Replace_btn";
            this.Replace_btn.Size = new System.Drawing.Size(141, 30);
            this.Replace_btn.TabIndex = 68;
            this.Replace_btn.Text = "<==";
            this.Replace_btn.UseVisualStyleBackColor = true;
            this.Replace_btn.Click += new System.EventHandler(this.Replace_btn_Click);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.LargeChange = 7;
            this.vScrollBar3.Location = new System.Drawing.Point(640, 421);
            this.vScrollBar3.Maximum = 255;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar3.TabIndex = 67;
            this.vScrollBar3.Value = 3;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 7;
            this.vScrollBar2.Location = new System.Drawing.Point(640, 387);
            this.vScrollBar2.Maximum = 255;
            this.vScrollBar2.Minimum = -255;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar2.TabIndex = 65;
            this.vScrollBar2.Value = 3;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 2;
            this.vScrollBar1.Location = new System.Drawing.Point(306, 548);
            this.vScrollBar1.Maximum = 10;
            this.vScrollBar1.Minimum = 3;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(45, 27);
            this.vScrollBar1.SmallChange = 2;
            this.vScrollBar1.TabIndex = 58;
            this.vScrollBar1.Value = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(600, 419);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 29);
            this.textBox3.TabIndex = 66;
            this.textBox3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 385);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 29);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 548);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 29);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "3";
            // 
            // Gama_btn
            // 
            this.Gama_btn.Location = new System.Drawing.Point(453, 454);
            this.Gama_btn.Name = "Gama_btn";
            this.Gama_btn.Size = new System.Drawing.Size(141, 30);
            this.Gama_btn.TabIndex = 63;
            this.Gama_btn.Text = "Gama";
            this.Gama_btn.UseVisualStyleBackColor = true;
            this.Gama_btn.Click += new System.EventHandler(this.Gama_btn_Click);
            // 
            // Contrast_btn
            // 
            this.Contrast_btn.Location = new System.Drawing.Point(453, 419);
            this.Contrast_btn.Name = "Contrast_btn";
            this.Contrast_btn.Size = new System.Drawing.Size(141, 30);
            this.Contrast_btn.TabIndex = 62;
            this.Contrast_btn.Text = "Contrast";
            this.Contrast_btn.UseVisualStyleBackColor = true;
            this.Contrast_btn.Click += new System.EventHandler(this.Contrast_btn_Click);
            // 
            // Brightness_btn
            // 
            this.Brightness_btn.Location = new System.Drawing.Point(453, 384);
            this.Brightness_btn.Name = "Brightness_btn";
            this.Brightness_btn.Size = new System.Drawing.Size(141, 30);
            this.Brightness_btn.TabIndex = 61;
            this.Brightness_btn.Text = "Brightness";
            this.Brightness_btn.UseVisualStyleBackColor = true;
            this.Brightness_btn.Click += new System.EventHandler(this.Brightness_btn_Click);
            // 
            // Sharpen_8_btn
            // 
            this.Sharpen_8_btn.Location = new System.Drawing.Point(306, 419);
            this.Sharpen_8_btn.Name = "Sharpen_8_btn";
            this.Sharpen_8_btn.Size = new System.Drawing.Size(141, 30);
            this.Sharpen_8_btn.TabIndex = 60;
            this.Sharpen_8_btn.Text = "Sharpen 8";
            this.Sharpen_8_btn.UseVisualStyleBackColor = true;
            this.Sharpen_8_btn.Click += new System.EventHandler(this.Sharpen_8_btn_Click);
            // 
            // Sharpen_4_btn
            // 
            this.Sharpen_4_btn.Location = new System.Drawing.Point(306, 384);
            this.Sharpen_4_btn.Name = "Sharpen_4_btn";
            this.Sharpen_4_btn.Size = new System.Drawing.Size(141, 30);
            this.Sharpen_4_btn.TabIndex = 59;
            this.Sharpen_4_btn.Text = "Sharpen 4";
            this.Sharpen_4_btn.UseVisualStyleBackColor = true;
            this.Sharpen_4_btn.Click += new System.EventHandler(this.Sharpen_4_btn_Click);
            // 
            // Edge_8_btn
            // 
            this.Edge_8_btn.Location = new System.Drawing.Point(306, 491);
            this.Edge_8_btn.Name = "Edge_8_btn";
            this.Edge_8_btn.Size = new System.Drawing.Size(141, 30);
            this.Edge_8_btn.TabIndex = 57;
            this.Edge_8_btn.Text = "Edge 8";
            this.Edge_8_btn.UseVisualStyleBackColor = true;
            this.Edge_8_btn.Click += new System.EventHandler(this.Edge_8_btn_Click);
            // 
            // Edge_4_btn
            // 
            this.Edge_4_btn.Location = new System.Drawing.Point(306, 456);
            this.Edge_4_btn.Name = "Edge_4_btn";
            this.Edge_4_btn.Size = new System.Drawing.Size(141, 30);
            this.Edge_4_btn.TabIndex = 55;
            this.Edge_4_btn.Text = "Edge 4";
            this.Edge_4_btn.UseVisualStyleBackColor = true;
            this.Edge_4_btn.Click += new System.EventHandler(this.Edge_4_btn_Click);
            // 
            // Median_btn
            // 
            this.Median_btn.Location = new System.Drawing.Point(159, 454);
            this.Median_btn.Name = "Median_btn";
            this.Median_btn.Size = new System.Drawing.Size(141, 30);
            this.Median_btn.TabIndex = 54;
            this.Median_btn.Text = "Median";
            this.Median_btn.UseVisualStyleBackColor = true;
            this.Median_btn.Click += new System.EventHandler(this.Median_btn_Click);
            // 
            // Gaussian_btn
            // 
            this.Gaussian_btn.Location = new System.Drawing.Point(159, 419);
            this.Gaussian_btn.Name = "Gaussian_btn";
            this.Gaussian_btn.Size = new System.Drawing.Size(141, 30);
            this.Gaussian_btn.TabIndex = 53;
            this.Gaussian_btn.Text = "Gaussian";
            this.Gaussian_btn.UseVisualStyleBackColor = true;
            this.Gaussian_btn.Click += new System.EventHandler(this.Gaussian_btn_Click);
            // 
            // MeanFilter_btn
            // 
            this.MeanFilter_btn.Location = new System.Drawing.Point(159, 384);
            this.MeanFilter_btn.Name = "MeanFilter_btn";
            this.MeanFilter_btn.Size = new System.Drawing.Size(141, 30);
            this.MeanFilter_btn.TabIndex = 52;
            this.MeanFilter_btn.Text = "Mean Filter";
            this.MeanFilter_btn.UseVisualStyleBackColor = true;
            this.MeanFilter_btn.Click += new System.EventHandler(this.MeanFilter_btn_Click);
            // 
            // GrayScale_btn
            // 
            this.GrayScale_btn.Location = new System.Drawing.Point(12, 384);
            this.GrayScale_btn.Name = "GrayScale_btn";
            this.GrayScale_btn.Size = new System.Drawing.Size(141, 30);
            this.GrayScale_btn.TabIndex = 51;
            this.GrayScale_btn.Text = "GrayScale";
            this.GrayScale_btn.UseVisualStyleBackColor = true;
            this.GrayScale_btn.Click += new System.EventHandler(this.GrayScale_btn_Click);
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(291, 18);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(94, 29);
            this.Load_btn.TabIndex = 50;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // pictureBox_Destination
            // 
            this.pictureBox_Destination.Location = new System.Drawing.Point(688, 54);
            this.pictureBox_Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Destination.Name = "pictureBox_Destination";
            this.pictureBox_Destination.Size = new System.Drawing.Size(373, 320);
            this.pictureBox_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Destination.TabIndex = 49;
            this.pictureBox_Destination.TabStop = false;
            // 
            // pictureBox_Source
            // 
            this.pictureBox_Source.Location = new System.Drawing.Point(12, 54);
            this.pictureBox_Source.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Source.Name = "pictureBox_Source";
            this.pictureBox_Source.Size = new System.Drawing.Size(373, 320);
            this.pictureBox_Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Source.TabIndex = 48;
            this.pictureBox_Source.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(982, 571);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 22);
            this.textBox5.TabIndex = 78;
            this.textBox5.Text = "0";
            // 
            // RotArbitrary_Btn
            // 
            this.RotArbitrary_Btn.Location = new System.Drawing.Point(835, 567);
            this.RotArbitrary_Btn.Name = "RotArbitrary_Btn";
            this.RotArbitrary_Btn.Size = new System.Drawing.Size(141, 30);
            this.RotArbitrary_Btn.TabIndex = 77;
            this.RotArbitrary_Btn.Text = "Rot Arbitrary";
            this.RotArbitrary_Btn.UseVisualStyleBackColor = true;
            this.RotArbitrary_Btn.Click += new System.EventHandler(this.RotArbitrary_Btn_Click);
            // 
            // FlipHorizontal_Btn
            // 
            this.FlipHorizontal_Btn.Location = new System.Drawing.Point(835, 530);
            this.FlipHorizontal_Btn.Name = "FlipHorizontal_Btn";
            this.FlipHorizontal_Btn.Size = new System.Drawing.Size(141, 30);
            this.FlipHorizontal_Btn.TabIndex = 76;
            this.FlipHorizontal_Btn.Text = "Flip Horizontal";
            this.FlipHorizontal_Btn.UseVisualStyleBackColor = true;
            this.FlipHorizontal_Btn.Click += new System.EventHandler(this.FlipHorizontal_Btn_Click);
            // 
            // FlipVertical_Btn
            // 
            this.FlipVertical_Btn.Location = new System.Drawing.Point(835, 495);
            this.FlipVertical_Btn.Name = "FlipVertical_Btn";
            this.FlipVertical_Btn.Size = new System.Drawing.Size(141, 30);
            this.FlipVertical_Btn.TabIndex = 75;
            this.FlipVertical_Btn.Text = "Flip Vertical";
            this.FlipVertical_Btn.UseVisualStyleBackColor = true;
            this.FlipVertical_Btn.Click += new System.EventHandler(this.FlipVertical_Btn_Click);
            // 
            // Rot180_Btn
            // 
            this.Rot180_Btn.Location = new System.Drawing.Point(835, 459);
            this.Rot180_Btn.Name = "Rot180_Btn";
            this.Rot180_Btn.Size = new System.Drawing.Size(141, 30);
            this.Rot180_Btn.TabIndex = 74;
            this.Rot180_Btn.Text = "Rot 180";
            this.Rot180_Btn.UseVisualStyleBackColor = true;
            this.Rot180_Btn.Click += new System.EventHandler(this.Rot180_Btn_Click);
            // 
            // RotMinus90_Btn
            // 
            this.RotMinus90_Btn.Location = new System.Drawing.Point(835, 423);
            this.RotMinus90_Btn.Name = "RotMinus90_Btn";
            this.RotMinus90_Btn.Size = new System.Drawing.Size(141, 30);
            this.RotMinus90_Btn.TabIndex = 73;
            this.RotMinus90_Btn.Text = "Rot -90";
            this.RotMinus90_Btn.UseVisualStyleBackColor = true;
            this.RotMinus90_Btn.Click += new System.EventHandler(this.RotMinus90_Btn_Click);
            // 
            // Rot90_Btn
            // 
            this.Rot90_Btn.Location = new System.Drawing.Point(835, 387);
            this.Rot90_Btn.Name = "Rot90_Btn";
            this.Rot90_Btn.Size = new System.Drawing.Size(141, 30);
            this.Rot90_Btn.TabIndex = 72;
            this.Rot90_Btn.Text = "Rot90";
            this.Rot90_Btn.UseVisualStyleBackColor = true;
            this.Rot90_Btn.Click += new System.EventHandler(this.Rot90_Btn_Click);
            // 
            // UpScaleLinear_Btn
            // 
            this.UpScaleLinear_Btn.Location = new System.Drawing.Point(688, 454);
            this.UpScaleLinear_Btn.Name = "UpScaleLinear_Btn";
            this.UpScaleLinear_Btn.Size = new System.Drawing.Size(141, 30);
            this.UpScaleLinear_Btn.TabIndex = 81;
            this.UpScaleLinear_Btn.Text = "Up scale-Linear";
            this.UpScaleLinear_Btn.UseVisualStyleBackColor = true;
            this.UpScaleLinear_Btn.Click += new System.EventHandler(this.UpScaleLinear_Btn_Click);
            // 
            // UpScaleNN_Btn
            // 
            this.UpScaleNN_Btn.Location = new System.Drawing.Point(688, 419);
            this.UpScaleNN_Btn.Name = "UpScaleNN_Btn";
            this.UpScaleNN_Btn.Size = new System.Drawing.Size(141, 30);
            this.UpScaleNN_Btn.TabIndex = 80;
            this.UpScaleNN_Btn.Text = "Up Scale -NN";
            this.UpScaleNN_Btn.UseVisualStyleBackColor = true;
            this.UpScaleNN_Btn.Click += new System.EventHandler(this.UpScaleNN_Btn_Click);
            // 
            // DownScale_Btn
            // 
            this.DownScale_Btn.Location = new System.Drawing.Point(688, 387);
            this.DownScale_Btn.Name = "DownScale_Btn";
            this.DownScale_Btn.Size = new System.Drawing.Size(141, 30);
            this.DownScale_Btn.TabIndex = 79;
            this.DownScale_Btn.Text = "Down Scale";
            this.DownScale_Btn.UseVisualStyleBackColor = true;
            this.DownScale_Btn.Click += new System.EventHandler(this.DownScale_Btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 639);
            this.Controls.Add(this.UpScaleLinear_Btn);
            this.Controls.Add(this.UpScaleNN_Btn);
            this.Controls.Add(this.DownScale_Btn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.RotArbitrary_Btn);
            this.Controls.Add(this.FlipHorizontal_Btn);
            this.Controls.Add(this.FlipVertical_Btn);
            this.Controls.Add(this.Rot180_Btn);
            this.Controls.Add(this.RotMinus90_Btn);
            this.Controls.Add(this.Rot90_Btn);
            this.Controls.Add(this.vScrollBar4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Replace_btn);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Gama_btn);
            this.Controls.Add(this.Contrast_btn);
            this.Controls.Add(this.Brightness_btn);
            this.Controls.Add(this.Sharpen_8_btn);
            this.Controls.Add(this.Sharpen_4_btn);
            this.Controls.Add(this.Edge_8_btn);
            this.Controls.Add(this.Edge_4_btn);
            this.Controls.Add(this.Median_btn);
            this.Controls.Add(this.Gaussian_btn);
            this.Controls.Add(this.MeanFilter_btn);
            this.Controls.Add(this.GrayScale_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.pictureBox_Destination);
            this.Controls.Add(this.pictureBox_Source);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Replace_btn;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gama_btn;
        private System.Windows.Forms.Button Contrast_btn;
        private System.Windows.Forms.Button Brightness_btn;
        private System.Windows.Forms.Button Sharpen_8_btn;
        private System.Windows.Forms.Button Sharpen_4_btn;
        private System.Windows.Forms.Button Edge_8_btn;
        private System.Windows.Forms.Button Edge_4_btn;
        private System.Windows.Forms.Button Median_btn;
        private System.Windows.Forms.Button Gaussian_btn;
        private System.Windows.Forms.Button MeanFilter_btn;
        private System.Windows.Forms.Button GrayScale_btn;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.PictureBox pictureBox_Destination;
        private System.Windows.Forms.PictureBox pictureBox_Source;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button RotArbitrary_Btn;
        private System.Windows.Forms.Button FlipHorizontal_Btn;
        private System.Windows.Forms.Button FlipVertical_Btn;
        private System.Windows.Forms.Button Rot180_Btn;
        private System.Windows.Forms.Button RotMinus90_Btn;
        private System.Windows.Forms.Button Rot90_Btn;
        private System.Windows.Forms.Button UpScaleLinear_Btn;
        private System.Windows.Forms.Button UpScaleNN_Btn;
        private System.Windows.Forms.Button DownScale_Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

