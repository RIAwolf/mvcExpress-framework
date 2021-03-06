// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php


using mvcexpress.core.traceObjects;
using System;

namespace mvcexpress
{
/**
 * Class to store framework global settings and some important variables.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version 2.0.rc4
 */
	public class MvcExpress
	{
		/** Home website of mvcExpress. */
		public static string WEBSITE_URL = "http://mvcExpress.org";

		/** Framework name */
		public static string NAME = "mvcExpress 2.0.4";

		/** Current framework major version */
		public static uint MAJOR_VERSION = 2;

		/** Current framework minor version */
		public static uint MINOR_VERSION = 0;

		/** Current framework revision version */
		public static uint REVISION = 4;

		/** Current framework version */
		public static string VERSION = "v" + MAJOR_VERSION + "." + MINOR_VERSION + "." + REVISION;

		/**
		 * Checks for CONFIG::debug variable value.
		 * If it is true framework functions has overhead code, this overhead is used for debugging and error checking.
		 * This value can help not to forget compile with CONFIG::debug set to false for release.
		 */
		public static bool DEBUG_COMPILE
		{
			get
			{
#if DEBUG
				return true;
#endif
				return false;
			}
		}


		/**
		 * Controls how proxies can be injected into mediators.
		 * If set to false - proxies can be injected without restrictions into mediators.
		 *  - Optionally, you can define how proxy should be injected into mediators by providing 'mediatorInjectClass' parameter then mapping the proxy.
		 *  - if 'mediatorInjectClass' is not provided -> "injectClass" or if not provided proxy class will be used.
		 * If set to true - proxies can't be injected into mediators, without providing 'mediatorInjectClass' parameter then mapping the proxy.
		 *  - if 'mediatorInjectClass' is not provided -> error will be thrown then attempting to inject proxy into mediator.
		 */
		public static bool usePureMediators = false;

		/**
		 * Time in ms for framework to wait for missing dependencies.
		 * By default pending dependency feature is disabled, as it is set to 0. If missing injection is encountered - error will be instantly thrown.
		 * If pendingInjectsTimeOut is > 0, framework will wait this amount of time in milliseconds for missing dependencies to be mapped.
		 * If dependency is mapped during this waiting time - framework will find missing dependencies and resolve them.
		 * If in this time dependencies will not be resolved - error will be thrown.
		 */
		public static uint pendingInjectsTimeOut = 0;

		/**
		 * Sets a debug function that will get framework activity constants as String's.
		 * CONFIG:debug  MUST be set to true for debugFunction to get any trace data from framework.
		 * For example you can use : MvcExpress.debugFunction = trace; to trace all debug data.
		 * it is good idea to set it before initializing first module.
		 */
		public static Action<string> debugFunction = null;


		//----------------------------------
		//     Internal
		//----------------------------------

		/**
		 * Function to get more detailed framework activity information as TraceObj objects.
		 * @private
		 */
		static Action<TraceObj> loggerFunction = null;

		/**
		 * Framework function for debugging.
		 * @param    traceObj
		 * @private
		 */
#if DEBUG
		static void debug(TraceObj traceObj)
		{
			if (debugFunction != null)
			{
				if (traceObj.canPrint)
				{
					debugFunction(traceObj.toString());
				}
			}

			loggerFunction?.Invoke(traceObj);
		}
#endif
	}
}