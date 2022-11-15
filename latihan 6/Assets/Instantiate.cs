using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject objek;
    public float waktu;
    public float batasWaktu = 3f;


    void Start()
    {

    }

    void Update()
    {
        waktu -= (Time.deltaTime * 1);
        
        if (waktu <= 0)
        {
            for (int i = 0; i<10; i++)
            {
                Instantiate(objek, transform.position, Quaternion.identity);
            }

            waktu = batasWaktu;
            
        }
    }

}
