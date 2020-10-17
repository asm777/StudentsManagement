using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StudentsManagement
{
    public class TimeTableActiveTilesManager
    {
        public TimeTableActiveTilesManager()
        {
            tiles = new List<Tile>();
        }

        public List<Tile> tiles { get; }
        public DateTime keyDate { set/*Todo:  calcTiles()*/; get; }

        public void calcTiles()
        {
            tiles.Clear();
            //Todo: fill tiles.
        }
    }

    public class Tile
    {
        public Tile()
        {
            left = 0;
            top = 0;
            width = 0;
            height = 0;
            color = Color.LightGreen;
            text = "free";
        }

        public int left { set; get; }
        public int top { set; get; }
        public int width { set; get; }
        public int height { set; get; }
        public Color color { set; get; }
        public string text { set; get; }
    }
}
