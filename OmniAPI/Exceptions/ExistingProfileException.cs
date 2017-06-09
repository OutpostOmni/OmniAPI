using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace OmniAPI.Exceptions {
    [Serializable]
    public class ExistingProfileException : Exception {
        public string ResourceReferenceProperty { get; set; }

        public ExistingProfileException() {}

        public ExistingProfileException(string message) : base(message) {}

        public ExistingProfileException(string message, Exception inner) : base(message, inner) {}

        protected ExistingProfileException(SerializationInfo info, StreamingContext context) : base(info, context) {
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
