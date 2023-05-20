// ====================================================================//
// <copyright file="Value.cs" company="tacitfirefox">
// Copyright (c) 2023 tacitfirefox. All rights reserved.
// Licensed user the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Axis;

using System;

/// <summary>
/// Defines a measured amount along the given dimensional axis.
/// </summary>
/// <typeparam name="T">The underlying numerical type of the dimensional axis this value is on.</typeparam>
public struct Value<T>
    where T : struct
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Value{T}"/> struct.
    /// </summary>
    /// <param name="dimension">The dimensional axis this value is on.</param>
    public Value(Dimension<T> dimension)
        : this(dimension, dimension.OriginValue)
    {
        this.Dimension = dimension;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Value{T}"/> struct.
    /// </summary>
    /// <param name="dimension">The dimensional axis this value is on.</param>
    /// <param name="magnitude">The magnitude of this value.</param>
    /// <exception cref="ArgumentNullException">Thrown when the given dimensional axis is default.</exception>
    public Value(
        Dimension<T> dimension,
        T magnitude)
    {
        this.Dimension = dimension ?? throw new ArgumentNullException(nameof(dimension));
        this.Magnitude = magnitude;
    }

    /// <summary>
    /// Gets or inits the <see cref="Dimension{T}"/> (or dimensional axis) this value is on.
    /// </summary>
    required public Dimension<T> Dimension { get; init; }

    /// <summary>
    /// Gets or sets the distance along the dimension axis this value is from the axis' origin value.
    /// </summary>
    public T Magnitude { get; set; }
}
