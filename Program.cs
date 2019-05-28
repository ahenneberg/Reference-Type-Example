using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Type_Example
{
    class Program
    {
// Assigning a reference-type variable copies the reference, not the object instance.
// Allows multiple variable to refer to the same object
        static void Main()
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;              // Copies p1 reference

            Console.WriteLine(p1.X);    // 7
            Console.WriteLine(p2.X);    // 7

            p1.X = 9;

            Console.WriteLine(p1.X);    // 9
            Console.WriteLine(p2.X);    // 9  
        }
    }
    public class Point { public int X, Y; }
}
/*                  This example shows that p1 and p2 are two references that point to the same object.
 *                                                      Point Class
 *                                          p1            
 *                                ____________________                   ____________________
 *                               |     Reference      |---------------->|   Object Metadata  |
 *                               |____________________|           |     |--------------------|
 *                                          p2                    |     |          9         |
 *                                ____________________            |     |--------------------|
 *                               |     Reference      |------------     |          0         |
 *                               |____________________|                 |____________________|                                                                       
     */
