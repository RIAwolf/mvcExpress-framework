// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.traceObjects.process {
using mvcexpress.core.traceObjects.TraceObj;
using mvcexpress.extensions.live.traceObjects.MvcTraceActionsLive;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version live.1.0.beta2
 */
public class TraceProcess_removeAllTasks extends TraceObj {

	public function TraceProcess_removeAllTasks(action:String, moduleName:String) {
		super(action, moduleName);
	}

	override public function toString():String {
		return "ÆÆ-- " + MvcTraceActionsLive.PROCESS_REMOVEALLTASKS + "     {" + moduleName + "}";
	}

}
}