using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
<<<<<<<< HEAD:Final_project/Assets/Scripts/CabinetPointerEvent.cs

public class CabinetPointerEvent : MonoBehaviour
========
public class PointerEvent : MonoBehaviour
>>>>>>>> bc5ed30341756b964284113afe7e16d5ba0a4f1d:Final_project/Assets/Scripts/PointerEvent.cs
{
    public Image LoadingBar;
    public Transform Cube;
    public Transform Manual;
    private bool IsOn;
    private float barTime = 0.0f;
<<<<<<<< HEAD:Final_project/Assets/Scripts/CabinetPointerEvent.cs
    public Transform Cabinet;
    public Transform Cabinet_1;

========
>>>>>>>> bc5ed30341756b964284113afe7e16d5ba0a4f1d:Final_project/Assets/Scripts/PointerEvent.cs
    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }

    void Update()
    {
        if (IsOn)
        {
            if (barTime <= 1.0f)
<<<<<<<< HEAD:Final_project/Assets/Scripts/CabinetPointerEvent.cs
                barTime += Time.deltaTime;

            LoadingBar.fillAmount = barTime / 1.0f;

========
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 1.0f;
            Instantiate(Manual, new Vector3(-300, 163, -143),Quaternion.Euler(0,-90,0));
>>>>>>>> bc5ed30341756b964284113afe7e16d5ba0a4f1d:Final_project/Assets/Scripts/PointerEvent.cs
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
            Debug.Log("In");
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

}
