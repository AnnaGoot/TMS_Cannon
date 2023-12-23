using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void SetScore(string text)
    {
        scoreText.text = text;

    }



}
