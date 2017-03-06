using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    // トリガーとの接触が起きた時に呼ばれるコールバック
    void OnTriggerEnter (Collider hit) {

        // 接触対象はPlayerタグですか？
        if (hit.CompareTag ("Player")) {
            // 何らかの処理
            Destroy(gameObject);


        }
    }
}
