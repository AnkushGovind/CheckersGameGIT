using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGameGP
{
    public partial class CheckersGameForm : Form
    {
        private static CheckersGameForm CheckersGameInstance;
        int n;
        PictureBox[,] pictureBox;
        public CheckersGameForm()
        {
            InitializeComponent();
        }

        internal static CheckersGameForm CheckersGameFormInstance()
        {
            if (CheckersGameInstance == null)

                CheckersGameInstance = new CheckersGameForm();
            return CheckersGameInstance;

        }


        private void CheckersGameForm_Load(object sender, EventArgs e)
        {
            n = 8;
            pictureBox = new PictureBox[n, n];
            int left = 2, top = 2;           
            Color[] colors = new Color[] {Color.White, Color.Black };
            for(int i = 0; i < n; i++)
            {
                left = 2;               
                if (i % 2 == 0){colors[0] = Color.White; colors[1] = Color.Black;}
                else {colors[1] = Color.White; colors[0] = Color.Black;}

                for(int j = 0; j < n; j++)
                {
                   
                    pictureBox[i,j]=new PictureBox();
                    pictureBox[i,j].Size = new Size(60,60);
                    pictureBox[i,j].BackColor = colors[(j%2==0) ? 1:0];
                    pictureBox[i,j].Location=new Point(left, top);
                    left +=60;
                    panel1.Controls.Add(pictureBox[i,j]);
                }
                top +=60;
            }


        }

        private void CheckersGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckersGameInstance = null;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayerInfoPanel.Visible=false;
        }
    }
}
