using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hlaser : MonoBehaviour
{
    public float speed = 100;
    public float damage = 20;

    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("KillMe", 5);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        
    }

}
