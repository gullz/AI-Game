using System;
using System.Collections;

namespace GAScrabble
{
	/// <summary>
	/// Summary description for Population.
	/// </summary>
	public class Population
	{

		public const int kLength = 8;
		protected const int kCrossover = kLength/2;
		protected const int kInitialPopulation = 1000;
		protected const int kPopulationLimit = 1000;
		protected const int kMin = 1;
		protected const int kMax = 1000;
		protected const float  kMutationFrequency = 0.10f;
		protected const float  kDeathFitness = 0.00f;
		protected const float  kReproductionFitness = 0.0f;

		protected ArrayList Genomes = new ArrayList();
		protected ArrayList GenomeReproducers  = new ArrayList();
		protected ArrayList GenomeResults = new ArrayList();
		protected ArrayList GenomeFamily = new ArrayList();

		protected int		  CurrentPopulation = kInitialPopulation;
		protected int		  Generation = 1;
		protected bool	  Best2 = true;

		public Population()
		{
			//
			// TODO: Add constructor logic here
			//
			for  (int i = 0; i < kInitialPopulation; i++)
			{
				ListGenome aGenome = new ListGenome(kLength, kMin, kMax);
				aGenome.SetCrossoverPoint(kCrossover);
				aGenome.CalculateFitness();
				Genomes.Add(aGenome);
			}

		}

		private void Mutate(Genome aGene)
		{
			if (ListGenome.TheSeed.Next(100) < (int)(kMutationFrequency * 100.0))
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

		public  void CalculateFitnessForAll(ArrayList genes)
		{
			foreach(ListGenome lg in genes)
			{
			  lg.CalculateFitness();
			}
		}

		public void DoCrossover(ArrayList genes)
		{
            for (int i = 0; i < genes.Count/2; i++)
            {
                ListGenome geneTop = genes[i] as ListGenome;
                ListGenome geneBottom = genes[genes.Count / 2 + i] as ListGenome;
                geneTop.Crossover(geneBottom);
            }
		}

		public Genome GetHighestScoreGenome()
		{
			Genomes.Sort();
			return (Genome)Genomes[0];
		}

		public virtual void WriteNextGeneration()
		{
			// just write the top 20
			Console.WriteLine("Generation {0}\n", Generation);
			if (Generation % 1 == 0) // just print every 100 generations
			{
				Genomes.Sort();
                int count = 0;
                foreach (Genome g in Genomes)
                {
                    Console.WriteLine("Genome {2}: {0} --> {1}\n", g.ToString(), g.CurrentFitness, count);
                    count++;
                    if (count == 10)
                        break;
                }

			}
		}

        public virtual void WriteTopGenome()
        {
            // just write the top 20
            Console.WriteLine("Generation {0}\n", Generation);
            if (Generation % 1 == 0) // just print every 100 generations
            {
                Genomes.Sort();
                Genome g = Genomes[0] as Genome;
                Console.WriteLine("Top Genome: {0} --> {1}\n", g.ToString(), g.CurrentFitness);
            }
        }

        public virtual Genome GetTopGenome()
        {
            // just write the top 20
            Console.WriteLine("Generation {0}\n", Generation);
             Genomes.Sort();
             Genome g = Genomes[0] as Genome;
             return g;
        }


	}
}
