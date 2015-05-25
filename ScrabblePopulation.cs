using System;
using System.Collections;

namespace GAScrabble
{
	/// <summary>
	/// 
	/// </summary>
	public class ScrabblePopulation : Population
	{
		public ScrabblePopulation()
		{
			//
			// TODO: Add constructor logic here
			//
			Genomes.Clear();
			for  (int i = 0; i < kInitialPopulation; i++)
			{
                ScrabbleGenome aGenome = new GAScrabble.ScrabbleGenome(ScrabbleGenome.WordLength, 1, ScrabbleGenome.WordLength);
				aGenome.SetCrossoverPoint(kCrossover);
				aGenome.CalculateFitness();
				Genomes.Add(aGenome);
			}

		}

		public ScrabblePopulation(int numberOfGenomes)
		{
			//
			// TODO: Add constructor logic here
			//
			Genomes.Clear();
			for  (int i = 0; i < numberOfGenomes; i++)
			{
                ScrabbleGenome aGenome = new ScrabbleGenome(ScrabbleGenome.WordLength, 1, ScrabbleGenome.WordLength);
				aGenome.SetCrossoverPoint(kCrossover);
				aGenome.CalculateFitness();
				Genomes.Add(aGenome);
			}

		}



        /// <summary>
        /// Mutate simply reverses 2 random letter positions
        /// </summary>
        /// <param name="aGene"></param>
		private void Mutate(Genome aGene)
		{
			if (ScrabbleGenome.TheSeed.Next(100) < (int)(kMutationFrequency * 100.0))
			{
				aGene.Mutate();
			}
		}

		public void NextGeneration()
		{
			// increment the generation;
			Generation++; 


			// check who can die
			for  (int i = 0; i < Genomes.Count; i++)
			{
				if  (((Genome)Genomes[i]).CanDie(kDeathFitness))
				{
					Genomes.RemoveAt(i);
					i--;
				}
			}


			// determine who can reproduce
			GenomeReproducers.Clear();
			GenomeResults.Clear();
			for  (int i = 0; i < Genomes.Count; i++)
			{
				if (((Genome)Genomes[i]).CanReproduce(kReproductionFitness))
				{
					GenomeReproducers.Add(Genomes[i]);			
				}
			}
			
			// do the crossover of the genes and add them to the population
			DoCrossover(GenomeReproducers);

			Genomes = (ArrayList)GenomeResults.Clone();
        //    Genomes = (ArrayList)GenomeReproducers.Clone();

			// mutate a few genes in the new population
			for  (int i = 0; i < Genomes.Count; i++)
			{
				Mutate((Genome)Genomes[i]);
			}

			// calculate fitness of all the genes
			for  (int i = 0; i < Genomes.Count; i++)
			{
				((Genome)Genomes[i]).CalculateFitness();
			}


			//			Genomes.Sort();

			// kill all the genes above the population limit
			if (Genomes.Count > kPopulationLimit)
				Genomes.RemoveRange(kPopulationLimit, Genomes.Count - kPopulationLimit);
			
			CurrentPopulation = Genomes.Count;
			
		}

		public void CalculateFitnessForAll(ArrayList genes)
		{
			foreach(ScrabbleGenome lg in genes)
			{
				lg.CalculateFitness();
			}
		}

		public void DoCrossover(ArrayList genes)
		{
			ArrayList GeneMoms = new ArrayList();
			ArrayList GeneDads = new ArrayList();

			for (int i = 0; i < genes.Count; i++)
			{
				// randomly pick the moms and dad's
				if (ScrabbleGenome.TheSeed.Next(100) % 2 > 0)
				{
					GeneMoms.Add(genes[i]);
				}
				else
				{
					GeneDads.Add(genes[i]);
				}
			}

			//  now make them equal
			if (GeneMoms.Count > GeneDads.Count)
			{
				while (GeneMoms.Count > GeneDads.Count)
				{
					GeneDads.Add(GeneMoms[GeneMoms.Count - 1]);
					GeneMoms.RemoveAt(GeneMoms.Count - 1);
				}

				if (GeneDads.Count > GeneMoms.Count)
				{
					GeneDads.RemoveAt(GeneDads.Count - 1); // make sure they are equal
				}

			}
			else
			{
				while (GeneDads.Count > GeneMoms.Count)
				{
					GeneMoms.Add(GeneDads[GeneDads.Count - 1]);
					GeneDads.RemoveAt(GeneDads.Count - 1);
				}

				if (GeneMoms.Count > GeneDads.Count)
				{
					GeneMoms.RemoveAt(GeneMoms.Count - 1); // make sure they are equal
				}
			}

			// now cross them over and add them according to fitness
			for (int i = 0; i < GeneDads.Count; i ++)
			{
				// pick best 2 from parent and children
			//	ScrabbleGenome babyGene1 = (ScrabbleGenome)((ScrabbleGenome)GeneDads[i]).Crossover((ScrabbleGenome)GeneMoms[i]);
			//	ScrabbleGenome babyGene2 = (ScrabbleGenome)((ScrabbleGenome)GeneMoms[i]).Crossover((ScrabbleGenome)GeneDads[i]);

                ScrabbleGenome babyGene1 = (ScrabbleGenome)((ScrabbleGenome)GeneDads[i]).Clone();
                ScrabbleGenome babyGene2 = (ScrabbleGenome)((ScrabbleGenome)GeneMoms[i]).Clone();

                babyGene1.SelfCrossover();
                babyGene2.Mutate();
			
				GenomeFamily.Clear();
				GenomeFamily.Add(GeneDads[i]);
				GenomeFamily.Add(GeneMoms[i]);
				GenomeFamily.Add(babyGene1);
				GenomeFamily.Add(babyGene2);
				CalculateFitnessForAll(GenomeFamily);
				GenomeFamily.Sort();

				if (Best2 == true)
				{
					// if Best2 is true, add top fitness genes
					GenomeResults.Add(GenomeFamily[0]);					
					GenomeResults.Add(GenomeFamily[1]);					

				}
				else
				{
					GenomeResults.Add(babyGene1);
					GenomeResults.Add(babyGene2);
				}
			}

		}


	}
}
