using System;
using System.Collections;
using System.Collections.Generic;
using NetSpell.SpellChecker;

 


namespace GAScrabble
{


	/// <summary>
	/// 
	/// </summary>
	public class ScrabbleGenome : ListGenome, ICloneable
	{
        private static Hashtable  _scrabblePoints = new Hashtable();

        public static Hashtable ScrabblePoints
        {
            get
            {
                return _scrabblePoints;
            }
        }

        public static void Initialize_scrabblePoints()
        {
              // A-1 B-3 C-3 D-2  E-1 F-4 G-2 H-4 I-1 J-8 K-5 L-1 M-3
               // N-1 O-1 P-3 Q-10 R-1 S-1 T-1 U-1 V-4 W-4 X-8 Y-4 Z-10
            _scrabblePoints['A'] = 1;
            _scrabblePoints['B'] = 3;
            _scrabblePoints['C'] = 3;
            _scrabblePoints['D'] = 2;
            _scrabblePoints['E'] = 1;
            _scrabblePoints['F'] = 4;
            _scrabblePoints['G'] = 2;
            _scrabblePoints['H'] = 4;
            _scrabblePoints['I'] = 1;
            _scrabblePoints['J'] = 8;
            _scrabblePoints['K'] = 5;
            _scrabblePoints['L'] = 1;
            _scrabblePoints['M'] = 3;
            _scrabblePoints['N'] = 1;
            _scrabblePoints['O'] = 1;
            _scrabblePoints['P'] = 3;
            _scrabblePoints['Q'] = 10;
            _scrabblePoints['R'] = 1;
            _scrabblePoints['S'] = 1;
            _scrabblePoints['T'] = 1;
            _scrabblePoints['U'] = 1;
            _scrabblePoints['U'] = 1;
            _scrabblePoints['V'] = 4;
            _scrabblePoints['W'] = 4;
            _scrabblePoints['X'] = 8;
            _scrabblePoints['Y'] = 4;
            _scrabblePoints['Z'] = 10;

        }

        static ScrabbleGenome()
        {
            Initialize_scrabblePoints();
        }

        protected List<char> _scrabbleBuffer = new List<char>();

        static protected char[] _initialScrabbleLetters = new char[] { 'I', 'C', 'O', 'N', 'S'};


        public static int WordLength
        {
            get
            {
                return _initialScrabbleLetters.Length;
            }
        }

       public static  string InitialScrabbleLetters
        {
            set
            {
                _initialScrabbleLetters = new char[value.Length];
                int i = 0;
                foreach (char c in value.ToCharArray())
                {
                    _initialScrabbleLetters[i] = c;
                    i++;
                }

            }
        }

        private void PopulateScrabbleBuffer()
        {
            _scrabbleBuffer.Clear();
            _scrabbleBuffer.AddRange(_initialScrabbleLetters);
        }

        /// <summary>
        /// Switch some letters around
        /// </summary>
        public override void Mutate()
        {
            int MutationIndex1 = TheSeed.Next((int)TheArray.Count);
            int MutationIndex2 = TheSeed.Next((int)TheArray.Count);
            char temp = (char)TheArray[MutationIndex1];
            TheArray[MutationIndex1] = TheArray[MutationIndex2];
            TheArray[MutationIndex2] = temp;

        }


        public override object GenerateGene()
        {
            // must be at least 2 letters
         //  int length = TheSeed.Next((int)Length - 2) + 2;
            int length = WordLength;
            PopulateScrabbleBuffer();
            TheArray.Clear();
            for (int i = 0; i < length; i++)
            {
                int nextCharIndex = TheSeed.Next(_scrabbleBuffer.Count - 1);
                TheArray.Add(_scrabbleBuffer[nextCharIndex]);
                _scrabbleBuffer.RemoveAt(nextCharIndex);
            }

            return this;
        }


		public ScrabbleGenome()
		{
			// 
			// TODO: Add constructor logic here
			//
		}

		public ScrabbleGenome(long length, object min, object max) : base(length, min, max)
		{
			//
			// TODO: Add constructor logic here
			//
            GenerateGene();
			
		}

        
        static private Spelling _speller = new Spelling();

       


		private float CalculateFromGAScrabbleBoard()
		{

			float fFitnessScore = 0.0f;
            string word = ToString();
            if (_speller.TestWord(word))
            {
                fFitnessScore = TheArray.Count;
            }
            else
            {
                fFitnessScore = .01f;
            }



			return fFitnessScore;
		}

		public override float CalculateFitness()
		{
		CurrentFitness = CalculateFromGAScrabbleBoard();
			//			CurrentFitness = CalculateClosestRatioToPi();
			//			CurrentFitness = CalculateNumbersProducingProductsWithSameDigitsAsFirst();
			//			CurrentFitness = CalculateClosestProductSum();
			//			CurrentFitness =  CalculateClosestSumTo10();
			return CurrentFitness;
		}

		public override string ToString()
		{
			string strResult = "";

            foreach (char val in TheArray)
            {
                strResult += val;
            }

			return strResult;
		}

		public override void CopyGeneInfo(Genome dest)
		{
			ScrabbleGenome theGene = (ScrabbleGenome)dest;
			theGene.Length = Length;
			theGene.TheMin = TheMin;
			theGene.TheMax = TheMax;
		}


		public override Genome Crossover(Genome g)
		{

			ScrabbleGenome CrossingGene = (ScrabbleGenome)g;
            CrossoverPoint = ((int)Math.Min((int)CrossingGene.TheArray.Count, (int)this.TheArray.Count)) / 2;
			for (int i = 0; i < CrossoverPoint; i++)
			{
                TheArray[i] = CrossingGene.TheArray[i];
				CrossingGene.TheArray[i] = TheArray[i];
			}

            for (int j = CrossoverPoint; j < CrossoverPoint*2; j++)
			{
                CrossingGene.TheArray[j] = TheArray[j];
				TheArray[j] = CrossingGene.TheArray[j];
			}


            return CrossingGene;
		}

        public override void SelfCrossover()
        {
			ScrabbleGenome CrossingGene = (ScrabbleGenome)this.Clone();
            CrossoverPoint = TheSeed.Next(TheArray.Count - 1) + 1; 
			for (int i = 0; i < CrossoverPoint; i++)
			{
                TheArray[i] = CrossingGene.TheArray[CrossingGene.TheArray.Count - (i+1)];
			}

            for (int j = CrossoverPoint; j < TheArray.Count; j++)
			{
                TheArray[j] = CrossingGene.TheArray[CrossingGene.TheArray.Count - (j + 1)];
			}


        }

        public object Clone()
        {
            ScrabbleGenome g = new ScrabbleGenome();
            g.TheArray = (ArrayList)TheArray.Clone();
            g.Length = Length;

            return g;
        }

	}
}
