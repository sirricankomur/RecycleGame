using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleGame.Abstract
{
    interface IWasteBinService
    {
        ///<summary>
        ///If the waste box is over 75% full, it empties the waste bin.
        /// </summary>
        /// <param name="wasteBin">Bin to Empty</param>
        /// <returns>Returns whether waste bin is emptied.</returns>
        bool Empty(IWasteBin wasteBin);

        /// <summary>
        /// Checks the adequacy of the capacity.
        /// </summary>
        /// <param name="wasteBin">Bin to be Checked</param>
        /// <param name="waste">Waste to be Checked</param>
        /// <returns>Returns whether waste will be added.</returns>
        bool CheckCapacity(IWasteBin wasteBin, IWaste waste);

        /// <summary>
        /// Resets the bin.
        /// <param name="wasteBin">Bin to Reset</param>
        /// </summary>
        void ResetBox(IWasteBin wasteBin);
    }
}
