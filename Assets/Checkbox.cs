using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Checkbox : MonoBehaviour, IDropHandler
{
    public GameObject target;
    public static int checkpoint = 0, resets, scores = 0, floor = 1;
    public static int star1 = 0, star2 = 0, star3 = 0, star4 = 0, star5 = 0;
    private int a, b, c, d, e;
    public static bool invTrue1 = false, invTrue2 = false, invTrue3 = false, invTrue4 = false, invTrue5 = false;
    public void OnDrop(PointerEventData eventData)
    {
        a = int.Parse(Mathcontroller.instance.chanal1);
        b = int.Parse(Mathcontroller.instance.chanal2);
        c = int.Parse(Mathcontroller.instance.chanal3);
        d = int.Parse(Mathcontroller.instance.chanal4);
        e = int.Parse(Mathcontroller.instance.chanal5);

        if (target.tag == "InvStart")
        {
            CheckNull();
        }

        if (StartScript.startPoint == 9)
        {

            if (target.name == "Inv1" && GameObject.Find("Inv1").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue1 = true;
                if (Mathcontroller.sameAns == 1)
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star1 = 1;
                    }
                    else
                    {
                        star1 = 0;
                    }
                }
                else
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag))
                    {
                        star1 = 1;
                    }
                    else
                    {
                        star1 = 0;
                    }
                }


            }

            else if (target.name == "Inv2" && GameObject.Find("Inv2").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue2 = true;
                if (Mathcontroller.sameAns == 1)
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star2 = 1;
                    }
                    else
                    {
                        star2 = 0;
                    }
                }
                else
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag))
                    {
                        star2 = 1;
                    }
                    else
                    {
                        star2 = 0;
                    }
                }
            }

            else if (target.name == "Inv3" && GameObject.Find("Inv3").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue3 = true;
                if (Mathcontroller.sameAns2 == 1)
                {

                    if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star3 = 1;
                    }
                    else
                    {
                        star3 = 0;
                    }
                }
                else
                {
                    if (c == int.Parse(eventData.pointerDrag.tag))
                    {
                        star3 = 1;
                    }
                    else
                    {
                        star3 = 0;
                    }
                }

            }

            else if (target.name == "Inv4" && GameObject.Find("Inv4").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue4 = true;
                if (Mathcontroller.sameAns == 1)
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star4 = 1;
                    }
                    else
                    {
                        star4 = 0;
                    }
                }
                if (Mathcontroller.sameAns2 == 1)
                {

                    if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star4 = 1;
                    }
                    else
                    {
                        star4 = 0;
                    }
                }
                else
                {
                    if (d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star4 = 1;
                    }
                    else
                    {
                        star4 = 0;
                    }
                }
            }

            else if (target.name == "Inv5" && GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue5 = true;
                if (Mathcontroller.sameAns == 1)
                {
                    if (a == int.Parse(eventData.pointerDrag.tag) || b == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star5 = 1;
                    }
                    else
                    {
                        star5 = 0;
                    }
                }
                if (Mathcontroller.sameAns2 == 1)
                {

                    if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star5 = 1;
                    }
                    else
                    {
                        star5 = 0;
                    }
                }
                else
                {
                    if (d == int.Parse(eventData.pointerDrag.tag) || e == int.Parse(eventData.pointerDrag.tag))
                    {
                        star5 = 1;
                    }
                    else
                    {
                        star5 = 0;
                    }
                }

            }
            if (invTrue1 && invTrue2 && invTrue3 && invTrue4 && invTrue5)
            {
                checkpoint = 5;
            }
            else
            {
                checkpoint = 0;
            }

        }
        if (StartScript.startPoint == 14)
        {
            if (target.name == "Inv3" && GameObject.Find("Inv3").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue3 = true;
                if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag))
                {
                    star3 = 1;
                }
                else
                {
                    star3 = 0;
                }

            }

            else if (target.name == "Inv4" && GameObject.Find("Inv4").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue4 = true;
                if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag))
                {
                    star4 = 1;
                }
                else
                {
                    star4 = 0;
                }
            }

            else if (target.name == "Inv5" && GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue5 = true;
                if (e == int.Parse(eventData.pointerDrag.tag))
                {
                    star5 = 1;
                }
                else
                {
                    star5 = 0;
                }
            }
            if (invTrue3 && invTrue4 && invTrue5)
            {
                checkpoint = 3;
            }
            else
            {
                checkpoint = 0;
            }

        }

        if (StartScript.startPoint == 19)
        {
            if (target.name == "Inv1" && GameObject.Find("Inv1").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue1 = true;
                if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag))
                {
                    star1 = 1;
                }
            }

            else if (target.name == "Inv2" && GameObject.Find("Inv2").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue2 = true;
                if (c == int.Parse(eventData.pointerDrag.tag) || d == int.Parse(eventData.pointerDrag.tag))
                {
                    star2 = 1;
                }
            }

            else if (target.name == "Inv5" && GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                CheckNull();
                invTrue5 = true;
                if (e == int.Parse(eventData.pointerDrag.tag))
                {
                    star5 = 1;
                }
            }
            if (invTrue1 && invTrue2 && invTrue5)
            {
                checkpoint = 3;
            }
            else
            {
                checkpoint = 0;
            }
            Debug.Log(invTrue1 + "  " + invTrue2 + "  " + invTrue3 + "  " + invTrue4 + "  " + invTrue5);
        }


        Debug.Log("you get star: " + star1 + " " + star2 + " " + star3 + " " + " " + star4 + " " + star5);
    }

    void CheckNull()
    {
        if (StartScript.startPoint == 9)
        {
            if (GameObject.Find("Inv1").GetComponentInChildren<Text>() == null)
            {
                star1 = 0;
                invTrue1 = false;
                Debug.Log("Inv1: No item");
            }
            if (GameObject.Find("Inv2").GetComponentInChildren<Text>() == null)
            {
                star2 = 0;
                invTrue2 = false;
                Debug.Log("Inv2: No item");
            }
            if (GameObject.Find("Inv3").GetComponentInChildren<Text>() == null)
            {
                star3 = 0;
                invTrue3 = false;
                Debug.Log("Inv3: No item");
            }
            if (GameObject.Find("Inv4").GetComponentInChildren<Text>() == null)
            {
                star4 = 0;
                invTrue4 = false;
                Debug.Log("Inv4: No item");
            }
            if (GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                star5 = 0;
                invTrue5 = false;
                Debug.Log("Inv5: No item");
            }

        }
        if (StartScript.startPoint == 14)
        {
            if (GameObject.Find("Inv3").GetComponentInChildren<Text>() == null)
            {
                star3 = 0;
                invTrue3 = false;
                Debug.Log("Inv3: No item");
            }
            if (GameObject.Find("Inv4").GetComponentInChildren<Text>() == null)
            {
                star4 = 0;
                invTrue4 = false;
                Debug.Log("Inv4: No item");
            }
            if (GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                star5 = 0;
                invTrue5 = false;
                Debug.Log("Inv5: No item");
            }

        }

        if (StartScript.startPoint == 19)
        {
            if (GameObject.Find("Inv1").GetComponentInChildren<Text>() == null)
            {
                star1 = 0;
                invTrue1 = false;
                Debug.Log("Inv1: No item");
            }
            if (GameObject.Find("Inv2").GetComponentInChildren<Text>() == null)
            {
                star2 = 0;
                invTrue2 = false;
                Debug.Log("Inv2: No item");
            }
            if (GameObject.Find("Inv5").GetComponentInChildren<Text>() == null)
            {
                star5 = 0;
                invTrue5 = false;
                Debug.Log("Inv5: No item");
            }

        }
    }
}
