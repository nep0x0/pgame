using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awan : MonoBehaviour
{
    public float kecepatan = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12) {
            transform.position = new Vector3(12, Random.Range(-4,4), 0);
            kecepatan = Random.Range(-3,-7);
        }

        transform.Translate(kecepatan * Time.deltaTime,0,0);
    }
}
