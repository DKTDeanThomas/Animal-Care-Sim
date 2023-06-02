using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BotActions : MonoBehaviour
{
    public UI uiInstance;
    public Clock Instance;

    public Transform funBot;
    public Transform cleanBot;
    public Transform foodBot;
    public GameObject particleprefab;

    private Vector2 dogSP = new Vector2(-5.63f, 2.976561f);
    private Vector2 catSP = new Vector2(-5.63f, -0.27f);
    private Vector2 rabbitSP = new Vector2(-5.63f, -3.6f);
    private Vector2 offset = new Vector2(0, 0.8f);



    public void Foodbot()
    {
        uiInstance.ShowFoodButtonSet(true);
        uiInstance.ShowFunButtonSet(false);
        uiInstance.ShowCleanButtonSet(false);


    }

    public void Funbot()
    {
        uiInstance.ShowFunButtonSet(true);
        uiInstance.ShowFoodButtonSet(false);
        uiInstance.ShowCleanButtonSet(false);

    }

    public void Cleanbot()
    {
        uiInstance.ShowCleanButtonSet(true);
        uiInstance.ShowFoodButtonSet(false);
        uiInstance.ShowFunButtonSet(false);


    }



    public void LetemCook()
    {

        uiInstance.DisableActions(1);
        Instance.ResumeTime();
    }

    public void FoodbotDog()
    {
        Instantiate(particleprefab, dogSP - offset, Quaternion.identity);
        Instantiate(foodBot, dogSP, Quaternion.identity);

    }

    public void FoodbotCat()
    {
        Instantiate(particleprefab, catSP - offset, Quaternion.identity);
        Instantiate(foodBot, catSP, Quaternion.identity);
        
    }
    public void FoodbotRabbit()
    {
        Instantiate(particleprefab, rabbitSP - offset, Quaternion.identity);
        Instantiate(foodBot, rabbitSP, Quaternion.identity);
        
    }

    //

    public void FunbotDog()
    {
        Instantiate(particleprefab, dogSP - offset, Quaternion.identity);
        Instantiate(funBot, dogSP, Quaternion.identity);
    }

    public void FunbotCat()
    {
        Instantiate(particleprefab, catSP - offset, Quaternion.identity);
        Instantiate(funBot, catSP, Quaternion.identity);
    }
    public void FunbotRabbit()
    {
        Instantiate(particleprefab, rabbitSP - offset, Quaternion.identity);
        Instantiate(funBot, rabbitSP, Quaternion.identity);
    }

    //

    public void CleanbotDog()
    {
        Instantiate(particleprefab, dogSP - offset, Quaternion.identity);
        Instantiate(cleanBot, dogSP, Quaternion.identity);
    }

    public void CleanbotCat()
    {
        Instantiate(particleprefab, catSP - offset, Quaternion.identity);
        Instantiate(cleanBot, catSP, Quaternion.identity);
    }
    public void CleanbotRabbit()
    {
        Instantiate(particleprefab, rabbitSP - offset, Quaternion.identity);
        Instantiate(cleanBot, rabbitSP, Quaternion.identity);
    }

}
