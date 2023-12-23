using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private ShootBase shootbase;

    public Vector2 InputRotation = new Vector2();

    public void Update()
    {
        InputRotation = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime);
    }

}
