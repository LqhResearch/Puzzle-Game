using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace New_Puzzle_Game
{
    public class Common
    {
        public static void ShufflePhotos(List<PictureBox> originalPhotoList, int piecesCount)
        {
            Bitmap bmp;
            Random rnd = new Random();
            //Tổng số mảnh ghép
            int totalPieces = piecesCount * piecesCount;

            for (int i = 0; i < totalPieces; i++)
            {
                int indexSource = rnd.Next(totalPieces);
                int indexDest = rnd.Next(totalPieces);
                if (indexSource == indexDest)
                    continue;

                try
                {
                    bmp = (Bitmap)originalPhotoList[indexSource].Image;
                    bmp.Tag = originalPhotoList[indexSource].Tag.ToString();
                    originalPhotoList[indexSource].Image = originalPhotoList[indexDest].Image;
                    originalPhotoList[indexSource].Tag = originalPhotoList[indexDest].Tag;
                    originalPhotoList[indexDest].Image = bmp;
                    originalPhotoList[indexDest].Tag = bmp.Tag;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error: shuffle photos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void CropPhoto(List<PictureBox> originalPhotoList, Bitmap imageFile, int piecesCount, int pieceSize, int offSetX, int offSetY, int distance)
        {
            if (imageFile != null)
            {
                int piecesIndex = 0;
                for (int j = 0; j < piecesCount; j++)
                    for (int i = 0; i < piecesCount; i++)
                    {
                        try
                        {
                            Rectangle imageRect = new Rectangle(i * pieceSize, j * pieceSize, pieceSize, pieceSize);
                            originalPhotoList[piecesIndex].Image = null;
                            originalPhotoList[piecesIndex].Image = imageFile.Clone(imageRect, PixelFormat.DontCare);
                            originalPhotoList[piecesIndex].Location = new Point(offSetX + i * (pieceSize + distance), offSetY + j * (pieceSize + distance));
                            originalPhotoList[piecesIndex].Size = new Size(pieceSize, pieceSize);
                            originalPhotoList[piecesIndex].Tag = piecesIndex.ToString();
                            piecesIndex++;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Error: crop photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }
    }
}