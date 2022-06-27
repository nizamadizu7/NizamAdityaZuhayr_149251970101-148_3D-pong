using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour
{
    private int speed=3;
    public KeyCode upKey;
    public KeyCode downKey;
    
    public GameObject go;
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
        if(go.transform.position.z < 2.7 && go.transform.position.z > -3){
            if(Input.GetKey(upKey))
            {
                return Vector3.forward * speed;
            }
            else if(Input.GetKey(downKey))
            {
                return Vector3.back * speed;
            }else return Vector3.zero;            
        }else return Vector3.zero;
    }

    private void MoveObject(Vector3 movement) {
        rb.velocity=movement;   
    }
}
