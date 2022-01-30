using UnityEngine;

public class UIUtilities : MonoBehaviour
{
	#region Public Methods
	public static void ChangeCanvasGroupActive(CanvasGroup canvasGroup, bool active)
	{
		if(!canvasGroup)
		{
			Debug.LogWarning("Cannot change the active status of a null canvas group", canvasGroup);
			return;
		}

		if(active)
		{
			canvasGroup.alpha = 1;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
		}
		else
		{
			canvasGroup.alpha = 0;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
		}
	}
	#endregion
}
