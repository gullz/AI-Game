using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace GAScrabble
{
    public class retrievWords
    {
        // A list of words that can be generated using the dictionary
        private List<string> words;

        // Constructor initialize the words list
        public retrievWords()
        {
            words = new List<string>();
        }
        // A method to add each word to the defined list
        public void addWord(string nextWord)
        {
            words.Add(nextWord);
        }

        // A method to list out distinct words from the defined and updated list       
        public string[] getWords()
        {
            List<string> temp=new List<string>();
            
            if (words.Count==0) // if no word is found the method returns null pointer
            {
                return null;
            }
            foreach(string word in words) // if a word is found in words
            {                    
                if (!temp.Contains(word)) // and it is not in the temporary list
                    temp.Add(word);       // in is added to the temp list
            }
            return temp.ToArray();
        }
        public void printWordsAll()
        {
            foreach (string word in words)
                Console.WriteLine(word);
        }

    }
}
