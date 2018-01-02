// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.workers.core.traceObjects.mediator {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj_SendMessage;
using mvcexpress.mvc.Mediator;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceMediator_sendWorkerMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceMediator_sendWorkerMessage(moduleName:String, $mediatorObject:Mediator, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.MEDIATOR_SENDSCOPEMESSAGE : MvcTraceActions.MEDIATOR_SENDSCOPEMESSAGE_CLEAN), moduleName);
		mediatorObject = $mediatorObject;
		type = $type;
		params = $params;
		//
		canPrint = false;
	}

}
}