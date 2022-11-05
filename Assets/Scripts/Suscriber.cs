using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscriber : MonoBehaviour
{
    public Notifier notifier;
    public int force = 500;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnRecolect += addForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addForce()
    {
        GetComponent<Rigidbody>().AddForce(0, force, force);
    }
}
