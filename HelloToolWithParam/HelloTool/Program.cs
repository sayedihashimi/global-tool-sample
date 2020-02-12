using System;

namespace HelloTool {
    class Program {
        /// <summary>
        /// A simple global tool with parameters.
        /// </summary>
        /// <param name="name">Your name (required)</param>
        /// <param name="age">Your age</param>
        static void Main(string name = "World", int age = 0) {
            string message = age <= 0 ? $"Hello there {name}!" : $"Hello there {name}, who is {age} years old";

            Console.WriteLine(message);
        }
    }
}
