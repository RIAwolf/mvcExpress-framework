// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.workers.core.traceObjects.moduleBase {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj_SendMessage;
using mvcexpress.modules.ModuleCore;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceModuleBase_sendWorkerMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceModuleBase_sendWorkerMessage(moduleName:String, $moduleObject:ModuleCore, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.MODULEBASE_SENDSCOPEMESSAGE : MvcTraceActions.MODULEBASE_SENDSCOPEMESSAGE_CLEAN), moduleName);
		moduleObject = $moduleObject;
		type = $type;
		params = $params;
		//
		canPrint = false;
	}

}
}