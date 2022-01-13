using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 direction = Vector3.forward;
    public int damage = 1;
    public float timeToDestroy = 3f;
    private Vector3 nuevaEscala = new Vector3(1f, 1f, 1f);
    void Start()
    {
        
    }
    void Update()
    {
        MoveBullet();
        BulletDestroy();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScaleTransform();
        }
    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
    void ScaleTransform()
    {
        this.gameObject.transform.localScale += nuevaEscala;
    }
    void BulletDestroy()
    {
        timeToDestroy -= Time.deltaTime;
        if (timeToDestroy <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
