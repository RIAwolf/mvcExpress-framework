// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.scoped.core.traceObjects {
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceModuleManager_unregisterScope extends TraceObj {

	public var scopeName:String;

	public function TraceModuleManager_unregisterScope(moduleName:String, $scopeName:String) {
		super(MvcTraceActions.MODULEMANAGER_UNREGISTERSCOPE, moduleName);
		scopeName = $scopeName;
	}

	override public function toString():String {
		return "##**-- " + MvcTraceActions.MODULEMANAGER_UNREGISTERSCOPE + " > moduleName : " + moduleName + ", scopeName : " + scopeName;
	}

}
}