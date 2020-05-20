using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanag3 : MonoBehaviour
{
    bool change;
    public Scene ReactionScene;
    IEnumerator Swap()
    {
        yield return new WaitForSeconds(10);
        //SceneManager.LoadScene("ReactionScene");
        change = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        change = false;
        StartCoroutine(Swap());

    }

    // Update is called once per frame
    void Update()
    {
        if (change == true)
        {
            SceneManager.LoadScene("ReactionScene", LoadSceneMode.Single);
            //SceneManager.SetActiveScene(ReactionScene);
        }
    }
}
