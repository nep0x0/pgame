using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
 
    [TextArea] public string pesan;
    public bool starter;
    [Range(0,10)]public float bahanBakar;
    public int ccMesin ;
    // Update is called once per frame      
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            starter = !starter;
            
        }
        if (starter)
        {
            bahanBakar -= Time.deltaTime;
            pesan = "Mesin Menyala Dengan CC" + ccMesin;

        }
        bahanBakar = Mathf.Clamp(bahanBakar, 0, 10);
        if (bahanBakar == 0)
        {
            pesan = "Mesin tidak dapat menyala karena tidak ada bahan bakar";
        }

    }
}

