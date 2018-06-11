using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioContinues : MonoBehaviour {


    private void Start()
    {
        GameObject.FindGameObjectWithTag("MusicObject").GetComponent<MusicClass>().PlayMusic();
    }
}
