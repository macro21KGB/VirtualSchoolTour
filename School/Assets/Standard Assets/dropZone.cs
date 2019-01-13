using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropZone : MonoBehaviour, IDropHandler {

	public int count = 3;

	public void OnDrop(PointerEventData eventData) {
		
		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null){
			d.parentToReturn = this.transform;
			count--;
			if (count <= 0){
				Debug.Log("Hai creato il solfato di ferro");
			}
		}
	}
	
		public void OnPointerEnter(PointerEventData eventData) {
		
	}
	
	public void OnPointerExit(PointerEventData eventData) {
	}
}
