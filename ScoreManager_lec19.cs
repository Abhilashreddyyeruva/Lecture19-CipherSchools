using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int _score = 0;
    // Start is called before the first frame update
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    
    
    public void AddScore(int points)
    {
        _score += points;  
        

    }
}
