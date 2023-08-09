using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControls
{
    public class Phone
    {
        public string Title { get; set; } = "";
        public string Os { get; set; } = "";
        public int Memory { get; set; }
        public int CameraRes { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Title}   OS: {Os}   Memory: {Memory}Gb   Camera: {CameraRes}Mpix   Price: {Price} rub.";
        }
    }

    public class Tablet
    {
        public string Title { get; set; } = "";
        public string Os { get; set; } = "";
        public int Memory { get; set; }
        public int Screen { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Title}   OS: {Os}   Memory: {Memory}Gb   Screen: {Screen}inch   Price: {Price} rub.";
        }
    }

    public class Notebook
    {
        public string Title { get; set; } = "";
        public string Processor { get; set; } = "";
        public int RAM { get; set; }
        public int HDD { get; set; }
        public string VRAM { get; set; } = "";
        public int Screen { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Title}   Processor: {Processor}   RAM: {RAM}Gb   HDD: {HDD}Gb   Video: {VRAM}   Screen: {Screen}inch   Price: {Price} rub.";
        }
    }
}
