// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php

using System;

namespace mvcexpress.core.traceObjects
{
/**
 * Base of all trace objects.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
	public class TraceObj : object
	{
		public string moduleName;
		public string action;

		// can print debug text.
		public bool canPrint = true;

		public TraceObj(string action, string moduleName)
		{
			this.action = action;
			this.moduleName = moduleName;
		}

		public string toString()
		{
			return "[TraceObj moduleName=" + moduleName + " action=" + action + "]";
		}
	}
}