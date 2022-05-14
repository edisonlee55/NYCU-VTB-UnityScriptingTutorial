using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int _gameScore;

    // Start is called before the first frame update
    private void Start()
    {
        _gameScore = 0;
    }

    public static int GetScore()
    {
        return _gameScore;
    }

    public static void AddScore(int i)
    {
        _gameScore += i;
    }
}