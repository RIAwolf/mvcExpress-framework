// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.mediator {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;
using mvcexpress.mvc.Mediator;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceMediator_addHandler extends TraceObj {

	public var type:String;
	public var handler:Function;
	public var mediatorObject:Mediator;

	public function TraceMediator_addHandler(moduleName:String, $mediatorObject:Mediator, $type:String, $handler:Function) {
		  

		super(MvcTraceActions.MEDIATOR_ADDHANDLER, moduleName);
		mediatorObject = $mediatorObject;
		type = $type;
		handler = $handler;
		//
		canPrint = false;
	}

}
}