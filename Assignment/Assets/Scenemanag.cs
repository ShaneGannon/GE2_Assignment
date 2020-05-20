using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanag : MonoBehaviour
{
    bool change;
    public int SceneTime;
    public string NextScene;
    IEnumerator Swap()
    {
        yield return new WaitForSeconds(SceneTime);
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
        if(change == true)
        {
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
            //SceneManager.SetActiveScene(ReactionScene);
        }
    }
}
