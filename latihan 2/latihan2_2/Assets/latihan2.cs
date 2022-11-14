using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan2 : MonoBehaviour
{
    [TextArea] public string pesan;
    public bool starter;
    [Range(0, 3)] public float bahanBakar;
    public int ccMesin;

    // Update is called once per frame

    void Update()
    {

/*        Nama    : Niansyah Eko Putra
        Nim     : 8020200101
        Kelas   : 01pt5 Pemrograman Game */

        bahanBakar = Mathf.Clamp(bahanBakar, 0, 3);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            starter = !starter;

        }
        
        if (starter && bahanBakar != 0)
        {
            bahanBakar -= Time.deltaTime;
            pesan = "Mobil berjalan dengan cc sebesar " + ccMesin;
        } else if (starter && bahanBakar <= 0)
        {
            pesan = "Mesin tidak dapat berjalan karena bahan bakar habis";
            starter = !starter;
        }



    }
}
