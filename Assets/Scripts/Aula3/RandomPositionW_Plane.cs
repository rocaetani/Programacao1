using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class RandomPositionW_Plane : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform plane;
    private Mesh mesh;
    private Vector3 meshMin;
    private Vector3 meshMax;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        mesh = plane.GetComponent<MeshFilter>().mesh;
        meshMin = mesh.bounds.min;
        meshMax = mesh.bounds.max;
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (Vector3.Distance(transform.position, target.position) < 0.00001f)
        {
            Vector3 newPosition = target.position;
            newPosition.x = Random.Range(meshMin.x, meshMax.x);
            newPosition.z = Random.Range(meshMin.z, meshMax.z);
            target.position = newPosition;
        }

    }
}