using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KindleImageResizer
{
    

    public partial class Form1 : Form
    {
        String fileLocation = "";
        Image imageMain;
        String kindleType = "Kindle";

        public Form1()
        {
            InitializeComponent();
        }

        private Image resizeImage(Image image)
        {
            Bitmap originalImage = new Bitmap(image);
            int newWidth = 600;
            int newHeight = 800;

            if (kindleType == "Kindle")
            {
                //Do nothing, the height and width are already at the right values
            }
            else
            {
                newWidth = 824;
                newHeight = 1200;
            }

            double aspectRatio = (double)originalImage.Width / (double)originalImage.Height;

            Bitmap newImage = new Bitmap(originalImage, newWidth, newHeight);

            Graphics g = Graphics.FromImage(newImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height);

            originalImage.Dispose();

            return newImage; 
        }

        private Image convertImageToGrayscale(Image image)
        {
            Bitmap imageToConvert = new Bitmap(image);
            for (int y = 0; y < imageToConvert.Height; y++)
            {
                for (int x = 0; x < imageToConvert.Width; x++)
                {
                    Color colour = imageToConvert.GetPixel(x, y);
                    int luma = (int)(colour.R * 0.3 + colour.G * 0.59 + colour.B * 0.11);
                    imageToConvert.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return imageToConvert;
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "All Images|*.png;*.jpg;*.gif|PNG|*.png|JPEG|*.jpg|GIF|*.gif";
            openDialog.Title = "Open";
            if (openDialog.ShowDialog() == DialogResult.Cancel)
            {
                //TODO: Add something here so it looks important
            }
            else
            {
                fileLocation = openDialog.FileName;
                imageMain = Image.FromFile(fileLocation);
                displayBox.Image = imageMain;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            imageMain = resizeImage(imageMain);
            imageMain = convertImageToGrayscale(imageMain);
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG|.jpg";
            saveDialog.Title = "Save";
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                imageMain.Save(saveDialog.FileName);  
            }
            displayBox.Image = imageMain;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kindleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (kindleRadio.Checked == true)
            {
                dxRadio.Checked = false;
                kindleType = "Kindle";
            }
        }

        private void dxRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (dxRadio.Checked == true)
            {
                kindleRadio.Checked = false;
                kindleType = "DX";
            }
        }
    }
}
