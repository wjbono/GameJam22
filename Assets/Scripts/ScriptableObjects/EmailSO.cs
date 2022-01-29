using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Email", menuName = "ScriptableObjects/Email")]
public class EmailSO : ScriptableObject
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("The title of this email")]
	private string emailTitle;
	[SerializeField]
	[Tooltip("The body of the email (description of the scenario)")]
	private string emailDescription;
	[SerializeField]
	[Tooltip("The option prompts that appear on the buttons to choose how to handle the scenario")]
	private List<string> optionPrompts;
	#endregion

	#region Properties
	public string EmailTitle { get { return emailTitle; } }
	public string EmailDescription { get { return emailDescription; } }
	public List<string> OptionPrompts { get { return optionPrompts; } }
	#endregion
}
