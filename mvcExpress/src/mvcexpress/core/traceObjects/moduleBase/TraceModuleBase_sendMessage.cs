// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.moduleBase {
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
public class TraceModuleBase_sendMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceModuleBase_sendMessage(moduleName:String, $moduleObject:ModuleCore, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.MODULEBASE_SENDMESSAGE : MvcTraceActions.MODULEBASE_SENDMESSAGE_CLEAN), moduleName);
		moduleObject = $moduleObject;
		type = $type;
		params = $params;
		//
		canPrint = false;
	}

}
}