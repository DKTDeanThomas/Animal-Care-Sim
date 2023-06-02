using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clock : MonoBehaviour
{
    public string[] tagsToDestroy;

    public Text clockText;
    public Button pauseButton;

    public float elapsedTime;
    public bool isPaused;
    private int hour = 9;
    private int minute = 0;

    private const int MinutesPerHour = 60;

    public UI uiInstance;

    public float tempNum;


    public Animal dogInstance;
    public Animal catInstance;
    public Animal rabbitInstance;

    private void Start()
    {
        pauseButton.onClick.AddListener(TogglePause);

        
    }

    public void Update()
    {
        if (hour == 09 && minute == 0)
        {
            tempNum = 1;         
            uiInstance.ShowActions(tempNum);
            minute++;
        }

        if (hour == 11 && minute == 0)
        {
            tempNum = 2;
            uiInstance.ShowActions(tempNum);
            minute++;
        }

        if (hour == 13 && minute == 0)
        {
            tempNum = 3;
            uiInstance.ShowActions(tempNum);
            minute++;
        }

        if (hour == 15 && minute == 0)
        {
            tempNum = 4;
            uiInstance.ShowActions(tempNum);
            minute++;
        }

        if (hour == 17 && minute == 0)
        {
           tempNum = 5;
            uiInstance.ShowActions(tempNum);
            minute++;
        }


        if (!isPaused)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= 1f)
            {
                elapsedTime = 0f;
                IncreaseTime();
                UpdateClockText();
                

                if (hour >= 18)
                {
                    PauseTime();
                    uiInstance.WinScreen.SetActive(true);
                }
            }
        }
    
    }

    private void IncreaseTime()
    {
        minute += 15;

        if (minute >= MinutesPerHour)
        {
            minute = 0;
            hour++;
        }

        dogInstance.DecrementAll();
        catInstance.DecrementAll();
        rabbitInstance.DecrementAll();

        if (minute >= 30)
        {
            DestroyObjects();
        }
       
    }



    private void UpdateClockText()
    {
        string formattedHour = hour.ToString().PadLeft(2, '0');
        string formattedMinute = minute.ToString().PadLeft(2, '0');
        clockText.text = $"{formattedHour}:{formattedMinute}";
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            StartCoroutine(ResumeDelay());
        }
        else
        {
            isPaused = true;
        }
    }

    public void PauseTime()
    {
        isPaused = true;
    }

    public void ResumeTime()
    {
        isPaused = false;
    }

    private IEnumerator ResumeDelay()
    {
        yield return new WaitForSeconds(1f);
        isPaused = false;
        IncreaseTime();
        UpdateClockText();
    }

    void DestroyObjects()
    {
        foreach (string tag in tagsToDestroy)
        {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject obj in taggedObjects)
            {
                Destroy(obj);
            }
        }
    }
}
