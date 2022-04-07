using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApproximationEngine;

namespace appr_LevenbergMarquardt
{
	public class LevenbergMarquardtEngine : IApprEngine
	{
		private ShowProgressFunc m_displayFunction;
		private FitFunc m_function;


		private double m_func(double x)
		{
			return 0;
		}

		public FitFunc FitFunction
		{
			get { return m_function; }
			set { m_function = value; }
		}

		public ShowProgressFunc ProgressFunction
		{
			get { return m_displayFunction; }
			set { m_displayFunction = value; }
		}

		public string Fit(int parametersNumber, int functionsNumber, ref double[] parameters,
			double accuracy, int maxIterations, double[] minValues, double[] maxValues)
		{
			int info = 0;
			Parameter[] pars = new Parameter[parameters.Length];

			for (int i = 0; i < parameters.Length; i++)
				pars[i] = new Parameter(parameters[i]);

			Parameter[] observedParameters = new Parameter[] { new Parameter(0.0) };
			LevenbergMarquardt levenbergMarquardt = new LevenbergMarquardt(m_func(0), pars, observedParameters, z);

			for (int i = 0; i < 50; i++)
			{
				levenbergMarquardt.Iterate();
			}
			
			switch (info)
			{
				case 0:
					return "Interrupted by user";
				case 1:
					return "EpsF reached";
				case 2:
					return "EpsX reached";
				case 3:
					return "EpsX and EpsF reached";
				case 4:
					return "EpsG reached";
				case 5:
					return "Iterations limit reached";
				case 6:
					return "EpsF is too low";
				case 7:
					return "EpsX is too low";
				case 8:
					return "EpsG is too low";
				case -1:
					return "Wrong parameters";
				default:
					return "Success";
			}
		}

		private void funcvecjac(ref double[] x,
		ref double[] fvec,
		ref double[,] fjac,
		ref int iflag)
		{

		}

		private void NewIteration(ref double[] x)
		{
			m_displayFunction(ref x, 0, ref x);
		}

	}
}
