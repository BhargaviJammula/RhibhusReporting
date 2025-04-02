﻿using Rhibhus.Reports.API.Data;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class TOCReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TOCReport()
        {
            InitializeComponent();
        }

        private void TOCReport_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var roleName = this.Parameters["roleNameParam"]?.Value?.ToString() ?? "";

            switch (roleName)
            {
                case UserRoleConstants.Doctor:
                    this.FindControl("xrId", true).Visible = false;
                    break;
                case UserRoleConstants.Accountant:
                    this.FindControl("xrAge", true).Visible = false;
                    break;
                case UserRoleConstants.Nurse:
                    this.FindControl("xrName", true).Visible = false;
                    break;
                case UserRoleConstants.Staff:
                    this.FindControl("xrEmail", true).Visible = false;
                    break;
                case UserRoleConstants.Admin:
                    this.FindControl("xrCity", true).Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
