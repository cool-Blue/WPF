using System.Collections.Generic;

namespace ContentToggleButton
{
	
	public class StaticButton
	{
		public List<string> Options { get; set; }
		public bool InitialState { get; set; }

		public StaticButton (List<string> options, bool state0)
		{
			Options = options;
			InitialState = state0;
		}
	}

}
