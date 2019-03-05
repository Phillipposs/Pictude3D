
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.FFMPEG;
namespace Picture3D.AnaglyphApi
{
    class VideoToFrames
    {
        public static void ReadFromVideo()
        {
            VideoFileReader reader = new VideoFileReader();
            // open video file
            reader.Open("small.mp4");
            // read 100 video frames out of it
            for (int i = 0; i < 100; i++)
            {
                Bitmap videoFrame = reader.ReadVideoFrame();


            }
            reader.Close();
        }
    }
}
