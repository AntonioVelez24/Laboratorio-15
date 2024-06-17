using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float MinXPosition;
    public float MaxXPosition;
    public float yPosition;
    public GameControl gameManager;
    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }
    void CreateEnemy()
    {
        float xPosition = Random.Range(MinXPosition, MaxXPosition);
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(EnemyPrefab, positionToCreate, transform.rotation);
        enemy.GetComponent<EnemyMovement>().SetEnemyContainerControl(this);
        Invoke("CreateEnemy", 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
                   
        
    }
    public void IncreasePoints(int PointsToAdd)
    {
        gameManager.IncreasePoints(PointsToAdd);
    }
}
