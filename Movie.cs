using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
      private string Title ;
      private String Category;
     
        //constructor
        public Movie( string _title, string _category)
        {
            this.Title = _title;
            Category = _category;

        }
 public string getTitle()
        {
            return Title;
        }

        public string getCategory()
        {
            return Category;
        }
    }
}
