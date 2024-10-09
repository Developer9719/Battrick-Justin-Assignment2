// Include code libraries you need below (use the namespace).
using System;
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

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Finish the Image");
            Window.SetSize(800, 600);

            imageChoices[0] = "Tree";
            imageChoices[1] = "Car";
            imageChoices[2] = "Plane";
            imageChoices[3] = "Stickman";
            imageChoices[4] = "House";

            int selection = Random.Integer(0, 4);
            Console.WriteLine(imageChoices[selection]);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);


        }
    }
}
