using RecycleGame.Concrete.Bins;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleGame
{
    public class Newspaper : IWaste
    {
        public string Name { get; set; }
        public int Volume { get; }
        public Image Image { get; }       

        ///<summary>
        ///Constructor of Newspaper Class
        ///</summary>
        ///<param name="volume">Volume of Waste</param>
        ///<param name="image">Image of Waste</param>
        public Newspaper(int volume, Image image)
        {    
            Name = "Newspaper";
            Volume = volume;
            Image = image;
        }
    }
}
