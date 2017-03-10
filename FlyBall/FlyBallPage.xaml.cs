using Xamarin.Forms;
using System;

namespace FlyBall
{
	public partial class FlyBallPage : ContentPage
	{
		public FlyBallPage()
		{
			InitializeComponent();
		}

		readonly string[] words = { "ELEPHANT", "BATMAN", "CAR", "APPLE", "FUCHSIA" };
		char[] correctWord, guessWord; 

		void startButtonClicked(object s, EventArgs e)
		{
			startButton.Text = "Restart";
			headLabel.IsVisible = false;
			bodyLabel.IsVisible = false;
			larmLabel.IsVisible = false;
			rarmLabel.IsVisible = false;
			llegLabel.IsVisible = false;
			rlegLabel.IsVisible = false;
			counter = 0;

			var rad = new System.Random();
			word = words[rad.Next(0, words.Length)];

			correctWord = word.ToCharArray();
			guessWord = new char[correctWord.Length];

			for (int i = 0; i < correctWord.Length; i++)
			{
				guessWord[i] = '_';
			}

			outputLabel.Text = "";
			foreach (char c in guessWord)
			{
				outputLabel.Text += c + " ";
			}

			//outputLabel.Text = word;
			//outputLabel.Text = spaces;
			//outputLabel.IsEnabled = false;
			//MakeLines();


		}
		int counter = 0;

		string word;
		string lines;
		string spaces = "        ";

		void aButtonClicked(object s, EventArgs e)
		{
			CheckLetter('A');
		}
		void bButtonClicked(object s, EventArgs e)
		{
			CheckLetter('B');
		}
		void cButtonClicked(object s, EventArgs e)
		{
			CheckLetter('C');
		}
		void dButtonClicked(object s, EventArgs e)
		{
			CheckLetter('D');
		}
		void eButtonClicked(object s, EventArgs e)
		{
			CheckLetter('E');
		}
		void fButtonClicked(object s, EventArgs e)
		{
			CheckLetter('F');
		}
		void gButtonClicked(object s, EventArgs e)
		{
			CheckLetter('G');
		}
		void hButtonClicked(object s, EventArgs e)
		{
			CheckLetter('H');
		}
		void iButtonClicked(object s, EventArgs e)
		{
			CheckLetter('I');
		}
		void jButtonClicked(object s, EventArgs e)
		{
			CheckLetter('J');
		}
		void kButtonClicked(object s, EventArgs e)
		{
			CheckLetter('K');
		}
		void lButtonClicked(object s, EventArgs e)
		{
			CheckLetter('L');
		}
		void mButtonClicked(object s, EventArgs e)
		{
			CheckLetter('M');
		}
		void nButtonClicked(object s, EventArgs e)
		{
			CheckLetter('N');
		}
		void oButtonClicked(object s, EventArgs e)
		{
			CheckLetter('O');
		}
		void pButtonClicked(object s, EventArgs e)
		{
			CheckLetter('P');
		}
		void qButtonClicked(object s, EventArgs e)
		{
			CheckLetter('Q');
		}
		void rButtonClicked(object s, EventArgs e)
		{
			CheckLetter('R');
		}
		void sButtonClicked(object s, EventArgs e)
		{
			CheckLetter('S');
		}
		void tButtonClicked(object s, EventArgs e)
		{
			CheckLetter('T');
		}
		void uButtonClicked(object s, EventArgs e)
		{
			CheckLetter('U');
		}
		void vButtonClicked(object s, EventArgs e)
		{
			CheckLetter('V');
		}
		void wButtonClicked(object s, EventArgs e)
		{
			CheckLetter('W');
		}
		void xButtonClicked(object s, EventArgs e)
		{
			CheckLetter('X');
		}
		void yButtonClicked(object s, EventArgs e)
		{
			CheckLetter('Y');
		}
		void zButtonClicked(object s, EventArgs e)
		{
			CheckLetter('Z');
		}

		private void MakeLines() 
		{
			lines = "";
			foreach (var element in word)
			{
				lines += "_ ";
				underLabel.Text = lines;
			}
		}

		private bool CheckLetter(char character)
		{
			

			if (word.Contains(character.ToString()) == true)
			{
				//char[] tempo = { character };
				//int[] vals = { word.IndexOfAny(tempo) };
				for (int i = 0; i < correctWord.Length; i++) 
				{
					if (correctWord[i] == character)
					{
						guessWord[i] = character;
					}
					//var theString = "ABCDEFGHIJ";
					//var aStringBuilder = new StringBuilder(theString);
					//aStringBuilder.Remove(3, 2);
					//aStringBuilder.Insert(3, "ZX");
					//theString = aStringBuilder.ToString();
					//string temp = spaces;
					//temp = spaces.Remove(vals[i], 1);
					//temp = spaces.Insert(vals[i], character.ToString());
					//outputLabel.Text = temp;
				}
				if (counter >= 6)
				{
					outputLabel.Text = "You Lose";

				}

				outputLabel.Text = "";
				foreach (char c in guessWord)
				{
					outputLabel.Text += c + " ";
				}
				return true;
			}
			else
			{
				counter++;
				headLabel.IsVisible = true;
				if (counter == 2)
				{
					bodyLabel.IsVisible = true;
				}
				if (counter == 3)
				{
					larmLabel.IsVisible = true;
				}
				if (counter == 4)
				{
					rarmLabel.IsVisible = true;
				}
				if (counter == 5)
				{
					llegLabel.IsVisible = true;
				}
				if (counter == 6)
				{
					rlegLabel.IsVisible = true;
				}
				if (counter >= 6)
				{
					outputLabel.Text = "You Lose";

				}
				return false;
			}

		}
	}
}
