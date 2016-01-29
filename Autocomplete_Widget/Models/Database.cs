using System.Collections.Generic;
using System.Linq;

namespace Autocomplete_Widget.Models
{
    public class Database
    {
        public static List<Language> FindLanguage(string LanguageName)
        {
            var list = new List<Language>()
            {
                new Language {Id = 1, Name="C" }
                 , new Language {Id = 2, Name="C++" }
                 , new Language {Id = 3, Name="C#" }
                 , new Language {Id = 4, Name="F#" }
                 , new Language {Id = 5, Name="JavaScript" }
                 , new Language {Id = 6, Name="Java" }
                 , new Language {Id = 7, Name="Python" }
                 , new Language {Id = 8, Name="Basic" }
            };
            return list.Where(z => z.Name.Contains(LanguageName)).ToList();
        }
    }
}