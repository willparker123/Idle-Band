using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introSwipeHandler : MonoBehaviour
{
    private int c = 0;
    public GameObject c0;
    public GameObject c1;
    public GameObject c2;
    public GameObject button;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
        EnableCanvas(c0);
        DisableCanvas(c1);
        DisableCanvas(c2);
        anim = button.GetComponent<Animation>();
    }

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void DisableCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
    }

    private void EnableCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    private void ButtonAnimation(int direction)
    {
        anim = button.GetComponent<Animation>();
        if (direction == 0) //left
        {
            anim.Play("left");
        }
        else if (direction == 1) //right
        {
            anim.Play("right");
        }
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (data.Direction==SwipeDirection.Left && c<2)
        {
            //ButtonAnimation(0);
            c++;
        }
        if (data.Direction == SwipeDirection.Right && c > 0)
        {
            //ButtonAnimation(1);
            c--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (c == 0) { EnableCanvas(c0); DisableCanvas(c1); DisableCanvas(c2); }
        else if (c == 1) { EnableCanvas(c1); DisableCanvas(c0); DisableCanvas(c2); }
        else if (c == 2) { EnableCanvas(c2); DisableCanvas(c0); DisableCanvas(c1); }
    }
}
