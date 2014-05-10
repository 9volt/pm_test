using UnityEngine;
using System.Collections;

public class hit_test : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Debug.Log("hit");
			anim.SetTrigger("hit");
		}
		if(Input.GetButtonDown("Fire2")){
			anim.SetBool("alive", !anim.GetBool("alive"));
		}
		if(Input.GetButtonDown("Fire3")){
			anim.SetTrigger("swing");
		}
	}
}
