using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberCount
{
    public partial class _Default : Page
    {

        protected void btnNumberCount_Click(object sender, EventArgs e)
        {
            string[] args = null;
            NumbertoWordConverstion(args);
        }

        private void NumbertoWordConverstion(string[] args)
        {

            int numberOfLetters = 0;

            for (int i = 1; i <= 1000; i++)
                numberOfLetters += LetterConverstion(i);

            lblTotalCount.Visible = true;
            lblcount.Visible = true;
            lblcount.Text = numberOfLetters.ToString();

        }

        private int LetterConverstion(int number)
        {
            try
            {
                string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] onesofOne = new string[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number == 1000)
                    return "onethousand".Length;
                string lettterString = "";
                int[] letters = new int[3];

                letters[0] = number / 100;
                letters[1] = (number / 10) % 10;
                letters[2] = number % 10;

                if (letters[0] > 0)
                {
                    lettterString += ones[letters[0]] + "hundred";
                    if (letters[1] != 0 || letters[2] != 0)
                        lettterString += "and";
                }

                if (letters[1] == 1)
                {
                    if (letters[2] == 0)
                        lettterString += tens[letters[1]];
                    else
                        lettterString += onesofOne[letters[2]];
                }
                else
                    lettterString += tens[letters[1]] + ones[letters[2]];

                return lettterString.Length;

            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }

     }
  }
 
       
    
