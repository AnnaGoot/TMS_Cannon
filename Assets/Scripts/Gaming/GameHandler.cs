using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public static GameHandler GameInstance;
    
    public PlayerInput InputModule;
    public Rotatebase RotationModule;
    public ShootBase shootModule;

    public UI uiModule;

    void Awake()
    {
        GameInstance = this;  
    }

    public void Update()
    {
        RotationModule.Rotate(InputModule.InputRotation);
        MouseInput();
    }


    private void MouseInput()
    {

        if (Input.GetMouseButtonDown(0))
        {
            shootModule.Shoot();
        }
    }
}
