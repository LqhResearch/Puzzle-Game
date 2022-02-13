using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace New_Puzzle_Game
{
    public enum Direction { Left, Right, Up, Down };
    public partial class PuzzleGame1 : Form
    {
        #region Properties
        private Bitmap imageFile;
        private PlaySound playSound = new PlaySound();
        private int totalSeconds;
        private int totalTurns;
        private int pieceSize;
        private int piecesCount;
        private int emptyPieceIndex;
        private int distance = 2;
        private string fileName = Application.StartupPath + @"\..\..\images\Picture-1.jpg";
        private List<PictureBox> originalPhotoList = new List<PictureBox>();
        private List<PictureBox> backgroundList = new List<PictureBox>();
        #endregion

        public PuzzleGame1()
        {
            InitializeComponent();
        }

        private void PuzzleGame1_Load(object sender, EventArgs e)
        {
            DifficultyLevel(3);
            totalSeconds = 0;
            totalTurns = 0;
        }

        #region Common function
        private void LoadPicture()
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file \n" + fileName, "Lỗi tìm FILE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Bitmap bmp = new Bitmap(fileName);

                float width = bmp.Size.Width;
                float height = bmp.Size.Height;
                float minSize = (width < height) ? width : height;

                float factor = 350 / minSize;
                if (factor > 0)
                {
                    width *= factor;
                    height *= factor;
                }

                imageFile = new Bitmap(bmp, new Size((int)width, (int)height));
                int imageSize = (imageFile.Width < imageFile.Height) ? imageFile.Width : imageFile.Height;
                imageSize -= imageSize % piecesCount;
                pieceSize = imageSize / piecesCount;

                // Tạo và sắp xếp các khung ảnh
                Rectangle imageRect = new Rectangle(0, 0, imageSize, imageSize);
                Bitmap originalPhoto = imageFile.Clone(imageRect, PixelFormat.DontCare);
                picAnswer.Image = new Bitmap(originalPhoto, new Size(150, 150));
                Common.CropPhoto(originalPhotoList, imageFile, piecesCount, pieceSize, 0, 0, distance);
                emptyPieceIndex = piecesCount * piecesCount - 1;

                // Làm việc với vị trí và kích thước
                int size = pieceSize * piecesCount + distance * (piecesCount - 1);
                pnlOriginPhoto.Size = new Size(size, size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessDialogKey(Keys key) // Sử dụng phím trên bàn phím
        {
            if (key == Keys.Up)
                lblMove_Click(lblUp, EventArgs.Empty);
            else if (key == Keys.Down)
                lblMove_Click(lblDown, EventArgs.Empty);
            else if (key == Keys.Left)
                lblMove_Click(lblLeft, EventArgs.Empty);
            else if (key == Keys.Right)
                lblMove_Click(lblRight, EventArgs.Empty);
            return base.ProcessDialogKey(key);
        }

        private void DifficultyLevel(int x)
        {
            PictureBox A = null;
            backgroundList.RemoveRange(0, piecesCount * piecesCount);
            originalPhotoList.RemoveRange(0, piecesCount * piecesCount);
            pnlOriginPhoto.Controls.Clear();
            piecesCount = x;
            emptyPieceIndex = piecesCount * piecesCount - 1;
            for (int i = 0; i < piecesCount * piecesCount; i++)
            {
                backgroundList.Add(A);
                originalPhotoList.Add(A);
            }
            for (int i = 0; i < originalPhotoList.Count; i++)
            {
                backgroundList[i] = new PictureBox();
                originalPhotoList[i] = new PictureBox();
                pnlOriginPhoto.Controls.Add(originalPhotoList[i]);
            }
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private bool IsWin()
        {
            for (int i = 0; i < originalPhotoList.Count; i++)
                if (originalPhotoList[i].Tag.ToString() != i.ToString())
                    return false;
            return true;
        }

        private bool IsMoveValid(Direction direction) //Yes
        {
            bool isValid = false;
            switch (direction)
            {
                case Direction.Left:
                    isValid = (emptyPieceIndex % piecesCount != (piecesCount - 1));
                    break;
                case Direction.Right:
                    isValid = (emptyPieceIndex % piecesCount != 0);
                    break;
                case Direction.Up:
                    isValid = (emptyPieceIndex < piecesCount * piecesCount - piecesCount);
                    break;
                case Direction.Down:
                    isValid = (emptyPieceIndex > piecesCount - 1);
                    break;
            }
            return isValid;
        }

        private void PrintTime()
        {
            if ((totalSeconds / 60) < 10)
                lblTime.Text = "0" + (totalSeconds / 60);
            else lblTime.Text = (totalSeconds / 60).ToString();

            if ((totalSeconds % 60) < 10)
                lblTime.Text += ":0" + (totalSeconds % 60);
            else lblTime.Text += ":" + (totalSeconds % 60).ToString();
        }
        #endregion
        #region Menu tool strip
        private void picture1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-1.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-2.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-3.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-4.png";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void chooseFromPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp|GIF Files(*.gif)|*.gif|All Files|*.*", RestoreDirectory = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    LoadPicture();
                    playToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lastPosition = 0;
            int lastPoint = piecesCount * piecesCount - 1;

            Common.ShufflePhotos(originalPhotoList, piecesCount);
            playToolStripMenuItem.Enabled = false;

            for (int i = 0; i < lastPoint + 1; i++)
                if (originalPhotoList[i].Tag.ToString() == lastPoint.ToString())
                {
                    lastPosition = i;
                    break;
                }

            originalPhotoList[lastPosition].Image = originalPhotoList[lastPoint].Image;
            originalPhotoList[lastPosition].Tag = originalPhotoList[lastPoint].Tag;
            originalPhotoList[lastPoint].Tag = lastPoint;
            originalPhotoList[lastPoint].Image = null;

            int size = pieceSize * piecesCount + distance * (piecesCount - 1);
            pnlOriginPhoto.Size = new Size(size, size);

            // Hiển thị thời gian lên màn hình
            totalSeconds = 0;
            totalTurns = 0;
            PrintTime();
            timer.Start();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTime.Text = "00:00";
            lblTurn.Text = "0";
            DifficultyLevel(piecesCount);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyLevel(3);
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyLevel(4);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyLevel(5);
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyLevel(6);
        }


        private void backHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (audioToolStripMenuItem.Text == "Sound")
            {
                playSound.OpenMediaFile("sound.mp3");
                playSound.PlayMediaFile(true);
                audioToolStripMenuItem.Text = "No sound";
            }
            else
            {
                playSound.CloseMediaFile();
                audioToolStripMenuItem.Text = "Sound";
            }
        }
        #endregion
        #region Events
        private void lblMove_Click(object sender, EventArgs e)
        {
            if (playToolStripMenuItem.Enabled == true)
            {
                MessageBox.Show("Bạn hãy nhấn Play (Alt+A) để để bắt đầu chơi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Bitmap tempBmp;
            int indexToSwap = -1;
            if (sender == lblLeft)
                if (IsMoveValid(Direction.Left))
                    indexToSwap = emptyPieceIndex + 1;
            if (sender == lblRight)
                if (IsMoveValid(Direction.Right))
                    indexToSwap = emptyPieceIndex - 1;
            if (sender == lblUp)
                if (IsMoveValid(Direction.Up))
                    indexToSwap = emptyPieceIndex + piecesCount;
            if (sender == lblDown)
                if (IsMoveValid(Direction.Down))
                    indexToSwap = emptyPieceIndex - piecesCount;
            if (indexToSwap != -1)
            {
                lblTurn.Text = (++totalTurns).ToString(); //Tăng số lần đi lên 1 và in ra
                tempBmp = (Bitmap)originalPhotoList[indexToSwap].Image;
                tempBmp.Tag = originalPhotoList[indexToSwap].Tag;
                originalPhotoList[indexToSwap].Image = originalPhotoList[emptyPieceIndex].Image;
                originalPhotoList[indexToSwap].Tag = originalPhotoList[emptyPieceIndex].Tag;
                originalPhotoList[emptyPieceIndex].Image = tempBmp;
                originalPhotoList[emptyPieceIndex].Tag = tempBmp.Tag;
                emptyPieceIndex = indexToSwap;
            }
            if (IsWin())
            {
                //Dừng và hiển thị thời gian kết quả
                timer.Stop();
                MessageBox.Show("Bạn đã hoàn thành!!!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblArrow_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Black;
            ((Label)sender).ForeColor = Color.White;
        }

        private void lblArrow_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
            ((Label)sender).ForeColor = Color.Black;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            PrintTime();
        }
        #endregion
    }
}
