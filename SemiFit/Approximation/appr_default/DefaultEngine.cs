using System;
using System.Collections.Generic;
using System.Text;
using ApproximationEngine;

namespace appr_default
{
	public class DefaultEngine : IApprEngine
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
			double S = 0;
			double prevS = 0;
			double curSp = 0;
			double curSm = 0;
			double deviation = 0.1;
			double[] currentParameters = new double[parametersNumber + 1];
			double value = 0;
			double[] arr = new double[parameters.Length];

			for (int i = 0; i <= parametersNumber; i++)
				currentParameters[i] = parameters[i];
			m_function(ref currentParameters, ref value, ref arr);
			S = S + value * value;
			prevS = S;
			for (int iteration = 0; iteration < maxIterations; iteration++)
			{
				for (int param = 0; param <= parametersNumber; param++)
				{
					curSp = 0;
					currentParameters[param] = parameters[param] + deviation * parameters[param];
					if ((currentParameters[param] >= minValues[param])&&(currentParameters[param] <= maxValues[param]))
					{
						m_function(ref currentParameters, ref value, ref arr);
							curSp = curSp + value * value;
					}
					else curSp = 1E300;
					curSm = 0;
					currentParameters[param] = parameters[param] - deviation * parameters[param];
					if ((currentParameters[param] >= minValues[param]) && (currentParameters[param] <= maxValues[param]))
					{
						m_function(ref currentParameters, ref value, ref arr);
							curSm = curSm + value * value;
					}
					else curSm = 1E300;
					if ((curSp < curSm) && (curSp < S))
					{
						S = curSp;
						parameters[param] = parameters[param] + deviation * parameters[param];
						currentParameters[param] = parameters[param];
					}
					else if ((curSm < curSp) && (curSm < S))
					{
						S = curSm;
						parameters[param] = parameters[param] - deviation * parameters[param];
						currentParameters[param] = parameters[param];
					}
					else currentParameters[param] = parameters[param];
				}
				if (Math.Abs(S - prevS) < accuracy * prevS)
					deviation /= 2;
				prevS = S;
				m_displayFunction(ref parameters, S, ref value);
			}
			return "Iterations limit reached";
		}
	}
}
