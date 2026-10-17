using System;
using System.Numerics;

namespace Farsight.Utils;

internal static class MatrixUtils
{
	public static Vector4 GetRow(this Matrix4x4 matrix, int row)
	{
		if (row < 0 || row > 3)
		{
			throw new ArgumentOutOfRangeException("row");
		}
		return new Vector4(matrix[row, 0], matrix[row, 1], matrix[row, 2], matrix[row, 3]);
	}
}
