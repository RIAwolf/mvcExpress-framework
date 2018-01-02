// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.workers.core.traceObjects.proxy {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj_SendMessage;
using mvcexpress.mvc.Proxy;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceProxy_sendWorkerMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceProxy_sendWorkerMessage(moduleName:String, $proxyObject:Proxy, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.PROXY_SENDSCOPEMESSAGE : MvcTraceActions.PROXY_SENDSCOPEMESSAGE_CLEAN), moduleName);
		proxyObject = $proxyObject;
		type = $type;
		params = $params;
		//
		canPrint = false;
	}

}
}