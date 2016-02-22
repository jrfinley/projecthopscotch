using UnityEngine;
using System.Collections;

public class Lane : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerStay(Collider other)
    {
        if(gameObject.name == "Lane_Left")
        {
            Managers.LaneManager.left = true;
            Managers.LaneManager.go_Left = other.gameObject;
        }
        if (gameObject.name == "Lane_Mid")
        {
            Managers.LaneManager.mid = true;
            Managers.LaneManager.go_Mid = other.gameObject;
        }
        if (gameObject.name == "Lane_Right")
        {
            Managers.LaneManager.right = true;
            Managers.LaneManager.go_Right = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "Lane_Left")
        {
            Managers.LaneManager.left = false;
            Managers.ScoreManager.score--;
        }
        if (gameObject.name == "Lane_Mid")
        {
            Managers.LaneManager.mid = false;
            Managers.ScoreManager.score--;
        }
        if (gameObject.name == "Lane_Right")
        {
            Managers.LaneManager.right = false;
            Managers.ScoreManager.score--;
        }
    }
}
