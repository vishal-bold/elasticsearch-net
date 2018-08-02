﻿using Elastic.Xunit.XunitPlumbing;

namespace Tests.Framework
{
	public class NeedsTypedKeysAttribute : SkipTestAttributeBase
	{
		public override bool Skip => !TestConfiguration.Instance.Random.TypedKeys;
		public override string Reason { get; } = "Random Configuration dictates no typed keys but this tests relies on it being set";
	}
}