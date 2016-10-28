using UnityEngine;
using System.Collections;

public class missileController : MonoBehaviour {
    //0 speed = no move
    public float speed;
    float destroyIn = 300;

    public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;

        destroyIn = destroyIn - 1;

        if (destroyIn < 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
