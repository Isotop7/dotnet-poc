using System;

namespace object_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create furniture ...");
            var f1 = new Furniture("Cupboard", 10, 5, 2.5);
            Console.WriteLine($"Volume: {f1.getVolume()}");
            f1.addDecoration("Lamp");
            f1.addDecoration("Glass");
            var dec1 = new Decoration("Hue Bridge", 29.95, 9);
            f1.addDecoration(dec1);
            Console.WriteLine($"Decorations: {f1.getDecoration()}");
            //var f2 = new Furniture(12, 2.2);
            //Console.WriteLine($"Volume: {f2.getVolume()}");
        }
    }
}
