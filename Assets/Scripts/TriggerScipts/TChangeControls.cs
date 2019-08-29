using UnityEngine;

public class TChangeControls : ATrigger {
	[SerializeField] private ControlsDictionary controlsDictionary = null;
	public override void Trigger(GameObject collisionObject) {
		PlayerInputManager.Instance.SetControlsDictionary(controlsDictionary);
	}
}
