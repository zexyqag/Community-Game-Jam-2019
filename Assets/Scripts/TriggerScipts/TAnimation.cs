using UnityEngine;

public class TAnimation : ATrigger {
	[SerializeField] public string Animation;
	[SerializeField] public Animator animator;
	public override void Trigger(Collider2D collision) {
		animator.Play(Animation);
	}
}
