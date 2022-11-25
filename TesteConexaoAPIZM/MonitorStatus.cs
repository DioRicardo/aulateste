namespace Monitor
{
    public partial class MonitorStatus
    {
        public long? MonitorId { get; set; }
        public string Status { get; set; }
        public string CaptureFps { get; set; }
        public string AnalysisFps { get; set; }
        public long? CaptureBandwidth { get; set; }
    }
}


