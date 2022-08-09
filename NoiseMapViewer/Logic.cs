using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseMapViewer
{
    public class Logic
    {
        PictureBox[,] pictureBoxes;
        string[,] pictures;
        Settings settings;
        FlowLayoutPanel flowLayoutPanel_Pictures;
        FlowLayoutPanel flowLayoutPanel1;
        ToolStripLabel toolStripStatusLabel_Position;
        Dictionary<string, Image> imageCache;

        public Logic(Settings settings, FlowLayoutPanel flowLayoutPanelPictures, FlowLayoutPanel flowLayoutPanel1, ToolStripLabel toolStripStatusLabelPosition)
        {
            this.settings = settings;
            flowLayoutPanel_Pictures = flowLayoutPanelPictures;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.toolStripStatusLabel_Position = toolStripStatusLabelPosition;
            imageCache = new Dictionary<string, Image>();
        }


        #region Logic
        public void LoadEverything()
        {
            flowLayoutPanel_Pictures.SuspendLayout();

            pictureBoxes = new PictureBox[settings.Tiles, settings.Tiles];

            BuildThePictureBoxes();

            PutPicturesInPictureBoxes();

            flowLayoutPanel_Pictures.ResumeLayout();
        }

        public void PutPicturesInPictureBoxes()
        {
            Dictionary<string, Image> newImageCache = new Dictionary<string, Image>();

            int offSet = (settings.Tiles - 1) / 2;
            int xPos = settings.PositionX;
            int yPos = settings.PositionY;

            int xPosMax = pictures.GetLength(0) - 1;
            int yPosMax = pictures.GetLength(1) - 1;

            for (int x = 0; x < settings.Tiles; x++)
            {
                for (int y = 0; y < settings.Tiles; y++)
                {
                    pictureBoxes[y, x].Image = null;

                    int xOffset = x - offSet + xPos;
                    int yOffset = y - offSet + yPos;

                    if (xOffset >= 0 && xOffset <= xPosMax)
                    {
                        if (yOffset >= 0 && yOffset <= yPosMax)
                        {
                            string fileName = pictures[xOffset, yOffset];

                            if (imageCache.TryGetValue(fileName, out Image image))
                            {
                                newImageCache.Add(fileName, image);
                            }
                            else
                            {
                                image = Image.FromFile(fileName);
                                newImageCache.Add(fileName, image);
                            }

                            pictureBoxes[y, x].Image = image;
                        }
                    }
                }
            }


            CleanupOldImages(imageCache, newImageCache);

            imageCache = newImageCache;

            toolStripStatusLabel_Position.Text = Path.GetFileNameWithoutExtension(pictures[settings.PositionX, settings.PositionY]);
        }

        private void CleanupOldImages(Dictionary<string, Image> imageCache, Dictionary<string, Image> newImageCache)
        {
            foreach (var item in imageCache.Keys)
            {
                if (!newImageCache.ContainsKey(item))
                {
                    imageCache[item].Dispose();
                }
            }
        }

        public void LoadPictureFiles(string path)
        {
            List<string> files = Directory.GetFiles(path, "*.png", SearchOption.AllDirectories).ToList();
            files.Sort();

            List<List<string>> listOfPictures = new List<List<string>>();
            string lastRow = "";
            List<string> row = new List<string>();
            foreach (var item in files)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
                string[] postions = fileNameWithoutExtension.Split("-");

                if (postions[0] != lastRow)
                {
                    row = new List<string>();
                    listOfPictures.Add(row);
                    lastRow = postions[0];
                }

                row.Add(item);
            }

            int xSize = listOfPictures[0].Count;
            int ySize = listOfPictures.Count;

            pictures = new string[xSize, ySize];

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    pictures[x, y] = listOfPictures[x][y];
                }
            }
        }

        public void BuildThePictureBoxes()
        {
            Padding padding = new Padding();
            padding.All = 0;

            int desiredPictureBoxes = settings.Tiles * settings.Tiles;
            while (flowLayoutPanel_Pictures.Controls.Count != desiredPictureBoxes)
            {
                if (flowLayoutPanel_Pictures.Controls.Count < desiredPictureBoxes)
                {
                    flowLayoutPanel_Pictures.Controls.Add(BuildPictureBox(padding));
                }
                else if (flowLayoutPanel_Pictures.Controls.Count > desiredPictureBoxes)
                {
                    flowLayoutPanel_Pictures.Controls[0].Dispose();
                }
            }

            int pos = 0;
            for (int x = 0; x < settings.Tiles; x++)
            {
                for (int y = 0; y < settings.Tiles; y++)
                {
                    PictureBox pictureBox = (PictureBox)flowLayoutPanel_Pictures.Controls[pos++];
                    pictureBoxes[x, y] = pictureBox;
                }
            }

            SizePictureBoxes();
        }

        public static PictureBox BuildPictureBox(Padding padding)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Margin = padding;
            return pictureBox;
        }

        public void SizePictureBoxes()
        {
            flowLayoutPanel_Pictures.SuspendLayout();

            foreach (Control item in flowLayoutPanel_Pictures.Controls)
            {
                item.SuspendLayout();
            }

            int dimension = Math.Min(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            int pictureBoxDimension = dimension / settings.Tiles;

            flowLayoutPanel_Pictures.Width = pictureBoxDimension * settings.Tiles;   //fix error when picture boxes were something like 15.8 pixels and the flow panel would put an extra tile in 
            flowLayoutPanel_Pictures.Height = pictureBoxDimension * settings.Tiles;

            foreach (Control item in flowLayoutPanel_Pictures.Controls)
            {
                item.Width = pictureBoxDimension;
                item.Height = pictureBoxDimension;
            }

            foreach (Control item in flowLayoutPanel_Pictures.Controls)
            {
                item.ResumeLayout();
            }

            flowLayoutPanel_Pictures.ResumeLayout();
        }
        #endregion Logic

    }
}
