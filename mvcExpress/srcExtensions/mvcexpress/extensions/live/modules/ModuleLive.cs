// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.modules {
using mvcexpress.core.ExtensionManager;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.live.core.CommandMapLive;
using mvcexpress.extensions.live.core.MediatorMapLive;
using mvcexpress.extensions.live.core.ProcessMapLive;
using mvcexpress.extensions.live.core.ProxyMapLive;
using mvcexpress.modules.ModuleCore;

  


/**
 * Core Module class, will support use of Processes and Tasks for contingently and repeatedly executed logic, represents single application unit in mvcExpress framework.
 * <p>
 * It starts framework and lets you set up your application. (or execute Commands for set up.)
 * You can create modular application by having more then one module.
 * </p>
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version live.2.0.rc4
 */
public class ModuleLive extends ModuleCore {

	/** Handle application processes */
	protected var processMap:ProcessMapLive;

	/**
	 * CONSTRUCTOR
	 * @param    moduleName    module name that is used for referencing a module. (if not provided - unique name will be generated.)
	 */
	public function ModuleLive(moduleName:String = null, mediatorMapClass:Class = null, proxyMapClass:Class = null, commandMapClass:Class = null, messengerClass:Class = null) {
		  

		CONFIG::debug {
			enableExtension(EXTENSION_LIVE_ID);
		}

		if (!mediatorMapClass) {
			mediatorMapClass = MediatorMapLive;
		} else {
			// TODO : in DEBUG chceck if subclasses right class
		}
		if (!proxyMapClass) {
			proxyMapClass = ProxyMapLive;
		} else {
			// TODO : in DEBUG chceck if subclasses right class
		}
		if (!commandMapClass) {
			commandMapClass = CommandMapLive;
		} else {
			// TODO : in DEBUG chceck if subclasses right class
		}
		super(moduleName, mediatorMapClass, proxyMapClass, commandMapClass, messengerClass);

	}

	override pureLegsCore function prepareModule():void {
		use namespace pureLegsCore

		processMap = new ProcessMapLive(moduleName, messenger, proxyMap as ProxyMapLive);
		(proxyMap as ProxyMapLive).setProcessMap(processMap);
		(mediatorMap as MediatorMapLive).setProcessMap(processMap);
		(commandMap as CommandMapLive).setProcessMap(processMap);
	}

	/** @inheritDoc */
	override public function disposeModule():void {
		use namespace pureLegsCore

		super.disposeModule();
		if (processMap) {
			processMap.dispose();
			processMap = null;
		}
	}


	/**
	 * Lists all processes and tasks.
	 */
	public function listMappedProcesses():String {
		return processMap.listProcesses();
	}

	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	/** @private */
	CONFIG::debug
	static pureLegsCore const EXTENSION_LIVE_ID:int = ExtensionManager.getExtensionIdByName(pureLegsCore::EXTENSION_LIVE_NAME);

	/** @private */
	CONFIG::debug
	static pureLegsCore const EXTENSION_LIVE_NAME:String = "live";

}
}