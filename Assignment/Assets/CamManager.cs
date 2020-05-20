using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public Camera introcam;
    public Camera HQCamera;

    // Start is called before the first frame update


    IEnumerator Switch()
    { 
            yield return new WaitForSeconds(25);
            introcam.enabled = false;
            HQCamera.enabled = true;       

    }


        // Start is called before the first frame update
        void Start()
    {
        introcam.enabled = true;
        HQCamera.enabled = false;
        StartCoroutine(Switch());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
