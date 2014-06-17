using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy {
	public int health;
	public string name;

	public Enemy(int h, string n){
		health = h;
		name = n;
	}
}

public class Ally {
	public int health;
	public string name;

	public Ally(int h, string n){
		health = h;
		name = n;
	}
}

public class BattleState : MonoBehaviour {
	public List<Enemy> enemies;
	public List<Ally> allies;

	// Use this for initialization
	void Start () {
		enemies = new List<Enemy>();
		allies = new List<Ally>();

		enemies.Add(new Enemy(5, "Bad Guy"));
		allies.Add(new Ally(5, "Good Guy"));
		allies.Add(new Ally(5, "Good Guy2"));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
