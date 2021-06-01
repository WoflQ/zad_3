using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody Bullet;
    public Transform firePlace;
    private Rigidbody projectile;
    private bool fire;
    public float power;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            projectile = Instantiate(Bullet, firePlace.position, transform.rotation);
            fire = true;
        }
    }
    private void FixedUpdate()
    {
        projectile.velocity = transform.TransformDirection(Vector3.forward*-1 * power);
        fire = false;
        Destroy(projectile.gameObject, 3);

    }
}
