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
            imageChoices[4] = "House";

            int selection = Random.Integer(0, 3);
            // Console.WriteLine(imageChoices[selection]);
            //chosenImage = imageChoices[selection];
            // For testing purposes
            chosenImage = imageChoices[0];
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
                if (chosenImage == imageChoices[i])
                {
                    if (imageChoices[i] == "Tree")
                    {
                        Draw.LineSize = 5;

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

                    }
                    else if (imageChoices[i] == "Plane")
                    {

                    }
                    else if (imageChoices[i] == "house")
                    {

                    }

                    // break; // Exit the loop once the matching image is found
                }
            }
        }
    }
}
