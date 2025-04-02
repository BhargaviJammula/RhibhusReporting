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
            this.xrNAMEVALUE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrEMAILVALUE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCITYVALUE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrAGEVALUE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIDVALUE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCITY = new DevExpress.XtraReports.UI.XRLabel();
            this.xrAGE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrEMAIL = new DevExpress.XtraReports.UI.XRLabel();
            this.xrName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrID = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrNAMEVALUE,
            this.xrEMAILVALUE,
            this.xrCITYVALUE,
            this.xrAGEVALUE,
            this.xrIDVALUE,
            this.xrCITY,
            this.xrAGE,
            this.xrEMAIL,
            this.xrName,
            this.xrID});
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
            // xrNAMEVALUE
            // 
            this.xrNAMEVALUE.Dpi = 254F;
            this.xrNAMEVALUE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[Name]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Nurse\', \'\', [Name])\n")});
            this.xrNAMEVALUE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrNAMEVALUE.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 102.87F);
            this.xrNAMEVALUE.Multiline = true;
            this.xrNAMEVALUE.Name = "xrNAMEVALUE";
            this.xrNAMEVALUE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrNAMEVALUE.SizeF = new System.Drawing.SizeF(1031.875F, 58.41998F);
            this.xrNAMEVALUE.StylePriority.UseFont = false;
            this.xrNAMEVALUE.Text = "xrNAME";
            // 
            // xrEMAILVALUE
            // 
            this.xrEMAILVALUE.Dpi = 254F;
            this.xrEMAILVALUE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Staff\', \'\', [Email])\n")});
            this.xrEMAILVALUE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrEMAILVALUE.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 208.327F);
            this.xrEMAILVALUE.Multiline = true;
            this.xrEMAILVALUE.Name = "xrEMAILVALUE";
            this.xrEMAILVALUE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrEMAILVALUE.SizeF = new System.Drawing.SizeF(1031.875F, 58.41998F);
            this.xrEMAILVALUE.StylePriority.UseFont = false;
            this.xrEMAILVALUE.Text = "xrEMAIL";
            // 
            // xrCITYVALUE
            // 
            this.xrCITYVALUE.Dpi = 254F;
            this.xrCITYVALUE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Admin\', \'\', [City])\n")});
            this.xrCITYVALUE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrCITYVALUE.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 408.5283F);
            this.xrCITYVALUE.Multiline = true;
            this.xrCITYVALUE.Name = "xrCITYVALUE";
            this.xrCITYVALUE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrCITYVALUE.SizeF = new System.Drawing.SizeF(1031.875F, 58.41995F);
            this.xrCITYVALUE.StylePriority.UseFont = false;
            this.xrCITYVALUE.Text = "xrCITY";
            // 
            // xrAGEVALUE
            // 
            this.xrAGEVALUE.Dpi = 254F;
            this.xrAGEVALUE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Accountant\', \'\', [Age])\n")});
            this.xrAGEVALUE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrAGEVALUE.LocationFloat = new DevExpress.Utils.PointFloat(898.3257F, 305.6349F);
            this.xrAGEVALUE.Multiline = true;
            this.xrAGEVALUE.Name = "xrAGEVALUE";
            this.xrAGEVALUE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrAGEVALUE.SizeF = new System.Drawing.SizeF(1031.875F, 58.42001F);
            this.xrAGEVALUE.StylePriority.UseFont = false;
            this.xrAGEVALUE.Text = "xrAGE";
            // 
            // xrIDVALUE
            // 
            this.xrIDVALUE.Dpi = 254F;
            this.xrIDVALUE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters.roleNameParam] == \'Doctor\', \'\', [ID])\n")});
            this.xrIDVALUE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.xrIDVALUE.LocationFloat = new DevExpress.Utils.PointFloat(898.3252F, 0F);
            this.xrIDVALUE.Multiline = true;
            this.xrIDVALUE.Name = "xrIDVALUE";
            this.xrIDVALUE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrIDVALUE.SizeF = new System.Drawing.SizeF(399.5209F, 58.42F);
            this.xrIDVALUE.StylePriority.UseFont = false;
            this.xrIDVALUE.StylePriority.UseTextAlignment = false;
            this.xrIDVALUE.Text = "xrID";
            this.xrIDVALUE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCITY
            // 
            this.xrCITY.Dpi = 254F;
            this.xrCITY.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Admin\', \'\', \'City\')\n")});
            this.xrCITY.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrCITY.LocationFloat = new DevExpress.Utils.PointFloat(491.1604F, 408.5283F);
            this.xrCITY.Multiline = true;
            this.xrCITY.Name = "xrCITY";
            this.xrCITY.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrCITY.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrCITY.StylePriority.UseFont = false;
            this.xrCITY.StylePriority.UseTextAlignment = false;
            this.xrCITY.Text = "CITY";
            this.xrCITY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrAGE
            // 
            this.xrAGE.Dpi = 254F;
            this.xrAGE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Accountant\', \'\', \'Age\')\n")});
            this.xrAGE.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrAGE.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 305.6349F);
            this.xrAGE.Multiline = true;
            this.xrAGE.Name = "xrAGE";
            this.xrAGE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrAGE.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrAGE.StylePriority.UseFont = false;
            this.xrAGE.StylePriority.UseTextAlignment = false;
            this.xrAGE.Text = "AGE";
            this.xrAGE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrEMAIL
            // 
            this.xrEMAIL.Dpi = 254F;
            this.xrEMAIL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Staff\', \'\', \'Email\')\n")});
            this.xrEMAIL.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrEMAIL.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 208.327F);
            this.xrEMAIL.Multiline = true;
            this.xrEMAIL.Name = "xrEMAIL";
            this.xrEMAIL.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrEMAIL.SizeF = new System.Drawing.SizeF(253.9999F, 58.42001F);
            this.xrEMAIL.StylePriority.UseFont = false;
            this.xrEMAIL.StylePriority.UseTextAlignment = false;
            this.xrEMAIL.Text = "EMAIL";
            this.xrEMAIL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrName
            // 
            this.xrName.Dpi = 254F;
            this.xrName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Nurse\', \'\', \'Name\')\n")});
            this.xrName.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrName.LocationFloat = new DevExpress.Utils.PointFloat(502.9198F, 102.87F);
            this.xrName.Multiline = true;
            this.xrName.Name = "xrName";
            this.xrName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrName.SizeF = new System.Drawing.SizeF(253.9999F, 58.41998F);
            this.xrName.StylePriority.UseFont = false;
            this.xrName.StylePriority.UseTextAlignment = false;
            this.xrName.Text = "NAME";
            this.xrName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrID
            // 
            this.xrID.Dpi = 254F;
            this.xrID.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(?roleNameParam == \'Doctor\', \'\', \'Id\')\n")});
            this.xrID.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13.59F);
            this.xrID.LocationFloat = new DevExpress.Utils.PointFloat(502.9197F, 0F);
            this.xrID.Multiline = true;
            this.xrID.Name = "xrID";
            this.xrID.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrID.SizeF = new System.Drawing.SizeF(253.9999F, 42.545F);
            this.xrID.StylePriority.UseFont = false;
            this.xrID.StylePriority.UseTextAlignment = false;
            this.xrID.Text = "ID";
            this.xrID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
        private DevExpress.XtraReports.UI.XRLabel xrCITY;
        private DevExpress.XtraReports.UI.XRLabel xrAGE;
        private DevExpress.XtraReports.UI.XRLabel xrEMAIL;
        private DevExpress.XtraReports.UI.XRLabel xrName;
        private DevExpress.XtraReports.UI.XRLabel xrID;
        private DevExpress.XtraReports.UI.XRLabel xrAGEVALUE;
        private DevExpress.XtraReports.UI.XRLabel xrIDVALUE;
        private DevExpress.XtraReports.UI.XRLabel xrNAMEVALUE;
        private DevExpress.XtraReports.UI.XRLabel xrEMAILVALUE;
        private DevExpress.XtraReports.UI.XRLabel xrCITYVALUE;
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
