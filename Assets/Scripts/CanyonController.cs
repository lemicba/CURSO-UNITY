using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonController : MonoBehaviour
{
    public Transform DisparoPosicionInicial;
    public GameObject Bala;
    public float timeToShoot = 1f;
    private float timeToShootLeft;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        //InvokeRepeating("Disparo", fireDelay, spawnInterval);
    }
    void Update()
    {
        Temporalizador();
    }

    void Disparo()
    {
        Instantiate(Bala, DisparoPosicionInicial.position, DisparoPosicionInicial.rotation);
    }
    private void ResetTimer()
    {
        timeToShootLeft = timeToShoot;
    }
    private void Temporalizador()
    {
        timeToShootLeft -= Time.deltaTime;
        if (timeToShootLeft <= 0)
        {
            Disparo();
            ResetTimer();
        }
    }
}
