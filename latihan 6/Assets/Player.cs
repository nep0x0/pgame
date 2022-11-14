using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float kecepatan = 5, kekuatanLompat = 300;
    Animator anim;
    Vector2 ambilUkuranDeafult;

    Rigidbody2D rb;

    public LayerMask layerYangKitaAnggapSebagaiTanah;
    public Transform posisiPendeteksiTanah;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ambilUkuranDeafult = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && Physics2D.OverlapCircle(posisiPendeteksiTanah.position,0,layerYangKitaAnggapSebagaiTanah))
        {
            rb.AddForce(Vector2.up * kekuatanLompat);
        }

        //a sama d // panah kiri sama panah kanan
        float gerakKiriKanan = Input.GetAxisRaw("Horizontal") * kecepatan;
        
        transform.Translate(gerakKiriKanan * Time.deltaTime, 0, 0);

        if (Physics2D.OverlapCircle(posisiPendeteksiTanah.position, 0, layerYangKitaAnggapSebagaiTanah)==false)
        {
            anim.Play("lompat");
        }
        else if (gerakKiriKanan != 0)
        {
            anim.Play("berlari");
        }
        else {
            anim.Play("diam");
        }

        if (gerakKiriKanan < 0)
        {
            transform.localScale = new Vector2(-ambilUkuranDeafult.x, ambilUkuranDeafult.y);
        }
        else if(gerakKiriKanan > 0){ 
            transform.localScale = new Vector2(ambilUkuranDeafult.x, ambilUkuranDeafult.y);
        }
    }
}
