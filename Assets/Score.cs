using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //点数
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("衝突: " + other.gameObject.tag);

        //小さい星？
        if(other.gameObject.tag == "SmallStarTag")
        {

        }
    }
}
