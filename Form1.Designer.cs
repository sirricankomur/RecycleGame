namespace RecycleGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pbxWastePictures = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScoreHeader = new System.Windows.Forms.Label();
            this.lblTimerHeader = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblWasteBin = new System.Windows.Forms.Label();
            this.pnlOrganicWaste = new System.Windows.Forms.Panel();
            this.btnAddOrganicWaste = new System.Windows.Forms.Button();
            this.btnEmptyOrganicWaste = new System.Windows.Forms.Button();
            this.pbarOrganicWaste = new System.Windows.Forms.ProgressBar();
            this.lbxOrganicWaste = new System.Windows.Forms.ListBox();
            this.pnlGlass = new System.Windows.Forms.Panel();
            this.btnAddGlass = new System.Windows.Forms.Button();
            this.btnEmptyGlass = new System.Windows.Forms.Button();
            this.pbarGlass = new System.Windows.Forms.ProgressBar();
            this.lbxGlass = new System.Windows.Forms.ListBox();
            this.pnlMetal = new System.Windows.Forms.Panel();
            this.btnAddMetal = new System.Windows.Forms.Button();
            this.btnEmptyMetal = new System.Windows.Forms.Button();
            this.pbarMetal = new System.Windows.Forms.ProgressBar();
            this.lbxMetal = new System.Windows.Forms.ListBox();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.btnAddPaper = new System.Windows.Forms.Button();
            this.btnEmptyPaper = new System.Windows.Forms.Button();
            this.pbarPaper = new System.Windows.Forms.ProgressBar();
            this.lbxPaper = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWastePictures)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlOrganicWaste.SuspendLayout();
            this.pnlGlass.SuspendLayout();
            this.pnlMetal.SuspendLayout();
            this.pnlPaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlPicture.Controls.Add(this.pbxWastePictures);
            this.pnlPicture.Location = new System.Drawing.Point(12, 12);
            this.pnlPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Padding = new System.Windows.Forms.Padding(7);
            this.pnlPicture.Size = new System.Drawing.Size(220, 184);
            this.pnlPicture.TabIndex = 2;
            // 
            // pbxWastePictures
            // 
            this.pbxWastePictures.Location = new System.Drawing.Point(9, 9);
            this.pbxWastePictures.Margin = new System.Windows.Forms.Padding(2);
            this.pbxWastePictures.Name = "pbxWastePictures";
            this.pbxWastePictures.Size = new System.Drawing.Size(202, 166);
            this.pbxWastePictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWastePictures.TabIndex = 0;
            this.pbxWastePictures.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblScoreHeader);
            this.panel2.Controls.Add(this.lblTimerHeader);
            this.panel2.Controls.Add(this.btnNewGame);
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(220, 315);
            this.panel2.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(13, 193);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(194, 56);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(13, 102);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(194, 56);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "60";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(13, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblScoreHeader
            // 
            this.lblScoreHeader.BackColor = System.Drawing.Color.Green;
            this.lblScoreHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreHeader.ForeColor = System.Drawing.Color.White;
            this.lblScoreHeader.Location = new System.Drawing.Point(13, 163);
            this.lblScoreHeader.Name = "lblScoreHeader";
            this.lblScoreHeader.Size = new System.Drawing.Size(194, 30);
            this.lblScoreHeader.TabIndex = 6;
            this.lblScoreHeader.Text = "SCOREBOARD";
            this.lblScoreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerHeader
            // 
            this.lblTimerHeader.BackColor = System.Drawing.Color.Green;
            this.lblTimerHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimerHeader.ForeColor = System.Drawing.Color.White;
            this.lblTimerHeader.Location = new System.Drawing.Point(13, 72);
            this.lblTimerHeader.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblTimerHeader.Name = "lblTimerHeader";
            this.lblTimerHeader.Size = new System.Drawing.Size(194, 30);
            this.lblTimerHeader.TabIndex = 2;
            this.lblTimerHeader.Text = "TIME";
            this.lblTimerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(153)))), ((int)(((byte)(192)))));
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(114)))), ((int)(((byte)(150)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(13, 13);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(194, 48);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWasteBin
            // 
            this.lblWasteBin.BackColor = System.Drawing.Color.GreenYellow;
            this.lblWasteBin.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWasteBin.ForeColor = System.Drawing.Color.Black;
            this.lblWasteBin.Location = new System.Drawing.Point(238, 12);
            this.lblWasteBin.Margin = new System.Windows.Forms.Padding(3, 8, 3, 5);
            this.lblWasteBin.Name = "lblWasteBin";
            this.lblWasteBin.Size = new System.Drawing.Size(346, 30);
            this.lblWasteBin.TabIndex = 4;
            this.lblWasteBin.Text = "WASTE BINS";
            this.lblWasteBin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrganicWaste
            // 
            this.pnlOrganicWaste.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlOrganicWaste.Controls.Add(this.btnAddOrganicWaste);
            this.pnlOrganicWaste.Controls.Add(this.btnEmptyOrganicWaste);
            this.pnlOrganicWaste.Controls.Add(this.pbarOrganicWaste);
            this.pnlOrganicWaste.Controls.Add(this.lbxOrganicWaste);
            this.pnlOrganicWaste.Location = new System.Drawing.Point(238, 50);
            this.pnlOrganicWaste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pnlOrganicWaste.Name = "pnlOrganicWaste";
            this.pnlOrganicWaste.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOrganicWaste.Size = new System.Drawing.Size(170, 231);
            this.pnlOrganicWaste.TabIndex = 5;
            // 
            // btnAddOrganicWaste
            // 
            this.btnAddOrganicWaste.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddOrganicWaste.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddOrganicWaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddOrganicWaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAddOrganicWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrganicWaste.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrganicWaste.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrganicWaste.Location = new System.Drawing.Point(8, 8);
            this.btnAddOrganicWaste.Name = "btnAddOrganicWaste";
            this.btnAddOrganicWaste.Size = new System.Drawing.Size(154, 34);
            this.btnAddOrganicWaste.TabIndex = 9;
            this.btnAddOrganicWaste.Text = "ORGANIC WASTE";
            this.btnAddOrganicWaste.UseVisualStyleBackColor = false;
            this.btnAddOrganicWaste.Click += new System.EventHandler(this.btnAddOrganicWaste_Click);
            // 
            // btnEmptyOrganicWaste
            // 
            this.btnEmptyOrganicWaste.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEmptyOrganicWaste.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEmptyOrganicWaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEmptyOrganicWaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.btnEmptyOrganicWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyOrganicWaste.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmptyOrganicWaste.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyOrganicWaste.Location = new System.Drawing.Point(8, 189);
            this.btnEmptyOrganicWaste.Name = "btnEmptyOrganicWaste";
            this.btnEmptyOrganicWaste.Size = new System.Drawing.Size(154, 34);
            this.btnEmptyOrganicWaste.TabIndex = 6;
            this.btnEmptyOrganicWaste.Text = "EMPTY";
            this.btnEmptyOrganicWaste.UseVisualStyleBackColor = false;
            this.btnEmptyOrganicWaste.Click += new System.EventHandler(this.btnEmptyOrganicWaste_Click);
            // 
            // pbarOrganicWaste
            // 
            this.pbarOrganicWaste.Location = new System.Drawing.Point(8, 156);
            this.pbarOrganicWaste.Name = "pbarOrganicWaste";
            this.pbarOrganicWaste.Size = new System.Drawing.Size(154, 23);
            this.pbarOrganicWaste.Step = 1;
            this.pbarOrganicWaste.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarOrganicWaste.TabIndex = 8;
            // 
            // lbxOrganicWaste
            // 
            this.lbxOrganicWaste.FormattingEnabled = true;
            this.lbxOrganicWaste.Location = new System.Drawing.Point(8, 45);
            this.lbxOrganicWaste.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbxOrganicWaste.Name = "lbxOrganicWaste";
            this.lbxOrganicWaste.Size = new System.Drawing.Size(154, 108);
            this.lbxOrganicWaste.TabIndex = 7;
            // 
            // pnlGlass
            // 
            this.pnlGlass.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlGlass.Controls.Add(this.btnAddGlass);
            this.pnlGlass.Controls.Add(this.btnEmptyGlass);
            this.pnlGlass.Controls.Add(this.pbarGlass);
            this.pnlGlass.Controls.Add(this.lbxGlass);
            this.pnlGlass.Location = new System.Drawing.Point(238, 284);
            this.pnlGlass.Name = "pnlGlass";
            this.pnlGlass.Padding = new System.Windows.Forms.Padding(5);
            this.pnlGlass.Size = new System.Drawing.Size(170, 233);
            this.pnlGlass.TabIndex = 10;
            // 
            // btnAddGlass
            // 
            this.btnAddGlass.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddGlass.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddGlass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddGlass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAddGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGlass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddGlass.ForeColor = System.Drawing.Color.Black;
            this.btnAddGlass.Location = new System.Drawing.Point(8, 8);
            this.btnAddGlass.Name = "btnAddGlass";
            this.btnAddGlass.Size = new System.Drawing.Size(154, 34);
            this.btnAddGlass.TabIndex = 12;
            this.btnAddGlass.Text = "GLASS WASTE";
            this.btnAddGlass.UseVisualStyleBackColor = false;
            this.btnAddGlass.Click += new System.EventHandler(this.btnAddGlass_Click);
            // 
            // btnEmptyGlass
            // 
            this.btnEmptyGlass.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEmptyGlass.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEmptyGlass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEmptyGlass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.btnEmptyGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyGlass.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmptyGlass.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyGlass.Location = new System.Drawing.Point(8, 191);
            this.btnEmptyGlass.Name = "btnEmptyGlass";
            this.btnEmptyGlass.Size = new System.Drawing.Size(154, 34);
            this.btnEmptyGlass.TabIndex = 6;
            this.btnEmptyGlass.Text = "EMPTY";
            this.btnEmptyGlass.UseVisualStyleBackColor = false;
            this.btnEmptyGlass.Click += new System.EventHandler(this.btnEmptyGlass_Click);
            // 
            // pbarGlass
            // 
            this.pbarGlass.Location = new System.Drawing.Point(8, 156);
            this.pbarGlass.Name = "pbarGlass";
            this.pbarGlass.Size = new System.Drawing.Size(154, 23);
            this.pbarGlass.TabIndex = 8;
            // 
            // lbxGlass
            // 
            this.lbxGlass.FormattingEnabled = true;
            this.lbxGlass.Location = new System.Drawing.Point(8, 45);
            this.lbxGlass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbxGlass.Name = "lbxGlass";
            this.lbxGlass.Size = new System.Drawing.Size(154, 108);
            this.lbxGlass.TabIndex = 7;
            // 
            // pnlMetal
            // 
            this.pnlMetal.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlMetal.Controls.Add(this.btnAddMetal);
            this.pnlMetal.Controls.Add(this.btnEmptyMetal);
            this.pnlMetal.Controls.Add(this.pbarMetal);
            this.pnlMetal.Controls.Add(this.lbxMetal);
            this.pnlMetal.Location = new System.Drawing.Point(414, 284);
            this.pnlMetal.Name = "pnlMetal";
            this.pnlMetal.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMetal.Size = new System.Drawing.Size(170, 233);
            this.pnlMetal.TabIndex = 12;
            // 
            // btnAddMetal
            // 
            this.btnAddMetal.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddMetal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddMetal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddMetal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAddMetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMetal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMetal.ForeColor = System.Drawing.Color.Black;
            this.btnAddMetal.Location = new System.Drawing.Point(8, 8);
            this.btnAddMetal.Name = "btnAddMetal";
            this.btnAddMetal.Size = new System.Drawing.Size(154, 34);
            this.btnAddMetal.TabIndex = 11;
            this.btnAddMetal.Text = "METAL WASTE";
            this.btnAddMetal.UseVisualStyleBackColor = false;
            this.btnAddMetal.Click += new System.EventHandler(this.btnAddMetal_Click);
            // 
            // btnEmptyMetal
            // 
            this.btnEmptyMetal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEmptyMetal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEmptyMetal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEmptyMetal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.btnEmptyMetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyMetal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmptyMetal.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyMetal.Location = new System.Drawing.Point(8, 191);
            this.btnEmptyMetal.Name = "btnEmptyMetal";
            this.btnEmptyMetal.Size = new System.Drawing.Size(154, 34);
            this.btnEmptyMetal.TabIndex = 6;
            this.btnEmptyMetal.Text = "EMPTY";
            this.btnEmptyMetal.UseVisualStyleBackColor = false;
            this.btnEmptyMetal.Click += new System.EventHandler(this.btnEmptyMetal_Click);
            // 
            // pbarMetal
            // 
            this.pbarMetal.Location = new System.Drawing.Point(8, 156);
            this.pbarMetal.Name = "pbarMetal";
            this.pbarMetal.Size = new System.Drawing.Size(154, 23);
            this.pbarMetal.TabIndex = 8;
            // 
            // lbxMetal
            // 
            this.lbxMetal.FormattingEnabled = true;
            this.lbxMetal.Location = new System.Drawing.Point(8, 45);
            this.lbxMetal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbxMetal.Name = "lbxMetal";
            this.lbxMetal.Size = new System.Drawing.Size(154, 108);
            this.lbxMetal.TabIndex = 7;
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlPaper.Controls.Add(this.btnAddPaper);
            this.pnlPaper.Controls.Add(this.btnEmptyPaper);
            this.pnlPaper.Controls.Add(this.pbarPaper);
            this.pnlPaper.Controls.Add(this.lbxPaper);
            this.pnlPaper.Location = new System.Drawing.Point(414, 50);
            this.pnlPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPaper.Size = new System.Drawing.Size(170, 231);
            this.pnlPaper.TabIndex = 11;
            // 
            // btnAddPaper
            // 
            this.btnAddPaper.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddPaper.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAddPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaper.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPaper.ForeColor = System.Drawing.Color.Black;
            this.btnAddPaper.Location = new System.Drawing.Point(8, 8);
            this.btnAddPaper.Name = "btnAddPaper";
            this.btnAddPaper.Size = new System.Drawing.Size(154, 34);
            this.btnAddPaper.TabIndex = 10;
            this.btnAddPaper.Text = "PAPER WASTE";
            this.btnAddPaper.UseVisualStyleBackColor = false;
            this.btnAddPaper.Click += new System.EventHandler(this.btnAddPaper_Click);
            // 
            // btnEmptyPaper
            // 
            this.btnEmptyPaper.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEmptyPaper.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEmptyPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEmptyPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
            this.btnEmptyPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyPaper.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmptyPaper.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyPaper.Location = new System.Drawing.Point(8, 189);
            this.btnEmptyPaper.Name = "btnEmptyPaper";
            this.btnEmptyPaper.Size = new System.Drawing.Size(154, 34);
            this.btnEmptyPaper.TabIndex = 6;
            this.btnEmptyPaper.Text = "EMPTY";
            this.btnEmptyPaper.UseVisualStyleBackColor = false;
            this.btnEmptyPaper.Click += new System.EventHandler(this.btnEmptyPaper_Click);
            // 
            // pbarPaper
            // 
            this.pbarPaper.Location = new System.Drawing.Point(8, 156);
            this.pbarPaper.Name = "pbarPaper";
            this.pbarPaper.Size = new System.Drawing.Size(154, 23);
            this.pbarPaper.TabIndex = 8;
            // 
            // lbxPaper
            // 
            this.lbxPaper.FormattingEnabled = true;
            this.lbxPaper.Location = new System.Drawing.Point(8, 45);
            this.lbxPaper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbxPaper.Name = "lbxPaper";
            this.lbxPaper.Size = new System.Drawing.Size(154, 108);
            this.lbxPaper.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(596, 532);
            this.Controls.Add(this.pnlMetal);
            this.Controls.Add(this.pnlGlass);
            this.Controls.Add(this.pnlPaper);
            this.Controls.Add(this.pnlOrganicWaste);
            this.Controls.Add(this.lblWasteBin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPicture);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WASTE COLLECTION GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWastePictures)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlOrganicWaste.ResumeLayout(false);
            this.pnlGlass.ResumeLayout(false);
            this.pnlMetal.ResumeLayout(false);
            this.pnlPaper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox pbxWastePictures;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimerHeader;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScoreHeader;
        private System.Windows.Forms.Label lblWasteBin;
        private System.Windows.Forms.Panel pnlOrganicWaste;
        private System.Windows.Forms.Button btnEmptyOrganicWaste;
        private System.Windows.Forms.ProgressBar pbarOrganicWaste;
        private System.Windows.Forms.ListBox lbxOrganicWaste;
        private System.Windows.Forms.Panel pnlGlass;
        private System.Windows.Forms.Button btnEmptyGlass;
        private System.Windows.Forms.ProgressBar pbarGlass;
        private System.Windows.Forms.ListBox lbxGlass;
        private System.Windows.Forms.Panel pnlMetal;
        private System.Windows.Forms.Button btnEmptyMetal;
        private System.Windows.Forms.ProgressBar pbarMetal;
        private System.Windows.Forms.ListBox lbxMetal;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.Button btnEmptyPaper;
        private System.Windows.Forms.ProgressBar pbarPaper;
        private System.Windows.Forms.ListBox lbxPaper;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnAddOrganicWaste;
        private System.Windows.Forms.Button btnAddGlass;
        private System.Windows.Forms.Button btnAddMetal;
        private System.Windows.Forms.Button btnAddPaper;
    }
}

