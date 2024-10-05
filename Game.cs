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

        //bool WasMouseButtonDown = false;

        float MouseX;
        float MouseY;

        Color RandomColor = Random.Color();

        Color[] colors = new Color[] {Random.Color(), Random.Color(), Random.Color(), Random.Color()};


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
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                colors = new Color[] { Random.Color(), Random.Color(), Random.Color(), Random.Color() };
            }

            MouseX = Input.GetMouseX();
            MouseY = Input.GetMouseY();

           
            Draw.FillColor = Color.Gray;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;
          
            Draw.Square(0, 0, 300);
            Draw.Square(300, 300, 300);
            Draw.Square(0, 300, 300);
            Draw.Square(300, 0, 300);

            if (MouseX >= 0 & MouseX <= 300 & MouseY >= 0 & MouseY <= 300 & Input.IsMouseButtonDown(MouseInput.Left))
            {              
                //bool IsMouseButtonDown = true;
       
                
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[0];
                
                Draw.Square(300, 300, 300);
                Draw.Square(0, 300, 300);
                Draw.Square(300, 0, 300);

            }
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 0 & MouseY <= 300)
            {            
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[1];

                Draw.Square(300, 300, 300);
                Draw.Square(0, 300, 300);
                Draw.Square(0, 0, 300);
            }
            else if (MouseX >= 0 & MouseX <= 300 & MouseY >= 300 & MouseY <= 600)
            {              
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[2];

                Draw.Square(0, 0, 300);
                Draw.Square(300, 0, 300);
                Draw.Square(300, 300, 300);
            }
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 300 & MouseY <= 600)
            {            
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[3];

                Draw.Square(300, 300, 300);
            }


        }
    }
}
