using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Helpers
{
    public class RandomColor
    {
        public List<string> colors = new List<string>()
        {
            "#FF5733", "#9FE2BF", "#6495ED", "#DE3163", "#40E0D0", "#FFBF00"
        };

        public string GetRandomColor()
        {
            var rand = new Random();

            var color = rand.Next(colors.Count);
            return colors[color];
        }
    }
}
