using System.IO;
using VideoLibrary;

namespace YouTubeDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.youtube.com/watch?v=xyIzhRvtIJ0";
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            File.WriteAllBytes(@"D:\Temp\YouTube\" + video.FullName, video.GetBytes());
        }
    }
}
