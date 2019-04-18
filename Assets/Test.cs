using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	public int hp = 50;
	public int power = 25;

	//int型の変数mpを宣言し、53で初期化
	public int mp = 53;

//	//試作した関数です
//	int Takedamage(int def,int dam){
//		return dam - def;
//	}

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
		Debug.Log (string.Format ("体力は残り{0}だ", this.hp));
	}

	//mpを消費して魔法攻撃をするMagic関数を作成
	//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示。
	public void Magic(){
		if (mp < 5) {
			Debug.Log ("MPが足りないため魔法が使えない。");
			return;
		} else {
			mp -= 5;
			Debug.Log (string.Format ("魔法攻撃をした。残りMPは{0}。", mp));
		}
	}
}

public class Test : MonoBehaviour {

	void Start () {
		Boss midboss = new Boss ();

//		midboss.Attack ();
//		midboss.Defence (3);

		//Magic関数を呼び出して、魔法を使用
		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認
		for (int i = 0; i < 11; i++) {
			midboss.Magic ();
		}
	}

	void Update () {
		
	}
}