using UnityEngine;

public class TChat : ATrigger {
	[SerializeField] private string Text = null;
	public override void Trigger(GameObject collisionObject) {
		DialogueManager.Instance.ChatAdd(Text);
	}
}
