using UnityEngine;
public class TToggleGameObjects : ATrigger {
	[SerializeField] private GameObject[] gameObjects;
	private enum Action { Toggle, Enable, Disable };
	[SerializeField] private Action action = Action.Toggle;
	public override void Trigger(GameObject collisionObject) {
		foreach(var obj in gameObjects) {
			if(action == Action.Toggle) {
				obj.SetActive(!obj.active);
			} else {
				obj.SetActive(action == Action.Enable ? true : false);
			}
		}
	}
}
