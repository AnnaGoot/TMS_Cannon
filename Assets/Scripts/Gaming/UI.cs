using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    private const string ScoreKey = "ScoreKey";
    
    [SerializeField] private TextMeshProUGUI scoreText;

    private int _xp = 0;

    void Start()
    {
        PlayerPrefs.GetInt(ScoreKey);

        SetScore(0);   
    }

    public void SetScore(int xp)
    {
        scoreText.text = $"Score: {_xp += xp}";

    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt(ScoreKey, _xp);
    }

}
