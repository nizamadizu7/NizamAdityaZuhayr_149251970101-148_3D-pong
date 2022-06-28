using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    [SerializeField]private Pad PlayerPad;
    MeshRenderer Wall;
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            if(gameObject.name.Contains("Bawah")){
                manager.Add1Score();
            }else if(gameObject.name.Contains("Kanan")){
                manager.Add2Score();
            }else if(gameObject.name.Contains("Atas")){
                manager.Add3Score();
            }else if(gameObject.name.Contains("Kiri")){
                manager.Add4Score();
            }
        }
    }
    void Start()
    {
        Wall = GetComponent<MeshRenderer>();
        Wall.enabled = false;
    }
}
