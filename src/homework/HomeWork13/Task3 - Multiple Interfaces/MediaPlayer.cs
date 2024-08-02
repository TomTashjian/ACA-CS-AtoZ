using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3___Multiple_Interfaces
{
    public class MediaPlayer : IPlayable, IRecordable
    {
        public void Pause()
        {
            Console.WriteLine("Paused");
        }

        public void Play()
        {
            Console.WriteLine("Playing");
        }

        public void Record()
        {
            Console.WriteLine("Recording");
        }

        public void StopRecording()
        {
            Console.WriteLine("Stopped Recording");
        }
    }
}
