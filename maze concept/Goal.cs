using System.Drawing;

namespace maze_concept
{
    class Goal
    {
        public int width, height;
        public int x, y;
        // defines public integer values for later use


        // below is a method which can be called on from form1.cs  which will be required to send defined graphics and the image source
        public void DrawGoal(Graphics g, Image goalSkin)
        {

            width = 45;
            height = 45;
            // integer valules for width and height are defined


            g.DrawImage(goalSkin, x + 2, y + 2, width, height);
            // values used to draw a rectangle with an image picture

        }

    }
}
