// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.combo.scopedLive.core {
using flash.utils.Dictionary;

using mvcexpress.core.messenger.Messenger;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.combo.scopedLive.mvc.ProxyScopedLive;
using mvcexpress.extensions.live.core.*;
using mvcexpress.extensions.live.modules.ModuleLive;
using mvcexpress.extensions.live.mvc.ProxyLive;
using mvcexpress.extensions.scoped.core.ProxyMapScoped;
using mvcexpress.mvc.Proxy;

  

  

/**
 * ProxyMap is responsible for storing proxy objects and handling injection.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version live.1.0.beta2
 */
public class ProxyMapScopedLive extends ProxyMapScoped {

	// pushed into proxies so they could provide data objects
	private var processMap:ProcessMapLive;

	public function ProxyMapScopedLive($moduleName:String, $messenger:Messenger) {
		super($moduleName, $messenger);
	}

	//----------------------------------
	//     internal stuff
	//----------------------------------

	/** @private */
	pureLegsCore function setProcessMap(value:ProcessMapLive):void {
		processMap = value;
	}


	/**
	 * Initiates proxy object.
	 * @param    proxyObject
	 * @private
	 */
	override pureLegsCore function initProxy(proxyObject:Proxy, proxyClass:Class, injectId:String):Boolean {
		  

		if (proxyObject is ProxyScopedLive || proxyObject is ProxyLive) {
			proxyObject["setProcessMap"](processMap);
		}
		return super.initProxy(proxyObject, proxyClass, injectId);
	}

	/**
	 * Dispose of proxyMap. Remove all registered proxies and set all internals to null.
	 * @private
	 */
	override pureLegsCore function dispose():void {
		  

		processMap = null;
		super.dispose();
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
