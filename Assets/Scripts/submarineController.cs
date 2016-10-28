using UnityEngine;
using System.Collections;

public class submarineController : MonoBehaviour {

    private CharacterController cControl;
    public Transform submarineHolder;
    public float speed;
    public float rotationSpeed;

    public Transform fireSpot;
    public GameObject missile;

	// Use this for initialization
	void Start () {
        cControl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //remember to assign the submarine holder.
        cControl.Move(submarineHolder.forward * Time.deltaTime * speed);

        //set rotation speed in inspector.
        submarineHolder.rotation = Quaternion.Slerp(
            submarineHolder.rotation, Camera.main.transform.rotation, Time.deltaTime * rotationSpeed);

        //assign both missile and firespot!
        if (GvrViewer.Instance.Triggered)
        {
            Instantiate (missile, fireSpot.position, fireSpot.rotation);
        }
	}
}
