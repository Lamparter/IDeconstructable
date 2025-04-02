using System;

namespace Riverside.DeconstructableInterfaces;

/// <summary>
/// An interface for types that can be deconstructed into two non-nullable components.
/// </summary>
/// <typeparam name="T1">Represents the first component of the deconstructed value.</typeparam>
/// <typeparam name="T2">Represents the second component of the deconstructed value.</typeparam>
public interface IDeconstructable<T1, T2>
{
    (T1, T2) Deconstruct();
}