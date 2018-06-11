using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    public float rotation;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}

   /* private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(player.transform.position, Vector3.up, -rotation * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(player.transform.position, Vector3.up, rotation * Time.deltaTime);
        }
    }*/

    // Update is called once per frame
    void LateUpdate () {
        transform.position = player.transform.position + offset;

    }
}
