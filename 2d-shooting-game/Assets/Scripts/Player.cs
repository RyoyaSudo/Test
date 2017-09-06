using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float spped = 5;

    public GameObject bullet;

    // Use this for initialization
    IEnumerator Start ()
    {
		while(true)
        {
            //弾をプレイヤーと同じ位置角度で作成
            Instantiate(bullet, transform.position, transform.rotation);

            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //左右
        float x = Input.GetAxisRaw("Horizontal");
        
        //上下
        float y = Input.GetAxisRaw("Vertical");

        //移動する向き
        Vector2 direction = new Vector2(x, y).normalized;

        GetComponent<Rigidbody2D>().velocity = direction * spped;
	}
}
