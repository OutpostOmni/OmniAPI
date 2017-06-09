using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace OmniAPI.Exceptions {
    [Serializable]
    public class UnrecognizedDataTypeException : Exception {
        public string ResourceReferenceProperty { get; set; }

        public UnrecognizedDataTypeException() {}

        public UnrecognizedDataTypeException(string message) : base(message) {}

        public UnrecognizedDataTypeException(string message, Exception inner) : base(message, inner) {}

        protected UnrecognizedDataTypeException(SerializationInfo info, StreamingContext context) : base(info, context) {
            ResourceReferenceProperty = info.GetString("ResourceReferenceProperty");
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            if (info == null) {
                throw new ArgumentNullException("info");
            }

            info.AddValue("ResourceReferenceProperty", ResourceReferenceProperty);
            base.GetObjectData(info, context);
        }
    }
}
