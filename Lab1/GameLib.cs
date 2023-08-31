using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class GameLib
    {
        public List<VideoGame> games { get; set; }
   

        public GameLib()
        {
        this.games = new List<VideoGame>();
        }

        public void addGame(VideoGame v)
        {
            games.Add(v);
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < games.Count; i++)
            {
                str += games[i];
            }
            return str;
        }

    }
}
