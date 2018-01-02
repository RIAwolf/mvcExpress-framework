// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.workers.mvc {
using flash.utils.ByteArray;

using mvcexpress.MvcExpress;
using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.workers.core.CommandMapWorker;
using mvcexpress.extensions.workers.core.WorkerManager;
using mvcexpress.extensions.workers.core.traceObjects.command.TraceCommand_sendWorkerMessage;
using mvcexpress.extensions.workers.modules.ModuleWorker;
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
 * @version workers.2.0.rc4
 */
dynamic public class CommandWorker extends Command {

	/** Instance of commandMap, typed as CommandMapWorker. (shortcut for 'commandMap as CommandMapWorker') */
	public var commandMapWorker:CommandMapWorker;

	//-------------------------
	// start/terminate worker
	//-------------------------

	/**
	 * Starts background worker.
	 *        If workerSwfBytes property is not provided - rootSwfBytes will be used.
	 * @param workerModuleClass
	 * @param workerModuleName
	 * @param workerSwfBytes    bytes of loaded swf file.
	 */
	public function startWorker(workerModuleClass:Class, workerModuleName:String, workerSwfBytes:ByteArray = null, giveAppPrivileges:Boolean = false):void {
		  

		WorkerManager.startWorker(messenger.moduleName, workerModuleClass, workerModuleName, workerSwfBytes, giveAppPrivileges);
	}

	/**
	 * terminates background worker and dispose worker module.
	 * @param workerModuleName
	 */
	public function terminateWorker(workerModuleName:String):void {
		  

 		WorkerManager.terminateWorker(messenger.moduleName, workerModuleName);
	}

	//-------------
	// check running workers
	//-------------

	/**
	 * Returns true if workers are supported.
	 */
	public static function get isWorkersSupported():Boolean {
		return WorkerManager.isSupported;
	}

	/**
	 * Checks if worker is created with given name.
	 * @param workerModuleName
	 */
	public function isWorkerCreated(workerModuleName:String):Boolean {
		  

		return WorkerManager.isWorkerCreated(workerModuleName);
	}


	/**
	 * Gives string with list of all running workers.
	 * @return
	 */
	public function listWorkers():String {
		  

		return WorkerManager.listWorkers();
	}

	//----------------------------------
	//   Worker MESSAGING
	//----------------------------------

	/**
	 * Sends message for other framework actors to react to.
	 * @param    type    type of the message. (Commands and handle functions must be mapped to type to be triggered.)
	 * @param    params    Object that will be send to Command execute() or to handle function as parameter.
	 */
	public function sendWorkerMessage(remoteWorkerModuleName:String, type:String, params:Object = null):void {
		  

		// log the action
		CONFIG::debug {
			MvcExpress.debug(new TraceCommand_sendWorkerMessage(messenger.moduleName, this, type, params, true));
		}
		//
		WorkerManager.sendWorkerMessage(messenger.moduleName, remoteWorkerModuleName, type, params);
		//
		// clean up logging
		CONFIG::debug {
			MvcExpress.debug(new TraceCommand_sendWorkerMessage(messenger.moduleName, this, type, params, false));
		}
	}

	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_id:int = ModuleWorker.pureLegsCore::EXTENSION_WORKER_ID;

	/** @private */
	CONFIG::debug
	static pureLegsCore var extension_name:String = ModuleWorker.pureLegsCore::EXTENSION_WORKER_NAME;

}
}