﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleConvertAll
    {
        public static void Main()
        {
            // Create an array of PointF objects.
            PointF[] apf = {
            new PointF(27.8F, 32.62F),
            new PointF(99.3F, 147.273F),
            new PointF(7.5F, 1412.2F) };

            // Display each element in the PointF array.
            Console.WriteLine();
            foreach (PointF p in apf)
                Console.WriteLine(p);

            // Convert each PointF element to a Point object.
            Point[] ap = Array.ConvertAll(apf,
                new Converter<PointF, Point>(PointFToPoint));

        }
}
