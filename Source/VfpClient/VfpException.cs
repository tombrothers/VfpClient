using System;
using System.Data.Common;
using System.Runtime.Serialization;

namespace VfpClient {
    [Serializable]
    public class VfpException : DbException {
        public VfpException() {
        }

        public VfpException(string message)
            : base(message) {
            VfpClientTracing.Tracer.TraceError(this);
        }

        public VfpException(string message, Exception innerException)
            : base(message, innerException) {
            VfpClientTracing.Tracer.TraceError(this);
        }

        public VfpException(string message, int errorCode)
            : base(message, errorCode) {
            VfpClientTracing.Tracer.TraceError(this);
        }

        public VfpException(SerializationInfo info, StreamingContext context)
            : base(info, context) {
            VfpClientTracing.Tracer.TraceError(this);
        }
    }
}