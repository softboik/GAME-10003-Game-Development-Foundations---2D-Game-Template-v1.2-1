// Include code libraries you need below (use the namespace).
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        bool IsMouseButtonDown;

        float MouseX;
        float MouseY;

        Color RandomColor = Random.Color();

        Color[] colors = new Color[] {Random.Color(), Random.Color(), Random.Color(), Random.Color(), Random.Color()};


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("silly lil' game");
            Window.SetSize(600, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
        
            MouseX = Input.GetMouseX();
            MouseY = Input.GetMouseY();

            Draw.Square(0, 0, 300);
            Draw.Square(300, 300, 300);
            Draw.Square(0, 300, 300);
            Draw.Square(300, 0, 300);

            Draw.FillColor = colors[4];
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;



            if (MouseX >= 0 & MouseX <= 300 & MouseY >= 0 & MouseY <= 300 & Input.IsMouseButtonDown(MouseInput.Left))
            {              
                bool IsMouseButtonDown = true;

                do
                {
                    Draw.Square(300, 300, 300);
                    Draw.Square(0, 300, 300);
                    Draw.Square(300, 0, 300);

                    Draw.LineColor = Color.Black;
                    Draw.LineSize = 3;
                    Draw.FillColor = colors[0];
                }
                while (IsMouseButtonDown);             
            }
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 0 & MouseY <= 300)
            {
                Draw.Square(300, 300, 300);
                Draw.Square(0, 300, 300);
                Draw.Square(0, 0, 300);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[1];
            }
            else if (MouseX >= 0 & MouseX <= 300 & MouseY >= 300 & MouseY <= 600)
            {
                Draw.Square(0, 0, 300);
                Draw.Square(300, 0, 300);
                Draw.Square(300, 300, 300);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[2];
            }
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 300 & MouseY <= 600)
            {
                Draw.Square(0, 0, 300);
                Draw.Square(0, 300, 300);
                Draw.Square(300, 0, 300);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[3];
            }


        }
    }
}
