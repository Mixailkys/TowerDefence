using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance = null;

    public GameObject spawnPoint;
    public GameObject[] enemies;
    public int maxEnimiesOnScreen;
    public int totalEnimies;
    public int enemiesPerSpawn;

    int enemiesOnScreen = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if(enemiesPerSpawn > 0 && enemiesOnScreen < totalEnimies)
            for (int i = 0; i < enemiesPerSpawn; i++)
            {
                if (enemiesOnScreen < maxEnimiesOnScreen)
                {
                    GameObject newEnemy = Instantiate(enemies[0]) as GameObject;
                    newEnemy.transform.position = spawnPoint.transform.position;
                    enemiesOnScreen += 1;
                }
                
            }
    }
}
