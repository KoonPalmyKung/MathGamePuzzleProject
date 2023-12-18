using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tohome : MonoBehaviour
{
    public static int homeKey = 0;
    public Image homePage;
    public Button homeButton;
    // Start is called before the first frame update
    void Start()
    {
        if (homeKey == 0)
        {
            homeButton.gameObject.SetActive(false);
        }
        if (homeKey == 5)
        {
            homeButton.gameObject.SetActive(true);
        }
        homeButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnButtonClick()
    {
        homeButton.gameObject.SetActive(false);
        homePage.gameObject.SetActive(true);
    }
}
