using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{

    public int score; //tracks score for game after destroying balloon object

    public TextMeshProUGUI scoreText; //modifies text to match "score" int


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    

    public void increaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();

    }

    public void decreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();

    }
    public void UpdateScoreText()
    {

        scoreText.text = "Score: " + score;
    }
}
