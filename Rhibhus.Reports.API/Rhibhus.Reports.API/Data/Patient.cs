namespace Rhibhus.Reports.API.Data
{
    public class Patient
    {
        public string PatientName { get; set; }
        public string ICNo { get; set; }
        public string OldICOrPassport { get; set; }
        public string MRN { get; set; }
        public string VisitNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string BloodGroup { get; set; }
        public string WardRmBedNo { get; set; }
        // Footer Details (List for multiple rows)
        public List<FeedChartFooter> FooterData { get; set; }
    }

    public class FeedChartFooter
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string TypeOfFeed { get; set; }
        public int AmountOffered { get; set; }
        public int AmountTaken { get; set; }
        public int PassedUrine { get; set; }
        public int Bowel { get; set; }
        public string Remarks { get; set; }
        public string Vomitus { get; set; }
        public string User { get; set; }
    }
}