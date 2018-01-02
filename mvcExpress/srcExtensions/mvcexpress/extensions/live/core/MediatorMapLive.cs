// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.core {
using flash.utils.Dictionary;

using mvcexpress.core.MediatorMap;
using mvcexpress.core.ProxyMap;
using mvcexpress.core.messenger.Messenger;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.live.modules.ModuleLive;
using mvcexpress.extensions.live.mvc.MediatorLive;
using mvcexpress.mvc.Mediator;

  

/**
 * Handles application mediators.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version live.2.0.rc4
 */
public class MediatorMapLive extends MediatorMap {

	// used internally to work with processes.
	private var processMap:ProcessMapLive;

	public function MediatorMapLive($moduleName:String, $messenger:Messenger, $proxyMap:ProxyMap) {
		super($moduleName, $messenger, $proxyMap);
	}

	override protected function prepareMediator(mediator:Mediator, mediatorClass:Class, viewObject:Object, injectClasses:Vector.<Class> = null):Boolean {
		  

		if (mediator is MediatorLive) {
			(mediator as MediatorLive).processMap = processMap;
		}
		return super.prepareMediator(mediator, mediatorClass, viewObject, injectClasses);
	}

	/** @private */
	pureLegsCore function setProcessMap(value:ProcessMapLive):void {
		processMap = value;
	}


	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	/** @private */
	CONFIG::debug
	override pureLegsCore function setSupportedExtensions(supportedExtensions:Dictionary):void {
		super.setSupportedExtensions(supportedExtensions);
		if (!SUPPORTED_EXTENSIONS[ModuleLive.EXTENSION_LIVE_ID]) {
			throw Error("This extension is not supported by current module. You need " + ModuleLive.EXTENSION_LIVE_NAME + " extension enabled.");
		}
	}
}
}