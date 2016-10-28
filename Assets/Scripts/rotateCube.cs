using UnityEngine;
using System.Collections;

public class rotateCube : MonoBehaviour {
    public float x = 1;
    public float y = 1;
    public float z = 1;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(x, y, z);
    }
}
