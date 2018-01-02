// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.core.traceObjects.proxyMap {
using mvcexpress.core.inject.InjectRuleVO;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.core.traceObjects.MvcTraceActions;
using mvcexpress.core.traceObjects.TraceObj;

/**
 * Class for mvcExpress tracing. (debug mode only)
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 * @private
 *
 * @version 2.0.rc1
 */
public class TraceProxyMap_injectStuff extends TraceObj {

	public var hostObject:Object;
	public var injectObject:Object;
	public var rule:InjectRuleVO;

	public function TraceProxyMap_injectStuff(moduleName:String, $hostObject:Object, $injectObject:Object, $rule:InjectRuleVO) {
		  

		super(MvcTraceActions.PROXYMAP_INJECTSTUFF, moduleName);
		hostObject = $hostObject;
		injectObject = $injectObject;
		rule = $rule;
		//
		canPrint = false;
	}

}
}