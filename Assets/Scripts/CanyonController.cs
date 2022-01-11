using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonController : MonoBehaviour
{
    public Transform DisparoPosicionInicial;
    public GameObject Bala;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparo();
        }
    }

    void Disparo()
    {
        Instantiate(Bala, DisparoPosicionInicial.position, DisparoPosicionInicial.rotation);
    }
}
