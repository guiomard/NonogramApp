using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Medium : ContentPage
	{
        int[,] currentMap = new int[10, 10];
        int[,] currentMapColor = new int[10, 10];
        int currentRep;
        Repository rep = new Repository();
        Random random = new Random();
        public Medium()
        {
            InitializeComponent();

            currentRep = random.Next(10);
            setGrid(currentRep);
        }
        private void OnButtonHomeClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void newClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Medium());
        }
        private void checkClicked(object sender, EventArgs e)
        {
            int errors = 0;

            for (int ck1 = 0; ck1 < 10; ck1++)
            {
                for (int ck2 = 0; ck2 < 10; ck2++)
                {
                    if (currentMap[ck2, ck1] != rep.getMediumPuzzleGrid(currentRep, ck2, ck1)) { errors++; }
                }
            }

            if (errors > 0)
            {
                checkButton.Text = errors + " incorrent tiles";
                checkButton.BackgroundColor = Color.Red;
                checkButton.FontSize = 10;
            }
            else
            {
                checkButton.Text = "Solved";
                checkButton.BackgroundColor = Color.Green;
                checkButton.FontSize = 15;
            }


            //homeButton.BackgroundColor = Color.Red;
            //ver1.Text = rep.getPuzzleHeader(0, 0, 0);

        }

        private void setGrid(int i)
        {
            hor1.Text = rep.getMediumPuzzleHeader(i, 0, 0);
            hor2.Text = rep.getMediumPuzzleHeader(i, 0, 1);
            hor3.Text = rep.getMediumPuzzleHeader(i, 0, 2);
            hor4.Text = rep.getMediumPuzzleHeader(i, 0, 3);
            hor5.Text = rep.getMediumPuzzleHeader(i, 0, 4);
            hor6.Text = rep.getMediumPuzzleHeader(i, 0, 5);
            hor7.Text = rep.getMediumPuzzleHeader(i, 0, 6);
            hor8.Text = rep.getMediumPuzzleHeader(i, 0, 7);
            hor9.Text = rep.getMediumPuzzleHeader(i, 0, 8);
            hor10.Text = rep.getMediumPuzzleHeader(i, 0, 9);

            ver1.Text = rep.getMediumPuzzleHeader(i, 1, 0);
            ver2.Text = rep.getMediumPuzzleHeader(i, 1, 1);
            ver3.Text = rep.getMediumPuzzleHeader(i, 1, 2);
            ver4.Text = rep.getMediumPuzzleHeader(i, 1, 3);
            ver5.Text = rep.getMediumPuzzleHeader(i, 1, 4);
            ver6.Text = rep.getMediumPuzzleHeader(i, 1, 5);
            ver7.Text = rep.getMediumPuzzleHeader(i, 1, 6);
            ver8.Text = rep.getMediumPuzzleHeader(i, 1, 7);
            ver9.Text = rep.getMediumPuzzleHeader(i, 1, 8);
            ver10.Text = rep.getMediumPuzzleHeader(i, 1, 9);
        }
        private void OnTileClicked(object sender, EventArgs e)
        {
            var thisTile = sender as Button;
            int thisRow = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(thisTile.CommandParameter) / 10) - 1));
            int thisCol = (Convert.ToInt32(thisTile.CommandParameter) % 10 - 1);

            if (thisCol < 0) { thisCol = 9; }

            switch (currentMapColor[thisRow, thisCol])
            {
                case 0:
                    thisTile.BackgroundColor = Color.Black;
                    currentMapColor[thisRow, thisCol]++;
                    currentMap[thisRow, thisCol] = 1;
                    break;
                case 1:
                    thisTile.BackgroundColor = Color.Red;
                    currentMapColor[thisRow, thisCol]++;
                    currentMap[thisRow, thisCol] = 0;
                    break;
                case 2:
                    thisTile.BackgroundColor = Color.White;
                    currentMapColor[thisRow, thisCol] = 0;
                    currentMap[thisRow, thisCol] = 0;
                    break;
                default:
                    thisTile.BackgroundColor = Color.White;
                    currentMap[thisRow, thisCol] = 0;
                    break;
            }

            homeButton.Text = (thisRow).ToString() + " " + (thisCol).ToString() + " " + currentMapColor[thisRow, thisCol];
        }
    }
}