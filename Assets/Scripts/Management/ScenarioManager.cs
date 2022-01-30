using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
    #region SerializeFields
    [SerializeField]
    [Tooltip("The email window which will be populated with data")]
    private EmailWindow emailWindow;
	#endregion

	#region Private Variables
	private EmailSO[] emailScenarios;
	#endregion

	#region MonoBehaviour
	void Start()
    {
        if(!emailWindow)
		{
            Debug.LogErrorFormat(gameObject, "{0} does not have an email window set for data initialization", gameObject.name);
            return;
		}

		StartCoroutine(InitializeEmailWindow());
    }
	#endregion

	#region Coroutines
	private IEnumerator InitializeEmailWindow()
	{
		yield return new WaitForSeconds(0.1f);
		emailScenarios = Resources.LoadAll<EmailSO>("ScriptableObjects/Scenarios");

		if (emailScenarios.Length == 0)
		{
			Debug.LogWarning("There are no scenarios present in the Resources/ScriptableObjects/Scenarios folder or they could not be loaded");
		}
		else
		{
			EmailSO randomScenario = emailScenarios[Random.Range(0, emailScenarios.Length)];
			emailWindow.InitializeWindow(randomScenario);
		}
	}
	#endregion
}
