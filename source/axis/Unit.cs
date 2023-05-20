// ====================================================================//
// <copyright file="Unit.cs" company="tacitfirefox">
// Copyright (c) 2023 tacitfirefox. All rights reserved.
// Licensed user the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Axis;

/// <summary>
/// Defines a unit of measurement.
/// </summary>
public record class Unit
{
    /// <summary>
    /// Gets or inits the name of this unit of measurement.
    /// </summary>
    required public string Name { get; init; }

    /// <summary>
    /// Gets or inits the common symbol of this unit of measurement.
    /// </summary>
    required public string Symbol { get; init; }

    /// <summary>
    /// Gets or inits the description of what this unit is a measurement of.
    /// </summary>
    required public string Measure { get; init; }
}
