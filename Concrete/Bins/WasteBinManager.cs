using RecycleGame.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleGame.Concrete.Bins
{
    class WasteBinManager : IWasteBinService
    {
        public List<string> GlassWastes { get; set; }
        public List<string> MetalWastes { get; set; }
        public List<string> OrganicWastes { get; set; }
        public List<string> PaperWastes { get; set; }
    
        public bool AddGlassWaste(IWasteBin wasteBin, IWaste waste)
        {
            if (IsGlassWaste(waste) && CheckCapacity(wasteBin, waste))
            {
                AddWasteToBin(wasteBin, waste);
                GlassWastes.Add(waste.Name);
                return true;
            }
            return false;
        }

        public bool AddMetalWaste(IWasteBin wasteBin, IWaste waste)
        {
            if (IsMetalWaste(waste) && CheckCapacity(wasteBin, waste))
            {
                AddWasteToBin(wasteBin, waste);
                MetalWastes.Add(waste.Name);
                return true;
            }
            return false;
        }

        public bool AddOrganicWaste(IWasteBin wasteBin, IWaste waste)
        {
            if (IsOrganicWaste(waste) && CheckCapacity(wasteBin, waste))
            {
                AddWasteToBin(wasteBin, waste);
                OrganicWastes.Add(waste.Name);
                return true;
            }
            return false;
        }

        public bool AddPaperWaste(IWasteBin wasteBin, IWaste waste)
        {
            if (IsPaperWaste(waste) && CheckCapacity(wasteBin, waste))
            {
                AddWasteToBin(wasteBin, waste);
                PaperWastes.Add(waste.Name);
                return true;
            }
            return false;
        }

        public void AddWasteToBin(IWasteBin wasteBin, IWaste waste)
        {
            wasteBin.ListBox.Items.Add(waste.Name + " (" + waste.Volume + ")");
            wasteBin.FullVolume += waste.Volume;
            wasteBin.ProgressBar.Value += waste.Volume;
            wasteBin.OccupancyRate = ((wasteBin.FullVolume * 100) / wasteBin.Capacity);
        }

        public bool IsGlassWaste(IWaste waste)
        {
            bool result = false;

            for (int i = 0; i < GlassWastes.Count; i++)
            {
                if (GlassWastes[i] == waste.Name)
                {
                    return true;
                }
            }

            return result;
        }

        public bool IsMetalWaste(IWaste waste)
        {
            bool result = false;

            for (int i = 0; i < MetalWastes.Count; i++)
            {
                if (MetalWastes[i] == waste.Name)
                {
                    return true;
                }
            }

            return result;
        }

        public bool IsOrganicWaste(IWaste waste)
        {
            bool result = false;

            for (int i = 0; i < OrganicWastes.Count; i++)
            {
                if (OrganicWastes[i] == waste.Name)
                {
                    return true;
                }
            }

            return result;
        }

        public bool IsPaperWaste(IWaste waste)
        {
            bool result = false;

            for (int i = 0; i < PaperWastes.Count; i++)
            {
                if (PaperWastes[i] == waste.Name)
                {
                    return true;
                }
            }

            return result;
        }

        public bool CheckCapacity(IWasteBin wasteBin, IWaste waste)
        {
            if (wasteBin.FullVolume + waste.Volume < wasteBin.Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Empty(IWasteBin wasteBin)
        {
            if (wasteBin.OccupancyRate >= 75)
            {
                wasteBin.FullVolume = 0;
                wasteBin.OccupancyRate = 0;
                wasteBin.ProgressBar.Value = 0;
                wasteBin.ListBox.Items.Clear();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ResetBox(IWasteBin wasteBin)
        {
            wasteBin.FullVolume = 0;
            wasteBin.OccupancyRate = 0;
            wasteBin.ProgressBar.Value = 0;
            wasteBin.ListBox.Items.Clear();
        }
    }
}
