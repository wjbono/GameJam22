using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EmailWindow : MonoBehaviour
{
    #region SerializeFields
    [SerializeField]
    [Tooltip("The email title text")]
    private TMP_Text emailTitle;
    [SerializeField]
    [Tooltip("The email body text")]
    private TMP_Text emailDescription;
    [SerializeField]
    [Tooltip("The face image")]
    private Image faceImage;
    [SerializeField]
    [Tooltip("The container for the scenario choice buttons")]
    private Transform scenarioButtonsContainer;
    [SerializeField]
    [Tooltip("The prefab for the scenario button")]
    private GameObject scenarioButtonPrefab;
    #endregion

    #region Private Variables
    private Sprite[] faceSprites;
	#endregion

	#region MonoBehaviour
	void Start()
	{
		faceSprites = Resources.LoadAll<Sprite>("Sprites/Faces");
	}
	#endregion

	#region Public Methods
	public void InitializeWindow(EmailSO email)
	{
        emailTitle.text = email.EmailTitle;
        emailDescription.text = email.EmailDescription;

        foreach(string prompt in email.OptionPrompts)
		{
            GameObject newButton = Instantiate(scenarioButtonPrefab, scenarioButtonsContainer);
            newButton.name = $"ScenarioChoiceButton{email.OptionPrompts.IndexOf(prompt)}";
            TMP_Text buttonText = newButton.GetComponentInChildren<TMP_Text>();
            if(!buttonText)
			{
                Debug.LogWarningFormat(newButton, "{0} - cannot find text component, so button text cannot be set", newButton.name);
			}
            else
			{
                buttonText.text = prompt;
			}
		}

        if(faceSprites.Length == 0)
		{
            Debug.LogWarning("There are no sprites present in the Resources/Sprites/Faces folder or they could not be loaded");
		}
        else
		{
            Sprite randomFace = faceSprites[Random.Range(0, faceSprites.Length)];
            faceImage.sprite = randomFace;
		}
	}
	#endregion
}
