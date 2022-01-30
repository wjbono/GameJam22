using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class UITabButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    #region SerializeFields
    [SerializeField]
    [Tooltip("The UITabGroup this button belongs to")]
    private UITabGroup tabGroup;
    #endregion

    #region Private Variables
    private Image background;
	#endregion

	#region Properties
    public Image Background { get { return background; } }
	#endregion

	#region MonoBehaviour
	void Start()
    {
        background = GetComponent<Image>();
        if(!background)
		{
            Debug.LogErrorFormat(gameObject, "{0} does not have a background image!", gameObject.name);
		}

        if(!tabGroup)
		{
            Debug.LogErrorFormat(gameObject, "{0} does not have a UITabGroup assigned to subscribe to!", gameObject.name);
		}
        tabGroup.Subscribe(this);
    }
	#endregion

	#region Interface Implementation
    public void OnPointerClick(PointerEventData eventData)
	{
        tabGroup.OnTabSelected(this);
	}

    public void OnPointerEnter(PointerEventData eventData)
	{
        tabGroup.OnTabEnter(this);
	}

    public void OnPointerExit(PointerEventData eventData)
	{
        tabGroup.OnTabExit(this);
	}
	#endregion

	#region Public Methods
	public void Select()
	{
	}

	public void Deselect()
	{
	}
	#endregion
}
