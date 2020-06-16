using RecycleGame.Concrete.Bins;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleGame
{
    public class Magazine : IWaste
    {
        public string Name { get; set; }
        public int Volume { get; }
        public Image Image { get; }

        ///<summary>
        ///Constructor of Magazine Class
        ///</summary>
        ///<param name="volume">Volume of Waste</param>
        ///<param name="image">Image of Waste</param>
        public Magazine(int volume, Image image)
        {         
            Name = "Magazine";
            Volume = volume;
            Image = image;
        }
    }
}
