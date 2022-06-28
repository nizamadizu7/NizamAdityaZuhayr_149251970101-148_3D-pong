using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public int player1;
    public int player2;
    public int player3;
    public int player4;

    public int maxScore;

    public BallController ball;

    public void Add1Score()
    {
        player1+=1;
        ball.ResetBall();
        if (player1 >=maxScore)
        {
            GameOver();
        }

    }
    public void Add2Score()
    {
        player2+=1;
        ball.ResetBall();
        if (player2 >=maxScore)
        {
            GameOver();
        }
    }
    public void Add3Score()
    {
        player3+=1;
        ball.ResetBall();
        if (player3 >=maxScore)
        {
            GameOver();
        }
    }
    public void Add4Score()
    {
        player4+=1;
        ball.ResetBall();
        if (player4 >=maxScore)
        {
            GameOver();
        }
    }


    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
