using UnityEngine;
public class TToggleComponents : ATrigger {
	[SerializeField] private MonoBehaviour[] components;
	private enum Action { Toggle, Enable, Disable };
	[SerializeField] private Action action = Action.Toggle;
	public override void Trigger(GameObject collisionObject) {
		foreach(var component in components) {
			if(action == Action.Toggle) {
				component.enabled = !component.enabled;
			} else {
				component.enabled = action == Action.Enable ? true : false;
			}
		}
	}
}



