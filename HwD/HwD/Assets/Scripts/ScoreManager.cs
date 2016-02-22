using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Managers
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;
        public Text ui_Score;

        // Use this for initialization
        void Start()
        {
            ui_Score = GameObject.Find("Score").GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            ui_Score.text = score.ToString();
            
        }

        void CalculateScore(float distance)
        {

        }
    }
}
