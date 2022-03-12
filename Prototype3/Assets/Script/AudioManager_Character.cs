using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_Character : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource line1;
    // public AudioSource line2;
    private AudioSource ourAudioSource;
    [SerializeField]
    private AudioClip line1;
    [SerializeField]
    private AudioClip line2;
    void Start()
    {
        //  line1.gameObject.GetComponent<AudioSource>();
        // line2.gameObject.GetComponent<AudioSource>();
        ourAudioSource = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
