using System;

namespace ConsoleApp.Phone.System

{
    public class Phone
    {
        
        
        public int id;
        public string Producer;
        public string Version;
        public string Screen;
        public string mainCamera;
        public string operatingSystem;
        public int Memory;
        public string productionYear;
        public int RandomAccessMemory;
        public string Network;
        public string Color;
        public string Weight;

        static int counter = 0;
        private static string aStr;

        public Phone()
        {
            counter++;
            id = counter;
        }
        public override string ToString()
        {
            return
           $"No: {id}\n" +
           $"Producer: {Producer}\n" +
           $"Version: {Version}\n" +
           $"Screen: {Screen}\n" +
           $"mainCamera: {mainCamera}\n" +
           $"operatingSystem: {operatingSystem}\n" +
           $"Memory: {Memory}\n" +
           $"productionYear: {productionYear}\n" +
           $"RandomAccessMemory: {RandomAccessMemory}\n" +
           $"Network: {Network}\n" +
           $"Color: {Color}\n" +
           $"Weight: {Weight}\n";
        }


    }
}
