using System.Drawing;
using System.Windows.Forms;

namespace New_Puzzle_Game
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnPuzzleGame1, "Xếp hình 1");
            tool.SetToolTip(btnPuzzleGame2, "Xếp hình 2");
            tool.SetToolTip(btnExit, "Thoát khỏi trò chơi");
            tool.SetToolTip(btnAbout, "Thông tin về tác giả");
        }

        private void btnPuzzleGame1_Click(object sender, System.EventArgs e)
        {
            PuzzleGame1 puzzle = new PuzzleGame1();
            this.Hide();
            puzzle.ShowDialog();
            this.Show();
        }

        private void btnPuzzleGame2_Click(object sender, System.EventArgs e)
        {
            PuzzleGame2 puzzle = new PuzzleGame2();
            this.Hide();
            puzzle.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Hover(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = Color.Green;
        }

        private void btn_Leave(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void btnAbout_Click(object sender, System.EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
