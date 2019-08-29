using UnityEngine;

public class TConsole : ATrigger {
	[SerializeField] [TextArea(3, 3)] private string Text = null;
	public override void Trigger(GameObject collisionObject) {
		DialogueManager.Instance.ConsoleAdd(Text);
	}
}
