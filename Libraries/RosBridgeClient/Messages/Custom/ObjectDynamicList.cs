using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Standard;

namespace RosSharp.RosBridgeClient.Messages.Custom
{
    public class ObjectDynamicList : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "bmw_em_msgs/ObjectDynamicList";

        public Header header;
        public ObjectDynamicData[] dynamic_objects;

        public ObjectDynamicList()
        {
            header = new Header();
            dynamic_objects = new ObjectDynamicData[0];
        }
    }

    public class ObjectDynamicData : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "bmw_em_msgs/ObjectDynamicData";

        public float x;
        public float y;
        public float width;
        public float height;
        public float length; // depth
        public float orientation;

        public byte class_prob_bicycle;
        public byte class_prob_car;
        public byte class_prob_motorcycle;
        public byte class_prob_pedestrian;
        public byte class_prob_stationary;
        public byte class_prob_unknown;
    }
}
