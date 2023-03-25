using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul6_1302210105
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public void IncreasePlayCount(int count)
        {
            this.playCount = count;
        }
        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.title = title;
            this.playCount = 0;
            this.id = rnd.Next(100000);
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video memiliki judul: " + title);
            Console.WriteLine("Video memiliki ID: " + id);
            Console.WriteLine("Video diputar sebanyak: " + playCount);
        }
    }
}
