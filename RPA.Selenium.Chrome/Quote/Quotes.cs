using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA.Selenium.Chrome.Quote;
public class Quotes
{
    public string Title { get; set; }     
    public string Author { get; set; }     
    public List<string> tags { get; set; } = new List<string>();
}
