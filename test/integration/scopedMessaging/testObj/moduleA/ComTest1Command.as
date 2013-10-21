package integration.scopedMessaging.testObj.moduleA {
import integration.scopedMessaging.testObj.moduleB.ChannelModuleB;

import mvcexpress.mvc.Command;

/**
 * CLASS COMMENT
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 */
public class ComTest1Command extends Command {

	//[Inject]
	//public var myProxy:MyProxy;

	public function execute(moduleB:ChannelModuleB):void {
		moduleB.command1executed = true;
	}

}
}