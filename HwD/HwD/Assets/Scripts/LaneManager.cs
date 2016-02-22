using UnityEngine;
using System.Collections;

namespace Managers
{
    public class LaneManager : MonoBehaviour
    {
        public static bool left = false;
        public static bool mid = false;
        public static bool right = false;

        public static GameObject go_Left;
        public static GameObject go_Mid;
        public static GameObject go_Right;

        public int score;
        
        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (left)
                {
                    Managers.ScoreManager.score++;
                    Destroy(go_Left);
                }
                else Managers.ScoreManager.score--;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (mid)
                {
                    Managers.ScoreManager.score++;
                    Destroy(go_Mid);
                }
                else Managers.ScoreManager.score--;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (right)
                {
                    Managers.ScoreManager.score++;
                    Destroy(go_Right);
                }
                else Managers.ScoreManager.score--;
            }
        }
    }
}