using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(transform.forward * 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(transform.forward * -10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(transform.right * 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(transform.right * -10.0f * Time.deltaTime);
        }

        //rotation
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -90 * Time.deltaTime, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 90 * Time.deltaTime, 0.0f, 0.0f);
        }
    }


}