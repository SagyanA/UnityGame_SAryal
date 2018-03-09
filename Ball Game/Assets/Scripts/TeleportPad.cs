using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour {

	public int code;

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.name == "Player") {
			foreach(TeleportPad tp in FindObjectsOfType<TeleportPad>())
			{
				if (tp.code==code && tp != this) {
					Vector3 position = tp.gameObject.transform.position;
					position.y+=2;
					collider.gameObject.transform.position=position;
				}
			}
		}

	}
}
