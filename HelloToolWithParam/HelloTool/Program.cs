using System;
using System.Text;
using McMaster.Extensions.CommandLineUtils;

namespace HelloTool {
    class Program {
        static int Main(string[] args) {
            var app = new CommandLineApplication();

            app.HelpOption();
            app.UsePagerForHelpText = false;
            var optionName = app.Option<string>("-n|--name <NAME>", "Your name (required)", CommandOptionType.SingleValue);
            optionName.IsRequired(allowEmptyStrings: false);
            var optionAge = app.Option<int>("-a|--age <AGE>", "Your age", CommandOptionType.SingleValue);

            app.OnExecute(() => {
                var name = optionName.Value();
                string message = $"Hello {name}";

                if (optionAge.HasValue()) {
                    message += $", who is {optionAge.Value()} years old";
                }

                Console.WriteLine(message);
            });

            return app.Execute(args);
        }
    }
}
