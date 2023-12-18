using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Resetdraganddrop : MonoBehaviour
{
    public Image End, mainHome;
    public Text scores, Max, title;
    public Button newstart, mainManu, resume, home;
    void Start()
    {
        newstart.onClick.AddListener(OnButtonClick);
        mainManu.onClick.AddListener(OnManu);
        resume.onClick.AddListener(OnResumeClick);
        Max.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scores.text = "" + Checkbox.scores;
        if (Checkbox.resets == 10)
        {
            End.gameObject.SetActive(true);
            title.gameObject.SetActive(true);
            resume.gameObject.SetActive(false);
            if (Checkbox.scores == 10)
            {
                Max.gameObject.SetActive(true);
            }

        }
        if (Checkbox.resets == 5)
        {
            Checkbox.resets = 0;
            Mathcontroller.sameAns = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            if (StartScript.startPoint == 9)
            {
                StartScript.startPoint = 10;
            }
            if (StartScript.startPoint == 14)
            {
                StartScript.startPoint = 15;
            }
            if (StartScript.startPoint == 19)
            {
                StartScript.startPoint = 20;
            }
        }

    }
    void OnButtonClick()
    {
        Checkbox.scores = 0;
        Checkbox.floor = 1;
        Checkbox.resets = 5;
        Mathcontroller.levelup = 0;
        End.gameObject.SetActive(false);
        Max.gameObject.SetActive(false);
    }
    void OnManu()
    {
        Checkbox.scores = 0;
        Checkbox.floor = 1;
        Checkbox.resets = 5;
        Mathcontroller.levelup = 0;
        StartScript.startPoint = 5;
        Tohome.homeKey = 0;
        End.gameObject.SetActive(false);
        Max.gameObject.SetActive(false);
    }
    void OnResumeClick()
    {
        home.gameObject.SetActive(true);
        End.gameObject.SetActive(false);
    }
}
