// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects {
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
public class TraceObj_SendMessage extends TraceObj {

	public var moduleObject:ModuleCore;
	public var commandObject:Command;
	public var proxyObject:Proxy;
	public var mediatorObject:Mediator;

	public function TraceObj_SendMessage(action:String, moduleName:String) {
		super(action, moduleName);
		//
		canPrint = false;
	}

}
}