using UnityEngine;

public class TConsole : ATrigger {
	[SerializeField] private string Text;
	public override void Trigger(Collider2D collision) {
		DialogueManager.Instance.ConsoleAdd(Text);
	}
}
