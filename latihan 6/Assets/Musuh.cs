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

    // Start is called before the first frame update
    void Start()
    {
        nowScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
                     Vector3.MoveTowards(
                        transform.position,
                        new Vector3(target.position.x, transform.position.y, transform.position.z) + offset,
                        speed * Time.deltaTime);



        if (target.position.x > transform.position.x) {
            transform.localScale = new Vector2(nowScale.x, nowScale.y);
        } else if (target.position.x < transform.position.x) {
            transform.localScale = new Vector2(-nowScale.x, nowScale.y);
        }

    }
}
