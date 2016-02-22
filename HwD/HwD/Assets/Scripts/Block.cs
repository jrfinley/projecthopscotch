using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    public float speed;
    public Vector3 killPoint;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.back * speed);

        if (transform.position.z <= killPoint.z)
        {
            Destroy(gameObject);
        }
    }
}
