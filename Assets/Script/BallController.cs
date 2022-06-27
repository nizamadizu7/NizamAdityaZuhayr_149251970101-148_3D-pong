using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;

    public bool nama;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = speed;
        StartCoroutine(generateBall());
    }

    public void ResetBall(){
        
    }

    IEnumerator generateBall(){
        Debug.Log("test");
        Debug.Log(Random.Range(1,4));
        yield return new WaitForSeconds(3);
    }
}
