using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Rotatebase rotatebase;
    [SerializeField] private float rotationSpeed;

    public void Update()
    {
        rotatebase.Rotate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * rotationSpeed);
    }

}
