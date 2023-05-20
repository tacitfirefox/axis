// ====================================================================//
// <copyright file="Dimension.cs" company="tacitfirefox">
// Copyright (c) 2023 tacitfirefox. All rights reserved.
// Licensed user the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Axis;

/// <summary>
/// Defines an axis of measurement.
/// </summary>
/// <typeparam name="T">The underlying numerical type of this dimensional axis.</typeparam>
public record class Dimension<T>
    where T : struct
{
    /// <summary>
    /// Gets or inits the <see cref="Axis.Unit"/> of measurement of this dimension.
    /// </summary>
    required public Unit Unit { get; init; }

    /// <summary>
    /// Gets or inits the minimum magnitude this dimension can measure from.
    /// </summary>
    required public T MinimumValue { get; init; }

    /// <summary>
    /// Gets or inits the maximum magnitude this dimension can measure to.
    /// </summary>
    required public T MaximumValue { get; init; }

    /// <summary>
    /// Gets or inits the origin (or zero) magnitude of this dimension.
    /// </summary>
    required public T OriginValue { get; init; }
}