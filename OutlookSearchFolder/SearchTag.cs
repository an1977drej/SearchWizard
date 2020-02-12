using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookSearchWizard
{
    class SearchTag
    {
        public string Name { get; set; }
        public string Betreff { get; set; }
        public string Inhalt { get; set; }
        public string Kategorie { get; set; }
        public string Von { get; set; }
        public string An { get; set; }
        public bool Anhang { get; set; }
        public string SearchString { get; set; }
        

        public SearchTag(string name, string betreff, string inhalt, string kategorie, string von, string an, bool anhang)
        {
            Name = name;
            Betreff = betreff;
            Inhalt = inhalt;
            Kategorie = kategorie;
            Von = von;
            An = an;
            Anhang = anhang;
            SearchString = $"{name};{betreff};{inhalt};{kategorie};{von};{An};{anhang.ToString()}";
        }

        public SearchTag(string searchString)
        {
            string[] words = searchString.Split(';');
            
            if (words.Length == 7)
            {
                Name = words[0];
                Betreff = words[1];
                Inhalt = words[2];
                Kategorie = words[3];
                Von = words[4];
                An = words[5];
                Anhang = Boolean.Parse(words[6]);
                SearchString = searchString;
            }



        }

    }
}
