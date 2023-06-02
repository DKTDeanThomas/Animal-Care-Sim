using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public GameObject foodbot;
    public GameObject funbot;
    public GameObject cleanbot;

    public GameObject actionPanel;

    public GameObject foodbuttonset;
    public GameObject funbuttonset;
    public GameObject cleanbuttonset;

    public GameObject GameOverCanvas;
    public Text letDie;

    public GameObject WinScreen;

    public Clock Instance;

    public void ShowFoodButtonSet(bool isTrue)
    {
        if (isTrue)
        foodbuttonset.SetActive(true);

        else foodbuttonset.SetActive(false);
    }

    public void ShowFunButtonSet(bool isTrue)
    {
        if (isTrue)
            funbuttonset.SetActive(true);
        else funbuttonset.SetActive(false);
    }

    public void ShowCleanButtonSet(bool isTrue)
    {
        if (isTrue)
        cleanbuttonset.SetActive(true);
        else cleanbuttonset.SetActive(false);
    }

    public void ShowActions(float isShow)
    {
        actionPanel.SetActive(true);
        Instance.PauseTime();

        switch (isShow)
        {
            case 1:
                foodbot.SetActive(true);
                funbot.SetActive(true);
                cleanbot.SetActive(true);

                break;

            case 2:
                cleanbot.SetActive(true);
                break;

            case 3:
                funbot.SetActive(true);
                break;

            case 4:
                foodbot.SetActive(true);
                cleanbot.SetActive(true);
                break;

            case 5:
                foodbot.SetActive(true);
                funbot.SetActive(true);
                break;

        }

    }

    public void DisableActions(float isShow)
    {
        
        
        actionPanel.SetActive(false);

        switch (isShow)
        {
            case 1:
                foodbot.SetActive(false);
                funbot.SetActive(false);
                cleanbot.SetActive(false);

                break;

            case 2:
                cleanbot.SetActive(false);
                break;

            case 3:
                funbot.SetActive(false);
                break;

            case 4:
                foodbot.SetActive(false);
                cleanbot.SetActive(false);
                break;

            case 5:
                foodbot.SetActive(false);
                funbot.SetActive(false);
                break;

        }
    }


}
