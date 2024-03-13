using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    public bool isGameOver;
    public ScorePoints scorePointsScript;
    public MoveWalls moveWallsScript;
    public MoveWalls moveWallsScript2;
    public float difficulty;

    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()    
    {
        isGameOver = true;
        button = GetComponent<Button>();
        moveWallsScript = GameObject.Find("block 1").GetComponent<MoveWalls>();
        moveWallsScript2 = GameObject.Find("block 2").GetComponent<MoveWalls>();
        scorePointsScript = GameObject.Find("Sphere").GetComponent<ScorePoints>();
         
    }
    public void SetDifficulty()
    {
        Debug.Log(gameObject.name);
        StartGame(difficulty);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(float difficulty)
    {
        Debug.Log("Difficulty: " + difficulty);
       isGameOver = false;
        scorePointsScript.score = 0;
        moveWallsScript.wallSpeed = difficulty;
        moveWallsScript2.wallSpeed = difficulty;
        AddPlayerControlledVelocity.difficulty = difficulty;
        titleScreen.gameObject.SetActive(false);
        
    }
}
