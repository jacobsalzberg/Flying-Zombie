using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    [SerializeField] Vector3 topPosition;
    [SerializeField] Vector3 bottomPosition;

    // Use this for initialization
    void Start () {
		
	}

    IEnumerator Move(Vector3 target)
    {
        while (Mathf.Abs((target - transform.localPosition).y ) > 0.20f)
        {

        }
    }
}
