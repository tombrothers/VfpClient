using System;
using System.Diagnostics;

namespace VfpClient {
    public static class TraceSourceExtentions {
        public static void TraceError(this TraceSource traceSource, Exception exception) {
            ArgumentUtility.CheckNotNull("traceSource", traceSource);
            ArgumentUtility.CheckNotNull("exception", exception);

            traceSource.TraceEvent(TraceEventType.Error, 0, exception.ToString());
        }

        public static void TraceError(this TraceSource traceSource, string message) {
            ArgumentUtility.CheckNotNull("traceSource", traceSource);

            traceSource.TraceEvent(TraceEventType.Error, 0, message);
        }

        public static void TraceVerbose(this TraceSource traceSource, string message) {
            ArgumentUtility.CheckNotNull("traceSource", traceSource);

            traceSource.TraceEvent(TraceEventType.Verbose, 0, message);
        }

        public static bool ShouldTraceVerbose(this TraceSource traceSource) {
            return traceSource.HasSourceLevel(SourceLevels.Verbose);
        }

        public static bool HasSourceLevel(this TraceSource traceSource, SourceLevels sourceLevel) {
            ArgumentUtility.CheckNotNull("traceSource", traceSource);

            return traceSource.Switch.Level == SourceLevels.All || (traceSource.Switch.Level & sourceLevel) == sourceLevel;
        }
    }
}