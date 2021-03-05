// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Textbox.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx.Shapes
{
    /// <summary>
    /// Class Textbox.
    /// Implements the <see cref="SpreadEx.Widgets" />
    /// </summary>
    /// <seealso cref="SpreadEx.Widgets" />
    public class Textbox : Widgets
    {
        /// <summary>
        /// The text
        /// </summary>
        private string _text;
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
        /// Initializes a new instance of the <see cref="Textbox" /> class.
        /// </summary>
        public Textbox()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Textbox" /> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="text">The text.</param>
        public Textbox(int x, int y, int width,int height,string text)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text;
        }
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <returns>Textbox.</returns>
        public static Textbox CreateInstance()
        {
            return new Textbox();
        }
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="text">The text.</param>
        /// <returns>Textbox.</returns>
        public static Textbox CreateInstance(int x, int y,int width, int height, string text)
        {
            return new Textbox()
            { X=x, Y=y,Text = text,Width = width,Height = height};
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
        public int Width
        {
            get => _width;
            set => _width = value;
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height
        {
            get => _height;
            set => _height = value;
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text
        {
            get => _text;
            set => _text = value;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Textbox ({_x},{_y}) width={_width} height={_height} text ={_text}";
         
        }
    }
}
