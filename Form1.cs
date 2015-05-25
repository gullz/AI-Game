using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;

namespace GAScrabble
{


    
    public delegate void SetScrabbleDisplayDelegate(string displayText);
    public partial class Form1 : Form
    {

        //-------------------------------------
        // retrieve words object definition
        public static retrievWords listOfWords;
        //-------------------------------------

        bool _solved = false;
        Image _tileImage = null;
        bool _stop = false; // stop flag

        retrievWords txtHandling = new retrievWords(); // texthandling object from class

        Button[] btnList; // for the text buttons

        Random _random = new Random(); // to generate random alphebatical letters

        String[,] strLetters = new String[4, 4]; // letter array horizontal
        String[,] strLettersVertically = new String[4, 4]; // letter array Vertically
        


        public Form1()
        {
            InitializeComponent();
            GetTileImage();
            btnList = new Button[] {button1,button2,button3,button4,button5,button6,button7,button8,button9,button10,button11,button12,button13,button14,button15,button16};

            

        }

        public void GetTileImage()
        {
            string tilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\ScrabbleTile.jpg";
            _tileImage = Image.FromFile(tilePath);
        }

        private string _answerText = "";


        private void GeneticAlgorithThreadContinuous()
        {
            //--------- defining a list ------------
            Form1.listOfWords = new retrievWords();
            //--------------------------------------
            // create  a new random scrabble genome population
            ScrabblePopulation population = new ScrabblePopulation();

            // continue through 100,000 generations or when the user hits stop
            for (int i = 0; i < 500; i++)
            {

                // get the next generation of genomes that are closer to the desired word fitness
                population.NextGeneration();

                // display the top word genome every 50 generations
                if (i % 50 == 0)
                {
                    population.WriteNextGeneration();
                    _answerText =  population.GetTopGenome().ToString();
                    _solved = true;
                    this.BeginInvoke(new SetScrabbleDisplayDelegate(SetScrabbleDisplay), new object[] { _answerText });
                    Invalidate();
                }
                
                // escape if the user hit stop
                if (_stop == true)                {
                    _stop = false;

                    break;
                }


            }

        }



        private void GeneticAlgorithmThread()
        {
            ScrabblePopulation population = new ScrabblePopulation();
            for (int i = 0; i < 100000; i++)
            {
                population.NextGeneration();

                if (_stop == true)
                {
                    _stop = false;
                    break;
                }


                if (i % 50 == 0)
                {
                    population.WriteTopGenome();
                }

                // break if the fitness is equal to the length of the answer
                if (population.GetHighestScoreGenome().CurrentFitness == ScrabbleGenome.WordLength || _stop == true)
                {
                    _answerText =  population.GetTopGenome().ToString();
                    _solved = true;
                    this.BeginInvoke(new SetScrabbleDisplayDelegate(SetScrabbleDisplay), new object[] { _answerText });
                    _stop = false; // reset the stop flag
                    break;
                }

            }
        }

        private void SetScrabbleDisplay(string displayText)
        {
            lblAnswer.Text = _answerText;
            Invalidate();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {




            ScrabbleGenome.InitialScrabbleLetters = txtAnagram.Text;
            Thread oThread = new Thread(new ThreadStart(GeneticAlgorithmThread));
            oThread.Start();
        }

        private void btnContinuous_Click(object sender, EventArgs e)
        {
            // get the scrambled letters
            ScrabbleGenome.InitialScrabbleLetters = txtAnagram.Text;
            _stop = false;
            // start the algorithm in a new thread
            Thread oThread = new Thread(new ThreadStart(GeneticAlgorithThreadContinuous));
            oThread.Start();
            //----------------------------------------------------------
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                if (oThread.ThreadState == ThreadState.Stopped)
                    break;
            }
            listOfWords.printWordsAll();
            string[] words = listOfWords.getWords();

            lstWords.Items.AddRange(words);
            //----------------------------------------------------------
        }

