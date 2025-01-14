﻿using System;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    /// <summary>
    /// Represents a cell in an <see cref="ITreeDataGridSource"/>.
    /// </summary>
    public interface ICell
    {
        bool CanEdit { get; }

        /// <summary>
        /// Gets the value of the cell.
        /// </summary>
        object? Value { get; }
    }
}
