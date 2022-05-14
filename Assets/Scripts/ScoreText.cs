using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = ScoreManager.GetScore().ToString();
    }
}