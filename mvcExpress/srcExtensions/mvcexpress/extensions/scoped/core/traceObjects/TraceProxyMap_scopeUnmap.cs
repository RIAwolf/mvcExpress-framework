// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.scoped.core.traceObjects {
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
public class TraceProxyMap_scopeUnmap extends TraceObj {

	public var scopeName:String;
	public var injectClass:Class;
	public var name:String;

	public var dependencies:Vector.<Object>;

	public var view:DisplayObject;

	public function TraceProxyMap_scopeUnmap(moduleName:String, $scopeName:String, $injectClass:Class, $name:String) {
		super(MvcTraceActions.PROXYMAP_SCOPEUNMAP, moduleName);
		scopeName = $scopeName;
		injectClass = $injectClass;
		name = $name;
	}

	override public function toString():String {
		return "{$}¶¶¶¶- " + MvcTraceActions.PROXYMAP_SCOPEUNMAP + " > scopeName : " + scopeName + ", injectClass : " + injectClass + ", name : " + name + "     {" + moduleName + "}";
	}

}
}