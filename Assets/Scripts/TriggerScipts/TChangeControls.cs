using UnityEngine;

public class TChangeControls : ATrigger {
	[SerializeField] private ControlsDictionary controlsDictionary;
	public override void Trigger(Collider2D collision) {
		PlayerInputManager.Instance.SetControlsDictionary(controlsDictionary);
	}
}
