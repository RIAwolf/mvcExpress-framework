// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.proxyMap {
using flash.display.DisplayObject;

using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceProxyMap_unmap extends TraceObj {

	public var injectClass:Class;
	public var name:String;

	public var dependencies:Vector.<Object>;

	public var view:DisplayObject;

	public function TraceProxyMap_unmap(moduleName:String, $injectClass:Class, $name:String) {
		super(MvcTraceActions.PROXYMAP_UNMAP, moduleName);
		injectClass = $injectClass;
		name = $name;
	}

	override public function toString():String {
		return "¶¶¶¶- " + MvcTraceActions.COMMANDMAP_UNMAP + " > injectClass : " + injectClass + ", name : " + name + "     {" + moduleName + "}";
	}

}
}