using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour
{

    public float gameTimer;

    public Text timerText;

    public bool timerRun = true;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string seconds = Mathf.Floor(gameTimer % 60).ToString("00");

        if (timerRun == true)
        {
            gameTimer -= Time.deltaTime;

            timerText.text = seconds;

            if (gameTimer <= 0)
            {
                timerRun = false;

                gameTimer = 0;

            }
        }

    }
}
