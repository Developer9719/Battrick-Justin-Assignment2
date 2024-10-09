// Include code libraries you need below (use the namespace).
using System;
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
        string[] imageChoices = new string[5];
        string chosenImage;

        // Create a brown color
        Color Brown = new Color(139, 69, 19, 255);
        Color Purple = new Color(128,0,128,255);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Finish the Image");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            imageChoices[0] = "Tree";
            imageChoices[1] = "Car";
            imageChoices[2] = "Plane";
            imageChoices[3] = "House";

            int selection = Random.Integer(0, 3);
            // Console.WriteLine(imageChoices[selection]);
            //chosenImage = imageChoices[selection];
            // For testing purposes
            chosenImage = imageChoices[3];
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            // Draw the ground
            Draw.LineColor = Color.Green;
            Draw.FillColor = Color.Green;
            Draw.Rectangle(0, 400, 800, 200);

            for (int i = 0; i < imageChoices.Length; i++)
            {
                Draw.LineSize = 5;
                Draw.FillColor = Color.Clear;

                if (chosenImage == imageChoices[i])
                {
                    if (imageChoices[i] == "Tree")
                    {
                        // Trunk
                        Draw.LineColor = Brown;
                        Draw.Line(350, 400, 375, 400);
                        Draw.Line(350, 400, 350, 350);

                        // Leaves
                        Draw.LineColor = Color.Green;
                        Draw.Line(350, 350, 250, 350);
                        Draw.Line(250, 350, 375, 225);
                        Draw.Line(375, 225, 300, 225);
                        Draw.Line(300, 225, 375, 150);
                        Draw.Line(375, 150, 325, 150);
                        Draw.Line(325, 150, 375, 100);
                    } 
                    else if (imageChoices[i] == "Car")
                    {
                        // Tires
                        Draw.LineColor = Color.Black;
                        Draw.Circle(250, 350, 50);

                        // Car Body
                        Draw.LineColor = Color.Blue;
                        Draw.Line(450, 350, 150, 350);
                        Draw.Line(150, 350, 150, 250);
                        Draw.Line(150, 250, 250, 250);
                        Draw.Line(250, 250, 250, 150);
                        Draw.Line(250, 150, 450, 150);
                    }
                    else if (imageChoices[i] == "Plane")
                    {
                        Draw.LineColor = Purple;
                        Draw.Line(400, 100, 450, 50);
                        Draw.Line(450, 50, 400, 50);
                        Draw.Line(400, 50, 350, 100);
                        Draw.Line(350, 100, 250, 100);
                        Draw.Line(250, 100, 250, 150);
                        Draw.Line(250, 150, 350, 150);
                        Draw.Line(350, 150, 400, 200);
                        Draw.Line(400, 200, 450, 200);
                        Draw.Line(450, 200, 400, 150);
                    }
                    else if (imageChoices[i] == "House")
                    {
                        Draw.LineColor = Brown;

                        // Door
                        Draw.Line(400, 300, 350, 300);
                        Draw.Line(350, 300, 350, 400);

                        // House
                        Draw.Line(250, 400, 250, 200);
                        Draw.Line(250,200,400,200);
                        Draw.Line(250, 400,400, 400);

                        // Roof
                        Draw.Line(250, 200, 400, 50);
                    }

                    // break; // Exit the loop once the matching image is found
                }
            }
        }
    }
}
