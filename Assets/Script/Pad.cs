using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    private int speed=5;
    [SerializeField] Vector3 BoundaryMax, BoundaryMin;

    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(gameObject.name.Contains("Player1")){
            movement1();
        }else if(gameObject.name.Contains("Player2")){
            movement2();
        }else if(gameObject.name.Contains("Player3")){
            movement3();
        }else if(gameObject.name.Contains("Player4")){
            movement4();
        }
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, BoundaryMin.x, BoundaryMax.x),
            Mathf.Clamp(transform.position.y, BoundaryMin.y, BoundaryMax.y),
            Mathf.Clamp(transform.position.z, BoundaryMin.z, BoundaryMax.z)
        );
    }
    void movement1(){
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }

    void movement2(){
         if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }

    void movement3(){
        if(Input.GetKey(KeyCode.A)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        
    }
    void movement4(){
        if(Input.GetKey(KeyCode.W)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }

    private void MoveObject(Vector3 movement) {
        rb.velocity=movement;
    }

    
}
