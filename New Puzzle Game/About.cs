using System;
using System.Windows.Forms;

namespace New_Puzzle_Game
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblProductName.Text = String.Format("Product name: {0}", Application.ProductName);
            lblProductVersion.Text = String.Format("Product version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright © 2021 by QH";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
