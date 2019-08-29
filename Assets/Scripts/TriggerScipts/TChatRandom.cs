using UnityEngine;

public class TChatRandom : ATrigger {
	[SerializeField] private string[] Text = null;
	public override void Trigger(GameObject collisionObject) {
		DialogueManager.Instance.ChatAdd(Text[Random.Range(0, Text.Length)]);
	}
}
