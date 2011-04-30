using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    System.Drawing.Image mainImage;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private System.Drawing.Image resizeImage(System.Drawing.Image image)
    {
        Bitmap originalImage = new System.Drawing.Bitmap(image);
        int newWidth = 600;
        int newHeight = 800;
        if (kindleDXRadio.Checked == true)
        {
            newWidth = 824;
            newHeight = 1200;
        }
        else if (kindleDXRadio.Checked == false && kindleRadio.Checked == true)
        {
            //Do nothing, the width and height are already set at the correct value
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a screen resolution')</SCRIPT>");
        }

        double aspectRatio = (double)originalImage.Width / (double)originalImage.Height;

        Bitmap newImage = new Bitmap(originalImage, newWidth, newHeight);

        Graphics g = Graphics.FromImage(newImage);
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
        g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height);

        originalImage.Dispose();

        return newImage;
    }

    private System.Drawing.Image convertImageToGrayscale(System.Drawing.Image image)
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

    protected void buttonConvert_Click(object sender, EventArgs e)
    {
        if (pictureUpload.HasFile == true)
        {
            mainImage = System.Drawing.Image.FromStream(pictureUpload.FileContent);
            mainImage = resizeImage(mainImage);
            mainImage = convertImageToGrayscale(mainImage);
            Response.ContentType = "image/jpeg";
            Response.AppendHeader("Content-Disposition", "attachment; filename=ConvertedImage.jpg");
            mainImage.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please upload a file')</SCRIPT>");
        }
    }
}