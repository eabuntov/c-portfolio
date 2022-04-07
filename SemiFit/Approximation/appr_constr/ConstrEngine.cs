﻿using System;
using System.Collections.Generic;
using System.Text;
using ApproximationEngine;

namespace appr_constr
{
	public class ConstrEngine : IApprEngine
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
			alglib.minasastate state;
			alglib.minasareport rep;

			alglib.minasacreate(parameters, minValues, maxValues, out state);
			alglib.minasasetcond(state, accuracy, accuracy, accuracy, maxIterations);
			alglib.minasaoptimize(state, gradf, repf, null);
			alglib.minasaresults(state, out parameters, out rep);
			return rep.terminationtype.ToString();
		}

		public void gradf(double[] x, ref double func, double[] grad, object obj)
		{
			m_function(ref x, ref func, ref grad);
		}


		private void repf(double[] arg, double func, object obj)
		{
			m_displayFunction(ref arg, func, ref func);
		}
	}
}
