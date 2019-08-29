using UnityEngine;

public class TResetPlayer : ATrigger {
	public override void Trigger(GameObject collisionObject) {
		CharacterController characterController = collisionObject.GetComponent<CharacterController>();
		characterController.resetToLastSafeSpace();
	}
}
