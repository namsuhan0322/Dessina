using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotation_speed = 60;

    void Start()
    {
        
    }

    void Update()
    {
        // Rotate(�����Ӹ��� ������ ����ŭ ȸ���Ѵ�)
        transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
    }
}
