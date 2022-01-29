using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITabGroup : MonoBehaviour
{
	#region SerializeFields
	[Header("Tab Visuals")]
	[SerializeField]
	[Tooltip("The background color for when the tab is idle")]
	private Color idleColor;
	[SerializeField]
	[Tooltip("The background color for when the tab is hovered over")]
	private Color hoverColor;
	[SerializeField]
	[Tooltip("The background color for when the tab is selected")]
	private Color selectedColor;

	[Header("Functionality")]
	[SerializeField]
	[Tooltip("The canvas groups to swap between")]
	private List<CanvasGroup> canvasGroupsToSwap;
	[SerializeField]
	[Tooltip("The tab that should be selected when the game starts")]
	private UITabButton initialSelectedTab;
	#endregion

	#region Private Variables
	private List<UITabButton> tabButtons;
	private UITabButton selectedTab;
	#endregion

	#region MonoBehaviour
	void Start()
	{
		if(initialSelectedTab)
		{
			OnTabSelected(initialSelectedTab);
		}
	}
	#endregion

	#region Public Methods
	public void Subscribe(UITabButton tabButton)
	{
		if (tabButtons == null)
		{
			tabButtons = new List<UITabButton>();
		}

		tabButtons.Add(tabButton);
	}

	public void OnTabEnter(UITabButton tabButton)
	{
		ResetTabs();
		if (!selectedTab || selectedTab != tabButton)
		{
			tabButton.Background.color = hoverColor;
		}
	}

	public void OnTabExit(UITabButton tabButton)
	{
		ResetTabs();
	}

	public void OnTabSelected(UITabButton tabButton)
	{
		if(selectedTab != null)
		{
			selectedTab.Deselect();
		}
		selectedTab = tabButton;
		selectedTab.Select();
		ResetTabs();
		tabButton.Background.color = selectedColor;
		int index = tabButton.transform.GetSiblingIndex();
		for(int i = 0; i < canvasGroupsToSwap.Count; i++)
		{
			if(i == index)
			{
				canvasGroupsToSwap[i].alpha = 1;
				canvasGroupsToSwap[i].interactable = true;
				canvasGroupsToSwap[i].blocksRaycasts = true;
			}
			else
			{
				canvasGroupsToSwap[i].alpha = 0;
				canvasGroupsToSwap[i].interactable = false;
				canvasGroupsToSwap[i].blocksRaycasts = false;
			}
		}
	}

	public void ResetTabs()
	{
		foreach(UITabButton tabButton in tabButtons)
		{
			if(selectedTab && selectedTab == tabButton)
			{
				continue;
			}
			tabButton.Background.color = idleColor;
		}
	}
	#endregion
}
