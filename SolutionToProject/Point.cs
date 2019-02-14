using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasProject
{
    /// <summary>
    /// This class represents a Point 
    /// Point contains of x, y coordinates within the Canvas range
    /// </summary>
    internal class Point
    {
        /// private data - x, y coordinates
        private int _x;
        private int _y;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="x">x coordinate of the new point</param>
        /// <param name="y">y coordinate of the new point</param>
        internal Point(int x, int y)
        {
           _x = x;
           _y = y;
        }

        /// <summary>
        /// X Getter
        /// </summary>
        /// <returns>returns the X value of the point</returns>
        internal int GetX()
        {
            return _x;
        }

        /// <summary>
        /// Y Getter
        /// </summary>
        /// <returns>returns the y value of the point</returns>
        internal int GetY()
        {
            return _y;
        }


        /// <summary>
        /// X Setter
        /// </summary>
        /// <param name="x">the new x coordiante of the point (must be between 0-canvas max width)</param>
        internal void SetX(int x)
        {
            if (x >= 0 && x < MyCanvas.MAX_WIDTH)
            {
                _x = x;
            }
            else
            {
                Console.WriteLine("$x value of {x} is invalid!");
            }
        }


        /// <summary>
        /// Y Setter
        /// </summary>
        /// <param name="y">the new y coordiante of the point (must be between 0-canvas max height)</param>
        internal void SetY(int y)
        {
            if (y >= 0 && y < MyCanvas.MAX_HEIGHT)
            {
                _y = y;
            }
            else
            {
                Console.WriteLine("$y value of {y} is invalid!");
            }
        }

        /// <summary>
        /// String representation of the class
        /// </summary>
        /// <returns>Point text representation</returns>
        public override string ToString()
        {
            return $" Point ( { this._x } , { this._y } )";
        }
    }
}
