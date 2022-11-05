using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int spheres = 0;
    public int health = 100;

    public TextMeshProUGUI sphereText;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sphereText.text = "Spheres: " + spheres;
        healthText.text = "Health: " + health;
    }
}