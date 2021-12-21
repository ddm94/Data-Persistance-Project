using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadScore();

        highscoreText.text = "Best Score: " + GameManager.Instance.score + "; Player: " + GameManager.Instance.playerName;
    }
}
