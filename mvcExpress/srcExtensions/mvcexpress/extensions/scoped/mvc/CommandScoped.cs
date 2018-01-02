// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.scoped.mvc {
using mvcexpress.MvcExpress;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.scoped.core.traceObjects.TraceCommand_sendScopeMessage;
using mvcexpress.extensions.scoped.core.CommandMapScoped;
using mvcexpress.extensions.scoped.core.ProxyMapScoped;
using mvcexpress.extensions.scoped.core.ScopeManager;
using mvcexpress.extensions.scoped.modules.ModuleScoped;
using mvcexpress.mvc.Command;

/**
 * Command, handles business logic of your application.                                                                                                    </br>
 * You most likely need it then:                                                                                                                            </br>
 *    - if you need to change application state with one or more logical statement.                                                                            </br>
 *    - if you need more then one unrelated proxies injected to make a decision.                                                                            </br>
 * Commands can get proxies injected and can send constants                                                                                                    </br>
 * <b><p>
 * It MUST contain custom execute(params:Object) function. Parameter can be typed as you wish.                                                                </br>
 * It is best practice to use same type as you use in message, that triggers this command.                                                                    </br>
 * If message does not send any parameter object - you still must have singe parameter, for example: execute(blank:Object). This parameter will be null.    </br>
 * </p></b>
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version scoped.1.0.beta2
 */
dynamic public class CommandScoped extends Command {


	public var commandMapScoped:CommandMapScoped;
	public var proxyMapScoped:ProxyMapScoped;

	//----------------------------------
	//     MESSAGING
	//----------------------------------

	/**
	 * Sends scoped module to module message, all modules that are listening to specified scopeName and message type will get it.
	 * @param    scopeName    both sending and receiving modules must use same scope to make module to module communication.
	 * @param    type        type of the message for Commands or Mediator's handle function to react to.
	 * @param    params        Object that will be passed to Command execute() function and to handle functions.
	 */
	protected function sendScopeMessage(scopeName:String, type:String, params:Object = null):void {
		  

		// log the action
		CONFIG::debug {
			MvcExpress.debug(new TraceCommand_sendScopeMessage(messenger.moduleName, this, type, params, true));
		}
		//
		ScopeManager.sendScopeMessage(messenger.moduleName, scopeName, type, params);
		//
		// clean up logging the action
		CONFIG::debug {
			MvcExpress.debug(new TraceCommand_sendScopeMessage(messenger.moduleName, this, type, params, false));
		}
	}

	/**
	 * Registers scope name.
	 * If scope name is not registered - module to module communication via scope and mapping proxies to scope is not possible.
	 * What features module can use with that scope is defined by parameters.
	 * @param    scopeName            Name of the scope.
	 * @param    messageSending        Modules can send constants to this scope.
	 * @param    messageReceiving    Modules can receive and handle constants from this scope.(or map commands to scoped constants);
	 * @param    proxieMapping        Modules can map proxies to this scope.
	 */
	protected function registerScope(scopeName:String, messageSending:Boolean = true, messageReceiving:Boolean = true, proxieMapping:Boolean = false):void {
		  

		ScopeManager.registerScope(messenger.moduleName, scopeName, messageSending, messageReceiving, proxieMapping);
	}

	/**
	 * Unregisters scope name.
	 * Then scope is not registered module to module communication via scope and mapping proxies to scope becomes not possible.
	 * @param    scopeName            Name of the scope.
	 */
	protected function unregisterScope(scopeName:String):void {
		  

		ScopeManager.unregisterScope(messenger.moduleName, scopeName);
	}


	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_id:int = ModuleScoped.pureLegsCore::EXTENSION_SCOPED_ID;

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_name:String = ModuleScoped.pureLegsCore::EXTENSION_SCOPED_NAME;

}
}