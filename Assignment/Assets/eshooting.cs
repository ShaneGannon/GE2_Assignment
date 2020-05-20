using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eshooting : MonoBehaviour
{
    public bool shooting = false;
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float rotSpeed = 180; // In degrees per second

    public float fireRate;

    Transform player;
    List<Transform> enemies;

    GameObject target;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
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

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            FindClosestEnemy();
        }
        float distance = Vector3.Distance(gameObject.transform.position, target.transform.position);
        if (distance < 1000)
        {
            shooting = true;
        }
        else
        {
            shooting = false;
        }
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Human");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        target = closest;
        return closest;
    }
}
