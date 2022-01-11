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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparo();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            DisparoFinal(2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            DisparoFinal(3);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            DisparoFinal(4);
        }
    }

    void Disparo()
    {
        Instantiate(Bala, DisparoPosicionInicial.position, DisparoPosicionInicial.rotation);
    }

    void DisparoFinal(int numeroDisparos)
    {
        float tiempo = 0f;

        for (int i = 0; i < numeroDisparos; i++)
        {
            Invoke("Disparo", (tiempo));
            tiempo = tiempo + 0.1f;
        }
    }
}
