using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnSwipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (this != null)
        {
            if (data.Direction == SwipeDirection.Left)
            {
                transform.Rotate(0, 4, 0, Space.Self);
            }
            else if (data.Direction == SwipeDirection.Right)
            {
                transform.Rotate(0, -4, 0, Space.Self);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.rotation.eulerAngles.y < 310 && this.transform.rotation.eulerAngles.y > 180)
        {
            transform.Rotate(0, 3, 0, Space.Self);
        }
        if (this.transform.rotation.eulerAngles.y > 50 && this.transform.rotation.eulerAngles.y <= 180)
        {
            transform.Rotate(0, -3, 0, Space.Self);
        }
    }
}
