using UnityEngine;

public class CharacterGrounding : MonoBehaviour {

	private new Rigidbody2D rigidbody2D;
	SpriteRenderer spriteRenderer;
	private Transform groundedObject;
	public bool IsGrounded { get; private set; }
	public bool IsInSafeSpace { get; private set; }

	[SerializeField]
	private LayerMask groundedLayer = 0;
	private Vector2 origin, size, sizeOffsetY;


	private void Awake() {
		spriteRenderer = GetComponent<SpriteRenderer>();
		rigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		sizeOffsetY = (Vector2.up * spriteRenderer.size.y * 0.99f) + (Vector2.right * spriteRenderer.size.x * 0.01f);
		size = spriteRenderer.size - sizeOffsetY;
		origin = spriteRenderer.transform.position + (Vector3.down * spriteRenderer.size.y * 0.5f) - size.y * Vector3.up * 0.5f;

		var raycastHit = Physics2D.BoxCast(origin, size, 0f, Vector2.zero, 0, groundedLayer);

		IsInSafeSpace = false;
		IsGrounded = false;
		if(raycastHit.collider != null) {
			if(raycastHit.collider.gameObject.CompareTag("StaticGameObject")) {
				IsInSafeSpace = true;
			}
			IsGrounded = true;
		}
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(origin, size);
	}
}
