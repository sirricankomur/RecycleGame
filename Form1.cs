using RecycleGame.Concrete.Bins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleGame
{
    public partial class Form1 : Form
    {
        IWaste _waste;
        OrganicWasteBin _organicWasteBin;
        PaperWasteBin _paperWasteBin;
        GlassWasteBin _glassWasteBin;
        MetalWasteBin _metalWasteBin;
        private int _time;
        private int _score;

        WasteBinManager _wasteBinManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _wasteBinManager = new WasteBinManager();
                      
            _organicWasteBin = new OrganicWasteBin(lbxOrganicWaste, pbarOrganicWaste, 0, 700);
            _paperWasteBin = new PaperWasteBin(lbxPaper, pbarPaper, 1000, 1200);
            _glassWasteBin = new GlassWasteBin(lbxGlass, pbarGlass, 600, 2200);
            _metalWasteBin = new MetalWasteBin(lbxMetal, pbarMetal, 800, 2300);

            
            btnExit.Enabled = false;
            DisableButtonsOfWasteBins();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            EnableButtonsOfWasteBins();
            ResetGame();
            RandomWaste();
            ChangeScoreboardColourAtPlaytime();

            btnExit.Enabled = true;
        }

        private void btnAddOrganicWaste_Click(object sender, EventArgs e)
        {
            // Waste, Organic Waste?
            if (IsOrganicWaste())
            {
                RandomWaste();
            }
        }

        private void btnAddPaper_Click(object sender, EventArgs e)
        {
            // Waste, Paper Waste?
            if (IsPaperWaste())
            {
                RandomWaste();
            }
        }

        private void btnAddGlass_Click(object sender, EventArgs e)
        {
            // Waste, Glass Waste?
            if (IsGlassWaste())
            {
                RandomWaste();
            }
        }

        private void btnAddMetal_Click(object sender, EventArgs e)
        {
            // Waste, Metal Waste?
            if (IsMetalWaste())
            {
                RandomWaste();
            }
        }

        private void btnEmptyOrganicWaste_Click(object sender, EventArgs e)
        {
            // If the box has a fill rate of over 75%, empty it and add the emptying score.
            if (_wasteBinManager.Empty(_organicWasteBin))
            {
                AddTime(3);
                AddBinEmptyingScore(_organicWasteBin);
            }
        }

        private void btnEmptyPaper_Click(object sender, EventArgs e)
        {
            // If the box has a fill rate of over 75%, empty it and add the emptying score.
            if (_wasteBinManager.Empty(_paperWasteBin))
            {
                AddTime(3);
                AddBinEmptyingScore(_paperWasteBin);
            }
        }

        private void btnEmptyGlass_Click(object sender, EventArgs e)
        {
            // If the box has a fill rate of over 75%, empty it and add the emptying score.
            if (_wasteBinManager.Empty(_glassWasteBin))
            {
                AddTime(3);
                AddBinEmptyingScore(_glassWasteBin);
            }
        }

        private void btnEmptyMetal_Click(object sender, EventArgs e)
        {
            // If the box has a fill rate of over 75%, empty it and add the emptying score.
            if (_wasteBinManager.Empty(_metalWasteBin))
            {
                AddTime(3);
                AddBinEmptyingScore(_metalWasteBin);               
            }
        }

        private void AddTime(int second)
        {
            _time = (Convert.ToInt32(lblTimer.Text) + second);
            lblTimer.Text = _time.ToString();
        }

        private void AddBinEmptyingScore(IWasteBin wasteBin)
        {
            _score += wasteBin.EmptyingScore;
            lblScore.Text = _score.ToString();
        }

        private void AddWasteAddingScore(IWaste waste)
        {
            _score += waste.Volume;
            lblScore.Text = _score.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitTheGame();
            DisableButtonsOfWasteBins();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _time--;

            // Zaman 0 oldu ise zaman sayacını kapat, Atık kutularının Ekle ve Boşalt butonlarını devre dışı bırak ve Yeni Oyun butonunu aktifleştir.
            if (_time == 0)
            {
                timer.Enabled = false;
                ResetScoreboardColour();
                DisableButtonsOfWasteBins();
                btnNewGame.Enabled = true;
                btnExit.Enabled = false;
            }
            lblTimer.Text = _time.ToString();
        }


        /// <summary>
        /// It generates random waste.
        /// </summary>
        private void RandomWaste()
        {
            Random random = new Random();
            int randomNumber = random.Next(8);

            _wasteBinManager.PaperWastes = new List<string>();
            _wasteBinManager.GlassWastes = new List<string>();
            _wasteBinManager.MetalWastes = new List<string>();
            _wasteBinManager.OrganicWastes = new List<string>();

            if (randomNumber == 0)
            {
                Image imageGlassBottle = Image.FromFile("glassBottle.png");
                _waste = new GlassBottle(600, imageGlassBottle);
                _wasteBinManager.GlassWastes.Add("Glass Bottle");
                pbxWastePictures.Image = imageGlassBottle;
            }
            else if (randomNumber == 1)
            {
                Image imageGlass = Image.FromFile("glass.png");
                _waste = new Glass(250, imageGlass);
                _wasteBinManager.GlassWastes.Add("Glass");
                pbxWastePictures.Image = imageGlass;
            }
            else if (randomNumber == 2)
            {
                Image imageNewspaper = Image.FromFile("newspaper.png");
                _waste = new Newspaper(250, imageNewspaper);
                _wasteBinManager.PaperWastes.Add("Newspaper");
                pbxWastePictures.Image = imageNewspaper;
            }
            else if (randomNumber == 3)
            {
                Image imageMagazine = Image.FromFile("magazine.png");
                _waste = new Magazine(200, imageMagazine);
                _wasteBinManager.PaperWastes.Add("Magazine");
                pbxWastePictures.Image = imageMagazine;
            }
            else if (randomNumber == 4)
            {
                Image imageTomato = Image.FromFile("tomato.png");
                _waste = new Tomato(150, imageTomato);
                _wasteBinManager.OrganicWastes.Add("Tomato");
                pbxWastePictures.Image = imageTomato;
            }
            else if (randomNumber == 5)
            {
                Image imageCucumber = Image.FromFile("cucumber.png");
                _waste = new Cucumber(120, imageCucumber);
                _wasteBinManager.OrganicWastes.Add("Cucumber");
                pbxWastePictures.Image = imageCucumber;
            }
            else if (randomNumber == 6)
            {
                Image imageColaBox = Image.FromFile("colaCan.png");
                _waste = new ColaCan(350, imageColaBox);
                _wasteBinManager.MetalWastes.Add("Cola Can");
                pbxWastePictures.Image = imageColaBox;
            }
            else if (randomNumber == 7)
            {
                Image imageTinCan = Image.FromFile("pasteCan.png");
                _waste = new PasteCan(550, imageTinCan);
                _wasteBinManager.MetalWastes.Add("Paste Can");
                pbxWastePictures.Image = imageTinCan;
            }

        }

        /// <summary>
        /// Waste, Organic Waste?
        /// </summary>
        /// <returns>Returns whether waste is Organic Waste.</returns>
        private bool IsOrganicWaste()
        {
            // Atık Organik Atık ise puana atık hacmi kadar ekle.
            if (_wasteBinManager.AddOrganicWaste(_organicWasteBin, _waste))
            {
                AddWasteAddingScore(_waste);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Waste, Paper Waste?
        /// </summary>
        /// <returns>Returns whether waste is Paper Waste.</returns>
        private bool IsPaperWaste()
        {
            // Atık Kağıt ise puana atık hacmi kadar ekle.
            if (_wasteBinManager.AddPaperWaste(_paperWasteBin, _waste))
            {
                _score += _waste.Volume;
                lblScore.Text = _score.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Waste, Glass Waste?
        /// </summary>
        /// <returns>Returns whether waste is Glass Waste.</returns>
        private bool IsGlassWaste()
        {
            if (_wasteBinManager.AddGlassWaste(_glassWasteBin, _waste))
            {
                _score += _waste.Volume;
                lblScore.Text = _score.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Waste, Metal Waste?
        /// </summary>
        /// <returns>Returns whether waste is Metal Waste.</returns>
        private bool IsMetalWaste()
        {
            if (_wasteBinManager.AddMetalWaste(_metalWasteBin,_waste))
            {
                _score += _waste.Volume;
                lblScore.Text = _score.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Enables the Add and Empty buttons of Waste Bins.
        /// </summary>
        private void EnableButtonsOfWasteBins()
        {
            btnAddOrganicWaste.Enabled = true;
            btnAddPaper.Enabled = true;
            btnAddGlass.Enabled = true;
            btnAddMetal.Enabled = true;

            btnEmptyOrganicWaste.Enabled = true;
            btnEmptyPaper.Enabled = true;
            btnEmptyGlass.Enabled = true;
            btnEmptyMetal.Enabled = true;
        }

        /// <summary>
        /// Disables the Add and Empty buttons of Waste Bins.
        /// </summary>
        private void DisableButtonsOfWasteBins()
        {
            btnAddOrganicWaste.Enabled = false;
            btnAddPaper.Enabled = false;
            btnAddGlass.Enabled = false;
            btnAddMetal.Enabled = false;

            btnEmptyOrganicWaste.Enabled = false;
            btnEmptyPaper.Enabled = false;
            btnEmptyGlass.Enabled = false;
            btnEmptyMetal.Enabled = false;
        }

        /// <summary>
        /// Resets the game.
        /// </summary>
        private void ResetGame()
        { 
            _wasteBinManager.ResetBox(_organicWasteBin);
            _wasteBinManager.ResetBox(_paperWasteBin);
            _wasteBinManager.ResetBox(_glassWasteBin);
            _wasteBinManager.ResetBox(_metalWasteBin);      

            lblScore.Text = "0";
            lblTimer.Text = "60";
            _time = 60;
            _score = 0;
            timer.Enabled = true;
            btnNewGame.Enabled = false;
        }

        /// <summary>
        /// Changes the color of Scoreboard at game time.
        /// </summary>
        private void ChangeScoreboardColourAtPlaytime()
        {
            lblTimer.BackColor = ColorTranslator.FromHtml("#83B412");
            lblTimer.ForeColor = Color.White;

            lblScore.BackColor = ColorTranslator.FromHtml("#83B412");
            lblScore.ForeColor = Color.White;
        }

        /// <summary>
        /// Resets (restores) the color of the Scoreboard.
        /// </summary>
        private void ResetScoreboardColour()
        {
            lblTimer.BackColor = Color.White;
            lblTimer.ForeColor = Color.Black;

            lblScore.BackColor = Color.White;
            lblScore.ForeColor = Color.Black;
        }

        /// <summary>
        /// Quits the game and resets the Scoreboard.
        /// </summary>
        private void ExitTheGame()
        {
            lblScore.Text = "0";
            lblTimer.Text = "60";
            _time = 60;
            _score = 0;
            timer.Enabled = false;
            btnNewGame.Enabled = true;
            btnExit.Enabled = false;
        }
      
    }
}
