using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FocusOnUIScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FocusOnCodingScreen()
    {
        Quaternion newRotation = new Quaternion();
        Vector3 newPosition = new Vector3(-1.352f, 5.62699986f, 7.46999979f);
        newRotation = Quaternion.Euler(12.878f, 155f, -1.445f);
        transform.rotation = newRotation;
    }

    public void FocusOnUIScreen()
    {
        Quaternion newRotation = new Quaternion();
        Vector3 newPotision = new Vector3(-0.1f, 5.672f, 4.9f);
        newRotation = Quaternion.Euler(12.878f, 200, -1.445f);
        transform.rotation = newRotation;
        transform.position = newPotision;
    }
}
