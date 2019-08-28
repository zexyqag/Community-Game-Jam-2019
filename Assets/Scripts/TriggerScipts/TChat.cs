using UnityEngine;

public class TChat : ATrigger {
	[SerializeField] private string Text;
	public override void Trigger(Collider2D collision) {
		DialogueManager.Instance.ChatAdd(Text);
	}
}
