// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.traceObjects.process {
using mvcexpress.core.traceObjects.TraceObj;
using mvcexpress.extensions.live.traceObjects.MvcTraceActionsLive;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version live.1.0.beta2
 */
public class TraceProcess_removeTask extends TraceObj {

	public var taskClass:Class;
	public var name:String;

	public function TraceProcess_removeTask(action:String, moduleName:String, $taskClass:Class, $name:String) {
		super(action, moduleName);
		taskClass = $taskClass;
		name = $name;
	}

	override public function toString():String {
		return "ÆÆÆ- " + MvcTraceActionsLive.PROCESS_REMOVETASK + " > taskClass : " + taskClass + ", name : " + name + "     {" + moduleName + "}";
	}

}
}