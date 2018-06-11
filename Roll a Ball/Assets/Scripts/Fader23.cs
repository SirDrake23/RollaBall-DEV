using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader23 : MonoBehaviour {


	// Use this for initialization
	void Start () {
        StartCoroutine(StartFade());
    }

    // Update is called once per frame
    IEnumerator StartFade () {
        yield return new WaitForSeconds(5);
        Initiate.Fade("MainMenu", Color.black, 0.1f);
    }
}
