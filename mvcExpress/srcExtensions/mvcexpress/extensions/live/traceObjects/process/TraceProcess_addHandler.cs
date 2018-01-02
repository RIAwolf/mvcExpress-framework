// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.traceObjects.process {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.TraceObj;
using mvcexpress.extensions.live.engine.Process;
using mvcexpress.extensions.live.traceObjects.MvcTraceActionsLive;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version live.1.0.beta2
 */
public class TraceProcess_addHandler extends TraceObj {

	public var type:String;
	public var handler:Function;
	public var processObject:Process;

	public function TraceProcess_addHandler(moduleName:String, $processObject:Process, $type:String, $handler:Function) {
		  

		super(MvcTraceActionsLive.PROCESS_ADDHANDLER, moduleName);
		processObject = $processObject;
		type = $type;
		handler = $handler;
		//
		canPrint = false;
	}

}
}