// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Widgets.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpreadEx
{
    /// <summary>
    /// Class Shape.
    /// </summary>
    public abstract class Widgets
    {
        /// <summary>
        /// Sets the x.
        /// </summary>
        /// <value>The x.</value>
        public abstract int X { set; }
        /// <summary>
        /// Sets the y.
        /// </summary>
        /// <value>The y.</value>
        public abstract int Y { set; }
    }
}