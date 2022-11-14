using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalingBaling : MonoBehaviour
{
    public float kecepatan = 500000000;
    public bool on = true;

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            on = !on;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            kecepatan *= -1;
        }

        if (on)
        {
            transform.Rotate(0, 0, kecepatan * Time.deltaTime);
        }

    }

}
