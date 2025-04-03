using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

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
