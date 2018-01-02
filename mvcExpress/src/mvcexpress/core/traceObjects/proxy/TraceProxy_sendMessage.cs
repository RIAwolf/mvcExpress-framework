// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.proxy {
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
public class TraceProxy_sendMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceProxy_sendMessage(moduleName:String, $proxyObject:Proxy, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.PROXY_SENDMESSAGE : MvcTraceActions.PROXY_SENDMESSAGE_CLEAN), moduleName);
		proxyObject = $proxyObject;
		type = $type;
		params = $params;
	}

}
}