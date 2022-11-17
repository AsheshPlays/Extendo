using System;

namespace Extendo.Modulation
{
	[Serializable]
	public class FloatModulation : Modulation<float>
	{
		// Set defaults
		public FloatModulation()
		{
			speed     = 1f;
			remapMax  = 1f;
			cutoffMax = 1f;
		}

		protected override float GetModulationValue
		(
			ModulateDelegate method,
			float time,
			float remapMin,
			float remapMax,
			float cutoffMin,
			float cutoffMax
		)
		{
			float timeValue = (time + offset) * speed;
			return method(timeValue, new (remapMin, remapMax), new (cutoffMin, cutoffMax));
		}
	}
}