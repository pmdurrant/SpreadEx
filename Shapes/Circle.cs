// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Circle.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx.Shapes
{
    /// <summary>
    /// Class Circle.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    /// <summary>
    /// Class Circle.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    public class Circle:Widgets
    {
        /// <summary>
        /// The size
        /// </summary>
        /// <summary>
        /// The size
        /// </summary>
        private int _size;
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
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
        /// Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="size">The size.</param>
        public Circle(int x,int y,int size)
        {
            X = x;
            Y = y;
            Size = size;

        }
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <returns>Circle.</returns>
        public static Circle CreateInstance()
        {
            return new Circle();
        }
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="size">The size.</param>
        /// <returns>Circle.</returns>
        public static Circle CreateInstance(int x, int y, int size)
        {
            return new Circle()
                { X = x, Y = y, Size = size };
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
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public int Size
        {
            get => _size;
            set => _size = value;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Circle ({_x},{_y}) size={_size}";
        }
    }
}