        Font _scrabbleFont = new Font(new FontFamily("Arial"), 24, FontStyle.Bold);
        Font _numberFont = new Font(new FontFamily("Arial"), 7, FontStyle.Bold);

        void DrawLetterTile(Graphics g, int position, char c)
        {
            // get the scrabble value for the letter we are painting
            int num = (int)ScrabbleGenome.ScrabblePoints[c];
            // determine the position of the wooden tile bitmap
            int xPosition = position;
            int yPosition = ClientRectangle.Height - (_tileImage.Height + 5);
            // flip the image 90 degrees each time to show different wood grains
            _tileImage.RotateFlip(RotateFlipType.Rotate90FlipX);

            // draw the blank tile
            g.DrawImage(_tileImage, xPosition , yPosition);

            // draw the scrabble letter in the center of the tile
            g.DrawString(c.ToString(), _scrabbleFont, Brushes.Black, new Point(xPosition + (_tileImage.Width - (int)g.MeasureString(c.ToString(), _scrabbleFont).Width) / 2, yPosition + (_tileImage.Height - _scrabbleFont.Height) / 2));

            // draw the scrabble point value in the lower right hand corner of the tile
            g.DrawString(num.ToString(), _numberFont, Brushes.Black, new Point(xPosition + _tileImage.Width - 15, yPosition + _tileImage.Height - 15));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // This will paint the answer
            if (_solved)
            {
                int position = 0;
                foreach (char c in lblAnswer.Text)
                {
                    position += _tileImage.Width + 5;
                    DrawLetterTile(e.Graphics, position, c.ToString().ToUpper()[0]);
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _stop = true; // stops the algorithm
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _stop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //try {
                 //Clear button texts
               foreach(Button button in btnList){

                   button.Text = "";
               }

               for (int i = 0; i < 16; i++ )
               {
                   // Generating random alphabetical letter

                   int num = _random.Next(0, 26); // Zero to 25
                   char let = (char)('a' + num);

                   btnList[i].Text = Convert.ToString(let);
               }
            
            //}catch(Exception ex){
                
            //}


        }

        // Button click events

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button1.Text).Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button2.Text).Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button3.Text).Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button4.Text).Trim();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button5.Text).Trim();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button6.Text).Trim();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button8.Text).Trim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button7.Text).Trim();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button9.Text).Trim();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button10.Text).Trim();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button12.Text).Trim();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button11.Text).Trim();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button13.Text).Trim();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button14.Text).Trim();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button15.Text).Trim();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = (txtUserInput.Text + button16.Text).Trim();
        }


        // Add to list box
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            lstUserInputs.Items.Add(txtUserInput.Text);
            txtUserInput.Text = "";
        }


        // Scan letters horizontally
        private void ScanLettersHorizontally(){ 
        
            

                    Button[,] but =  new Button[4,4] {{button1,button2,button3,button4},{button5,button6,button7,button8},{button9,button10,button11,button12},{button13,button14,button15,button16}};
                    
                        for (int i = 0; i < 4; i++) {

                            for (int j = 0; j < 4; j++) {
                               strLetters[i,j] = but[i,j].Text;
                                           
                               }
                        }
             
        }


        // scan letters vertically
        private void ScanLettersvertically()
        {
            
            Button[,] butVertical = new Button[4, 4] { { button1, button5, button9, button13 }, { button2, button6, button10, button14 }, { button3, button7, button11, button15 }, { button4, button8, button12, button16 } };

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    strLettersVertically[i, j] = butVertical[i, j].Text;

                }
            }

        }


        // For testing purposes only
        private void btnTesting_Click(object sender, EventArgs e)
        {

            ScanLettersHorizontally();
            ScanLettersvertically();
            
            for (int i = 0; i < 4; i++)
            {
                String str = "";
                String strVertical = "";
                for (int j = 0; j < 4; j++)
                {
                   str = str + strLetters[i,j];
                   strVertical = strVertical + strLettersVertically[i, j];
                   //MessageBox.Show(str);
                }

                lstGettingLetters.Items.Add(str);
                lstGettingLetters.Items.Add(strVertical);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}