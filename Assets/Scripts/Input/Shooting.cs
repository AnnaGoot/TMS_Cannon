using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : PlayerInput
{
    public GameObject cannon_ball;
    public Transform ShootingStart;
    public float force;

    new

        // Update is called once per frame
        void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(cannon_ball, ShootingStart.position, ShootingStart.rotation);
            bullet.GetComponent<Rigidbody>().velocity = force * Time.deltaTime * ShootingStart.forward;
        }
    }



}
