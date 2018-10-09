using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RosSharp.RosBridgeClient;

namespace RosSharp.RosBridgeClient.Messages.Custom
{
    public class RegionOfInterest : Message
    {
        public uint x_offset;
        public uint y_offset;
        public uint height;
        public uint width;
        public bool do_rectify;

        public RegionOfInterest()
        {
            x_offset = 0;
            y_offset = 0;
            height = 0;
            width = 0;
            do_rectify = false;
        }
    }

    public class CameraInfo : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/CameraInfo";
        public Standard.Header header;
        public uint height;
        public uint width;
        public string distortion_model;
        public double[] D;
        public double[] k;
        public double[] R;
        public double[] P;
        public uint binning_x;
        public uint binning_y;
        public RegionOfInterest roi;

        public CameraInfo()
        {
            header = new Standard.Header();
            width = 0;
            height = 0;
            distortion_model = "";
            D = new double[0];
            k = new double[0];
            R = new double[0];
            P = new double[0];
            binning_x = 0;
            binning_y = 0;
            roi = new RegionOfInterest();
        }
    }
}
