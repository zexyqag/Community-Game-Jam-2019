using UnityEngine;

public class TTeleportPlayer : ATrigger {
	public GameObject spawnPoint = null;
	public override void Trigger(GameObject collisionObject) {
		CharacterController characterController = collisionObject.GetComponent<CharacterController>();
		characterController.teleportPlayer(spawnPoint.transform.position);
	}
}
