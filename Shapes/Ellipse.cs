// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Ellipse.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx.Shapes
{
    /// <summary>
    /// Class Ellipse.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    public class Ellipse:Widgets
    {
        /// <summary>
        /// The x1
        /// </summary>
        private int _x1;
        /// <summary>
        /// The y1
        /// </summary>
        private int _y1;
        /// <summary>
        /// The horizontal diameter
        /// </summary>
        private int _horizontalDiameter;
        /// <summary>
        /// The vertical diameter
        /// </summary>
        private int _verticalDiameter;

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        private int _x
        {
            get => _x1;
            set => _x1 = value;
        }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        private int _y
        {
            get => _y1;
            set => _y1 = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse" /> class.
        /// </summary>
        public Ellipse()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse" /> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="horizontalDiameter">The horizontal diameter.</param>
        /// <param name="verticalDiameter">The vertical diameter.</param>
        public Ellipse(int x , int y,int horizontalDiameter, int verticalDiameter)
        {
            X = x;
            Y = y;
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="horizontalDiameter">The horizontal diameter.</param>
        /// <param name="verticalDiameter">The vertical diameter.</param>
        /// <returns>Ellipse.</returns>
        public static Ellipse CreateInstance(int x, int y, int horizontalDiameter, int verticalDiameter)
        {
            return new Ellipse()
                { X = x, Y = y, HorizontalDiameter = horizontalDiameter,VerticalDiameter =verticalDiameter };
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
        /// Gets or sets the horizontal diameter.
        /// </summary>
        /// <value>The horizontal diameter.</value>
        public int HorizontalDiameter
        {
            get => _horizontalDiameter;
            set => _horizontalDiameter = value;
        }

        /// <summary>
        /// Gets or sets the vertical diameter.
        /// </summary>
        /// <value>The vertical diameter.</value>
        public int VerticalDiameter
        {
            get => _verticalDiameter;
            set => _verticalDiameter = value;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Ellipse  ({_x},{_y}) diameterH = {_horizontalDiameter} diameterV = {_verticalDiameter}";
        }
    }
}
