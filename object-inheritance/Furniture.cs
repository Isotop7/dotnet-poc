using System;
using System.Collections.Generic;

namespace object_inheritance
{
    public class Furniture
    {
        public string Description { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        private double Volume;
        private List<Decoration> decorations = new List<Decoration>();

        public Furniture(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public Furniture(string description, double height, double width, double length)
        {
            this.Description = description;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Volume = getVolume();
        }

        public void addDecoration(string description)
        {
            this.decorations.Add(new Decoration(description));
        }

        public void addDecoration(Decoration d)
        {
            this.decorations.Add(d);
        }

        public string getDecoration()
        {
            var result = "";
            foreach(var d in decorations)
            {
                result += d.Description + "; ";
            }
            return result;
        }

        public double getVolume()
        {
            if( this.Height == 0 || this.Width == 0 || this.Length == 0)
            {
                throw new ArgumentOutOfRangeException($"Any value of furniture is not set. Can't calculate volume with zero value. H={this.Height},W={this.Width},L={this.Length}");
            } else
            {
                return this.Height * this.Width * this.Length;
            }
        }
    }
}
