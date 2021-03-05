// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Square.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx.Shapes
{
    /// <summary>
    /// Class Square.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    /// <summary>
    /// Class Square.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    public class Square : Widgets
    {
        /// <summary>
        /// The x
        /// </summary>
        /// <summary>
        /// The x
        /// </summary>
        private int _x;
        /// <summary>
        /// The y
        /// </summary>
        /// <summary>
        /// The y
        /// </summary>
        private int _y;
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
        private int x
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        private int y
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square" /> class.
        /// </summary>
        public Square()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Square" /> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="size">The size.</param>
        public Square(int x,int y,int size)
        {
            X = x;
            Y = y;
            Size = size;

        }

        /// <summary>
        /// Sets the x.
        /// </summary>
        /// <value>The x.</value>
        public override int X
        {
            set => x = value;
        }

        /// <summary>
        /// Sets the y.
        /// </summary>
        /// <value>The y.</value>
        public override int Y
        {
            set => y = value;
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
            return $"Square ({_x},{_y}) size = {_size} ";
        }
    }
}
