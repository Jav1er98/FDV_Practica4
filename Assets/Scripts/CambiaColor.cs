using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{
    public Notificador notificador;
    private MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        notificador.OnMiEvento += miRespuesta;
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void miRespuesta()
    {
        Debug.Log(notificador.contador);
        _meshRenderer.materials[0].color = Random.ColorHSV();
    }
}

