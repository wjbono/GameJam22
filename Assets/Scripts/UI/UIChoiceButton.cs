using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIChoiceButton : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    CameraFocus cameraFocus;

    // Start is called before the first frame update
    void Start()
    {
        cameraFocus = Camera.main.GetComponent<CameraFocus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton()
    {
        if (gameObject.GetComponentInChildren<TMP_Text>().text == "Encourage the child to stand up for themselves")
        {
            GameManager.Instance.SetChoice(GameManager.UserChoice.STAND_UP);
        }
        else if (gameObject.GetComponentInChildren<TMP_Text>().text == "Encourage the child to find an outlet for their pain and frustration")
        {
            GameManager.Instance.SetChoice(GameManager.UserChoice.FIND_OUTLET);
        }
        else if (gameObject.GetComponentInChildren<TMP_Text>().text == "Encourage the child to find like-minded friends")
        {
            GameManager.Instance.SetChoice(GameManager.UserChoice.MAKE_FRIENDS);
        }
        else { return; }
        cameraFocus.FocusOnCodingScreen();
    }
}
