using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ApproximationEngine
{
	public delegate void FitFunc(ref double[] x, ref double func, ref double[] grad);

	public delegate void ShowProgressFunc(ref double[] x,
		double f,
		ref double g);

	public interface IApprEngine
	{
		FitFunc FitFunction
		{
			get;
			set;
		}
		ShowProgressFunc ProgressFunction
		{
			get;
			set;
		}
		string Fit(int parametersNumber, int functionsNumber, ref double[] parameters,
			double accuracy, int maxIterations, double[] minValues, double[] maxValues);
	}
}
