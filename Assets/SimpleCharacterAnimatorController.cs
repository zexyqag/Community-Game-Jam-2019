using UnityEngine;

public class SimpleCharacterAnimatorController : MonoBehaviour {
	private Animator animator = null;
	private SpriteRenderer spriteRenderer = null;
	[SerializeField] private CharacterController characterController = null;
	[SerializeField] private CharacterGrounding characterGrounding = null;

	private void Awake() {
		animator = gameObject.GetComponent<Animator>();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	private void Update() {
		animator.SetBool("inAir", !characterGrounding.IsGrounded);
		animator.SetFloat("speed", Mathf.Abs(characterController.speed()));

		if(Mathf.Abs(characterController.speed()) > 0) {
			spriteRenderer.flipX = characterController.speed() < 0 ? true : false ;
		}
	}
}
