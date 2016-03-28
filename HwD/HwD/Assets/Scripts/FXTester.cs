using UnityEngine;
using System.Collections;

public class FXTester : MonoBehaviour
{
    public GameObject particleExplosion = null;


    // Use this for initialization
    void Start ()
    {
	
	}
    void Explosion()
    {
        //create and destroy a particle 
        GameObject explosion = GameObject.Instantiate(particleExplosion, gameObject.transform.position + new Vector3(0.0f, 0.0f, 12.0f), Quaternion.identity) as GameObject;
        DestroyObject(explosion, 5.0f);
    }
    // Update is called once per frame
    void Update ()
    {
	
	}
}
