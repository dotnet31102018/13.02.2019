using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanvasProject;

namespace CanvasProject
{
    /// <summary>
    /// This class represents a Buttons consist of two points
    /// Top-left and Bottom-right
    /// The width and height are calculated automatically upon instance creation and points modification
    /// The Setters validates the Top-left and Bottom-right points
    /// </summary>
    internal class MyButton
    {

        /// protected data topleft and bottomright
        protected Point _topLeft;
        protected Point _bottomRight;

        /// private data - width + height
        private int _width;
        private int _height;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="topLeft">Top-left coordinates of the new button</param>
        /// <param name="bottomRight">bottom-right coordinates of the new button</param>
        internal MyButton(Point topLeft, Point bottomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
            UpdateWidthAndHeight();
        }

        /// <summary>
        /// Returns the auto calculated width of the button (between top-left and bottom-right)
        /// </summary>
        /// <returns>button width</returns>
        internal int GetWidth()
        {
            return _width;
        }

        /// <summary>
        /// Returns the auto calculated height of the button (between top-left and bottom-right)
        /// </summary>
        /// <returns>button height</returns>
        internal int GetHeight()
        {
            return _height;
        }

        /// <summary>
        /// top-left point getter
        /// </summary>
        /// <returns>topleft point</returns>
        internal Point GetTopLeft()
        {
            return _topLeft;
        }

        /// <summary>
        /// bottom-right point getter
        /// </summary>
        /// <returns>bottomright point</returns>
        internal Point GetbottomRight()
        {
            return _bottomRight;
        }

        /// <summary>
        /// Updates the width and height of the button
        /// </summary>
        private void UpdateWidthAndHeight()
        {
            this._width = _bottomRight.GetX() - _topLeft.GetX();
            this._height = _bottomRight.GetY() - _topLeft.GetY();
        }

        /// <summary>
        /// bottom-right setter
        /// </summary>
        /// <param name="br">the new bottomright point</param>
        /// <returns>true if valid</returns>
        internal bool SetBottomRight(Point br)
        {
            if (br.GetX() < this._topLeft.GetX() || br.GetY() < this._topLeft.GetY())
            {
                return false;
            }

            this._bottomRight = br;

            this.UpdateWidthAndHeight();

            return true;
        }

        /// <summary>
        /// top-left setter
        /// </summary>
        /// <param name="tl">the new topleft point</param>
        /// <returns>true if valid</returns>
        internal bool SetTopLeft(Point tl)
        {
            if (tl.GetX() > this._bottomRight.GetX() || tl.GetY() > this._bottomRight.GetY())
            {
                return false;
            }

            this._topLeft = tl;

            this.UpdateWidthAndHeight();

            return true;
        }

        /// <summary>
        /// String representation of the class
        /// </summary>
        /// <returns>MyButton text representation</returns>
        public override string ToString()
        {
            return $"Button TopLeft : { this._topLeft }, bottomRight : { this._bottomRight }, Width : { this._width }, Height : { this._height }";
        }
    }
}
