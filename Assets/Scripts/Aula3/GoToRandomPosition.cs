using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class GoToRandomPosition : MonoBehaviour
{

    public float speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (Vector3.Distance(transform.position, target.position) < 0.00001f)
        {
            Vector3 new_position = target.position;
            new_position.x = Random.Range(-4.5f, 4.5f);
            new_position.z = Random.Range(-4.5f, 4.5f);
            target.position = new_position;
        }

    }
}
