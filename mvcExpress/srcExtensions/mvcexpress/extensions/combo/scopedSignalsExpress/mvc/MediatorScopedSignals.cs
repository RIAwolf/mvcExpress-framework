// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.combo.scopedSignalsExpress.mvc {
using flash.utils.Dictionary;

using mindscriptact.signalsExpress.SignalExpress;

using mvcexpress.core.namespace.pureLegsCore;
using mvcexpress.extensions.scoped.mvc.MediatorScoped;

  

public class MediatorScopedSignals extends MediatorScoped {


	pureLegsCore var signalHandlerRegistry:Dictionary = new Dictionary();
	pureLegsCore var bridgeSignalRegistry:Dictionary = new Dictionary();

	/**
	 * Add signal handler.
	 * @param signal    signal object.
	 * @param handler    handler function to be executed then signal dispatches.
	 */
	protected function addSignalHandler(signal:SignalExpress, handler:Function):void {
		  

		if (signalHandlerRegistry[signal] == null) {
			signalHandlerRegistry[signal] = 0;
		}
		signalHandlerRegistry[signal]++;
		signal.add(handler);
	}

	/**
	 * Remove signal handler.
	 * @param signal    signal object
	 * @param handler    handler function to be not executed then signal dispatches.
	 */
	protected function removeSignalHandler(signal:SignalExpress, handler:Function):void {
		  

		if (signalHandlerRegistry[signal] != null) {
			signalHandlerRegistry[signal]--;
			if (signalHandlerRegistry[signal] <= 0) {
				delete signalHandlerRegistry[signal];
			}
		}
		signal.remove(handler);
	}

	/**
	 * Remove all added signal handlers.
	 */
	protected function removeAllSignalHandlers():void {
		  

		for (var signal:Object in signalHandlerRegistry) {
			signal.removeAll();
			delete signalHandlerRegistry[signal];
		}
	}


	//------------------
	// Signal bridging to messages
	//------------------


	/**
	 * Bridge signal to message. Then signal is dispatched - message will be sent.
	 * @param signal    signal to bridge to message.
	 * @param messageType    message type to be send then signal is dispatched.
	 */
	protected function bridgeSignalToMessage(signal:SignalExpress, messageType:String):void {
		  

		if (signal.paramCount > 1) {
			throw Error("Only signals that dispatches one or zero parameters are supported. (mvcExpress messages can pass single objects only.)");
		}

		var sendMessageFunction:Function = this.sendMessage;
		var handleFunction:Function = function (param:Object = null):void {
			sendMessageFunction(messageType, param);
		};

		if (!(signal in bridgeSignalRegistry)) {
			bridgeSignalRegistry[signal] = new Dictionary();
		}
		if (!(messageType in bridgeSignalRegistry[signal])) {
			bridgeSignalRegistry[signal][messageType] = handleFunction;
			addSignalHandler(signal, handleFunction);
		}
	}

	/**
	 * Remove bridge from signal to message. Then signal is dispatched - message will be sent.
	 * @param signal    signal to no longer bridge to message.
	 * @param messageType    message type to not be send then signal is dispatched.
	 */
	protected function unbridgeSignalToMessage(signal:SignalExpress, messageType:String):void {
		  

		if (signal in bridgeSignalRegistry) {
			if (messageType in bridgeSignalRegistry[signal]) {
				removeSignalHandler(signal, bridgeSignalRegistry[signal][messageType]);
				delete bridgeSignalRegistry[signal][messageType];
			}
		}

	}

	//----------------------------------
	//     INTERNAL
	//----------------------------------

	override pureLegsCore function remove():void {
		removeAllSignalHandlers();
		super.pureLegsCore::remove();
	}


}
}
