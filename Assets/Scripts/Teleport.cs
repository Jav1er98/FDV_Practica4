using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Teleport goal;
    private bool isteleport = false;

    void OnTriggerEnter(Collider other)
    {
        if (isteleport)
        {
            return;
        }

        goal.isteleport = true;
        other.gameObject.transform.position = new Vector3(goal.transform.position.x, other.gameObject.transform.position.y, goal.transform.position.z);
    }

    void OnTriggerExit(Collider other)
    {
        isteleport = false;
    }
}
