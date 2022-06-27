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

    public int minScore;

    public BallController ball;

    // public void AddRightScore(int increment)
    // {
    //     rightScore =rightScore - increment;
    //     ball.ResetBall();
    //     if (rightScore >= minScore)
    //     {
    //         GameOver();
    //     }

    // }

    // public void AddLeftScore(int increment)
    // {
    //     leftScore = leftScore - increment;
    //     ball.ResetBall();
    //     if (leftScore >= minScore)
    //     {
    //         GameOver();
    //     }
    // }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
