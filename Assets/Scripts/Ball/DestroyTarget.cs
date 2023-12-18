using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name == "Target")
        {
            Destroy(target.gameObject);
        }

    }



}
