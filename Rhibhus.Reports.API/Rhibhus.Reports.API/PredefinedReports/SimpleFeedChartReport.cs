using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class SimpleFeedChartReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SimpleFeedChartReport()
        {
            InitializeComponent();

			xrPictureBox1.BeforePrint += xrPictureBox1_BeforePrint;

		}

		private void xrPictureBox1_BeforePrint(object sender, CancelEventArgs e)
		{
			try
			{
				XRPictureBox pictureBox = sender as XRPictureBox;
				if (pictureBox == null) return;


				string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "signatures", "signature.png");

				if (File.Exists(imagePath))
				{
					// Convert Image to byte array and set it
					pictureBox.Image = ConvertImageToBitmap(imagePath);
					pictureBox.Sizing = ImageSizeMode.ZoomImage;
				}
				else
				{
					CreatePlaceholderImage(pictureBox);
				}
			}
			catch (Exception ex)
			{
				CreatePlaceholderImage(sender as XRPictureBox);
			}
		}

		private Bitmap ConvertImageToBitmap(string imagePath)
		{
			using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
			{
				return new Bitmap(fs);
			}
		}

		// Create a Placeholder Image
		private void CreatePlaceholderImage(XRPictureBox pictureBox)
		{
			if (pictureBox == null) return;

			Bitmap bitmap = new Bitmap(200, 100);
			using (Graphics g = Graphics.FromImage(bitmap))
			{
				g.Clear(Color.White);
				g.DrawString("Signature Not Found", new Font("Arial", 10), Brushes.Black, 10, 40);
				g.DrawRectangle(Pens.Black, 0, 0, 199, 99);
			}

			pictureBox.Image = bitmap;
		}
	}
}
