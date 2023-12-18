using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recheck : MonoBehaviour
{
    private int a, b, c, d, e;
    public Button secretButton;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        secretButton.gameObject.SetActive(false);
        myButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        a = Checkbox.star1;
        b = Checkbox.star2;
        c = Checkbox.star3;
        d = Checkbox.star4;
        e = Checkbox.star5;
        if (StartScript.startPoint == 9)
        {
            if (Checkbox.checkpoint == 5)
            {
                secretButton.gameObject.SetActive(true);
            }
            else
            {
                secretButton.gameObject.SetActive(false);
            }
        }
        if (StartScript.startPoint == 14 || StartScript.startPoint == 19)
        {
            if (Checkbox.checkpoint == 3)
            {
                secretButton.gameObject.SetActive(true);
            }
            else
            {
                secretButton.gameObject.SetActive(false);
            }
        }

    }

    void OnButtonClick()
    {
        secretButton.gameObject.SetActive(false);
        if (StartScript.startPoint == 9)
        {
            if (a == 1 && b == 1 && c == 1 && d == 1 && e == 1)
            {
                Checkbox.scores++;
                Checkbox.checkpoint = 10;
                Checkbox.floor++;
            }
            else
            {
                Checkbox.checkpoint = 7;
                Checkbox.floor++;
            }
        }
        if (StartScript.startPoint == 14)
        {
            if (c == 1 && d == 1 && e == 1)
            {
                Checkbox.scores++;
                Checkbox.checkpoint = 10;
                Checkbox.floor++;
            }
            else
            {
                Checkbox.checkpoint = 14;
                Checkbox.floor++;
            }
        }
        if (StartScript.startPoint == 19)
        {
            if (a == 1 && b == 1 && e == 1)
            {
                Checkbox.scores++;
                Checkbox.checkpoint = 10;
                Checkbox.floor++;
            }
            else
            {
                Checkbox.checkpoint = 19;
                Checkbox.floor++;
            }
        }
        Debug.Log("You get Scores: " + Checkbox.scores);

    }
}
