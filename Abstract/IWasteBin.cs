using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleGame
{
    public interface IWasteBin
    {
        ///<summary>
        ///Gets and returns the value of the ListBox to which the waste will be added.
        /// </summary>
        ListBox ListBox { get; set; }

        ///<summary>
        ///Gets and returns the value of ProgressBar to show Occupancy Rate.
        /// </summary>
        ProgressBar ProgressBar { get; set; }

        ///<summary>
        ///Gets the capacity value of the waste bin and returns it.
        /// </summary>
        int Capacity { get; set; }

        ///<summary>
        ///Returns the full volume of the waste bin.
        /// </summary>
        int FullVolume { get; set; }

        ///<summary>
        ///Returns the occupancy rate of the waste bin.
        /// </summary>
        int OccupancyRate { get; set; }

        ///<summary>
        ///Returns how many points will be added to the game score when the waste bin is emptied.
        /// </summary>
        int EmptyingScore { get; }
    }
}
