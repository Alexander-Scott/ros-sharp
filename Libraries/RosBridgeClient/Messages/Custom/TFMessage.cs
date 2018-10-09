using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Custom
{
    public class TFVector : Message
    {
        public double x;
        public double y;
        public double z;

        public TFVector()
        {
            x = 0;
            y = 0;
            z = 0;
        }
    }

    public class TFQuaternion : Message
    {
        public double x;
        public double y;
        public double z;
        public double w;

        public TFQuaternion()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }
    }

    public class TFTransform : Message
    {
        public TFVector translation;
        public TFQuaternion rotation;

        public TFTransform()
        {
            translation = new TFVector();
            rotation = new TFQuaternion();
        }
    }

    public class TFTransformStamped : Message
    {
        public Standard.Header header;
        public string child_frame_id;
        public TFTransform transform;

        public TFTransformStamped()
        {
            header = new Standard.Header();
            child_frame_id = "";
            transform = new TFTransform();
        }
    }

    public class TFMessage : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "tf2_msgs/TFMessage";
        public TFTransformStamped[] transforms;

        public TFMessage()
        {
            transforms = new TFTransformStamped[0];
        }
    }
}
