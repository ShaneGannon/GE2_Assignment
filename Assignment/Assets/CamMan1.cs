using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMan1 : MonoBehaviour
{
    public Camera Wideshot;
    public Camera RedL;
    public Camera YellowL;
    public Camera GreenL;
    public Camera RedF;
    public Camera YellowF;
    public Camera GreenF;

    // Start is called before the first frame update


    IEnumerator Switch()
    {
        yield return new WaitForSeconds(15);
        Wideshot.enabled = false;
        RedL.enabled = true;

        yield return new WaitForSeconds(10);
        RedL.enabled = false;
        YellowL.enabled = true;

        yield return new WaitForSeconds(10);
        YellowL.enabled = false;
        GreenL.enabled = true;

        yield return new WaitForSeconds(20);
        GreenL.enabled = false;
        RedF.enabled = true;

        yield return new WaitForSeconds(20);
        RedF.enabled = false;
        YellowF.enabled = true;

        yield return new WaitForSeconds(20);
        YellowF.enabled = false;
        GreenF.enabled = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        Wideshot.enabled = true;
        RedL.enabled = false;
        RedF.enabled = false;
        YellowL.enabled = false;
        YellowF.enabled = false;
        GreenL.enabled = false;
        GreenF.enabled = false;
        StartCoroutine(Switch());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
