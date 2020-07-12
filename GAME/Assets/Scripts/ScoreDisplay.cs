using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + ScoreManager.score.ToString();
        
    }
}
