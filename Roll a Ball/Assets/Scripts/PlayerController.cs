using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;

    public AudioClip fx;
    public AudioClip fx2;
    public float volume;
    public float volume2;
    AudioSource fxClip;
    AudioSource fxClip2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        fxClip = GetComponent<AudioSource>();
        fxClip2 = GetComponent<AudioSource>();
        count = 0;
        setCountText();
	winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Quit();
        }
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive (false);
            count++;
            setCountText();
            fxClip.PlayOneShot(fx, volume);
        }
    }

    void setCountText() {
        countText.text = "SCORE\n\r" + count.ToString();
	if (count >= 8){
		winText.text = "LEVEL COMPLETE";
        fxClip2.PlayOneShot(fx2, volume2);
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
#else

        Application.Quit();
#endif
    }

}
