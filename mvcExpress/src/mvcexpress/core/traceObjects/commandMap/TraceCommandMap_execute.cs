// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.commandMap {
using flash.display.DisplayObject;

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
public class TraceCommandMap_execute extends TraceObj {

	public var commandObject:Command;
	public var commandClass:Class;
	public var params:Object;

	public var view:DisplayObject;

	public var messageFromModule:ModuleCore;
	public var messageFromMediator:Mediator;
	public var messageFromProxy:Proxy;
	public var messageFromCommand:Command;

	public function TraceCommandMap_execute(moduleName:String, $commandObject:Command, $commandClass:Class, $params:Object) {
		super(MvcTraceActions.COMMANDMAP_EXECUTE, moduleName);
		commandObject = $commandObject;
		commandClass = $commandClass;
		params = $params;
	}

	override public function toString():String {
		return "©* " + MvcTraceActions.COMMANDMAP_EXECUTE + " > commandClass : " + commandClass + ", params : " + params + "     {" + moduleName + "}";
	}

}
}