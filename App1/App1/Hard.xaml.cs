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
	public partial class Hard : ContentPage
    {
        int[,] currentMap = new int[15, 15];
        int[,] currentMapColor = new int[15, 15];
        int currentRep;
        Repository rep = new Repository();
        Random random = new Random();
        public Hard()
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
            Navigation.PushAsync(new Hard());
        }
        private void checkClicked(object sender, EventArgs e)
        {
            int errors = 0;

            for (int ck1 = 0; ck1 < 15; ck1++)
            {
                for (int ck2 = 0; ck2 < 15; ck2++)
                {
                    if (currentMap[ck2, ck1] != rep.getHardPuzzleGrid(currentRep, ck2, ck1)) { errors++; }
                }
            }

            if (errors > 0)
            {
                checkButton.Text = errors + " incorrent tiles";
                checkButton.BackgroundColor = Color.Red;
                checkButton.FontSize = 5;
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
            hor1.Text = rep.getHardPuzzleHeader(i, 0, 0);
            hor2.Text = rep.getHardPuzzleHeader(i, 0, 1);
            hor3.Text = rep.getHardPuzzleHeader(i, 0, 2);
            hor4.Text = rep.getHardPuzzleHeader(i, 0, 3);
            hor5.Text = rep.getHardPuzzleHeader(i, 0, 4);
            hor6.Text = rep.getHardPuzzleHeader(i, 0, 5);
            hor7.Text = rep.getHardPuzzleHeader(i, 0, 6);
            hor8.Text = rep.getHardPuzzleHeader(i, 0, 7);
            hor9.Text = rep.getHardPuzzleHeader(i, 0, 8);
            hor10.Text = rep.getHardPuzzleHeader(i, 0, 9);
            hor11.Text = rep.getHardPuzzleHeader(i, 0, 10);
            hor12.Text = rep.getHardPuzzleHeader(i, 0, 11);
            hor13.Text = rep.getHardPuzzleHeader(i, 0, 12);
            hor14.Text = rep.getHardPuzzleHeader(i, 0, 13);
            hor15.Text = rep.getHardPuzzleHeader(i, 0, 14);

            ver1.Text = rep.getHardPuzzleHeader(i, 1, 0);
            ver2.Text = rep.getHardPuzzleHeader(i, 1, 1);
            ver3.Text = rep.getHardPuzzleHeader(i, 1, 2);
            ver4.Text = rep.getHardPuzzleHeader(i, 1, 3);
            ver5.Text = rep.getHardPuzzleHeader(i, 1, 4);
            ver6.Text = rep.getHardPuzzleHeader(i, 1, 5);
            ver7.Text = rep.getHardPuzzleHeader(i, 1, 6);
            ver8.Text = rep.getHardPuzzleHeader(i, 1, 7);
            ver9.Text = rep.getHardPuzzleHeader(i, 1, 8);
            ver10.Text = rep.getHardPuzzleHeader(i, 1, 9);
            ver11.Text = rep.getHardPuzzleHeader(i, 1, 10);
            ver12.Text = rep.getHardPuzzleHeader(i, 1, 11);
            ver13.Text = rep.getHardPuzzleHeader(i, 1, 12);
            ver14.Text = rep.getHardPuzzleHeader(i, 1, 13);
            ver15.Text = rep.getHardPuzzleHeader(i, 1, 14);
        }
        private void OnTileClicked(object sender, EventArgs e)
        {
            var thisTile = sender as Button;
            int thisRow = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(thisTile.CommandParameter) / 15) - 1));
            int thisCol = (Convert.ToInt32(thisTile.CommandParameter) % 15 - 1);

            if (thisCol < 0) { thisCol = 14; }

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

            homeButton.Text = (thisRow).ToString() + " " + (thisCol).ToString() + " " + currentMapColor[thisRow, thisCol] + " " + currentMap[thisRow, thisCol];
        }
    }
}