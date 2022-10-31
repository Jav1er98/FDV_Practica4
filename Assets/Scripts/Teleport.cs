using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Teleport Goal;
    private bool IsTeleporting = false;

    void OnTriggerEnter(Collider other)
    {
        if (IsTeleporting)
        {
            return;
        }

        Goal.IsTeleporting = true;
        other.gameObject.transform.position = new Vector3(Goal.transform.position.x, other.gameObject.transform.position.y, Goal.transform.position.z);
    }

    void OnTriggerExit(Collider other)
    {
        IsTeleporting = false;
    }
}
