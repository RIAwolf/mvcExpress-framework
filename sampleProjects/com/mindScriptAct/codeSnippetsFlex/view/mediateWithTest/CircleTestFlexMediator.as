package com.mindScriptAct.codeSnippetsFlex.view.mediateWithTest {
import flash.display.Sprite;

import mvcexpress.mvc.Mediator;

/**
 * CLASS COMMENT
 * @author Raimundas Banevicius (http://www.mindscriptact.com/)
 */
public class CircleTestFlexMediator extends Mediator {

	[Inject]
	public var view:Sprite;

	//[Inject]
	//public var myProxy:MyProxy;

	override protected function onRegister():void {
		trace("CircleTestMediator.onRegister");

	}

	override protected function onRemove():void {

	}

}
}