using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleGame
{
    public class PaperWasteBin : IWasteBin
    {     
        public ListBox ListBox { get; set; }    
        public ProgressBar ProgressBar { get; set; }
        public int EmptyingScore { get; }
        public int Capacity { get; set; }
        public int FullVolume { get; set; }
        public int OccupancyRate { get; set; }

        ///<summary>
        ///Constructor of MetalWasteBin Class
        ///</summary>
        ///<param name="listBox">ListBox to Add Waste</param>
        ///<param name="progressBar">ProgressBar to show occupancy when waste is to be added</param>
        ///<param name="emptyingScore">Points To Be Earned When The Box Is Empty</param>
        ///<param name="capacity">Capacity of the Bin</param>
        public PaperWasteBin(ListBox listBox, ProgressBar progressBar, int emptyingScore, int capacity)
        {
            ListBox = listBox;
            ProgressBar = progressBar;
            EmptyingScore = emptyingScore;
            Capacity = capacity;

            progressBar.Maximum = Capacity;
            progressBar.Minimum = 0;
        }
    }
}
