using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {
	//要素数が5の、int型の配列arrayを宣言して好きな値で初期化
	int[] array = {1,3,5,7,9};


	void Start () {
		
		//for文を使い、配列の各要素の値を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//for文を使い、配列の各要素の値を逆順に表示
		for (int j = array.Length - 1; 0 <= j; j--) {
			Debug.Log (array [j]);
		}

	}

	void Update () {
		
	}
}
