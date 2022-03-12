using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject ThirdPersonCamera;
    public GameObject FirstPersonCamera;
    public int CamMode;


    // Code by Jimmy Vegas: https://www.youtube.com/watch?v=nR5P7AH4aHE
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera")) {
            if (CamMode == 1){
                CamMode = 0;
            }
            else {
                CamMode += 1;
            }
            StartCoroutine(CamChange());
        }
    

     IEnumerator CamChange() {
        yield return new WaitForSeconds(0.0f);
        if (CamMode == 0) {
            ThirdPersonCamera.SetActive(true);
            FirstPersonCamera.SetActive(false);
        }
        if (CamMode == 1)
        {
            FirstPersonCamera.SetActive(true);
         //  ThirdPersonCamera.SetActive(false);
        }
    }
    

    }
}
