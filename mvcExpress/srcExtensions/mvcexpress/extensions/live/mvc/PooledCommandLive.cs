// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.live.mvc {
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.live.core.ProcessMapLive;
using mvcexpress.extensions.live.modules.ModuleLive;
using mvcexpress.mvc.PooledCommand;

  

/**
 * Command that is automatically pooled.
 * All PooledCommand's are automatically pooled after execution - unless lock() is used.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version live.1.0.beta2
 */
public class PooledCommandLive extends PooledCommand {

	/** Handles application processes. */
	public var processMap:ProcessMapLive;

	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_id:int = ModuleLive.pureLegsCore::EXTENSION_LIVE_ID;

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_name:String = ModuleLive.pureLegsCore::EXTENSION_LIVE_NAME

}
}