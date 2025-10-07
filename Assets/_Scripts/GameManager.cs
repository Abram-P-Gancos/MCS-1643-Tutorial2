using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int winningScore = 10;
    public TMP_Text player1text;
    public TMP_Text player2text;
    public TMP_Text WinMessage;

    private static int Player1Score;
    private static int Player2Score;

    public static bool playing;

    // Start is called before the first frame update
    void Start()
    {
        WinMessage.transform.parent.gameObject.SetActive(false);

        Player1Score = 0;

        Player2Score = 0;

        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        player1text.text = Player1Score.ToString();
        player2text.text = Player2Score.ToString();

        if (Player1Score >= winningScore)
        {
            WinMessage.text = "PLAYER 1\nWINS";
            WinMessage.transform.parent.gameObject.SetActive(true);
        }
        else if (Player2Score >= winningScore)
        {
            WinMessage.text = "PLAYER 2\nWINS";
            WinMessage.transform.parent.gameObject.SetActive(true);
        }
    }
    public static void AddScore(int player)
    {
        if (player == 1)
        {
            Player1Score++;
            if (Player1Score == winningScore)
            {
                playing = false;
            }
        }
        else if (player == 2)
        {
            Player2Score++;
            if (Player2Score == winningScore)
            {
                playing = false;
            }
        }
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
