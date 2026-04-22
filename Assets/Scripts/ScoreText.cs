using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public void SetScore(int value)
    {
        scoretext.text = value.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
