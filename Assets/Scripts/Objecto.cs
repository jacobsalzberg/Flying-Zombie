using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour {

    [SerializeField] private float objectSpeed = 1;
    private float resetPosition = -14.58f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * (objectSpeed * Time.deltaTime));

        if (transform.localPosition.z <= resetPosition)
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y, 49.84f);
            transform.position = newPos;
        }

	}
}
