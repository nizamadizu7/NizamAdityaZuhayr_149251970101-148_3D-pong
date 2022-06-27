using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoller : MonoBehaviour
{
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;

    public ScoreManager manager;

    private void Update()
    {
        
        score1.text = manager.player1.ToString();
        score2.text = manager.player2.ToString();
        score3.text = manager.player3.ToString();
        score4.text = manager.player4.ToString();
    }
}
