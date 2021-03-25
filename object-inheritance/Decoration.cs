using System;

namespace object_inheritance
{
    public class Decoration
    {
        public string Description { get; set; }
        public double Value { get; set; }
        public int Need { get; set; }

        public Decoration(string description)
        {
            this.Description = description;
        }

        public Decoration(string description, double value)
        {
            this.Description = description;
            this.Value = value;
        }

        public Decoration(string description, double value, int need)
        {
            this.Description = description;
            this.Value = value;
            if (need < 0 || need > 10)
            {
                this.Need = 0;
                throw new ArgumentOutOfRangeException("Invalid need. Has to be between 0 and 10.");
            } else
            {
                this.Need = need;
            }
        }
    }
}
