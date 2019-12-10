using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    public static CoinCollection instance;
    public Text scoreText;
    private int score;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        scoreText.text = "X" + score.ToString();
    }
}

