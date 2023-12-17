using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : PlayerInput
{
    public GameObject cannon_ball;
    public Transform ShootingStart;
    public float force;
    public float ti = 0;
    new


        // Update is called once per frame
        void Update()
    {
        if (ti > 0) { ti -= Time.deltaTime; }
        else
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(cannon_ball, ShootingStart.position, ShootingStart.rotation);
            bullet.GetComponent<Rigidbody>().velocity = force * Time.deltaTime * ShootingStart.forward;
        }
    }



}
