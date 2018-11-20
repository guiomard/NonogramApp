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
    public partial class Repository : ContentPage
    {
        public static int[,] easy0Grid = new int[,] { { 1, 1, 1, 0, 0 }, { 1, 1, 1, 0, 0 }, { 1, 0, 1, 1, 1 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 1 } };
        public static String[,] easy0Header = new string[,] { { "3", "2", "3", "1\n1", "3" }, { "3", "3", "1 3", "1", "2" } };
        public static int[,] easy1Grid = new int[,] { { 1, 1, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 1, 1 }, { 0, 1, 0, 1, 0 } };
        public static String[,] easy1Header = new string[,] { { "1", "1\n1\n1", "3", "3", "3" }, { "3", "1 1", "4", "2", "1 1" } };
        public static int[,] easy2Grid = new int[,] { { 1, 1, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 1, 1 }, { 0, 1, 0, 1, 0 } };
        public static String[,] easy2Header = new string[,] { { "1", "1\n1\n1", "3", "3", "3" }, { "3", "1 1", "4", "2", "1 1" } };
        public static int[,] easy3Grid = new int[,] { { 1, 1, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 0, 1, 1, 1, 1 }, { 0, 0, 0, 1, 1 }, { 0, 1, 0, 1, 0 } };
        public static String[,] easy3Header = new string[,] { { "1", "1\n1\n1", "3", "3", "3" }, { "3", "1 1", "4", "2", "1 1" } };
        public static int[,] easy4Grid = new int[,] { { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 1 }, { 1, 1, 1, 0, 1 }, { 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 0 } };
        public static String[,] easy4Header = new string[,] { { "2", "3", "3", "1\n1", "3" }, { "2", "1", "3 1", "3", "3" } };
        public static int[,] easy5Grid = new int[,] { { 0, 0, 0, 0, 1 }, { 0, 0, 1, 1, 1 }, { 1, 0, 0, 0, 1 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 0, 0 } };
        public static String[,] easy5Header = new string[,] { { "3", "2", "1\n2", "1\n1", "3" }, { "1", "3", "1 1", "4", "3" } };
        public static int[,] easy6Grid = new int[,] { { 1, 1, 1, 1, 0 }, { 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 }, { 1, 0, 1, 1, 1 } };
        public static String[,] easy6Header = new string[,] { { "1\n1", "2", "3\n1", "1\n2", "2" }, { "4", "2", "1", "2", "1 3" } };
        public static int[,] easy7Grid = new int[,] { { 0, 1, 1, 1, 1 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 0 }, { 1, 1, 1, 1, 0 } };
        public static String[,] easy7Header = new string[,] { { "2", "1\n2", "1\n1", "3\n1", "2" }, { "4", "2", "1", "2", "4" } };
        public static int[,] easy8Grid = new int[,] { { 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 1, 1, 0, 0 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 } };
        public static String[,] easy8Header = new string[,] { { "1\n2", "3\n1", "3", "1", "2" }, { "2", "1", "2", "1 3", "3 1" } };
        public static int[,] easy9Grid = new int[,] { { 1, 1, 0, 1, 1 }, { 0, 0, 0, 1, 1 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 1, 1, 1 } };
        public static String[,] easy9Header = new string[,] { { "1\n1", "1\n1", "1", "2\n2", "2\n2" }, { "2 2", "2", "2", "2", "3" } };
        public static int[,] easyxGrid = new int[,] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        public static String[,] easyxHeader = new string[,] { { "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0" } };

        public Repository()
        {
            InitializeComponent();
            
        }

        public String getEasyPuzzleHeader(int i1, int i2, int i3)
        {
            switch (i1)
            {
                case 0:
                    return easy0Header[i2, i3];
                    break;
                case 1:
                    return easy1Header[i2, i3];
                    break;
                case 2:
                    return easy2Header[i2, i3];
                    break;
                case 3:
                    return easy3Header[i2, i3];
                    break;
                case 4:
                    return easy4Header[i2, i3];
                    break;
                case 5:
                    return easy5Header[i2, i3];
                    break;
                case 6:
                    return easy6Header[i2, i3];
                    break;
                case 7:
                    return easy7Header[i2, i3];
                    break;
                case 8:
                    return easy8Header[i2, i3];
                    break;
                case 9:
                    return easy9Header[i2, i3];
                    break;
                default:
                    return "";
                    break;
            }
        }
        public int getEasyPuzzleGrid(int i1, int i2, int i3)
        {
            switch (i1)
            {
                case 0:
                    return easy0Grid[i2, i3];
                    break;
                case 1:
                    return easy1Grid[i2, i3];
                    break;
                case 2:
                    return easy2Grid[i2, i3];
                    break;
                case 3:
                    return easy3Grid[i2, i3];
                    break;
                case 4:
                    return easy4Grid[i2, i3];
                    break;
                case 5:
                    return easy5Grid[i2, i3];
                    break;
                case 6:
                    return easy6Grid[i2, i3];
                    break;
                case 7:
                    return easy7Grid[i2, i3];
                    break;
                case 8:
                    return easy8Grid[i2, i3];
                    break;
                case 9:
                    return easy9Grid[i2, i3];
                    break;
                default:
                    return 0;
                    break;
            }
        }


    }
}