// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Rectangle.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx.Shapes
{
    /// <summary>
    /// Class Rectangle.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    public class Rectangle: Widgets
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        private int _x { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        private int _y { get; set; }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        private int _width { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        private int _height { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        public Rectangle()
        {
          
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Rectangle(int x,int y,int width,int height)
        {
          
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Sets the x.
        /// </summary>
        /// <value>The x.</value>
        public override int X
        {
            set => _x = value;
        }


        /// <summary>
        /// Sets the y.
        /// </summary>
        /// <value>The y.</value>
        public override int Y
        {
            set => _y = value;
        }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height  { get; set; }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Rectangle({_x},{_y}) width = {_width} height = {_height}";
        }
    }
}
