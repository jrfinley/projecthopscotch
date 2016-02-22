using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public int roundTime;
        public static string gameState;
        private System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        private float minutes;
        private float seconds;
        private Text timeText;

        void Awake()
        {
            gameState = "Start";
            timeText = GameObject.Find("Time").GetComponent<Text>();
        }

        void Update()
        {
            switch (gameState)
            {
                case "Start":
                    print(gameState);
                    if (Input.GetMouseButtonDown(0))
                    {
                        gameState = "Play";
                    }
                    break;
                case "Play":
                    print(gameState);
                    timer.Start();
                    float elapsedTime = 0.001f * timer.ElapsedMilliseconds;
                    minutes = Mathf.Floor(elapsedTime / 60);
                    seconds = (elapsedTime % 60);
                    timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
                    if (minutes >= roundTime)
                    {
                        gameState = "GameOver";
                    }
                    break;
                case "GameOver":
                    print(gameState);
                    timer.Stop();
                    print(minutes.ToString("00") + ":" + seconds.ToString("00"));
                    if (Input.GetMouseButtonDown(0))
                    {
                        gameState = "Reset";
                    }
                    break;
                case "Reset":
                    print(gameState);
                    Managers.ScoreManager.score = 0;
                    timer.Reset();
                    timeText.text = ("00:00");
                    gameState = "Start";
                    break;
            }            
        }
    }
}