using System;
using UnityEngine;

namespace Extendo.Modulation
{
	[AddComponentMenu("Extendo/Modulators/Vector2 Modulator")]
	public class Vector2Modulator : Modulator<Vector2>
	{
		public Vector2Modulator()
		{
			speed    = Vector2.one;
			to       = Vector2.one;
			cutoffTo = Vector2.one;
		}

		protected override Vector2 GetModulationValue
		(
			ModulateDelegate method,
			float time,
			Vector2 remapMin,
			Vector2 remapMax,
			Vector2 cutoffMin,
			Vector2 cutoffMax
		)
		{
			Vector2 timeValue = Vector2.Scale((Vector2.one * time) + offset, speed);

			return new Vector2
				(
					method(timeValue.x, new (remapMin.x, remapMax.x), new (cutoffMin.x, cutoffMax.x)),
					method(timeValue.y, new (remapMin.y, remapMax.y), new (cutoffMin.y, cutoffMax.y))
				)
				* strength;
		}
	}
}