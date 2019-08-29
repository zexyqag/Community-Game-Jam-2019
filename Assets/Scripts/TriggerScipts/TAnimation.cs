using UnityEngine;

public class TAnimation : ATrigger {
	[SerializeField] public string Animation;
	[SerializeField] public Animator animator;
	public override void Trigger(GameObject collisionObject) {
		animator.Play(Animation);
	}
}
