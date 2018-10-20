using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
    private GameObject unitychan;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Debug.Log(this.unitychan.transform.position.z);
        if (this.unitychan.transform.position.z - 5 >= this.transform.position.z)
        {
            //
            Destroy(gameObject);
            Debug.Log("削除成功");
            //Debug.Log(this.unitychan.transform.position.z);
        }


    }
}
