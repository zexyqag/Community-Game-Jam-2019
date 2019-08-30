using UnityEngine;

public class TTeleportPlayer : ATrigger {
	[SerializeField] private GameObject teleportTo = null;
	public override void Trigger(GameObject collisionObject) {
		CharacterController characterController = collisionObject.GetComponent<CharacterController>();
		characterController.teleportPlayer(teleportTo.transform.position);
	}
}
