using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    public string Name;
    public float Attentionlvl;
    public float Energylvl;
    public float Hungerlvl;
    public float Cleanlinesslvl;

    public float healthPoints;

    public UI uiInstance;
    public BotActions Instance;
    public Clock cInstance;

    public float decMod = 2;
    public float incMod = 10;

    public Text attentionstatus;
    public Text hungerstatus;
    public Text energystatus;
    public Text cleanstatus;
    public Image vibe;
    public GameObject heartStat1;
    public GameObject heartStat2;
    public GameObject heartStat3;

    public GameObject animalCanvas;

    public bool isdog = false;
    public bool iscat = false;
    public bool israbbit = false;

    public void Update()
    {
        if (Attentionlvl > 0 && Attentionlvl <= 33)
        {
            attentionstatus.text = "lonely";
            attentionstatus.color = Color.red;
        }

        else if (Attentionlvl > 33 && Attentionlvl <= 66)
        {
            attentionstatus.text = "fine";
            attentionstatus.color = Color.yellow;
        }

        else if (Attentionlvl > 66 && Attentionlvl <= 100)
        {
            attentionstatus.text = "Good";
            attentionstatus.color = Color.green;
        }

        //

        if (Hungerlvl > 0 && Hungerlvl <= 33)
        {
            hungerstatus.text = "starved";
            hungerstatus.color = Color.red;
        }

        else if (Hungerlvl > 33 && Hungerlvl <= 66)
        {
            hungerstatus.text = "fine";
            hungerstatus.color = Color.yellow;
        }

        else if (Hungerlvl > 66 && Hungerlvl <= 100)
        {
            hungerstatus.text = "Full";
            hungerstatus.color = Color.green;
        }

        //

        if (Energylvl > 0 && Energylvl <= 33)
        {
            energystatus.text = "Tired";
            energystatus.color = Color.red;
        }

        else if (Energylvl > 33 && Energylvl <= 66)
        {
            energystatus.text = "fine";
            energystatus.color = Color.yellow;
        }

        else if (Energylvl > 66 && Energylvl <= 100)
        {
            energystatus.text = "Good";
            energystatus.color = Color.green;
        }

        //

        if (Cleanlinesslvl > 0 && Cleanlinesslvl <= 33)
        {
            cleanstatus.text = "Dirty";
            cleanstatus.color = Color.red;
        }

        else if (Cleanlinesslvl > 33 && Cleanlinesslvl <= 66)
        {
            cleanstatus.text = "fine";
            cleanstatus.color = Color.yellow;
        }

        else if (Cleanlinesslvl > 66 && Cleanlinesslvl <= 100)
        {
            cleanstatus.text = "Clean";
            cleanstatus.color = Color.green;

        }

        //

        if (healthPoints > 0 && healthPoints <= 33)
        {

            heartStat2.SetActive(true);
            heartStat2.SetActive(false);
            heartStat3.SetActive(false);         
        }

        else if (healthPoints > 33 && healthPoints <= 66)
        {

            heartStat2.SetActive(true);
            heartStat2.SetActive(true);
            heartStat3.SetActive(false);

        }

        else if (healthPoints > 66 && healthPoints <= 100)
        {
            heartStat2.SetActive(true);
            heartStat2.SetActive(true);
            heartStat3.SetActive(true);
        }
    }



    public void DecrementAll()
    {
        HealthCalc();
        AttentionCalc(false);
        HungerCalc(false);
        EnergyCalc(false);
        CleanCalc(false);

    }


    public void AttentionCalc(bool crement)
    {
        if (crement)
        {
            Attentionlvl += incMod;
        }

        else
        {
            Attentionlvl-= decMod;

            if (Attentionlvl <= 0)
                Attentionlvl = 0;
        }

        Instance.LetemCook();
    }

    public void EnergyCalc(bool crement)
    {
        if (crement)
        {
            Energylvl += incMod;
        }

        else
        {
            Energylvl -= decMod;
            
            if (Energylvl <= 0)
                Energylvl = 0;
        }
        Instance.LetemCook();
    }

    public void HungerCalc(bool crement)
    {
        if (crement)
        {
            Hungerlvl += incMod;
        }

        else
        {
            Hungerlvl-=decMod;

            if (Hungerlvl <= 0)
                Hungerlvl = 0;
        }
        Instance.LetemCook();
    }

    public void CleanCalc(bool crement)
    {
        if (crement)
        {
            Cleanlinesslvl += incMod;
        }

        else
        {
            Cleanlinesslvl -= decMod;

            if (Cleanlinesslvl <= 0)
                Cleanlinesslvl = 0;
        }
        Instance.LetemCook();
    }

    public void HealthCalc()
    {

        healthPoints = (Cleanlinesslvl + Hungerlvl + Energylvl + Attentionlvl) / 4;

        if (healthPoints >= 100)
        {
            healthPoints = 100;
        }

        if (healthPoints < 10)
        {
            uiInstance.GameOverCanvas.SetActive(true);
            uiInstance.letDie.text = "You let the " + Name + " die";
           
        }
    }
}


