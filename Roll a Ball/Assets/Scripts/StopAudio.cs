﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("MusicObject").GetComponent<MusicClass>().StopMusic();
    }
}
