using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Mathcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private string a, marks, remarks;
    const string glyphs = "ABCDE", keys = "+-";
    private int answer, b, c, FakeAns1, FakeAns2;
    public static int Ans1, Ans2;

    public Text valueA, valueB, valueAnswer, valueMarks;
    public Text valueA2, valueB2, valueB3, valueAnswer2, valueMarks2, valueRemarks1, valueRemarks2, equal2, equal4, divide1, divide2, divide3, divide4;
    public Text valueA3, equal3, mark3;
    public Text valueA4;
    public Text states;
    public GameObject[] choiceDrag;
    public Image box1, box2, cross1, cross2, valueDivide1, valueDivide2, cC1, cC2;
    public int[] logs = new int[5];
    public static int levelup, sameAns = 0, sameAns2 = 0;
    public static Mathcontroller instance;
    public string chanal1, chanal2, chanal3, chanal4, chanal5;


    private void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (StartScript.startPoint == 10)
        {
            StartScript.startPoint = 9;
            Additionmethod();
            states.text = "" + Checkbox.floor;
        }
        else if (StartScript.startPoint == 15)
        {
            StartScript.startPoint = 14;
            Multiplymethod();
            states.text = "" + Checkbox.floor;
        }
        else if (StartScript.startPoint == 20)
        {
            StartScript.startPoint = 19;
            Divicemethod();
            states.text = "" + Checkbox.floor;
        }

        chanal1 = logs[0].ToString();
        chanal2 = logs[1].ToString();
        chanal3 = logs[2].ToString();
        chanal4 = logs[3].ToString();
        chanal5 = logs[4].ToString();

    }
    void Additionmethod()
    {
        a += glyphs[Random.Range(0, glyphs.Length)];
        if (levelup <= 3)
        {
            b = Random.Range(1, 10);
            do
            {
                answer = Random.Range(1, 10);
            } while (answer == b);
            levelup++;
        }
        if (levelup > 3 && levelup <= 7)
        {
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    b = Random.Range(10, 20);
                } while (b == 0);
            }
            if (c == 0)
            {
                do
                {
                    b = Random.Range(-20, -10);
                } while (b == 0);
            }
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    answer = Random.Range(10, 20);
                } while (answer == b || answer == 0);
            }
            if (c == 0)
            {
                do
                {
                    answer = Random.Range(-20, -10);
                } while (answer == b || answer == 0);
            }
            levelup++;
        }
        if (levelup > 7)
        {
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    b = Random.Range(20, 99);
                } while (b == 0);
            }
            if (c == 0)
            {
                do
                {
                    b = Random.Range(-99, -20);
                } while (b == 0);
            }
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    answer = Random.Range(20, 99);
                } while (answer == b || answer == 0);
            }
            if (c == 0)
            {
                do
                {
                    answer = Random.Range(-99, -20);
                } while (answer == b || answer == 0);
            }
            levelup++;
        }
        //b=-18;answer=18;

        if (levelup > 5)
        {
            marks += keys[Random.Range(0, keys.Length)];
            if (marks == "+")
            {
                remarks = "-";
                c = answer - b;
                //aAnswer = answer - b;
                valueMarks.text = "" + marks;
                valueMarks2.text = "" + marks;
            }
            else
            {
                remarks = "+";
                c = answer + b;
                //aAnswer = answer + b;
                valueMarks.text = "" + marks;
                valueMarks2.text = "" + marks;
            }
        }
        else
        {
            remarks = "+";
            c = answer + b;
            valueMarks.text = "-";
            valueMarks2.text = "-";
        }
        Ans1 = b;
        Ans2 = c;
        valueA.text = "" + a;
        valueB.text = "" + b;
        valueAnswer.text = "" + answer;

        valueA2.text = "" + a;
        valueB2.text = "" + b;
        valueAnswer2.text = "" + answer;

        valueRemarks1.text = "" + remarks;
        valueRemarks2.text = "" + remarks;
        cross1.gameObject.SetActive(false);
        cross2.gameObject.SetActive(false);

        valueA3.text = "" + a;

        valueA4.text = "" + a;

        RandomNumber();

        for (int i = 0; i < choiceDrag.Length; i++)
        {
            if (i == logs[0])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            else if (i == logs[1])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            else if (i == logs[2])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + 0;
            }
            else if (i == logs[3])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + c;
            }
            else if (i == logs[4])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + c;
            }
        }
        if (b == c)
        {
            sameAns = 1;
        }
        else
        {
            sameAns = 0;
        }
        if (c == 0)
        {
            sameAns2 = 1;
        }
        else
        {
            sameAns2 = 0;
        }
    }

    void Multiplymethod()
    {
        a += glyphs[Random.Range(0, glyphs.Length)];
        if (levelup <= 3)
        {
            do
            {
                b = Random.Range(1, 12);
            } while (b == 0);

            do
            {
                answer = Random.Range(2, 12);
            } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            levelup++;
        }
        if (levelup > 3 && levelup <= 7)
        {
            do
            {
                b = Random.Range(-12, -1);
            } while (b == 0);

            do
            {
                answer = Random.Range(-12, 12);
            } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            levelup++;
        }
        if (levelup > 7)
        {
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    b = Random.Range(5, 12);
                } while (b == 0);
            }
            if (c == 0)
            {
                do
                {
                    b = Random.Range(-12, -5);
                } while (b == 0);
            }
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    answer = Random.Range(13, 25);
                } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            }
            if (c == 0)
            {
                do
                {
                    answer = Random.Range(-25, -13);
                } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            }
            levelup++;
        }
        c = b * answer;
        //marks += keys[Random.Range(0, keys.Length)];
        Ans1 = b;
        Ans2 = answer;
        valueA.gameObject.SetActive(false);
        valueMarks.gameObject.SetActive(false);
        valueB.text = b + "" + a;
        valueAnswer.text = "" + c;

        valueA2.gameObject.SetActive(false);
        valueB3.text = b + "" + a;
        valueMarks2.gameObject.SetActive(false);
        valueAnswer2.text = "" + c;
        valueRemarks1.gameObject.SetActive(false);
        valueRemarks2.gameObject.SetActive(false);
        box1.gameObject.SetActive(false);
        box2.gameObject.SetActive(false);
        valueB2.gameObject.SetActive(false);
        equal2.gameObject.SetActive(false);

        equal3.gameObject.SetActive(false);
        equal4.gameObject.SetActive(true);
        valueA3.gameObject.SetActive(false);
        mark3.gameObject.SetActive(false);

        valueA4.text = "" + a;

        RandomNumber();

        do
        {
            FakeAns1 = Random.Range(b - 5, b + 5);
        } while (FakeAns1 == b || FakeAns1 == answer);

        do
        {
            FakeAns2 = Random.Range(answer - 5, answer + 5);
        } while (FakeAns2 == b || FakeAns2 == answer);

        for (int i = 0; i < choiceDrag.Length; i++)
        {
            if (i == logs[0])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + FakeAns1;
            }
            if (i == logs[1])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + FakeAns2;
            }
            if (i == logs[2])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            if (i == logs[3])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            if (i == logs[4])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + answer;
            }
        }
    }
    void Divicemethod()
    {
        //int stoploop = 0;
        /*stoploop++;
        if (stoploop > 10)
        {
            FakeAns2 = 0;
            stoploop = 0;
        }*/
        a += glyphs[Random.Range(0, glyphs.Length)];
        if (levelup <= 3)
        {
            do
            {
                b = Random.Range(1, 12);
            } while (b == 0);
            do
            {
                answer = Random.Range(2, 12);
            } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            levelup++;
        }
        if (levelup > 3 && levelup <= 7)
        {
            do
            {
                b = Random.Range(-12, -1);
            } while (b == 0);
            do
            {
                answer = Random.Range(-12, 12);
            } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            levelup++;
        }
        if (levelup > 7)
        {
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    b = Random.Range(5, 12);
                } while (b == 0);
            }
            if (c == 0)
            {
                do
                {
                    b = Random.Range(-12, -5);
                } while (b == 0);
            }
            c = Random.Range(0, 2);
            if (c == 1)
            {
                do
                {
                    answer = Random.Range(13, 25);
                } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            }
            if (c == 0)
            {
                do
                {
                    answer = Random.Range(-25, -13);
                } while (answer == b || answer == 1 || answer == -1 || answer == 0);
            }
        }


        c = b * answer;
        Ans1 = b;
        Ans2 = c;
        divide1.text = "" + a;
        divide2.text = "" + b;
        valueAnswer.text = "" + answer;
        valueA.gameObject.SetActive(false);
        valueMarks.gameObject.SetActive(false);
        valueB.gameObject.SetActive(false);
        valueDivide1.gameObject.SetActive(true);

        cC1.transform.position = new Vector2(cC1.transform.position.x, cC1.transform.position.y - 35);
        divide3.text = "" + a;
        divide4.text = "" + b;
        valueAnswer2.text = "" + answer;
        valueRemarks1.text = "x";
        valueRemarks2.text = "x";
        valueA2.gameObject.SetActive(false);
        valueMarks2.gameObject.SetActive(false);
        valueB2.gameObject.SetActive(false);
        valueDivide2.gameObject.SetActive(true);
        cross1.gameObject.SetActive(false);
        cross2.gameObject.SetActive(false);

        cC2.gameObject.SetActive(false);
        valueA4.text = "" + a;

        RandomNumber();
        do
        {
            FakeAns1 = Random.Range(answer - 5, answer + 5);
        } while (FakeAns1 == c || FakeAns1 == b);

        do
        {
            FakeAns2 = Random.Range(answer - 5, answer + 5) * b;
        } while (FakeAns2 == c || FakeAns2 == answer || FakeAns2 == b || FakeAns2 > 999);

        for (int i = 0; i < choiceDrag.Length; i++)
        {
            if (i == logs[0])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + FakeAns1;
            }
            if (i == logs[1])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + FakeAns2;
            }
            if (i == logs[2])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            if (i == logs[3])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + b;
            }
            if (i == logs[4])
            {
                choiceDrag[i].GetComponentInChildren<Text>().text = "" + c;
            }
        }
    }
    void RandomNumber()
    {
        for (int i = 0; i < logs.Length; i++)
        {
            int randomNumber = Random.Range(1, 6);

            while (System.Array.IndexOf(logs, randomNumber) != -1)
            {
                randomNumber = Random.Range(1, 6);
            }
            logs[i] = randomNumber;
        }
        for (int j = 0; j < logs.Length; j++)
        {
            if (logs[j] == 5)
            {
                logs[j] = 0;
            }
        }
        Debug.Log("Random numbers: " + string.Join(", ", logs));
    }


}
