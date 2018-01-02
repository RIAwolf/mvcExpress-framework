// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.messenger {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;
using mvcexpress.modules.ModuleCore;
using mvcexpress.mvc.Command;
using mvcexpress.mvc.Mediator;
using mvcexpress.mvc.Proxy;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceMessenger_send_handler extends TraceObj {

	public var type:String;
	public var params:Object;
	public var handler:Function;
	public var handlerClassName:String;

	public var messageFromModule:ModuleCore;
	public var messageFromMediator:Mediator;
	public var messageFromProxy:Proxy;
	public var messageFromCommand:Command;

	public function TraceMessenger_send_handler(moduleName:String, $type:String, $params:Object, $handler:Function, $handlerClassName:String) {
		  

		super(MvcTraceActions.MESSENGER_SEND_HANDLER, moduleName);
		type = $type;
		params = $params;
		handler = $handler;
		handlerClassName = $handlerClassName;
		//
		canPrint = false;
	}

}
}