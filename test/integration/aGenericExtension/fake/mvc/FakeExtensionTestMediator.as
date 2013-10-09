package integration.aGenericExtension.fake.mvc {
import flash.display.Sprite;

import integration.aGenericExtension.fake.module.FakeExtensionModule;

import integration.aGenericExtension.fake.module.FakeExtensionModule;

import mvcexpress.core.namespace.pureLegsCore;

import mvcexpress.mvc.Mediator;

use namespace pureLegsCore;

/**
 * TODO:CLASS COMMENT
 * @author rbanevicius
 */
public class FakeExtensionTestMediator extends Mediator {

	[Inject]
	public var view:Sprite;

	override protected function onRegister():void {

	}

	override protected function onRemove():void {

	}


	//----------------------------------
	//    Extension checking: INTERNAL, DEBUG ONLY.
	//----------------------------------

	CONFIG::debug
	static pureLegsCore var extension_id:int = FakeExtensionModule.pureLegsCore::EXTENSION_TEST_ID;

	CONFIG::debug
	static pureLegsCore var extension_name:String = FakeExtensionModule.pureLegsCore::EXTENSION_TEST_NAME

}
}