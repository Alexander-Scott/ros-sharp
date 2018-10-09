using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Custom
{
    public class SensorRt3000 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "bmw_sen_msgs/SensorRt3000";

        public Standard.Header header;
        public double altitude;
        public double latitude;
        public double longitude;

        public float roll;
        public float pitch;
        public float heading;

        public SensorRt3000()
        {
            header = new Standard.Header();
            altitude = 0;
            latitude = 0;
            longitude = 0;
        }
    }
}
