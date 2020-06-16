using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleGame
{
    interface IWaste
    {
        ///<summary>
        ///Returns the name of the Waste.
        /// </summary>
        string Name { get; set; }

        ///<summary>
        ///Returns the volume of waste.
        /// </summary>
        int Volume { get; }

        ///<summary>
        ///Returns the image (image address) of waste.
        /// </summary>
        System.Drawing.Image Image { get; }
    }
}
