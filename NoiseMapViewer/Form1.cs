namespace NoiseMapViewer
{
    public partial class Form1 : Form
    {
        Settings settings;
        Logic logic;

        int x = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();

            settings = new Settings();
            logic = new Logic(settings, this.flowLayoutPanel_Pictures, this.flowLayoutPanel1, this.toolStripStatusLabel_Position);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTileSize();
            //logic.LoadPictureFiles();

            ////logic.LoadEverything();
        }



        private void button_Up_Click(object sender, EventArgs e)
        {
            settings.PositionY--;
            SetNumericValues();
            logic.PutPicturesInPictureBoxes();
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            settings.PositionX++;
            SetNumericValues();
            logic.PutPicturesInPictureBoxes();
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            settings.PositionY++;
            SetNumericValues();
            logic.PutPicturesInPictureBoxes();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            settings.PositionX--;
            SetNumericValues();
            logic.PutPicturesInPictureBoxes();
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            logic.SizePictureBoxes();
            SetNumericValues();
            int left = flowLayoutPanel_Pictures.Width + 21;  //padding neede to get the right spot
            panel1.Location = new Point(left, 15);  //15 is the correct height
        }

        private void button_ZoomIn_Click(object sender, EventArgs e)
        {
            settings.Tiles = Math.Max(1, settings.Tiles - 2);
            SetNumericValues();
            logic.LoadEverything();
        }

        private void button_ZoomOut_Click(object sender, EventArgs e)
        {
            settings.Tiles += 2;
            SetNumericValues();
            logic.LoadEverything();
        }

        private void SetNumericValues()
        {
            numericUpDown_Tiles.Value = settings.Tiles;
            numericUpDown_XPos.Value = settings.PositionX;
            numericUpDown_YPos.Value = settings.PositionY;
        }

        private void UpdateNumericValues(object sender, EventArgs e)
        {
            settings.Tiles = (int)numericUpDown_Tiles.Value;
            settings.PositionX = (int)numericUpDown_XPos.Value;
            settings.PositionY = (int)numericUpDown_YPos.Value;
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            logic.LoadEverything();
        }


        private void LoadTileSize()
        {
            comboBox_TileSize.Items.Clear();

            foreach (var item in Directory.GetDirectories(settings.RootFolder).OrderBy(e=>e))
            {
                comboBox_TileSize.Items.Add(Path.GetFileName(item));
            }

            if (comboBox_TileSize.Items.Count > 0)
            {
                comboBox_TileSize.SelectedItem = comboBox_TileSize.Items[0];
            }
        }

        private void comboBox_TileSize_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadZoom();
        }

        private void LoadZoom()
        {
            comboBox_Zoom.Items.Clear();
            string dir = Path.Combine(settings.RootFolder, comboBox_TileSize.Text);

            foreach (var item in Directory.GetDirectories(dir).OrderBy(e => e))
            {
                comboBox_Zoom.Items.Add(Path.GetFileName(item));
            }

            if (comboBox_Zoom.Items.Count > 0)
            {
                comboBox_Zoom.SelectedItem = comboBox_Zoom.Items[0];
            }
        }

        private void comboBox_Zoom_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSeed();
        }

        private void LoadSeed()
        {
            comboBox_Seed.Items.Clear();
            string dir = Path.Combine(settings.RootFolder, comboBox_TileSize.Text, comboBox_Zoom.Text);

            foreach (var item in Directory.GetDirectories(dir).OrderBy(e => e))
            {
                comboBox_Seed.Items.Add(Path.GetFileName(item));
            }

            if (comboBox_Seed.Items.Count > 0)
            {
                comboBox_Seed.SelectedItem = comboBox_Seed.Items[0];
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            string dir = Path.Combine(settings.RootFolder, comboBox_TileSize.Text, comboBox_Zoom.Text, comboBox_Seed.Text);
            logic.LoadPictureFiles(dir);

            logic.LoadEverything();
        }
    }
}