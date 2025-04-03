using System;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class DynamicJsonReport : XtraReport
    {
        public DynamicJsonReport()
        {
            InitializeComponent();
            AddHiLabel();
        }

        private void AddHiLabel()
        {
            XRLabel label = new XRLabel
            {
                Text = "Hi",
                // Position in the report
               
            };

            this.Bands[BandKind.Detail].Controls.Add(label);
        }
    }
}
