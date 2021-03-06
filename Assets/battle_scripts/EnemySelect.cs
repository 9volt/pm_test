﻿using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions {
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Select your party member.")]
	public class EnemySelect : GUIContentAction {
		public FsmEvent sendEvent;
		private BattleState bs;

		public override void OnEnter(){
			bs = GameObject.FindGameObjectWithTag("battlestate").GetComponent<BattleState>();
		}

		// Update is called once per frame
		public override void Reset () {
			bs = GameObject.FindGameObjectWithTag("battlestate").GetComponent<BattleState>();
		}

		public override void OnGUI(){
			base.OnGUI();

			float top = .75f * Screen.height;
			float left = .25f * Screen.width;
			float width = .2f * Screen.width;
			float height = .1f * Screen.height;
			foreach(Enemy e in bs.enemies){
				if(GUI.Button(new Rect(left, top, width, height), e.name)){
					Fsm.Event(sendEvent);
				}
				top = top + height;
			}
		}
	}
}