using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {
    private Quaternion startingRotation;
    public float speed;

    void Start()
    {
        //save the starting rotation
        startingRotation = this.transform.rotation;
    }

    void Update()
    {
        //return back to the starting rotation
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(0));
        }

        //go to 90 degrees with right arrow
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(90));
        }

        //go to -90 degrees with left arrow
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(-90));
        }

    }

    IEnumerator Rotate(float rotationAmount)
    {
        Quaternion finalRotation = Quaternion.Euler(0, rotationAmount, 0) * startingRotation;

        while (this.transform.rotation != finalRotation)
        {
            this.transform.rotation = Quaternion.Lerp(finalRotation, this.transform.rotation, Time.deltaTime * speed);
            yield return 0;
        }
    }
}