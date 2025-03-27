using DevExpress.XtraReports.UI;
using Rhibhus.Reports.API.Services;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        // This method will handle the language setting logic and can be reused
        protected void SetLanguageForReport(string countryNameParam)
        {
            var languageData = new LanguageService().ReadJsonFromFile(countryNameParam);

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
                    }
                }
            }
        }
    }
}