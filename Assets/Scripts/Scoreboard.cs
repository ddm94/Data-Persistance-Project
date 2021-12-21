using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public GameObject highscoreEntry;

    // Start is called before the first frame update
    void Start()
    {
        /* foreach( GameManager.ScoreData data in GameManager.Instance.scores) 
        {
            GameObject newEntry = Instantiate(highscoreEntry, transform);
        }

        newScore.transform.Find("NameText").GetComponent<TextMeshProUGUI>().text = data.playerName;
            newScore.transform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = data.score.ToString();
        */
    }
}
