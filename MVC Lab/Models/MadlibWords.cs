using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab.Models
{
    public class MadlibWords
    {
        public List<string> PartsOfSpeech { get; set; }
        public List<string> UserWords { get; set; }
        public string MadlibParagraph { get; set; }

        public void PutWordsInParagraph()
        {
            foreach (string word in UserWords)
            {
                int index = MadlibParagraph.IndexOf('|');
                MadlibParagraph = MadlibParagraph.Remove(index, 1).Insert(index, word);
            }
        }
    }
}
