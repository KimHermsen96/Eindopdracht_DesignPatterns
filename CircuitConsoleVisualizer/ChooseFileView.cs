using System;
using System.Collections.Generic;
using System.IO;
using CircuitLogic.controllers.Adapter_pattern;
using CircuitLogic.models;

namespace CircuitConsoleVisualizer
{
    public class ChooseFileView
    {
        public string ChosenFile { get; set; }
        private List<CircuitFile> Files { get; set; }

        public ChooseFileView()
        {
            bool noChosenFile = true;
            Files = new List<CircuitFile>();

            /*var adapter = new JsonToListAdapter();*/
            var adapter = new XmlToListAdapter();
            Files = adapter.ToList();


            while (noChosenFile)
            {
                Console.WriteLine("Choose a circuit");
                GetFiles();

                var choice = Console.ReadLine();
                var isNumeric = int.TryParse(choice, out int n);
                if (isNumeric && n >= 0 && n <= Files.Count)
                {
                    ChosenFile = Files[n - 1].Location;
                    noChosenFile = false;
                    Console.Clear();
                    Console.WriteLine("You chose:" + Files[n - 1].Name + " " + Files[n - 1].Location);
                }
            }
        }

        public void GetFiles()
        {
            for (int i = 0; i < Files.Count; i++) Console.WriteLine("Choose " + (i + 1) + " for " + Files[i].Name);
        }
    }
}
