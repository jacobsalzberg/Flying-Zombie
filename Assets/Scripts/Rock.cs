using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Objecto {

    [SerializeField] Vector3 topPosition;
    [SerializeField] Vector3 bottomPosition;
    [Tooltip("How fast does the rock move")]
    [SerializeField] float speed;

    // Use this for initialization
    void Start () {
        StartCoroutine(Move(bottomPosition));
	}
    protected override void Update()
    {
        base.Update(); //base usa o update da classe de que rock herdou
    }

    IEnumerator Move(Vector3 target)
    {
        //target --> where we wanna go
        //transform.localPosition --> where we currently are
        // >0.20 --> further out than starting  point
        while (Mathf.Abs((target - transform.localPosition).y ) >= 0.3f)
        {
            //If it got to the maximum point, up
            //print ((target-transform.localPosition).y);
            Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;
            transform.localPosition += direction * Time.deltaTime * speed;

            yield return null;
        }

        print("Reached the target");

        yield return new WaitForSeconds(0.5f);

        //check if its at the top or the bottom.. if it's at top, target = bottom, else target=top
        Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;

        //Call itself over again!!
        StartCoroutine(Move(newTarget)); 
    }
}                                    
