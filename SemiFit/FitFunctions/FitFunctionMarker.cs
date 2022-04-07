using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public abstract class FitFunctionMarker
	{
		protected bool m_move, m_rotate;
		protected PointF m_position;
		protected FitFunction m_parentFunction;
		protected const float value_uninitialized = (float)-3.4E38;
		public const float float_changed = (float)3.4E38;

		public FitFunction ParentFunction
		{
			get { return m_parentFunction; }
		}

		public bool CanMove
		{
			get { return m_move; }
		}

		public bool CanRotate
		{
			get { return m_rotate; }
		}

		public PointF Position
		{
			get { return m_position; }
			set { m_position = value; }
		}

		public FitFunctionMarker(bool can_move, bool can_rotate, FitFunction parent)
		{
			m_move = can_move;
			m_rotate = can_rotate;
			m_parentFunction = parent;
		}

		public virtual PointF GetCoords(RectangleF view)
		{
			return new PointF(0, 0);
		}

		public virtual void Move(double dx, double dy)
		{
			
		}

		public virtual void Rotate(double angle)
		{
			
		}

		public virtual void UpdateCoords(RectangleF view)
		{
			m_position.X = float_changed;
			this.GetCoords(view);
		}
	}
}
