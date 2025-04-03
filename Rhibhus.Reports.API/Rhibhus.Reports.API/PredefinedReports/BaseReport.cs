using DevExpress.XtraReports.UI;
using Rhibhus.Reports.API.Services;
using System.Diagnostics;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        // This method will handle the language setting logic and can be reused
        protected void SetLanguageForReport(string countryNameParam)
        {
            var languageData = new LanguageService().ReadJsonFromFile(countryNameParam);
            var totalControls = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            #region Type 1

            //foreach (XRLabel control in this.Bands.OfType<DetailBand>().SelectMany(b => b.Controls.OfType<XRLabel>()))
            //{
            //    var value = languageData.GetValue(control.Text)?.ToString();

            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        control.Text = value;
            //    }
            //}

            #endregion

            #region Type 2

            //this.Bands.OfType<DetailBand>().SelectMany(b => b.Controls.OfType<XRLabel>()).ToList().ForEach(control => 
            //{ 
            //    if (languageData.GetValue(control.Text) is string value && !string.IsNullOrEmpty(value)) control.Text = value; 
            //});

            #endregion

            // Iterate through each band in the collection
            foreach (Band band in this.Bands.OfType<DetailBand>())
            {
                // Iterate through all controls in the current band
                foreach (XRLabel control in band.Controls.OfType<XRLabel>())
                {
                    // Retrieve the corresponding text from the language data
                    var value = languageData.GetValue(control.Text)?.ToString();

                    if (!string.IsNullOrEmpty(value))
                    {
                        // Set the text of the header cell
                        control.Text = value;
                        totalControls++;
                    }
                }
            }

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time: " + elapsed);
            Console.WriteLine($"Elapsed Time in milliseconds: {elapsed.TotalMilliseconds}, Total Controls: {totalControls}");
        }
    }
}
