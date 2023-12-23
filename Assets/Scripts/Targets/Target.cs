using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour
{
    public int Bounty = 10;


    private int currentHP = 100;

    public void GetDamage(int damage)
    {
        transform.DOScale(1.5f, 0.2f).SetLoops(2, LoopType.Yoyo);
        
        Debug.Log(damage +"was taken");

        currentHP -= damage;

        if (currentHP <= 0)
            gameObject.SetActive(false);
    }

    private void Death()
    {
        //add some logic too get xp

        gameObject.SetActive(false);

    }


}
