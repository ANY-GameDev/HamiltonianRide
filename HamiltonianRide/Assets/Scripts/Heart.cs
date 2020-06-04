using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [Tooltip("The velocity of the object, in meters per second")] [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Transform t = GetComponent<Transform>();

    }

        // Update is called once per frame
        void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x + speed, transform.localScale.y + speed, transform.localScale.z);
        if ((Mathf.Abs(transform.localScale.x) < -400f) && ((transform.localScale.x) < -200f) && (speed > 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) > -20f) && ((transform.localScale.x) < 20f) && (speed > 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) > 20f) && ((transform.localScale.x) < 40f) && (speed > 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) > 40f) && ((transform.localScale.x) < 60f) && (speed > 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) > 60f) && ((transform.localScale.x) > 40f) && (speed > 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) < 60f) && ((transform.localScale.x) > 40f) && (speed < 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) < 40f) && ((transform.localScale.x) > 20f) && (speed < 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) < 20f) && ((transform.localScale.x) > 0f) && (speed < 0f))
            speed = 0.001f;
        else if ((Mathf.Abs(transform.localScale.x) < 20f) && ((transform.localScale.x) < 0f) && (speed < 0f))
            speed = 0.001f;

    }
}
