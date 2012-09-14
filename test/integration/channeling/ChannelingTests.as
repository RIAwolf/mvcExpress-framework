package integration.channeling {
import integration.channeling.testObj.moduleA.ChannelModuleA;
import integration.channeling.testObj.moduleB.ChannelModuleB;
import org.flexunit.Assert;

/**
 * COMMENT
 * @author
 */
public class ChannelingTests {
	
	private var channelModulA:ChannelModuleA;
	private var channelModulB:ChannelModuleB;
	
	[Before]
	
	public function runBeforeEveryTest():void {
		channelModulA = new ChannelModuleA();
		channelModulB = new ChannelModuleB();
	}
	
	[After]
	
	public function runAfterEveryTest():void {
		channelModulA.disposeModule();
		channelModulB.disposeModule();
	}
	
	[Test]
	
	public function channeling_moduleToModuleChanneling_addChannelHandler_sendsMessage():void {
		//
		channelModulA.cheateTestMediator();
		channelModulB.cheateTestMediator();
		//
		Assert.assertFalse("test1 handler must be false", channelModulA.view.test1handled);
		Assert.assertFalse("test2 handler must be false", channelModulA.view.test2handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test3handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test4handled);
		//
		channelModulA.addChannelHandler_test1();
		
		channelModulB.sendChannelMessage_test1();
		//
		Assert.assertTrue("test1 handler must be true after addChannelHandler() and sendChannelMessage()", channelModulA.view.test1handled);
	}
	
	[Test]
	
	public function channeling_moduleToModuleChannelingRemoveHandler_sendMessageDoesNothing():void {
		//
		channelModulA.cheateTestMediator();
		channelModulB.cheateTestMediator();
		//
		Assert.assertFalse("test1 handler must be false", channelModulA.view.test1handled);
		Assert.assertFalse("test2 handler must be false", channelModulA.view.test2handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test3handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test4handled);
		//
		channelModulA.addChannelHandler_test1();
		
		channelModulA.removeChannelHandler_test1();
		
		channelModulB.sendChannelMessage_test1();
		//
		Assert.assertFalse("test1 handler must be false after addChannelHandler(), removeChannelHandler and sendChannelMessage()", channelModulA.view.test1handled);
	}
	
	[Test]
	
	public function channeling_moduleToModuleChanneling_addChannel2Handler_sendsMessage():void {
		//
		channelModulA.cheateTestMediator();
		channelModulB.cheateTestMediator();
		//
		Assert.assertFalse("test1 handler must be false", channelModulA.view.test1handled);
		Assert.assertFalse("test2 handler must be false", channelModulA.view.test2handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test3handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test4handled);
		//
		channelModulA.addChannelHandler_test1();
		channelModulA.addChannelHandler_test2();
		
		channelModulB.sendChannelMessage_test2();
		//
		Assert.assertTrue("test1 handler must be true after addChannelHandler() and sendChannelMessage()", channelModulA.view.test2handled);
		Assert.assertFalse(channelModulA.view.test1handled);
	}
	
	[Test]
	
	public function channeling_moduleToModuleChanneling_add2ChannelHandler_sendsMessage():void {
		//
		channelModulA.cheateTestMediator();
		channelModulB.cheateTestMediator();
		//
		Assert.assertFalse("test1 handler must be false", channelModulA.view.test1handled);
		Assert.assertFalse("test2 handler must be false", channelModulA.view.test2handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test3handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test4handled);
		//
		channelModulA.addChannelHandler_test1();
		channelModulA.addChannelHandler_test2();
		channelModulA.addChannelHandler_testChannel_test3();
		
		channelModulB.sendChannelMessage_testChannel_test3();
		//
		Assert.assertTrue("test3 handler must be true after addChannelHandler() and sendChannelMessage()", channelModulA.view.test3handled);
		Assert.assertFalse(channelModulA.view.test1handled);
		Assert.assertFalse(channelModulA.view.test2handled);
	}
	
	[Test]
	
	public function channeling_moduleToModuleChanneling_addChannelHandler_sendsMessageWithParams():void {
		//
		channelModulA.cheateTestMediator();
		channelModulB.cheateTestMediator();
		//
		Assert.assertFalse("test1 handler must be false", channelModulA.view.test1handled);
		Assert.assertFalse("test2 handler must be false", channelModulA.view.test2handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test3handled);
		Assert.assertFalse("test3 handler must be false", channelModulA.view.test4handled);
		//
		channelModulA.addChannelHandler_test1();
		channelModulA.addChannelHandler_test2();
		channelModulA.addChannelHandler_testChannel_test3();
		channelModulA.addChannelHandler_testChannel_test4_withParams();
		
		channelModulB.sendChannelMessage_testChannel_test4_withParams();
		//
		
		"test4 params string"
		Assert.assertEquals("params must be sent properly", channelModulA.view.test4params, "test4 params string");
		Assert.assertTrue("test4 handler must be true after addChannelHandler() and sendChannelMessage()", channelModulA.view.test4handled);
		Assert.assertFalse(channelModulA.view.test1handled);
		Assert.assertFalse(channelModulA.view.test2handled);
		Assert.assertFalse(channelModulA.view.test3handled);
	}
	
		[Test]
	
	public function channeling_messegeToCommandChanneling_addChannelCommand_commandsHandlesMessage():void {
		//
		channelModulA.mapCommand_ComTest1();
		//
		Assert.assertFalse("Cammand test1 executed flag mast be false", channelModulA.command1executed);
		//
		channelModulA.sendChannelMessage_comTest1();
		//
		Assert.assertTrue("Command test1 must be true after commandMap.channelMap() and  sendChannelMessage()", channelModulA.command1executed);

	}
	

}
}