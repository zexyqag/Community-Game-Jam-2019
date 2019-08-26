using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(CharacterGrounding))]
[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour {

	[SerializeField] [Range(0f, 100f)] private float maxGroundSpeed = 20, AirAcceleration = 50, jumpForce = 30;

	[Header("Acceleration")] [SerializeField] [Range(0f, 0.1f)] private float AccelerationGround = 0.15f;
	[SerializeField] [Range(0f, 0.1f)] private float AccelerationGroundNo = 0.225f, AccelerationGroundNeg = 0.30f;

	private float moveSpeed;
	private new Rigidbody2D rigidbody2D;
	private CharacterGrounding characterGrounding;
	private PlayerInputManager playerInputManager;

	private void Awake() {
		rigidbody2D = GetComponent<Rigidbody2D>();
		characterGrounding = GetComponent<CharacterGrounding>();
		playerInputManager = FindObjectOfType<PlayerInputManager>();
	}

	private void Update() {
		if(playerInputManager.JumpDown && characterGrounding.IsGrounded) {
			rigidbody2D.AddForce(Vector2.up * jumpForce * rigidbody2D.mass, ForceMode2D.Impulse);
		} else if(playerInputManager.JumpUp && rigidbody2D.velocity.y >= 0) {
			rigidbody2D.velocity *= Vector2.right;
		}

		if(Input.GetKeyDown(KeyCode.K))
			rigidbody2D.velocity = Vector2.left * 25;
	}

	private void FixedUpdate() {
		moveCharacter(new Vector2(playerInputManager.direction.x, 0));
	}

	private void moveCharacter(Vector2 direction) {
		if(characterGrounding.IsGrounded) {
			if(direction.x * moveSpeed < 0) {
				moveSpeed = Mathf.Lerp(moveSpeed, direction.x * maxGroundSpeed, AccelerationGroundNeg);
			} else if(direction.x == 0) {
				moveSpeed = Mathf.Lerp(moveSpeed, direction.x * maxGroundSpeed, AccelerationGroundNo);
			} else {
				moveSpeed = Mathf.Lerp(moveSpeed, direction.x * maxGroundSpeed, AccelerationGround);
			}
			rigidbody2D.velocity = Vector2.right * moveSpeed + rigidbody2D.velocity * Vector2.up;
		} else {
			moveSpeed = rigidbody2D.velocity.x;

			if(direction.x * rigidbody2D.velocity.x < 0 || Mathf.Abs(rigidbody2D.velocity.x) < maxGroundSpeed) {
				rigidbody2D.velocity += Vector2.right * direction.x * AirAcceleration * Time.deltaTime;
			}
		}
	}
}
