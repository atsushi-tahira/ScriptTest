using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

	public int hp = 50;
	public int defend = 14;
	public int Damage(int def,int dam){

		int Dam = dam - def;
		if (Dam > 0) {
			return Dam;
		} else {
			return 0;
		}

	}

	// Use this for initialization
	void Start () {
		int damaged = Damage (defend, 15);
		this.hp -= damaged;
		Debug.Log (string.Format ("{0}のダメージを受けた。残りの体力は{1}", damaged, hp));
		Debug.Log ("defend = " + defend);
		Debug.Log("damaged = " + damaged);
		Debug.Log ("hp = " + this.hp);

		
	}



	// Update is called once per frame
	void Update () {

		
	}
}
