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
        public List<Tile> tiles { get; }
        string dbPath;

        public TimeTableActiveTilesManager(DateTime keyDate, string dbPath)
        {
            this.dbPath = dbPath;
            tiles = new List<Tile>();
            KeyDate = keyDate;
        }

        private DateTime keyDate;
        public DateTime KeyDate { 
            set {
                keyDate = value;
                TilesGenerate();
            } 
            get {
                return keyDate;
            } 
        }

        private void TilesGenerate()
        {
            //Looking for startDate and finishDate
            Diapazon diapazon = new Diapazon(KeyDate);
            DateTime startDate = diapazon.startDate;
            DateTime finishDate = diapazon.finishDate;

            DateTime date = startDate;
            int baseLeft = 40;
            int tileWidth = 49;
            int betweenTilesV = 1;
            int betweenTilesH = 7;
            int baseTop = 60;
            int tileHeight = 6;
            tiles.Clear();
            for (int day=0; day<21; day++) //Three weeks
            {
                for (int unit = 0; unit < 24 * 4; unit++)
                { //for possible lesson unit per hour
                    Tile tile = new Tile();
                    
                    tile.left = baseLeft + day * (tileWidth + betweenTilesH);
                    tile.width = tileWidth;

                    tile.top = baseTop + unit * (tileHeight + betweenTilesV);
                    tile.height = tileHeight;

                    //tile.text = "Tile"
                    bool isEvenHour = unit / 4 % 2 == 0;
                    if (isEvenHour)
                    {
                        tile.color = Color.LightSeaGreen;
                    }

                    tiles.Add(tile);
                }
            }

            LessonsListManager lessonsListManager = new LessonsListManager(dbPath);
            List<LessonInfo> lessonInfos = lessonsListManager.getLessonsList(startDate, finishDate);

            for (int i=0; i<lessonInfos.Count; i++)
            {
                LessonInfo lessonInfo = lessonInfos[i];

                int tileNum = 0;
                DateTime lessonDateTime = startDate;
                while (lessonDateTime < lessonInfo.DateAndTime)
                {
                    lessonDateTime = lessonDateTime.AddMinutes(15); //***
                    tileNum++;
                }

                tiles[tileNum].height = lessonInfo.duration * tileHeight + (lessonInfo.duration - 1) * betweenTilesV;
                tiles[tileNum].text = lessonInfo.studentInfo.name;
                tiles[tileNum].color = Color.LightGreen;
                tiles[tileNum].free = false;
            }
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
            color = Color.Gray;
            text = "free";
            free = true;
        }

        public int left { set; get; }
        public int top { set; get; }
        public int width { set; get; }
        public int height { set; get; }
        public Color color { set; get; }
        public string text { set; get; }
        public bool free { set; get; }
    }
}


//DateTime startDate1 = () =>
//{
//    DateTime strtDat = KeyDate;
//    int numberOfMon = 0;
//    while (true)
//    {
//        if (strtDat.DayOfWeek == DayOfWeek.Monday)
//        {
//            numberOfMon++;
//            if (numberOfMon == 2)
//            {
//                break;
//            }
//        }
//        strtDat = strtDat.AddDays(-1);
//    }
//    return strtDat;
//}