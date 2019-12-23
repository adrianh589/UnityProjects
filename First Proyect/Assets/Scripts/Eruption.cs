using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {

    public GameObject cube;
    public GameObject capsule;
    public float fireRate = 0.5f;

	// Use this for initialization
	void Start () {
        StartCoroutine(ThrowSrone());
        StartCoroutine(ThrowCapsule());
    }
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator ThrowSrone()
    {
        while (true)
        {
            Instantiate(cube, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }

    IEnumerator ThrowCapsule()
    {
        while (true)
        {
            Instantiate(capsule, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
