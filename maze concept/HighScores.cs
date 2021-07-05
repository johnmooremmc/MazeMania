using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace maze_concept
{
    class HighScores
    {
        public void UpdateHighScore(string username, int Score)
        {
            StreamWriter writer;
            StreamReader reader;


            string binPath = Application.StartupPath + @"\HighScores.txt";

            List<(string, int) > HighScoreList = new List<(string, int)>();

            string line = "";
            string[] values;
            string name = "";
            int scores = 0;
            int lowerScore = 0;
            int counter = 0;

            writer = File.AppendText(binPath);

            if(Score != 0)
            {
                writer.WriteLine(username + "," + Score.ToString());

            }

            writer.Close();



            reader = File.OpenText(binPath);

            while(!reader.EndOfStream)
            {
                line = reader.ReadLine();
                values = line.Split(',');
                name = values[0];
                scores = int.Parse(values[1]);
                HighScoreList.Add((name, scores));

                if (Score < lowerScore || counter == 0 )
                {
                    lowerScore = Score;
                }
                counter++;

            }
            reader.Close();

            HighScoreList = HighScoreList.OrderByDescending(x => x.Item2).Take(10).ToList();

            foreach(var (names,score2) in HighScoreList)
            {
                if (ActiveForm == MazeMania.ActiveForm)

                {
                    ((MazeMania)MazeMania.ActiveForm).LBhighscores.Items.Add(names.PadRight(10) + score2);
                }
            }





        }

        




    }
}
