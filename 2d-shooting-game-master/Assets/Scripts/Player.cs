using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 5; //移動速度
    public GameObject bullet;//PlayerBulletプレハブ

	// Use this for initialization
	IEnumerator Start () {
		while(true)
        {
            //弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);

            //0.05秒待機
            yield return new WaitForSeconds(0.05f);
        }
	}
	
	// Update is called once per frame
	void Update () {

        //左右移動
        float x = Input.GetAxisRaw("Horizontal");

        //上下移動
        float y = Input.GetAxisRaw("Vertical");

        //移動方向を求める
        Vector2 direction = new Vector2(x, y).normalized;

        //移動する向きとスピードの代入
        GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}
