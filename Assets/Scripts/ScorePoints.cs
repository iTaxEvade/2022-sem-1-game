using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScorePoints : MonoBehaviour
{
    // Start is called before the first frame update
    public float score = 0.0f;
    public string strTag;
    public TextMeshProUGUI scoreText;
    public DifficultyButton Dbutton;
   

    void Start()
    {
        Dbutton = GameObject.Find("EasyB").GetComponent<DifficultyButton>();
        score = 0;
        scoreText.text = "Score: " + score;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Point"))
        {
            score = score + (100.0f * AddPlayerControlledVelocity.difficulty);
            scoreText.text = "Score: " + score;
         
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
