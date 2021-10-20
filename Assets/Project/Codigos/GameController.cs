using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int totalScore;

    public static GameController instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        instance = this;   
    }

    // Update is called once per frame
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
}
