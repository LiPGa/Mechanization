using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpet : PickableProp {

	public override void OnItemAction(ItemGrid grid,EventArgs e){

		if(ItemPack.GetPack().isOn("铅笔")){
			HUD hud = HUD.GetHUD();
			hud.BrotherSpeak("难过","By accident, I destroy the crucial clues!");
			hud.Lose();
		}
	}

}
