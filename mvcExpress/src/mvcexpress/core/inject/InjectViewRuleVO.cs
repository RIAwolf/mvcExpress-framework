using System;
using System.Collections.Generic;
using mvcexpress.mvc;

namespace mvcexpress.core.inject
{
	public class InjectViewRuleVO
	{
		public Dictionary<string, Mediator> mediatorMapping = new Dictionary<string, Mediator>();

		public List<Type> mapOrder = new List<Type>();

		public InjectViewRuleVO()
		{
		}
	}
}