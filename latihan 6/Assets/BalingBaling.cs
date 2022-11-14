using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalingBaling : MonoBehaviour
{
    public float kecepatan = 50;
    public bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
