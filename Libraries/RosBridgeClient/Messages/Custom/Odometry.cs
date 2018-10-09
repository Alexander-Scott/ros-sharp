using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Custom
{
    public class Odometry : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "bmw_arch_msgs/Odometry";
        public Standard.Header header;
        public double pos_x;
        public double pos_y;
        public double heading;
        public double slip_angle;
        public double track_angle;
        public double sigma_pos_x;
        public double sigma_pos_y;
        public double sigma_heading;
        public double sigma_slip_angle;
        public double sigma_track_angle;
        public sbyte status_flag;
        public UInt32 counter_sync;

        public Odometry()
        {
            counter_sync = 0;
            header = new Standard.Header();
            heading = 0;
            pos_x = 0;
            pos_y = 0;
            sigma_heading = 0;
            sigma_pos_x = 0;
            sigma_pos_y = 0;
            sigma_slip_angle = 0;
            slip_angle = 0;
            status_flag = SByte.MinValue;
            track_angle = 0;
        }
    }
}
