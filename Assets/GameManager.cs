using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Score = 0;

    public Text ScoreOutput;
    void Update()
    {
        ScoreOutput.text = "Score: " + Score;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ScoreCount()
    {
        Score++;
    }
    
}
