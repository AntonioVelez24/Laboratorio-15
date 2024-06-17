using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Button startButton;
    public Text textPoints;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadGameScene());
        IncreasePoints(0);
    }
    public void IncreasePoints(int pointsToAdd)
    {
        points = points + pointsToAdd;
        textPoints.text = "Puntos: " + points;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
