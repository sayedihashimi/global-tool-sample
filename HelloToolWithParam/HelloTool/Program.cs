using System;
using Microsoft.VisualBasic;

namespace HelloTool {
    class Program {
        /// <summary>
        /// A simple global tool with parameters.
        /// </summary>
        /// <param name="name">Your name (required)</param>
        /// <param name="age">Your age</param>
        static void Main(string name = "unknown", int age = 10) {
            string message = age <= 0 ? $"Hello2 {name}" : $"Hello {name}, who is {age} years old";

            Console.WriteLine(message);
        }
    }
}
