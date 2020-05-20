using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hshooting : MonoBehaviour
{
    public bool shooting = false;
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float rotSpeed = 180; // In degrees per second

    public float fireRate;

    Transform player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    private void OnEnable()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (shooting)
            {

                GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab
                    , spawnPoint.position
                    , transform.rotation
                    );


            }
            yield return new WaitForSeconds(1.0f / (float)fireRate);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            shooting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            shooting = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Enemy")
        {
            Vector3 toPlayer = other.transform.position - transform.position;


            transform.rotation = Quaternion.RotateTowards(transform.rotation,
                Quaternion.LookRotation(toPlayer)
                , rotSpeed * Time.deltaTime
                );

            /*
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(toPlayer)
                , Time.deltaTime
                );                
                */
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
