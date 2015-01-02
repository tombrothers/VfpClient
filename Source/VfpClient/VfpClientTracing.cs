using System.Diagnostics;

namespace VfpClient {
    public static class VfpClientTracing {
        private static TraceSource _traceSource = GetDefaultTraceSource();

        public static TraceSource Tracer {
            get { return _traceSource; }
            set { _traceSource = value ?? GetDefaultTraceSource(); }
        }

        private static TraceSource GetDefaultTraceSource() {
            var traceSource = new TraceSource("VfpClient");

#if DEBUG
            traceSource.Switch.Level = SourceLevels.All;
#endif

            return traceSource;
        }
    }
}