namespace CombineISIRFiles {
    using System;
    using System.Collections.Generic;
    using NDesk.Options;
    class Program {
        static int Verbosity;
        static void Main(string[] args) {
            int Year = 0;
            string Path = string.Empty;
            bool ShowHelp = false;
            var FileNames = new List<string>();
            var Parameters = new OptionSet() {
                {"P|Path=", "Folder Path where ISIR's are Stored.",  (string P) => Path = P },
                {"Y|Year=", "Year associated with ISIR file.", (int Y) => Year = Y},
                {"<>", "The ISIR File Names - Exclude the year, and use the -Y Switch.", F => {
                    FileNames.Add(F);
                }
               }};

            var Extra = Parameters.Parse(args);

            foreach (var File in FileNames) {
                Console.WriteLine(File + Environment.NewLine);
            }
            Console.WriteLine(Year.ToString());
            Console.WriteLine(Path);
            Console.ReadLine();

        }
    }
}
