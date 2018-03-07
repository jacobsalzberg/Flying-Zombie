using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour {

    [SerializeField] private float objectSpeed = 1;
    [SerializeField] private float resetPosition = -14.58f;
    [SerializeField] private float startPosition = 49.84f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {

        if (!GameManager.instance.GameOver) //if the game is NOT over, move the objects
            transform.Translate(Vector3.back * (objectSpeed * Time.deltaTime));
        {
            if (transform.localPosition.z <= resetPosition)
            {
                Vector3 newPos = new Vector3(transform.position.x, transform.position.y, startPosition);
                transform.position = newPos;
            }
        }
        

        

	}
}
