using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text kibbleText;
    private int kibble;
    // Start is called before the first frame update
    void Start()
    {
        kibble = 0;
        kibbleText.text = "Score: " + kibble;
    }

    
}
