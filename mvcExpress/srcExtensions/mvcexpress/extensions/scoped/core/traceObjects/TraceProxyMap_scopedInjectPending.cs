// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.scoped.core.traceObjects {
using mvcexpress.core.inject.InjectRuleVO;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceProxyMap_scopedInjectPending extends TraceObj {

	public var scopeName:String;
	public var hostObject:Object;
	public var injectObject:Object;
	public var rule:InjectRuleVO;

	public function TraceProxyMap_scopedInjectPending($scopeName:String, moduleName:String, $hostObject:Object, $injectObject:Object, $rule:InjectRuleVO) {
		super(MvcTraceActions.PROXYMAP_INJECTPENDING, moduleName);
		scopeName = $scopeName;
		hostObject = $hostObject;
		injectObject = $injectObject;
		rule = $rule;
	}

	override public function toString():String {
		return "!!!!! " + MvcTraceActions.PROXYMAP_INJECTPENDING + " > for scopeName:" + scopeName + " with id:" + rule.injectId + "(needed in " + hostObject + ")" + "     {" + moduleName + "}";
	}
}
}