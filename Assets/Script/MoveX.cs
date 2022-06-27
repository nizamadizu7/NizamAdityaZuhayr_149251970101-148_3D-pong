using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    private int speed=3;
    public KeyCode rightKey;
    public KeyCode leftKey;

    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput(){
        if(Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if(Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }else return Vector3.zero;
    }

    private void MoveObject(Vector3 movement) {
        rb.velocity=movement;
    }
}
