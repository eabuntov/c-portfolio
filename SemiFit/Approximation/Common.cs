using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ApproximationEngine
{
	public delegate void FitFunc(ref double[] x,
		ref double f,
		ref double[] g);

	public delegate void ShowProgressFunc(ref double[] x,
		double f,
		ref double[] g);
}
