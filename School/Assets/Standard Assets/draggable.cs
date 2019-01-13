using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class draggable : MonoBehaviour , IBeginDragHandler, IDragHandler, IEndDragHandler {


	public Transform parentToReturn = null;
	
	public void OnBeginDrag(PointerEventData eventData){
		 parentToReturn = this.transform.parent;
		 this.transform.SetParent(this.transform.parent.parent);
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}
	
	public void OnDrag(PointerEventData eventData){
		this.transform.position = eventData.position;
	}
	
	
	public void OnEndDrag(PointerEventData eventData){
		 this.transform.SetParent(parentToReturn);
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
	
}
