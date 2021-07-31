using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace maze_concept
{
    class HighScores
    {

        // below, a method will be called from form one with given username string and integer value score
        public void UpdateHighScore(string username, int Score, bool FormVisable)
        {



            StreamWriter writer;
            StreamReader reader;
            // using ysstem.threading.tesks? definess writer and reader for further tasks



            string binPath = Application.StartupPath + @"\HighScores.txt";
            // defines a path to the text file containing highscores

            List<(string, int)> HighScoreList = new List<(string, int)>();
            // defines a line of usernames by scores. 


            string line = "";
            // defines a line break

            string[] values;
            // defines an empty  variable, values which is defined as a character array.

            string name = "";
            // defines an empty string for further use

            int scores = 0;
            int lowerScore = 0;
            int counter = 0;
            // defines the variables as being 0 for a start.  The counter is defined as 0, because it is starting from the top. 0th position in document


            writer = File.AppendText(binPath);
            // defines the writer as being able to open the file from the path descirbed above.  reaching the highscores.txt file

            if (Score != 0)
            // if the score recieved is not 0
            // this means that after every reset, and fail, the score would be a waste to upload
            {
                writer.WriteLine(username + "|" + Score.ToString());
                // write a new line.
                // username|Score
            }

            writer.Close();
            // end the writer, as the score has been checked, and perhaps added



            reader = File.OpenText(binPath);
            // now define the reader as being able to open the highscores file defined by the path above

            while (!reader.EndOfStream)
            // While the value of a new line doees not return NULL
            {
                line = reader.ReadLine();
                // defines the concept of a line within the text document

                values = line.Split('|');
                // defines two variables by the "|" split

                name = values[0];
                // defines name, a string, by the first value on the line

                scores = int.Parse(values[1]);
                // defines score by the seccond value on each line

                HighScoreList.Add((name, scores));
                // list is formed as the while loop adds values to it

                if (Score < lowerScore || counter == 0)
                // while there is a score within the list to iterate to next
                {
                    lowerScore = Score;
                    // defines lowerscore as score 
                }
                counter++;
                // increase counter, counding the number of scores, and therefore lines of the text document

            }
            reader.Close();
            // end reader, there are no more scores to read

            HighScoreList = HighScoreList.OrderByDescending(x => x.Item2).Take(10).ToList();
            // sort the list by desecending order.  Highest score on top
            // also only take the top 10 values inclusive

            if (FormVisable)
            {

                foreach (var (names, score2) in HighScoreList)
                // for each of the 10 scores in the list formed
                {

                    ((MazeMania)MazeMania.ActiveForm).LBhighscores.Items.Add("   " + names.PadRight(10) + "-".PadRight(10) + score2.ToString());


                    //Console.WriteLine(names + " :  " + score2);
                    // for devalopment purposes, will write the 10 scores in the console for debugging, and for proof of concept earlier into devalopment

                }
            }
        }


    }
}
