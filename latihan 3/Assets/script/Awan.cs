using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awan : MonoBehaviour
{

	public float kecepatan;

	void Update()
	{
		if (transform.position.x >= 12)
        {
			transform.position = new Vector3(-12, Random.Range(7, -7), transform.position.z);
			kecepatan = Random.Range(-10, 1000);
        }

		transform.Translate(kecepatan * Time.deltaTime, 0, 0);
	}


}
