using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VictoryDefeat : MonoBehaviour
{
    public int chickenMax;
    public int chickenRemaining;
    public GameObject gameUI;
    public GameObject victoryUI;
    public GameObject defeatUI;

    private void Awake()
    {
        gameUI = GameObject.Find("GameInterface");
        //defeatUI = GameObject.Find("GameOver");
        //victoryUI = GameObject.Find("Victory"); 
    }

    void Start()
    {
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chicken");

        chickenMax = chickens.Count();
        chickenRemaining = chickenMax;

        gameUI.GetComponent<GameUI>().SetCounterChicken(chickenRemaining);
        gameUI.GetComponent<GameUI>().SetMaxChicken(chickenMax);
    }

    public void DecrementChicken()
    {
        chickenRemaining--;
        gameUI.GetComponent<GameUI>().SetCounterChicken(chickenRemaining);

        if (chickenRemaining <= 0)
        {
            Victory();
        }
    }

    public void Victory()
    {
        Time.timeScale = 0f;
        victoryUI.SetActive(true);
    }

    public void Defeat()
    {
        Time.timeScale = 0f;
        defeatUI.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Jerome");
    }

    public void ExitButton()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
