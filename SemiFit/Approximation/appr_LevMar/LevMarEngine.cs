using System;
using System.Collections.Generic;
using System.Text;
using ApproximationEngine;

namespace appr_LevMar
{
	public class LevMarEngine : IApprEngine
	{
		private ShowProgressFunc m_displayFunction;
		private FitFunc m_function;

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
			alglib.minlmstate state;
			alglib.minlmreport rep;

			alglib.minlmcreatefgh(parameters, out state);
			alglib.minlmsetcond(state, accuracy, accuracy, accuracy, maxIterations);
			alglib.minlmoptimize(state, func, gradf, hessf, repf, null);
			alglib.minlmresults(state, out parameters, out rep);
			return rep.terminationtype.ToString();
		}

		public void func(double[] x, ref double func, object obj)
		{
			double [] tmp = new double [x.Length];
			m_function(ref x, ref func, ref tmp); 
		}

		public void gradf(double[] x, ref double func, double[] grad, object obj)
		{
			m_function(ref x, ref func, ref grad);
		}

		public void hessf(double[] x, ref double func, double[] grad, double[,] hess, object obj)
		{
			// this callback calculates Hessian.
			double tmp = 0;
			for (int i = 0; i < x.Length; i++)
				for (int j = 0; j < x.Length; j++)
				{
					tmp = x[j];
					x[j] += 0.0001*tmp;
					m_function(ref x, ref func, ref grad);
					hess[i, j] = grad[i];
					x[j] = tmp - 0.0001 * tmp;
					m_function(ref x, ref func, ref grad);
					hess[i, j] -= grad[i];
					hess[i, j] /= 0.0002 * tmp;
					x[j] = tmp;
				}
			m_function(ref x, ref func, ref grad);
		}

		private void repf(double[] arg, double func, object obj)
		{
			m_displayFunction(ref arg, func, ref func);
		}

	}
}
