using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour {

    [SerializeField] float objectSpeed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * (objectSpeed * Time.deltaTime));
	}
}
