using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameManager gameManager;
    public int value = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 300 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            gameManager.spheres += value;
            Destroy(gameObject);
        }
           
    }
}
