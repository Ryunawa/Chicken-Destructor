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
        victoryUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void Defeat()
    {
        defeatUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainMap");
        Time.timeScale = 1;
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
