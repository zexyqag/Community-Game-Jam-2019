using UnityEngine;

public class TResetPlayer : ATrigger {
	public override void Trigger(Collider2D collision) {
		CharacterController characterController = collision.gameObject.GetComponent<CharacterController>();
		if(characterController != null) {
			characterController.resetToLastSafeSpace();
		}
	}
}
