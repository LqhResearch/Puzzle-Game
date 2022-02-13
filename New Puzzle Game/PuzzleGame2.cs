using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace New_Puzzle_Game
{
    public partial class PuzzleGame2 : Form
    {
        #region Properties
        private Bitmap imageFile;
        private PlaySound playSound = new PlaySound();
        private int totalSeconds = 0;
        private int pieceSize;
        private int piecesCount = 0;
        private bool isRedFrame = false;
        private string fileName = Application.StartupPath + @"\..\..\images\Picture-1.jpg";
        private List<PictureBox> originalPhotoList = new List<PictureBox>();

        // Tọa độ để xác định vị trí các khung ảnh sẽ tạo ra
        private int offSetX;
        private int offSetY;

        // Vị trí chuột trên khung ảnh khi bắt đầu khi bắt đầu drag. Dùng để điều chỉnh vị trí chuột luôn tương đối với khung ảnh.
        private Point startDragPoint;

        //Vị trí khung ảnh gốc khi bắt đầu drag dùng để hoán đổi vị trí ảnh nếu 2 ảnh mới đè lên ảnh cũ
        private Point picLocation;
        #endregion

        public PuzzleGame2()
        {
            InitializeComponent();
            DifficultyLevel(3);
            totalSeconds = 0;
        }

        #region Common function
        private void DifficultyLevel(int x)
        {
            PictureBox A = null;
            for (int i = 0; i < piecesCount * piecesCount; i++)
                pnlUI.Controls.Remove(originalPhotoList[i]);
            originalPhotoList.RemoveRange(0, piecesCount * piecesCount);
            pnlImage.Controls.Clear();
            pnlImage.Invalidate();
            piecesCount = x;
            for (int i = 0; i < piecesCount * piecesCount; i++)
                originalPhotoList.Add(A);
            for (int i = 0; i < originalPhotoList.Count; i++)
            {
                originalPhotoList[i] = new PictureBox();
                originalPhotoList[i].MouseUp += new MouseEventHandler(picCell_MouseUp);
                originalPhotoList[i].MouseMove += new MouseEventHandler(picCell_MouseMove);
                originalPhotoList[i].MouseDown += new MouseEventHandler(picCell_MouseDown);
                pnlUI.Controls.Add(originalPhotoList[i]);
            }

            // Thêm sự kiện vẽ lưới vào sự kiện Paint của pnlImage
            pnlImage.Paint += new PaintEventHandler(DrawGrid);
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void DrawGrid(object obj, PaintEventArgs pe) // Sự kiện vẽ lưới cho pnlImage
        {
            Graphics graphics = pnlImage.CreateGraphics();
            Pen pen = Pens.White;
            int totalPieces = pieceSize * piecesCount;
            for (int i = 0; i < piecesCount; i++)
            {
                int pos = pieceSize * i;
                graphics.DrawLine(pen, new Point(0, pos), new Point(totalPieces, pos)); // Vẽ lưới ngang
                graphics.DrawLine(pen, new Point(pos, 0), new Point(pos, totalPieces)); // Vẽ lưới dọc
            }
        }

        private void LoadPicture()
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file \n" + fileName, "Lỗi đường dẫn", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int size = pieceSize * piecesCount + 3;
                offSetX = size + 117; offSetY = 0;
                Common.CropPhoto(originalPhotoList, imageFile, piecesCount, pieceSize, offSetX, offSetY, 0);

                // Xáo trộn các khung ảnh
                Rectangle imageRect = new Rectangle(0, 0, imageSize, imageSize);
                Bitmap originalPhotoListc = imageFile.Clone(imageRect, PixelFormat.DontCare);
                picAnswer.Image = new Bitmap(originalPhotoListc, new Size(150, 150));

                // Tính toán vị trí
                pnlImage.Size = new Size(size, size);
                this.Size = new Size(size * 2 + 130, size + 150 + 100 + 24);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsWin()
        {
            for (int i = 0; i < piecesCount; i++)
                for (int j = 0; j < piecesCount; j++)
                {
                    int index = i * piecesCount + j; // Tính thứ tự đúng của khung ảnh ở vị trí hiện tại
                    Control ctl = pnlUI.GetChildAtPoint(new Point(j * pieceSize + 1, i * pieceSize + 1)); // Lấy control tại vị trí hiện tại
                    if (ctl == null || !(ctl is PictureBox)) // Nếu khung ảnh không tồn tại trả về false
                        return false;
                    if (ctl.Tag.ToString() != index.ToString()) // Nếu khung ảnh có vị trí sai trả về false
                        return false;
                }
            return true;
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
        private void picture1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-1.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-2.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = Application.StartupPath + @"\..\..\images\Picture-3.jpg";
            LoadPicture();
            playToolStripMenuItem.Enabled = true;
        }

        private void picture4ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.ShufflePhotos(originalPhotoList, piecesCount);
            playToolStripMenuItem.Enabled = false;

            // Hiển thị thời gian lên màn hình
            totalSeconds = 0;
            PrintTime();
            timer.Start();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTime.Text = "00:00";
            DifficultyLevel(piecesCount);
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
        #region Drag and drop picture
        private void picCell_MouseDown(object sender, MouseEventArgs e)
        {
            if (playToolStripMenuItem.Enabled)
                MessageBox.Show("Bạn hãy nhấn Play (Alt+A) để để bắt đầu chơi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Khi nhấn chuột và khung ảnh, sẽ lưu vị trí nhấn chuột và vị trí khung ảnh lại
            PictureBox pic = (PictureBox)sender;
            startDragPoint = e.Location;
            picLocation = pic.Location;

            // Đưa khung ảnh lên trên cùng để ko bị che mất
            pic.BringToFront();
            isRedFrame = true;
        }

        private void picCell_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            // Di chuyển khung ảnh theo chuột khi kéo
            if (e.Button == MouseButtons.Left)
                pic.Location = new Point(pic.Left + e.X - startDragPoint.X, pic.Top + e.Y - startDragPoint.Y);

            // Tính vị trí dòng và cột với đơn vị là 1 pieceSize
            int col = pic.Location.X / pieceSize;
            int row = pic.Location.Y / pieceSize;
            if (col >= piecesCount || row >= piecesCount)
                return;

            // Vẽ đường biên màu đỏ xác định vị trí mới của ảnh trên panel
            if (isRedFrame)
            {
                Graphics graphics = pnlImage.CreateGraphics();
                graphics.DrawRectangle(Pens.Red, new Rectangle(col * pieceSize, row * pieceSize, pieceSize, pieceSize));
            }
        }

        private void picCell_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            // Tính vị trí dòng và cột với đơn vị là 1 pieceSize
            int col = pic.Location.X / pieceSize;
            int row = pic.Location.Y / pieceSize;
            if (col >= piecesCount || row >= piecesCount)
                return;

            Control ctrl = pnlUI.GetChildAtPoint(new Point(col * pieceSize + 1, row * pieceSize + 1)); // Lấy control tại ví trí mới

            // Nếu đã có một khung ảnh tại ô này, thì chuyển vị trí của khung ảnh này về vị trí của khung ảnh vừa drop
            if (ctrl != null && ctrl is PictureBox)
                ctrl.Location = picLocation;

            // Gán vị trí mới cho khung ảnh
            pic.Location = new Point(col * pieceSize + 1, row * pieceSize + 1);

            if (IsWin())
            {
                //Dừng và hiển thị thời gian kết quả
                timer.Stop();
                MessageBox.Show("Bạn đã hoàn thành", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            isRedFrame = false;
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            PrintTime();
        }
    }
}