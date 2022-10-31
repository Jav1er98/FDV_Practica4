using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSlerp : MonoBehaviour
{
    public Transform goal;
    public float speed;
    public float accuracy = 0.01f;
    public float AcceptanceRadius = 1.0f;
    public float SlerpFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(goal);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goalPositionAtSelfHeight = new Vector3(goal.position.x, transform.position.y, goal.position.z);
        if (Vector3.Distance(transform.position, goalPositionAtSelfHeight) > AcceptanceRadius)
        {
            Quaternion DesiredRotation = Quaternion.LookRotation(goalPositionAtSelfHeight - transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, DesiredRotation, SlerpFactor);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
