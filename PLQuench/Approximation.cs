using System;

namespace PLQuench
{
	public delegate void FitFunc(ref double[] x,
		ref double[] fvec,
		ref double[,] fjac,
		ref int iflag);

	public delegate void ShowProgressFunc(ref double[] x,
		double f,
		ref double[] g);

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
