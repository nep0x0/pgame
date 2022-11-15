using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed;

    Vector2 nowScale;
    Animator anim;

    public string tagTarget;
    public bool kenaTarget;
    


    // Start is called before the first frame update
    void Start()
    {
        nowScale = transform.localScale;
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


        if (kenaTarget == true)
        {
            anim.Play("attack");
            target.GetComponent<Player>().darah -= Time.deltaTime * 20;

        }
        else if (Vector3.Distance(target.position, transform.position) < 3)
        {
            anim.Play("walk");
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, transform.position.z) + offset, speed * Time.deltaTime);
        }
        else
        {
            anim.Play("diam");
        }


        if (target.position.x > transform.position.x)
        {
            transform.localScale = new Vector2(nowScale.x, nowScale.y);
        }
        else if (target.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(-nowScale.x, nowScale.y);
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == tagTarget)
        {
            kenaTarget = true;
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == tagTarget)
        {
            kenaTarget = false;
        }
    }


}
