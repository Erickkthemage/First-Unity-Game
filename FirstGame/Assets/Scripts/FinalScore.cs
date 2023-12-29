using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {
        score.text = GameManager.finalScore.ToString();        
    }
}
