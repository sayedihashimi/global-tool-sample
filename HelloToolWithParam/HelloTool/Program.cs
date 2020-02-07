using System;
using McMaster.Extensions.CommandLineUtils;

namespace HelloTool {
    class Program {
        static int Main(string[] args) {
            var app = new CommandLineApplication();

            app.OnExecute(() => {
                Console.WriteLine("Hello2 World!");
            });

            return app.Execute(args);
        }
    }
}
