namespace Rhibhus.Reports.API.PredefinedReports
{
    partial class TOCReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.Drawing.Watermark watermark1 = new DevExpress.XtraPrinting.Drawing.Watermark();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTableOfContents1 = new DevExpress.XtraReports.UI.XRTableOfContents();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.FOOTERREPORT = new DevExpress.XtraReports.UI.XRSubreport();
            this.ID = new DevExpress.XtraReports.Parameters.Parameter();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Permanent = new DevExpress.XtraReports.UI.CalculatedField();
            this.Temporary = new DevExpress.XtraReports.UI.CalculatedField();
            this.cityNameParam = new DevExpress.XtraReports.Parameters.Parameter();
            this.roleNameParam = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2,
            this.xrSubreport3,
            this.xrLabel14,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.HeightF = 709.1528F;
            this.detailBand1.HierarchyPrintOptions.Indent = 50.8F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.Dpi = 254F;
            this.xrSubreport2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "[Addresses]\n")});
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(996.5145F, 628.4505F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("City", null, "Addresses.City"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", null, "Addresses.Country"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("State", null, "Addresses.State"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Street", null, "Addresses.Street"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Type", null, "Addresses.Permanent"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Zipcode", null, "Addresses.ZipCode"));
            this.xrSubreport2.ReportSource = new Rhibhus.Reports.API.PredefinedReports.AddressReport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(601.4862F, 69.00342F);
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.Dpi = 254F;
            this.xrSubreport3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "[Addresses]")});
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(290.6651F, 628.4506F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("City", null, "Addresses.City"));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", null, "Addresses.Country"));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("State", null, "Addresses.State"));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Street", null, "Addresses.Street"));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Type", null, "Addresses.Temporary"));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Zipcode", null, "Addresses.ZipCode"));
            this.xrSubreport3.ReportSource = new Rhibhus.Reports.API.PredefinedReports.AddressReport();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(612.7993F, 69.00342F);
            // 
            // xrLabel14
            // 
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(740.833F, 532.9886F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(343.9584F, 58.42004F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "ADDRESSES";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[Name]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Nurse\', \'\', [Name])\n")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 102.87F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(1031.875F, 58.41998F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Staff\', \'\', [Email])\n")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 208.327F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(1031.875F, 58.41998F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Admin\', \'\', [City])\n")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 408.5283F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(1031.875F, 58.41995F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "xrLabel9";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Accountant\', \'\', [Age])\n")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(898.3257F, 305.6349F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(1031.875F, 58.42001F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Doctor\', \'\', [ID])\n")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(399.5209F, 58.42F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Admin\', \'\', \'City\')\n")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(491.1604F, 408.5283F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "CITY";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Accountant\', \'\', \'Age\')\n")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 305.6349F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "AGE";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Staff\', \'\', \'Email\')\n")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 208.327F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "EMAIL";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Nurse\', \'\', \'Name\')\n")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 102.87F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(253.9999F, 58.41998F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "NAME";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Doctor\', \'\', \'Id\')\n")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(502.9197F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(253.9999F, 42.545F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "ID";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableOfContents1});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 218.8633F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTableOfContents1
            // 
            this.xrTableOfContents1.Dpi = 254F;
            this.xrTableOfContents1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "[Name]\n")});
            this.xrTableOfContents1.LevelDefault.Height = 135.3607F;
            this.xrTableOfContents1.LevelDefault.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrTableOfContents1.LevelTitle.Height = 82.2325F;
            this.xrTableOfContents1.LevelTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrTableOfContents1.LevelTitle.Text = "                                                                                 " +
    "                             TABLE OF CONTENTS";
            this.xrTableOfContents1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.270029F);
            this.xrTableOfContents1.Name = "xrTableOfContents1";
            this.xrTableOfContents1.StylePriority.UseTextAlignment = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1,
            this.xrLabel13,
            this.xrLabel12});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 276.7191F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Dpi = 254F;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ReportSource = new Rhibhus.Reports.API.PredefinedReports.HeaderReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(500.2746F, 58.42F);
            // 
            // xrLabel13
            // 
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(1020.327F, 206.1635F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(333.5181F, 70.55566F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "DETAILS";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Name])")});
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(402.824F, 206.1634F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(617.5035F, 58.42001F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.FOOTERREPORT});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 73.40443F;
            this.PageFooter.Name = "PageFooter";
            // 
            // FOOTERREPORT
            // 
            this.FOOTERREPORT.Dpi = 254F;
            this.FOOTERREPORT.LocationFloat = new DevExpress.Utils.PointFloat(25.4F, 0F);
            this.FOOTERREPORT.Name = "FOOTERREPORT";
            this.FOOTERREPORT.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ID", this.ID));
            this.FOOTERREPORT.ReportSource = new Rhibhus.Reports.API.PredefinedReports.FooterReport();
            this.FOOTERREPORT.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // ID
            // 
            this.ID.Description = "Parameter1";
            this.ID.Name = "ID";
            this.ID.Type = typeof(int);
            this.ID.ValueInfo = "0";
            this.ID.Visible = false;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataMember = "GetEmployees";
            this.objectDataSource1.DataSource = typeof(global::Rhibhus.Reports.API.Services.EmployeeRepository);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // Permanent
            // 
            this.Permanent.DataMember = "Addresses";
            this.Permanent.Expression = "\'Permanent\'\n";
            this.Permanent.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.Permanent.Name = "Permanent";
            // 
            // Temporary
            // 
            this.Temporary.DataMember = "Addresses";
            this.Temporary.Expression = "\'Temporary\'\n";
            this.Temporary.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.Temporary.Name = "Temporary";
            // 
            // cityNameParam
            // 
            this.cityNameParam.Description = "Parameter1";
            this.cityNameParam.Name = "cityNameParam";
            this.cityNameParam.Visible = false;
            // 
            // roleNameParam
            // 
            this.roleNameParam.Description = "Parameter1";
            this.roleNameParam.Name = "roleNameParam";
            this.roleNameParam.Visible = false;
            // 
            // TOCReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter});
            this.BookmarkDuplicateSuppress = false;
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Permanent,
            this.Temporary});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Dpi = 254F;
            this.FilterString = "(?cityNameParam = ?cityNameParam Or ?cityNameParam Is Null) And (?roleNameParam =" +
    " ?roleNameParam Or ?roleNameParam Is Null)";
            this.Margins = new DevExpress.Drawing.DXMargins(25.4F, 64F, 0F, 0F);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.cityNameParam, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.roleNameParam, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.cityNameParam,
            this.ID,
            this.roleNameParam});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "24.2";
            watermark1.Font = new DevExpress.Drawing.DXFont("Verdana", 72F);
            watermark1.ForeColor = System.Drawing.Color.SlateGray;
            watermark1.Id = "Watermark1";
            watermark1.Text = "RHIBHUS REPORTS";
            watermark1.TextTransparency = 167;
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            watermark1});
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRSubreport FOOTERREPORT;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.CalculatedField Permanent;
        private DevExpress.XtraReports.UI.CalculatedField Temporary;
        private DevExpress.XtraReports.Parameters.Parameter cityNameParam;
        private DevExpress.XtraReports.Parameters.Parameter ID;
        private DevExpress.XtraReports.UI.XRTableOfContents xrTableOfContents1;
        private DevExpress.XtraReports.Parameters.Parameter roleNameParam;
    }
}
