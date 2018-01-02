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
public class TraceModuleManager_registerScope extends TraceObj {

	public var scopeName:String;

	public var messageSending:Boolean;

	public var messageReceiving:Boolean;

	public var proxieMap:Boolean;

	public function TraceModuleManager_registerScope(moduleName:String, $scopeName:String, $messageSending:Boolean, $messageReceiving:Boolean, $proxieMap:Boolean) {
		super(MvcTraceActions.MODULEMANAGER_CREATEMODULE, moduleName);
		$scopeName = $scopeName;
		$messageSending = $messageSending;
		$messageReceiving = $messageReceiving;
		$proxieMap = $proxieMap;

	}

	override public function toString():String {
		return "##**++ " + MvcTraceActions.MODULEMANAGER_CREATEMODULE + " > moduleName : " + moduleName + " scopeName=" + scopeName + " messageSending=" + messageSending + " messageReceiving=" + messageReceiving + " proxieMap=" + proxieMap + "]";
	}

}
}