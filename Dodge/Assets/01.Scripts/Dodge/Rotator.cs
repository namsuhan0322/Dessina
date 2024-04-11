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
        // Rotate(프레임마다 지정한 값만큼 회전한다)
        transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
    }
}
