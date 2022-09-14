using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public Text meteoritesHit;
    
    int meteoritesHitScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        meteoritesHit.text = meteoritesHitScore.ToString() + " meteorites hit";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addHit()
    {
        meteoritesHitScore += 1;
        meteoritesHit.text = meteoritesHitScore.ToString() + " meteorites hit";
    }
}
