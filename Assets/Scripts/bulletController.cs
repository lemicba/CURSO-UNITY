using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed = 35f;
    public Vector3 direction = Vector3.forward;
    public int damage = 1;
    void Start()
    {
        
    }
    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
