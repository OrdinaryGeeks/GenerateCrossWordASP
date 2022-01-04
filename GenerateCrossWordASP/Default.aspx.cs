using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GenerateCrossWordASP
{
    public partial class _Default : Page
    {

        string[][] validEntries;
        bool[][] openSpace;

        StreamWriter answerKey;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {





            }
            else
            {
                answerKey = new StreamWriter(new FileStream((@"C:\Users\Nathan\Desktop\AnswerKeys\answerKey.txt"), FileMode.OpenOrCreate));



                openSpace = new bool[20][];
                validEntries = new string[20][];
                for (int i = 0; i < 20; i++)

                {
                    openSpace[i] = new bool[20];
                    validEntries[i] = new string[20];

                }

                for(int i = 0; i<20; i++)
                    for(int j = 0; j<20; j++)
                    {

                        openSpace[i][j] = false;
                        validEntries[i][j] = "";
                    }




            }

        }
        public char RandomChar()
        {


            Random rand = new Random();

            int newCharIndex = rand.Next(0, 26);


            char[] theAlphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


            return theAlphabet[newCharIndex];




        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            answerKey = new StreamWriter(new FileStream((@"C:\Users\Nathan\Desktop\AnswerKeys\answerKey" + DateTime.Now.Minute + ".txt"), FileMode.OpenOrCreate));

            openSpace = new bool[20][];
            validEntries = new string[20][];
            for (int i = 0; i < 20; i++)

            {
                openSpace[i] = new bool[20];
                validEntries[i] = new string[20];

            }

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                {

                    openSpace[i][j] = false;
                    validEntries[i][j] = "";
                }


            #region
        
                if (tb0x0y.Text != "") { validEntries[0][0] = tb0x0y.Text; openSpace[0][0] = true; }
            if (tb0x1y.Text != "") { validEntries[0][1] = tb0x1y.Text; openSpace[0][1] = true; }
            if (tb0x2y.Text != "") { validEntries[0][2] = tb0x2y.Text; openSpace[0][2] = true; }
            if (tb0x3y.Text != "") { validEntries[0][3] = tb0x3y.Text; openSpace[0][3] = true; }
            if (tb0x4y.Text != "") { validEntries[0][4] = tb0x4y.Text; openSpace[0][4] = true; }
            if (tb0x5y.Text != "") { validEntries[0][5] = tb0x5y.Text; openSpace[0][5] = true; }
            if (tb0x6y.Text != "") { validEntries[0][6] = tb0x6y.Text; openSpace[0][6] = true; }
            if (tb0x7y.Text != "") { validEntries[0][7] = tb0x7y.Text; openSpace[0][7] = true; }
            if (tb0x8y.Text != "") { validEntries[0][8] = tb0x8y.Text; openSpace[0][8] = true; }
            if (tb0x9y.Text != "") { validEntries[0][9] = tb0x9y.Text; openSpace[0][9] = true; }
            if (tb0x10y.Text != "") { validEntries[0][10] = tb0x10y.Text; openSpace[0][10] = true; }
            if (tb0x11y.Text != "") { validEntries[0][11] = tb0x11y.Text; openSpace[0][11] = true; }
            if (tb0x12y.Text != "") { validEntries[0][12] = tb0x12y.Text; openSpace[0][12] = true; }
            if (tb0x13y.Text != "") { validEntries[0][13] = tb0x13y.Text; openSpace[0][13] = true; }
            if (tb0x14y.Text != "") { validEntries[0][14] = tb0x14y.Text; openSpace[0][14] = true; }
            if (tb0x15y.Text != "") { validEntries[0][15] = tb0x15y.Text; openSpace[0][15] = true; }
            if (tb0x16y.Text != "") { validEntries[0][16] = tb0x16y.Text; openSpace[0][16] = true; }
            if (tb0x17y.Text != "") { validEntries[0][17] = tb0x17y.Text; openSpace[0][17] = true; }
            if (tb0x18y.Text != "") { validEntries[0][18] = tb0x18y.Text; openSpace[0][18] = true; }
            if (tb0x19y.Text != "") { validEntries[0][19] = tb0x19y.Text; openSpace[0][19] = true; }

            if (tb1x0y.Text != "") { validEntries[1][0] = tb1x0y.Text; openSpace[1][0] = true; }
            if (tb1x1y.Text != "") { validEntries[1][1] = tb1x1y.Text; openSpace[1][1] = true; }
            if (tb1x2y.Text != "") { validEntries[1][2] = tb1x2y.Text; openSpace[1][2] = true; }
            if (tb1x3y.Text != "") { validEntries[1][3] = tb1x3y.Text; openSpace[1][3] = true; }
            if (tb1x4y.Text != "") { validEntries[1][4] = tb1x4y.Text; openSpace[1][4] = true; }
            if (tb1x5y.Text != "") { validEntries[1][5] = tb1x5y.Text; openSpace[1][5] = true; }
            if (tb1x6y.Text != "") { validEntries[1][6] = tb1x6y.Text; openSpace[1][6] = true; }
            if (tb1x7y.Text != "") { validEntries[1][7] = tb1x7y.Text; openSpace[1][7] = true; }
            if (tb1x8y.Text != "") { validEntries[1][8] = tb1x8y.Text; openSpace[1][8] = true; }
            if (tb1x9y.Text != "") { validEntries[1][9] = tb1x9y.Text; openSpace[1][9] = true; }
            if (tb1x10y.Text != "") { validEntries[1][10] = tb1x10y.Text; openSpace[1][10] = true; }
            if (tb1x11y.Text != "") { validEntries[1][11] = tb1x11y.Text; openSpace[1][11] = true; }
            if (tb1x12y.Text != "") { validEntries[1][12] = tb1x12y.Text; openSpace[1][12] = true; }
            if (tb1x13y.Text != "") { validEntries[1][13] = tb1x13y.Text; openSpace[1][13] = true; }
            if (tb1x14y.Text != "") { validEntries[1][14] = tb1x14y.Text; openSpace[1][14] = true; }
            if (tb1x15y.Text != "") { validEntries[1][15] = tb1x15y.Text; openSpace[1][15] = true; }
            if (tb1x16y.Text != "") { validEntries[1][16] = tb1x16y.Text; openSpace[1][16] = true; }
            if (tb1x17y.Text != "") { validEntries[1][17] = tb1x17y.Text; openSpace[1][17] = true; }
            if (tb1x18y.Text != "") { validEntries[1][18] = tb1x18y.Text; openSpace[1][18] = true; }
            if (tb1x19y.Text != "") { validEntries[1][19] = tb1x19y.Text; openSpace[1][19] = true; }

            if (tb2x0y.Text != "") { validEntries[2][0] = tb2x0y.Text; openSpace[2][0] = true; }
            if (tb2x1y.Text != "") { validEntries[2][1] = tb2x1y.Text; openSpace[2][1] = true; }
            if (tb2x2y.Text != "") { validEntries[2][2] = tb2x2y.Text; openSpace[2][2] = true; }
            if (tb2x3y.Text != "") { validEntries[2][3] = tb2x3y.Text; openSpace[2][3] = true; }
            if (tb2x4y.Text != "") { validEntries[2][4] = tb2x4y.Text; openSpace[2][4] = true; }
            if (tb2x5y.Text != "") { validEntries[2][5] = tb2x5y.Text; openSpace[2][5] = true; }
            if (tb2x6y.Text != "") { validEntries[2][6] = tb2x6y.Text; openSpace[2][6] = true; }
            if (tb2x7y.Text != "") { validEntries[2][7] = tb2x7y.Text; openSpace[2][7] = true; }
            if (tb2x8y.Text != "") { validEntries[2][8] = tb2x8y.Text; openSpace[2][8] = true; }
            if (tb2x9y.Text != "") { validEntries[2][9] = tb2x9y.Text; openSpace[2][9] = true; }
            if (tb2x10y.Text != "") { validEntries[2][10] = tb2x10y.Text; openSpace[2][10] = true; }
            if (tb2x11y.Text != "") { validEntries[2][11] = tb2x11y.Text; openSpace[2][11] = true; }
            if (tb2x12y.Text != "") { validEntries[2][12] = tb2x12y.Text; openSpace[2][12] = true; }
            if (tb2x13y.Text != "") { validEntries[2][13] = tb2x13y.Text; openSpace[2][13] = true; }
            if (tb2x14y.Text != "") { validEntries[2][14] = tb2x14y.Text; openSpace[2][14] = true; }
            if (tb2x15y.Text != "") { validEntries[2][15] = tb2x15y.Text; openSpace[2][15] = true; }
            if (tb2x16y.Text != "") { validEntries[2][16] = tb2x16y.Text; openSpace[2][16] = true; }
            if (tb2x17y.Text != "") { validEntries[2][17] = tb2x17y.Text; openSpace[2][17] = true; }
            if (tb2x18y.Text != "") { validEntries[2][18] = tb2x18y.Text; openSpace[2][18] = true; }
            if (tb2x19y.Text != "") { validEntries[2][19] = tb2x19y.Text; openSpace[2][19] = true; }

            if (tb3x0y.Text != "") { validEntries[3][0] = tb3x0y.Text; openSpace[3][0] = true; }
            if (tb3x1y.Text != "") { validEntries[3][1] = tb3x1y.Text; openSpace[3][1] = true; }
            if (tb3x2y.Text != "") { validEntries[3][2] = tb3x2y.Text; openSpace[3][2] = true; }
            if (tb3x3y.Text != "") { validEntries[3][3] = tb3x3y.Text; openSpace[3][3] = true; }
            if (tb3x4y.Text != "") { validEntries[3][4] = tb3x4y.Text; openSpace[3][4] = true; }
            if (tb3x5y.Text != "") { validEntries[3][5] = tb3x5y.Text; openSpace[3][5] = true; }
            if (tb3x6y.Text != "") { validEntries[3][6] = tb3x6y.Text; openSpace[3][6] = true; }
            if (tb3x7y.Text != "") { validEntries[3][7] = tb3x7y.Text; openSpace[3][7] = true; }
            if (tb3x8y.Text != "") { validEntries[3][8] = tb3x8y.Text; openSpace[3][8] = true; }
            if (tb3x9y.Text != "") { validEntries[3][9] = tb3x9y.Text; openSpace[3][9] = true; }
            if (tb3x10y.Text != "") { validEntries[3][10] = tb3x10y.Text; openSpace[3][10] = true; }
            if (tb3x11y.Text != "") { validEntries[3][11] = tb3x11y.Text; openSpace[3][11] = true; }
            if (tb3x12y.Text != "") { validEntries[3][12] = tb3x12y.Text; openSpace[3][12] = true; }
            if (tb3x13y.Text != "") { validEntries[3][13] = tb3x13y.Text; openSpace[3][13] = true; }
            if (tb3x14y.Text != "") { validEntries[3][14] = tb3x14y.Text; openSpace[3][14] = true; }
            if (tb3x15y.Text != "") { validEntries[3][15] = tb3x15y.Text; openSpace[3][15] = true; }
            if (tb3x16y.Text != "") { validEntries[3][16] = tb3x16y.Text; openSpace[3][16] = true; }
            if (tb3x17y.Text != "") { validEntries[3][17] = tb3x17y.Text; openSpace[3][17] = true; }
            if (tb3x18y.Text != "") { validEntries[3][18] = tb3x18y.Text; openSpace[3][18] = true; }
            if (tb3x19y.Text != "") { validEntries[3][19] = tb3x19y.Text; openSpace[3][19] = true; }

            if (tb4x0y.Text != "") { validEntries[4][0] = tb4x0y.Text; openSpace[4][0] = true; }
            if (tb4x1y.Text != "") { validEntries[4][1] = tb4x1y.Text; openSpace[4][1] = true; }
            if (tb4x2y.Text != "") { validEntries[4][2] = tb4x2y.Text; openSpace[4][2] = true; }
            if (tb4x3y.Text != "") { validEntries[4][3] = tb4x3y.Text; openSpace[4][3] = true; }
            if (tb4x4y.Text != "") { validEntries[4][4] = tb4x4y.Text; openSpace[4][4] = true; }
            if (tb4x5y.Text != "") { validEntries[4][5] = tb4x5y.Text; openSpace[4][5] = true; }
            if (tb4x6y.Text != "") { validEntries[4][6] = tb4x6y.Text; openSpace[4][6] = true; }
            if (tb4x7y.Text != "") { validEntries[4][7] = tb4x7y.Text; openSpace[4][7] = true; }
            if (tb4x8y.Text != "") { validEntries[4][8] = tb4x8y.Text; openSpace[4][8] = true; }
            if (tb4x9y.Text != "") { validEntries[4][9] = tb4x9y.Text; openSpace[4][9] = true; }
            if (tb4x10y.Text != "") { validEntries[4][10] = tb4x10y.Text; openSpace[4][10] = true; }
            if (tb4x11y.Text != "") { validEntries[4][11] = tb4x11y.Text; openSpace[4][11] = true; }
            if (tb4x12y.Text != "") { validEntries[4][12] = tb4x12y.Text; openSpace[4][12] = true; }
            if (tb4x13y.Text != "") { validEntries[4][13] = tb4x13y.Text; openSpace[4][13] = true; }
            if (tb4x14y.Text != "") { validEntries[4][14] = tb4x14y.Text; openSpace[4][14] = true; }
            if (tb4x15y.Text != "") { validEntries[4][15] = tb4x15y.Text; openSpace[4][15] = true; }
            if (tb4x16y.Text != "") { validEntries[4][16] = tb4x16y.Text; openSpace[4][16] = true; }
            if (tb4x17y.Text != "") { validEntries[4][17] = tb4x17y.Text; openSpace[4][17] = true; }
            if (tb4x18y.Text != "") { validEntries[4][18] = tb4x18y.Text; openSpace[4][18] = true; }
            if (tb4x19y.Text != "") { validEntries[4][19] = tb4x19y.Text; openSpace[4][19] = true; }

            if (tb5x0y.Text != "") { validEntries[5][0] = tb5x0y.Text; openSpace[5][0] = true; }
            if (tb5x1y.Text != "") { validEntries[5][1] = tb5x1y.Text; openSpace[5][1] = true; }
            if (tb5x2y.Text != "") { validEntries[5][2] = tb5x2y.Text; openSpace[5][2] = true; }
            if (tb5x3y.Text != "") { validEntries[5][3] = tb5x3y.Text; openSpace[5][3] = true; }
            if (tb5x4y.Text != "") { validEntries[5][4] = tb5x4y.Text; openSpace[5][4] = true; }
            if (tb5x5y.Text != "") { validEntries[5][5] = tb5x5y.Text; openSpace[5][5] = true; }
            if (tb5x6y.Text != "") { validEntries[5][6] = tb5x6y.Text; openSpace[5][6] = true; }
            if (tb5x7y.Text != "") { validEntries[5][7] = tb5x7y.Text; openSpace[5][7] = true; }
            if (tb5x8y.Text != "") { validEntries[5][8] = tb5x8y.Text; openSpace[5][8] = true; }
            if (tb5x9y.Text != "") { validEntries[5][9] = tb5x9y.Text; openSpace[5][9] = true; }
            if (tb5x10y.Text != "") { validEntries[5][10] = tb5x10y.Text; openSpace[5][10] = true; }
            if (tb5x11y.Text != "") { validEntries[5][11] = tb5x11y.Text; openSpace[5][11] = true; }
            if (tb5x12y.Text != "") { validEntries[5][12] = tb5x12y.Text; openSpace[5][12] = true; }
            if (tb5x13y.Text != "") { validEntries[5][13] = tb5x13y.Text; openSpace[5][13] = true; }
            if (tb5x14y.Text != "") { validEntries[5][14] = tb5x14y.Text; openSpace[5][14] = true; }
            if (tb5x15y.Text != "") { validEntries[5][15] = tb5x15y.Text; openSpace[5][15] = true; }
            if (tb5x16y.Text != "") { validEntries[5][16] = tb5x16y.Text; openSpace[5][16] = true; }
            if (tb5x17y.Text != "") { validEntries[5][17] = tb5x17y.Text; openSpace[5][17] = true; }
            if (tb5x18y.Text != "") { validEntries[5][18] = tb5x18y.Text; openSpace[5][18] = true; }
            if (tb5x19y.Text != "") { validEntries[5][19] = tb5x19y.Text; openSpace[5][19] = true; }

            if (tb6x0y.Text != "") { validEntries[6][0] = tb6x0y.Text; openSpace[6][0] = true; }
            if (tb6x1y.Text != "") { validEntries[6][1] = tb6x1y.Text; openSpace[6][1] = true; }
            if (tb6x2y.Text != "") { validEntries[6][2] = tb6x2y.Text; openSpace[6][2] = true; }
            if (tb6x3y.Text != "") { validEntries[6][3] = tb6x3y.Text; openSpace[6][3] = true; }
            if (tb6x4y.Text != "") { validEntries[6][4] = tb6x4y.Text; openSpace[6][4] = true; }
            if (tb6x5y.Text != "") { validEntries[6][5] = tb6x5y.Text; openSpace[6][5] = true; }
            if (tb6x6y.Text != "") { validEntries[6][6] = tb6x6y.Text; openSpace[6][6] = true; }
            if (tb6x7y.Text != "") { validEntries[6][7] = tb6x7y.Text; openSpace[6][7] = true; }
            if (tb6x8y.Text != "") { validEntries[6][8] = tb6x8y.Text; openSpace[6][8] = true; }
            if (tb6x9y.Text != "") { validEntries[6][9] = tb6x9y.Text; openSpace[6][9] = true; }
            if (tb6x10y.Text != "") { validEntries[6][10] = tb6x10y.Text; openSpace[6][10] = true; }
            if (tb6x11y.Text != "") { validEntries[6][11] = tb6x11y.Text; openSpace[6][11] = true; }
            if (tb6x12y.Text != "") { validEntries[6][12] = tb6x12y.Text; openSpace[6][12] = true; }
            if (tb6x13y.Text != "") { validEntries[6][13] = tb6x13y.Text; openSpace[6][13] = true; }
            if (tb6x14y.Text != "") { validEntries[6][14] = tb6x14y.Text; openSpace[6][14] = true; }
            if (tb6x15y.Text != "") { validEntries[6][15] = tb6x15y.Text; openSpace[6][15] = true; }
            if (tb6x16y.Text != "") { validEntries[6][16] = tb6x16y.Text; openSpace[6][16] = true; }
            if (tb6x17y.Text != "") { validEntries[6][17] = tb6x17y.Text; openSpace[6][17] = true; }
            if (tb6x18y.Text != "") { validEntries[6][18] = tb6x18y.Text; openSpace[6][18] = true; }
            if (tb6x19y.Text != "") { validEntries[6][19] = tb6x19y.Text; openSpace[6][19] = true; }

            if (tb7x0y.Text != "") { validEntries[7][0] = tb7x0y.Text; openSpace[7][0] = true; }
            if (tb7x1y.Text != "") { validEntries[7][1] = tb7x1y.Text; openSpace[7][1] = true; }
            if (tb7x2y.Text != "") { validEntries[7][2] = tb7x2y.Text; openSpace[7][2] = true; }
            if (tb7x3y.Text != "") { validEntries[7][3] = tb7x3y.Text; openSpace[7][3] = true; }
            if (tb7x4y.Text != "") { validEntries[7][4] = tb7x4y.Text; openSpace[7][4] = true; }
            if (tb7x5y.Text != "") { validEntries[7][5] = tb7x5y.Text; openSpace[7][5] = true; }
            if (tb7x6y.Text != "") { validEntries[7][6] = tb7x6y.Text; openSpace[7][6] = true; }
            if (tb7x7y.Text != "") { validEntries[7][7] = tb7x7y.Text; openSpace[7][7] = true; }
            if (tb7x8y.Text != "") { validEntries[7][8] = tb7x8y.Text; openSpace[7][8] = true; }
            if (tb7x9y.Text != "") { validEntries[7][9] = tb7x9y.Text; openSpace[7][9] = true; }
            if (tb7x10y.Text != "") { validEntries[7][10] = tb7x10y.Text; openSpace[7][10] = true; }
            if (tb7x11y.Text != "") { validEntries[7][11] = tb7x11y.Text; openSpace[7][11] = true; }
            if (tb7x12y.Text != "") { validEntries[7][12] = tb7x12y.Text; openSpace[7][12] = true; }
            if (tb7x13y.Text != "") { validEntries[7][13] = tb7x13y.Text; openSpace[7][13] = true; }
            if (tb7x14y.Text != "") { validEntries[7][14] = tb7x14y.Text; openSpace[7][14] = true; }
            if (tb7x15y.Text != "") { validEntries[7][15] = tb7x15y.Text; openSpace[7][15] = true; }
            if (tb7x16y.Text != "") { validEntries[7][16] = tb7x16y.Text; openSpace[7][16] = true; }
            if (tb7x17y.Text != "") { validEntries[7][17] = tb7x17y.Text; openSpace[7][17] = true; }
            if (tb7x18y.Text != "") { validEntries[7][18] = tb7x18y.Text; openSpace[7][18] = true; }
            if (tb7x19y.Text != "") { validEntries[7][19] = tb7x19y.Text; openSpace[7][19] = true; }

            if (tb8x0y.Text != "") { validEntries[8][0] = tb8x0y.Text; openSpace[8][0] = true; }
            if (tb8x1y.Text != "") { validEntries[8][1] = tb8x1y.Text; openSpace[8][1] = true; }
            if (tb8x2y.Text != "") { validEntries[8][2] = tb8x2y.Text; openSpace[8][2] = true; }
            if (tb8x3y.Text != "") { validEntries[8][3] = tb8x3y.Text; openSpace[8][3] = true; }
            if (tb8x4y.Text != "") { validEntries[8][4] = tb8x4y.Text; openSpace[8][4] = true; }
            if (tb8x5y.Text != "") { validEntries[8][5] = tb8x5y.Text; openSpace[8][5] = true; }
            if (tb8x6y.Text != "") { validEntries[8][6] = tb8x6y.Text; openSpace[8][6] = true; }
            if (tb8x7y.Text != "") { validEntries[8][7] = tb8x7y.Text; openSpace[8][7] = true; }
            if (tb8x8y.Text != "") { validEntries[8][8] = tb8x8y.Text; openSpace[8][8] = true; }
            if (tb8x9y.Text != "") { validEntries[8][9] = tb8x9y.Text; openSpace[8][9] = true; }
            if (tb8x10y.Text != "") { validEntries[8][10] = tb8x10y.Text; openSpace[8][10] = true; }
            if (tb8x11y.Text != "") { validEntries[8][11] = tb8x11y.Text; openSpace[8][11] = true; }
            if (tb8x12y.Text != "") { validEntries[8][12] = tb8x12y.Text; openSpace[8][12] = true; }
            if (tb8x13y.Text != "") { validEntries[8][13] = tb8x13y.Text; openSpace[8][13] = true; }
            if (tb8x14y.Text != "") { validEntries[8][14] = tb8x14y.Text; openSpace[8][14] = true; }
            if (tb8x15y.Text != "") { validEntries[8][15] = tb8x15y.Text; openSpace[8][15] = true; }
            if (tb8x16y.Text != "") { validEntries[8][16] = tb8x16y.Text; openSpace[8][16] = true; }
            if (tb8x17y.Text != "") { validEntries[8][17] = tb8x17y.Text; openSpace[8][17] = true; }
            if (tb8x18y.Text != "") { validEntries[8][18] = tb8x18y.Text; openSpace[8][18] = true; }
            if (tb8x19y.Text != "") { validEntries[8][19] = tb8x19y.Text; openSpace[8][19] = true; }

            if (tb9x0y.Text != "") { validEntries[9][0] = tb9x0y.Text; openSpace[9][0] = true; }
            if (tb9x1y.Text != "") { validEntries[9][1] = tb9x1y.Text; openSpace[9][1] = true; }
            if (tb9x2y.Text != "") { validEntries[9][2] = tb9x2y.Text; openSpace[9][2] = true; }
            if (tb9x3y.Text != "") { validEntries[9][3] = tb9x3y.Text; openSpace[9][3] = true; }
            if (tb9x4y.Text != "") { validEntries[9][4] = tb9x4y.Text; openSpace[9][4] = true; }
            if (tb9x5y.Text != "") { validEntries[9][5] = tb9x5y.Text; openSpace[9][5] = true; }
            if (tb9x6y.Text != "") { validEntries[9][6] = tb9x6y.Text; openSpace[9][6] = true; }
            if (tb9x7y.Text != "") { validEntries[9][7] = tb9x7y.Text; openSpace[9][7] = true; }
            if (tb9x8y.Text != "") { validEntries[9][8] = tb9x8y.Text; openSpace[9][8] = true; }
            if (tb9x9y.Text != "") { validEntries[9][9] = tb9x9y.Text; openSpace[9][9] = true; }
            if (tb9x10y.Text != "") { validEntries[9][10] = tb9x10y.Text; openSpace[9][10] = true; }
            if (tb9x11y.Text != "") { validEntries[9][11] = tb9x11y.Text; openSpace[9][11] = true; }
            if (tb9x12y.Text != "") { validEntries[9][12] = tb9x12y.Text; openSpace[9][12] = true; }
            if (tb9x13y.Text != "") { validEntries[9][13] = tb9x13y.Text; openSpace[9][13] = true; }
            if (tb9x14y.Text != "") { validEntries[9][14] = tb9x14y.Text; openSpace[9][14] = true; }
            if (tb9x15y.Text != "") { validEntries[9][15] = tb9x15y.Text; openSpace[9][15] = true; }
            if (tb9x16y.Text != "") { validEntries[9][16] = tb9x16y.Text; openSpace[9][16] = true; }
            if (tb9x17y.Text != "") { validEntries[9][17] = tb9x17y.Text; openSpace[9][17] = true; }
            if (tb9x18y.Text != "") { validEntries[9][18] = tb9x18y.Text; openSpace[9][18] = true; }
            if (tb9x19y.Text != "") { validEntries[9][19] = tb9x19y.Text; openSpace[9][19] = true; }

            if (tb10x0y.Text != "") { validEntries[10][0] = tb10x0y.Text; openSpace[10][0] = true; }
            if (tb10x1y.Text != "") { validEntries[10][1] = tb10x1y.Text; openSpace[10][1] = true; }
            if (tb10x2y.Text != "") { validEntries[10][2] = tb10x2y.Text; openSpace[10][2] = true; }
            if (tb10x3y.Text != "") { validEntries[10][3] = tb10x3y.Text; openSpace[10][3] = true; }
            if (tb10x4y.Text != "") { validEntries[10][4] = tb10x4y.Text; openSpace[10][4] = true; }
            if (tb10x5y.Text != "") { validEntries[10][5] = tb10x5y.Text; openSpace[10][5] = true; }
            if (tb10x6y.Text != "") { validEntries[10][6] = tb10x6y.Text; openSpace[10][6] = true; }
            if (tb10x7y.Text != "") { validEntries[10][7] = tb10x7y.Text; openSpace[10][7] = true; }
            if (tb10x8y.Text != "") { validEntries[10][8] = tb10x8y.Text; openSpace[10][8] = true; }
            if (tb10x9y.Text != "") { validEntries[10][9] = tb10x9y.Text; openSpace[10][9] = true; }
            if (tb10x10y.Text != "") { validEntries[10][10] = tb10x10y.Text; openSpace[10][10] = true; }
            if (tb10x11y.Text != "") { validEntries[10][11] = tb10x11y.Text; openSpace[10][11] = true; }
            if (tb10x12y.Text != "") { validEntries[10][12] = tb10x12y.Text; openSpace[10][12] = true; }
            if (tb10x13y.Text != "") { validEntries[10][13] = tb10x13y.Text; openSpace[10][13] = true; }
            if (tb10x14y.Text != "") { validEntries[10][14] = tb10x14y.Text; openSpace[10][14] = true; }
            if (tb10x15y.Text != "") { validEntries[10][15] = tb10x15y.Text; openSpace[10][15] = true; }
            if (tb10x16y.Text != "") { validEntries[10][16] = tb10x16y.Text; openSpace[10][16] = true; }
            if (tb10x17y.Text != "") { validEntries[10][17] = tb10x17y.Text; openSpace[10][17] = true; }
            if (tb10x18y.Text != "") { validEntries[10][18] = tb10x18y.Text; openSpace[10][18] = true; }
            if (tb10x19y.Text != "") { validEntries[10][19] = tb10x19y.Text; openSpace[10][19] = true; }

            if (tb11x0y.Text != "") { validEntries[11][0] = tb11x0y.Text; openSpace[11][0] = true; }
            if (tb11x1y.Text != "") { validEntries[11][1] = tb11x1y.Text; openSpace[11][1] = true; }
            if (tb11x2y.Text != "") { validEntries[11][2] = tb11x2y.Text; openSpace[11][2] = true; }
            if (tb11x3y.Text != "") { validEntries[11][3] = tb11x3y.Text; openSpace[11][3] = true; }
            if (tb11x4y.Text != "") { validEntries[11][4] = tb11x4y.Text; openSpace[11][4] = true; }
            if (tb11x5y.Text != "") { validEntries[11][5] = tb11x5y.Text; openSpace[11][5] = true; }
            if (tb11x6y.Text != "") { validEntries[11][6] = tb11x6y.Text; openSpace[11][6] = true; }
            if (tb11x7y.Text != "") { validEntries[11][7] = tb11x7y.Text; openSpace[11][7] = true; }
            if (tb11x8y.Text != "") { validEntries[11][8] = tb11x8y.Text; openSpace[11][8] = true; }
            if (tb11x9y.Text != "") { validEntries[11][9] = tb11x9y.Text; openSpace[11][9] = true; }
            if (tb11x10y.Text != "") { validEntries[11][10] = tb11x10y.Text; openSpace[11][10] = true; }
            if (tb11x11y.Text != "") { validEntries[11][11] = tb11x11y.Text; openSpace[11][11] = true; }
            if (tb11x12y.Text != "") { validEntries[11][12] = tb11x12y.Text; openSpace[11][12] = true; }
            if (tb11x13y.Text != "") { validEntries[11][13] = tb11x13y.Text; openSpace[11][13] = true; }
            if (tb11x14y.Text != "") { validEntries[11][14] = tb11x14y.Text; openSpace[11][14] = true; }
            if (tb11x15y.Text != "") { validEntries[11][15] = tb11x15y.Text; openSpace[11][15] = true; }
            if (tb11x16y.Text != "") { validEntries[11][16] = tb11x16y.Text; openSpace[11][16] = true; }
            if (tb11x17y.Text != "") { validEntries[11][17] = tb11x17y.Text; openSpace[11][17] = true; }
            if (tb11x18y.Text != "") { validEntries[11][18] = tb11x18y.Text; openSpace[11][18] = true; }
            if (tb11x19y.Text != "") { validEntries[11][19] = tb11x19y.Text; openSpace[11][19] = true; }

            if (tb12x0y.Text != "") { validEntries[12][0] = tb12x0y.Text; openSpace[12][0] = true; }
            if (tb12x1y.Text != "") { validEntries[12][1] = tb12x1y.Text; openSpace[12][1] = true; }
            if (tb12x2y.Text != "") { validEntries[12][2] = tb12x2y.Text; openSpace[12][2] = true; }
            if (tb12x3y.Text != "") { validEntries[12][3] = tb12x3y.Text; openSpace[12][3] = true; }
            if (tb12x4y.Text != "") { validEntries[12][4] = tb12x4y.Text; openSpace[12][4] = true; }
            if (tb12x5y.Text != "") { validEntries[12][5] = tb12x5y.Text; openSpace[12][5] = true; }
            if (tb12x6y.Text != "") { validEntries[12][6] = tb12x6y.Text; openSpace[12][6] = true; }
            if (tb12x7y.Text != "") { validEntries[12][7] = tb12x7y.Text; openSpace[12][7] = true; }
            if (tb12x8y.Text != "") { validEntries[12][8] = tb12x8y.Text; openSpace[12][8] = true; }
            if (tb12x9y.Text != "") { validEntries[12][9] = tb12x9y.Text; openSpace[12][9] = true; }
            if (tb12x10y.Text != "") { validEntries[12][10] = tb12x10y.Text; openSpace[12][10] = true; }
            if (tb12x11y.Text != "") { validEntries[12][11] = tb12x11y.Text; openSpace[12][11] = true; }
            if (tb12x12y.Text != "") { validEntries[12][12] = tb12x12y.Text; openSpace[12][12] = true; }
            if (tb12x13y.Text != "") { validEntries[12][13] = tb12x13y.Text; openSpace[12][13] = true; }
            if (tb12x14y.Text != "") { validEntries[12][14] = tb12x14y.Text; openSpace[12][14] = true; }
            if (tb12x15y.Text != "") { validEntries[12][15] = tb12x15y.Text; openSpace[12][15] = true; }
            if (tb12x16y.Text != "") { validEntries[12][16] = tb12x16y.Text; openSpace[12][16] = true; }
            if (tb12x17y.Text != "") { validEntries[12][17] = tb12x17y.Text; openSpace[12][17] = true; }
            if (tb12x18y.Text != "") { validEntries[12][18] = tb12x18y.Text; openSpace[12][18] = true; }
            if (tb12x19y.Text != "") { validEntries[12][19] = tb12x19y.Text; openSpace[12][19] = true; }

            if (tb13x0y.Text != "") { validEntries[13][0] = tb13x0y.Text; openSpace[13][0] = true; }
            if (tb13x1y.Text != "") { validEntries[13][1] = tb13x1y.Text; openSpace[13][1] = true; }
            if (tb13x2y.Text != "") { validEntries[13][2] = tb13x2y.Text; openSpace[13][2] = true; }
            if (tb13x3y.Text != "") { validEntries[13][3] = tb13x3y.Text; openSpace[13][3] = true; }
            if (tb13x4y.Text != "") { validEntries[13][4] = tb13x4y.Text; openSpace[13][4] = true; }
            if (tb13x5y.Text != "") { validEntries[13][5] = tb13x5y.Text; openSpace[13][5] = true; }
            if (tb13x6y.Text != "") { validEntries[13][6] = tb13x6y.Text; openSpace[13][6] = true; }
            if (tb13x7y.Text != "") { validEntries[13][7] = tb13x7y.Text; openSpace[13][7] = true; }
            if (tb13x8y.Text != "") { validEntries[13][8] = tb13x8y.Text; openSpace[13][8] = true; }
            if (tb13x9y.Text != "") { validEntries[13][9] = tb13x9y.Text; openSpace[13][9] = true; }
            if (tb13x10y.Text != "") { validEntries[13][10] = tb13x10y.Text; openSpace[13][10] = true; }
            if (tb13x11y.Text != "") { validEntries[13][11] = tb13x11y.Text; openSpace[13][11] = true; }
            if (tb13x12y.Text != "") { validEntries[13][12] = tb13x12y.Text; openSpace[13][12] = true; }
            if (tb13x13y.Text != "") { validEntries[13][13] = tb13x13y.Text; openSpace[13][13] = true; }
            if (tb13x14y.Text != "") { validEntries[13][14] = tb13x14y.Text; openSpace[13][14] = true; }
            if (tb13x15y.Text != "") { validEntries[13][15] = tb13x15y.Text; openSpace[13][15] = true; }
            if (tb13x16y.Text != "") { validEntries[13][16] = tb13x16y.Text; openSpace[13][16] = true; }
            if (tb13x17y.Text != "") { validEntries[13][17] = tb13x17y.Text; openSpace[13][17] = true; }
            if (tb13x18y.Text != "") { validEntries[13][18] = tb13x18y.Text; openSpace[13][18] = true; }
            if (tb13x19y.Text != "") { validEntries[13][19] = tb13x19y.Text; openSpace[13][19] = true; }

            if (tb14x0y.Text != "") { validEntries[14][0] = tb14x0y.Text; openSpace[14][0] = true; }
            if (tb14x1y.Text != "") { validEntries[14][1] = tb14x1y.Text; openSpace[14][1] = true; }
            if (tb14x2y.Text != "") { validEntries[14][2] = tb14x2y.Text; openSpace[14][2] = true; }
            if (tb14x3y.Text != "") { validEntries[14][3] = tb14x3y.Text; openSpace[14][3] = true; }
            if (tb14x4y.Text != "") { validEntries[14][4] = tb14x4y.Text; openSpace[14][4] = true; }
            if (tb14x5y.Text != "") { validEntries[14][5] = tb14x5y.Text; openSpace[14][5] = true; }
            if (tb14x6y.Text != "") { validEntries[14][6] = tb14x6y.Text; openSpace[14][6] = true; }
            if (tb14x7y.Text != "") { validEntries[14][7] = tb14x7y.Text; openSpace[14][7] = true; }
            if (tb14x8y.Text != "") { validEntries[14][8] = tb14x8y.Text; openSpace[14][8] = true; }
            if (tb14x9y.Text != "") { validEntries[14][9] = tb14x9y.Text; openSpace[14][9] = true; }
            if (tb14x10y.Text != "") { validEntries[14][10] = tb14x10y.Text; openSpace[14][10] = true; }
            if (tb14x11y.Text != "") { validEntries[14][11] = tb14x11y.Text; openSpace[14][11] = true; }
            if (tb14x12y.Text != "") { validEntries[14][12] = tb14x12y.Text; openSpace[14][12] = true; }
            if (tb14x13y.Text != "") { validEntries[14][13] = tb14x13y.Text; openSpace[14][13] = true; }
            if (tb14x14y.Text != "") { validEntries[14][14] = tb14x14y.Text; openSpace[14][14] = true; }
            if (tb14x15y.Text != "") { validEntries[14][15] = tb14x15y.Text; openSpace[14][15] = true; }
            if (tb14x16y.Text != "") { validEntries[14][16] = tb14x16y.Text; openSpace[14][16] = true; }
            if (tb14x17y.Text != "") { validEntries[14][17] = tb14x17y.Text; openSpace[14][17] = true; }
            if (tb14x18y.Text != "") { validEntries[14][18] = tb14x18y.Text; openSpace[14][18] = true; }
            if (tb14x19y.Text != "") { validEntries[14][19] = tb14x19y.Text; openSpace[14][19] = true; }

            if (tb15x0y.Text != "") { validEntries[15][0] = tb15x0y.Text; openSpace[15][0] = true; }
            if (tb15x1y.Text != "") { validEntries[15][1] = tb15x1y.Text; openSpace[15][1] = true; }
            if (tb15x2y.Text != "") { validEntries[15][2] = tb15x2y.Text; openSpace[15][2] = true; }
            if (tb15x3y.Text != "") { validEntries[15][3] = tb15x3y.Text; openSpace[15][3] = true; }
            if (tb15x4y.Text != "") { validEntries[15][4] = tb15x4y.Text; openSpace[15][4] = true; }
            if (tb15x5y.Text != "") { validEntries[15][5] = tb15x5y.Text; openSpace[15][5] = true; }
            if (tb15x6y.Text != "") { validEntries[15][6] = tb15x6y.Text; openSpace[15][6] = true; }
            if (tb15x7y.Text != "") { validEntries[15][7] = tb15x7y.Text; openSpace[15][7] = true; }
            if (tb15x8y.Text != "") { validEntries[15][8] = tb15x8y.Text; openSpace[15][8] = true; }
            if (tb15x9y.Text != "") { validEntries[15][9] = tb15x9y.Text; openSpace[15][9] = true; }
            if (tb15x10y.Text != "") { validEntries[15][10] = tb15x10y.Text; openSpace[15][10] = true; }
            if (tb15x11y.Text != "") { validEntries[15][11] = tb15x11y.Text; openSpace[15][11] = true; }
            if (tb15x12y.Text != "") { validEntries[15][12] = tb15x12y.Text; openSpace[15][12] = true; }
            if (tb15x13y.Text != "") { validEntries[15][13] = tb15x13y.Text; openSpace[15][13] = true; }
            if (tb15x14y.Text != "") { validEntries[15][14] = tb15x14y.Text; openSpace[15][14] = true; }
            if (tb15x15y.Text != "") { validEntries[15][15] = tb15x15y.Text; openSpace[15][15] = true; }
            if (tb15x16y.Text != "") { validEntries[15][16] = tb15x16y.Text; openSpace[15][16] = true; }
            if (tb15x17y.Text != "") { validEntries[15][17] = tb15x17y.Text; openSpace[15][17] = true; }
            if (tb15x18y.Text != "") { validEntries[15][18] = tb15x18y.Text; openSpace[15][18] = true; }
            if (tb15x19y.Text != "") { validEntries[15][19] = tb15x19y.Text; openSpace[15][19] = true; }

            if (tb16x0y.Text != "") { validEntries[16][0] = tb16x0y.Text; openSpace[16][0] = true; }
            if (tb16x1y.Text != "") { validEntries[16][1] = tb16x1y.Text; openSpace[16][1] = true; }
            if (tb16x2y.Text != "") { validEntries[16][2] = tb16x2y.Text; openSpace[16][2] = true; }
            if (tb16x3y.Text != "") { validEntries[16][3] = tb16x3y.Text; openSpace[16][3] = true; }
            if (tb16x4y.Text != "") { validEntries[16][4] = tb16x4y.Text; openSpace[16][4] = true; }
            if (tb16x5y.Text != "") { validEntries[16][5] = tb16x5y.Text; openSpace[16][5] = true; }
            if (tb16x6y.Text != "") { validEntries[16][6] = tb16x6y.Text; openSpace[16][6] = true; }
            if (tb16x7y.Text != "") { validEntries[16][7] = tb16x7y.Text; openSpace[16][7] = true; }
            if (tb16x8y.Text != "") { validEntries[16][8] = tb16x8y.Text; openSpace[16][8] = true; }
            if (tb16x9y.Text != "") { validEntries[16][9] = tb16x9y.Text; openSpace[16][9] = true; }
            if (tb16x10y.Text != "") { validEntries[16][10] = tb16x10y.Text; openSpace[16][10] = true; }
            if (tb16x11y.Text != "") { validEntries[16][11] = tb16x11y.Text; openSpace[16][11] = true; }
            if (tb16x12y.Text != "") { validEntries[16][12] = tb16x12y.Text; openSpace[16][12] = true; }
            if (tb16x13y.Text != "") { validEntries[16][13] = tb16x13y.Text; openSpace[16][13] = true; }
            if (tb16x14y.Text != "") { validEntries[16][14] = tb16x14y.Text; openSpace[16][14] = true; }
            if (tb16x15y.Text != "") { validEntries[16][15] = tb16x15y.Text; openSpace[16][15] = true; }
            if (tb16x16y.Text != "") { validEntries[16][16] = tb16x16y.Text; openSpace[16][16] = true; }
            if (tb16x17y.Text != "") { validEntries[16][17] = tb16x17y.Text; openSpace[16][17] = true; }
            if (tb16x18y.Text != "") { validEntries[16][18] = tb16x18y.Text; openSpace[16][18] = true; }
            if (tb16x19y.Text != "") { validEntries[16][19] = tb16x19y.Text; openSpace[16][19] = true; }

            if (tb17x0y.Text != "") { validEntries[17][0] = tb17x0y.Text; openSpace[17][0] = true; }
            if (tb17x1y.Text != "") { validEntries[17][1] = tb17x1y.Text; openSpace[17][1] = true; }
            if (tb17x2y.Text != "") { validEntries[17][2] = tb17x2y.Text; openSpace[17][2] = true; }
            if (tb17x3y.Text != "") { validEntries[17][3] = tb17x3y.Text; openSpace[17][3] = true; }
            if (tb17x4y.Text != "") { validEntries[17][4] = tb17x4y.Text; openSpace[17][4] = true; }
            if (tb17x5y.Text != "") { validEntries[17][5] = tb17x5y.Text; openSpace[17][5] = true; }
            if (tb17x6y.Text != "") { validEntries[17][6] = tb17x6y.Text; openSpace[17][6] = true; }
            if (tb17x7y.Text != "") { validEntries[17][7] = tb17x7y.Text; openSpace[17][7] = true; }
            if (tb17x8y.Text != "") { validEntries[17][8] = tb17x8y.Text; openSpace[17][8] = true; }
            if (tb17x9y.Text != "") { validEntries[17][9] = tb17x9y.Text; openSpace[17][9] = true; }
            if (tb17x10y.Text != "") { validEntries[17][10] = tb17x10y.Text; openSpace[17][10] = true; }
            if (tb17x11y.Text != "") { validEntries[17][11] = tb17x11y.Text; openSpace[17][11] = true; }
            if (tb17x12y.Text != "") { validEntries[17][12] = tb17x12y.Text; openSpace[17][12] = true; }
            if (tb17x13y.Text != "") { validEntries[17][13] = tb17x13y.Text; openSpace[17][13] = true; }
            if (tb17x14y.Text != "") { validEntries[17][14] = tb17x14y.Text; openSpace[17][14] = true; }
            if (tb17x15y.Text != "") { validEntries[17][15] = tb17x15y.Text; openSpace[17][15] = true; }
            if (tb17x16y.Text != "") { validEntries[17][16] = tb17x16y.Text; openSpace[17][16] = true; }
            if (tb17x17y.Text != "") { validEntries[17][17] = tb17x17y.Text; openSpace[17][17] = true; }
            if (tb17x18y.Text != "") { validEntries[17][18] = tb17x18y.Text; openSpace[17][18] = true; }
            if (tb17x19y.Text != "") { validEntries[17][19] = tb17x19y.Text; openSpace[17][19] = true; }

            if (tb18x0y.Text != "") { validEntries[18][0] = tb18x0y.Text; openSpace[18][0] = true; }
            if (tb18x1y.Text != "") { validEntries[18][1] = tb18x1y.Text; openSpace[18][1] = true; }
            if (tb18x2y.Text != "") { validEntries[18][2] = tb18x2y.Text; openSpace[18][2] = true; }
            if (tb18x3y.Text != "") { validEntries[18][3] = tb18x3y.Text; openSpace[18][3] = true; }
            if (tb18x4y.Text != "") { validEntries[18][4] = tb18x4y.Text; openSpace[18][4] = true; }
            if (tb18x5y.Text != "") { validEntries[18][5] = tb18x5y.Text; openSpace[18][5] = true; }
            if (tb18x6y.Text != "") { validEntries[18][6] = tb18x6y.Text; openSpace[18][6] = true; }
            if (tb18x7y.Text != "") { validEntries[18][7] = tb18x7y.Text; openSpace[18][7] = true; }
            if (tb18x8y.Text != "") { validEntries[18][8] = tb18x8y.Text; openSpace[18][8] = true; }
            if (tb18x9y.Text != "") { validEntries[18][9] = tb18x9y.Text; openSpace[18][9] = true; }
            if (tb18x10y.Text != "") { validEntries[18][10] = tb18x10y.Text; openSpace[18][10] = true; }
            if (tb18x11y.Text != "") { validEntries[18][11] = tb18x11y.Text; openSpace[18][11] = true; }
            if (tb18x12y.Text != "") { validEntries[18][12] = tb18x12y.Text; openSpace[18][12] = true; }
            if (tb18x13y.Text != "") { validEntries[18][13] = tb18x13y.Text; openSpace[18][13] = true; }
            if (tb18x14y.Text != "") { validEntries[18][14] = tb18x14y.Text; openSpace[18][14] = true; }
            if (tb18x15y.Text != "") { validEntries[18][15] = tb18x15y.Text; openSpace[18][15] = true; }
            if (tb18x16y.Text != "") { validEntries[18][16] = tb18x16y.Text; openSpace[18][16] = true; }
            if (tb18x17y.Text != "") { validEntries[18][17] = tb18x17y.Text; openSpace[18][17] = true; }
            if (tb18x18y.Text != "") { validEntries[18][18] = tb18x18y.Text; openSpace[18][18] = true; }
            if (tb18x19y.Text != "") { validEntries[18][19] = tb18x19y.Text; openSpace[18][19] = true; }

            if (tb19x0y.Text != "") { validEntries[19][0] = tb19x0y.Text; openSpace[19][0] = true; }
            if (tb19x1y.Text != "") { validEntries[19][1] = tb19x1y.Text; openSpace[19][1] = true; }
            if (tb19x2y.Text != "") { validEntries[19][2] = tb19x2y.Text; openSpace[19][2] = true; }
            if (tb19x3y.Text != "") { validEntries[19][3] = tb19x3y.Text; openSpace[19][3] = true; }
            if (tb19x4y.Text != "") { validEntries[19][4] = tb19x4y.Text; openSpace[19][4] = true; }
            if (tb19x5y.Text != "") { validEntries[19][5] = tb19x5y.Text; openSpace[19][5] = true; }
            if (tb19x6y.Text != "") { validEntries[19][6] = tb19x6y.Text; openSpace[19][6] = true; }
            if (tb19x7y.Text != "") { validEntries[19][7] = tb19x7y.Text; openSpace[19][7] = true; }
            if (tb19x8y.Text != "") { validEntries[19][8] = tb19x8y.Text; openSpace[19][8] = true; }
            if (tb19x9y.Text != "") { validEntries[19][9] = tb19x9y.Text; openSpace[19][9] = true; }

            #endregion
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    answerKey.WriteLine(validEntries[i][j]);

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    answerKey.WriteLine(openSpace[i][j]);

            answerKey.Close();
        }
    }
}