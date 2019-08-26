using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(CharacterGrounding))]
[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed = 5;
	[SerializeField]
	private float jumpForce = 10;

	public float Speed { get; private set; }

	private new Rigidbody2D rigidbody2D;
	private CharacterGrounding characterGrounding;

	private void Awake() {
		rigidbody2D = GetComponent<Rigidbody2D>();
		characterGrounding = GetComponent<CharacterGrounding>();
	}

	private void Update() {
		if(Input.GetButtonDown("Fire1") && characterGrounding.IsGrounded) {
			rigidbody2D.AddForce(Vector2.up * jumpForce * rigidbody2D.mass, ForceMode2D.Impulse);
		}
	}

	private void FixedUpdate() {
		moveCharacter(new Vector2(Input.GetAxisRaw("Horizontal"), 0));
	}

	private void moveCharacter(Vector2 direction) {
		rigidbody2D.position += direction * Time.deltaTime * moveSpeed;
	}
}
