using UnityEngine;

public class TConsole : ATrigger {
	[SerializeField] private string Text = null;
	public override void Trigger(GameObject collisionObject) {
		DialogueManager.Instance.ConsoleAdd(Text);
	}
}
