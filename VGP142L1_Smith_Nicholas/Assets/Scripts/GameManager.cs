using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] Transform[] locations;
    [SerializeField] GameObject endPoint;
    // Start is called before the first frame update
    private void Start()
    {
        endPoint.transform.position = locations[Random.Range(0, 9)].position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
