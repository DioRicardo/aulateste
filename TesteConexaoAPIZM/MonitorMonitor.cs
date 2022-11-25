﻿namespace Monitor
{
    public partial class MonitorMonitor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public object Notes { get; set; }
        public long? ServerId { get; set; }
        public long StorageId { get; set; }
        public object ManufacturerId { get; set; }
        public object ModelId { get; set; }
        public string Type { get; set; }
        public string Function { get; set; }
        public string Capturing { get; set; }
        public long Enabled { get; set; }
        public long DecodingEnabled { get; set; }
        public string Decoding { get; set; }
        public bool JanusEnabled { get; set; }
        public bool JanusAudioEnabled { get; set; }
        public string JanusProfileOverride { get; set; }
        public bool JanusUseRtspRestream { get; set; }
        public object LinkedMonitors { get; set; }
        public string Triggers { get; set; }
        public string EventStartCommand { get; set; }
        public string EventEndCommand { get; set; }
        public string OnvifUrl { get; set; }
        public string OnvifUsername { get; set; }
        public string OnvifPassword { get; set; }
        public string OnvifOptions { get; set; }
        public bool OnvifEventListener { get; set; }
        public string OnvifAlarmText { get; set; }
        public bool UseAmcrestApi { get; set; }
        public string Device { get; set; }
        public long Channel { get; set; }
        public long Format { get; set; }
        public object V4LMultiBuffer { get; set; }
        public object V4LCapturesPerFrame { get; set; }
        public object Protocol { get; set; }
        public string Method { get; set; }
        public object Host { get; set; }
        public string Port { get; set; }
        public string SubPath { get; set; }
        public string Path { get; set; }
        public object SecondPath { get; set; }
        public object Options { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public long Colours { get; set; }
        public long Palette { get; set; }
        public string Orientation { get; set; }
        public long Deinterlacing { get; set; }
        public object DecoderHwAccelName { get; set; }
        public object DecoderHwAccelDevice { get; set; }
        public long SaveJpeGs { get; set; }
        public long VideoWriter { get; set; }
        public long OutputCodec { get; set; }
        public string Encoder { get; set; }
        public string OutputContainer { get; set; }
        public object EncoderParameters { get; set; }
        public long RecordAudio { get; set; }
        public string RecordingSource { get; set; }
        public object RtspDescribe { get; set; }
        public long Brightness { get; set; }
        public long Contrast { get; set; }
        public long Hue { get; set; }
        public long Colour { get; set; }
        public string EventPrefix { get; set; }
        public object LabelFormat { get; set; }
        public long LabelX { get; set; }
        public long LabelY { get; set; }
        public long LabelSize { get; set; }
        public long ImageBufferCount { get; set; }
        public long MaxImageBufferCount { get; set; }
        public long WarmupCount { get; set; }
        public long PreEventCount { get; set; }
        public long PostEventCount { get; set; }
        public long StreamReplayBuffer { get; set; }
        public long AlarmFrameCount { get; set; }
        public long SectionLength { get; set; }
        public long MinSectionLength { get; set; }
        public long FrameSkip { get; set; }
        public long MotionFrameSkip { get; set; }
        public object AnalysisFpsLimit { get; set; }
        public long AnalysisUpdateDelay { get; set; }
        public string MaxFps { get; set; }
        public object AlarmMaxFps { get; set; }
        public long FpsReportInterval { get; set; }
        public long RefBlendPerc { get; set; }
        public long AlarmRefBlendPerc { get; set; }
        public long Controllable { get; set; }
        public long? ControlId { get; set; }
        public string ControlDevice { get; set; }
        public string ControlAddress { get; set; }
        public object AutoStopTimeout { get; set; }
        public long TrackMotion { get; set; }
        public object TrackDelay { get; set; }
        public long ReturnLocation { get; set; }
        public object ReturnDelay { get; set; }
        public long ModectDuringPtz { get; set; }
        public long DefaultRate { get; set; }
        public long DefaultScale { get; set; }
        public string DefaultCodec { get; set; }
        public long SignalCheckPoints { get; set; }
        public string SignalCheckColour { get; set; }
        public string WebColour { get; set; }
        public bool Exif { get; set; }
        public object Sequence { get; set; }
        public long ZoneCount { get; set; }
        public object Refresh { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public bool RtspServer { get; set; }
        public string RtspStreamName { get; set; }
        public string Importance { get; set; }
        public bool MqttEnabled { get; set; }
        public string MqttSubscriptions { get; set; }
        public string Analysing { get; set; }
        public string AnalysisSource { get; set; }
        public string AnalysisImage { get; set; }
        public string Recording { get; set; }
    }
}


