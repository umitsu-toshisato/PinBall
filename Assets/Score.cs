using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //�_��
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("�Փ�: " + other.gameObject.tag);

        //���������H
        if(other.gameObject.tag == "SmallStarTag")
        {

        }
    }
}
