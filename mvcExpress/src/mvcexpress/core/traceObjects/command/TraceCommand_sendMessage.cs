// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.command {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj_SendMessage;
using mvcexpress.mvc.Command;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceCommand_sendMessage extends TraceObj_SendMessage {

	public var type:String;
	public var params:Object;

	public function TraceCommand_sendMessage(moduleName:String, $commandObject:Command, $type:String, $params:Object, preSend:Boolean) {
		  

		super(((preSend) ? MvcTraceActions.COMMAND_SENDMESSAGE : MvcTraceActions.COMMAND_SENDMESSAGE_CLEAN), moduleName);
		commandObject = $commandObject;
		type = $type;
		params = $params;
		//
		canPrint = false;
	}

}
}