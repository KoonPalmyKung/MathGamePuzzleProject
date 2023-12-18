using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backgroundchange : MonoBehaviour
{
    public Image BG1;
    public Image BG2;
    public Image Ans1, Ans2, Ans3, Ans4, Ans5;
    // Start is called before the first frame update
    public Text Tans1, Tans2, Tans3, Tans4, Tans5;
    void Start()
    {
        BG1.gameObject.SetActive(false);
        BG2.gameObject.SetActive(false);
        Ans1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Checkbox.checkpoint == 10)
        {
            BG1.gameObject.SetActive(true);
            Checkbox.checkpoint = 0;
            Invoke("Aferdelay", 2f);

        }
        if (Checkbox.checkpoint == 7)
        {
            if (Checkbox.star1 == 0)
            {
                Tans1.text = "" + Mathcontroller.Ans1;
                Ans1.gameObject.SetActive(true);
                Tans1.gameObject.SetActive(true);
            }
            if (Checkbox.star2 == 0)
            {
                Tans2.text = "" + Mathcontroller.Ans1;
                Ans2.gameObject.SetActive(true);
                Tans2.gameObject.SetActive(true);
            }
            if (Checkbox.star3 == 0)
            {
                Tans3.text = "" + 0;
                Ans3.gameObject.SetActive(true);
                Tans3.gameObject.SetActive(true);
            }
            if (Checkbox.star4 == 0)
            {
                Tans4.text = "" + Mathcontroller.Ans2;
                Ans4.gameObject.SetActive(true);
                Tans4.gameObject.SetActive(true);
            }
            if (Checkbox.star5 == 0)
            {
                Tans5.text = "" + Mathcontroller.Ans2;
                Ans5.gameObject.SetActive(true);
                Tans5.gameObject.SetActive(true);
            }
            BG2.gameObject.SetActive(true);
            Checkbox.checkpoint = 0;
            Invoke("Aferdelay", 4f);
        }

        if (Checkbox.checkpoint == 14)
        {
            if (Checkbox.star3 == 0)
            {
                Tans3.text = "" + Mathcontroller.Ans1;
                Ans3.gameObject.SetActive(true);
                Tans3.gameObject.SetActive(true);
            }
            if (Checkbox.star4 == 0)
            {
                Tans4.text = "" + Mathcontroller.Ans1;
                Ans4.gameObject.SetActive(true);
                Tans4.gameObject.SetActive(true);
            }
            if (Checkbox.star5 == 0)
            {
                Tans5.text = "" + Mathcontroller.Ans2;
                Ans5.gameObject.SetActive(true);
                Tans5.gameObject.SetActive(true);
            }
            BG2.gameObject.SetActive(true);
            Checkbox.checkpoint = 0;
            Invoke("Aferdelay", 4f);
        }
        if (Checkbox.checkpoint == 19)
        {
            if (Checkbox.star1 == 0)
            {
                Ans1.transform.position = new Vector2(Ans1.transform.position.x, Ans1.transform.position.y - 35);
                Tans1.text = "" + Mathcontroller.Ans1;
                Ans1.gameObject.SetActive(true);
                Tans1.gameObject.SetActive(true);
            }
            if (Checkbox.star2 == 0)
            {
                Ans2.transform.position = new Vector2(Ans2.transform.position.x, Ans2.transform.position.y - 35);
                Tans2.text = "" + Mathcontroller.Ans1;
                Ans2.gameObject.SetActive(true);
                Tans2.gameObject.SetActive(true);
            }
            if (Checkbox.star5 == 0)
            {
                Tans5.text = "" + Mathcontroller.Ans2;
                Ans5.gameObject.SetActive(true);
                Tans5.gameObject.SetActive(true);
            }
            BG2.gameObject.SetActive(true);
            Checkbox.checkpoint = 0;
            Invoke("Aferdelay", 4f);
        }
    }
    void Aferdelay()
    {
        BG1.gameObject.SetActive(false);
        BG2.gameObject.SetActive(false);
        Ans1.gameObject.SetActive(false);
        Ans2.gameObject.SetActive(false);
        Ans3.gameObject.SetActive(false);
        Ans4.gameObject.SetActive(false);
        Ans5.gameObject.SetActive(false);
        Tans1.gameObject.SetActive(false);
        Tans2.gameObject.SetActive(false);
        Tans3.gameObject.SetActive(false);
        Tans4.gameObject.SetActive(false);
        Tans5.gameObject.SetActive(false);
        Checkbox.star1 = 0;
        Checkbox.star2 = 0;
        Checkbox.star3 = 0;
        Checkbox.star4 = 0;
        Checkbox.star5 = 0;
        if (Checkbox.floor > 10)
        {
            Checkbox.resets = 10;
        }
        else
        {
            Checkbox.resets = 5;
        }
    }
}
