// Multiple Interfaces:
// Create an interface IPlayable with methods Play() and Pause().
// Define another interface IRecordable with methods Record() and StopRecording().
// Create a class MediaPlayer that implements both interfaces.
// Create an instance of MediaPlayer and test its play, pause, record, and stop recording functionality.

namespace Task3___Multiple_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.Play();
            mediaPlayer.Pause();
            mediaPlayer.Record();
            mediaPlayer.StopRecording();
        }
    }
}
