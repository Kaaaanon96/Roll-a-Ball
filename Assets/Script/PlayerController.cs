using UnityEngine;
using System.Collections;

//ボールの移動用のスクリプト

public class PlayerController : MonoBehaviour 
{
	// speedを制御する
	public float speed = 25;

	void FixedUpdate() {
		// 入力をxとzに格納する
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");

		// 同一のgameObjectが持つrigidbodyコンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidBodyの横(x)と奥(z)に力を加える
        rigidbody.AddForce (x * speed, 0, z * speed);
	}
}
