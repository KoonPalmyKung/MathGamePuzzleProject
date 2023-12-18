using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{

    public static int startPoint = 5;
    public Image image;
    public Button plusMinus, Mutipy, Divide, home;
    void Start()
    {
    }
    void Update()
    {
        if (startPoint == 5)
        {
            image.gameObject.SetActive(true);
            plusMinus.onClick.AddListener(OneClick);
            Mutipy.onClick.AddListener(TwoClick);
            Divide.onClick.AddListener(ThreeClick);
        }
        else
        {
            image.gameObject.SetActive(false);
        }

    }
    void OneClick()
    {
        startPoint = 10;
        Checkbox.scores = 0;
        Checkbox.floor = 1;
        Tohome.homeKey = 5;
        image.gameObject.SetActive(false);
        home.gameObject.SetActive(true);
    }
    void TwoClick()
    {
        startPoint = 15;
        Checkbox.scores = 0;
        Checkbox.floor = 1;
        Tohome.homeKey = 5;
        image.gameObject.SetActive(false);
        home.gameObject.SetActive(true);
    }
    void ThreeClick()
    {
        startPoint = 20;
        Checkbox.scores = 0;
        Checkbox.floor = 1;
        Tohome.homeKey = 5;
        image.gameObject.SetActive(false);
        home.gameObject.SetActive(true);
    }
}
