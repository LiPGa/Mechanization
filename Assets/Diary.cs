using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : Prop {


	public override void BeforeShowDescription(){
		this._showDescription = false;
		HUD hud = HUD.GetHUD();	
		hud.BrotherSpeak("难过","In the scruffy diary, numorous pictures of the failed experiment are presented to me. Carious legs and screwy gestures make me mad.");
		hud.Lose();
	}

}
