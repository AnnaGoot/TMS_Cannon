using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public PlayerInput InputModule;
    public Rotatebase RotationModule;
    public ShootBase shootModule;

    public UI uiModule;

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

    public void SetScoreOnUI(int score)
    {
        uiModule.SetScore("Score:" + score);

    }

}
