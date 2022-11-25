namespace Monitor
{
    public partial class Monitor
    {
        public MonitorMonitor MonitorMonitor { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public CameraModel CameraModel { get; set; }
        public MonitorStatus MonitorStatus { get; set; }
        public Dictionary<string, long?> EventSummary { get; set; }
    }
}


