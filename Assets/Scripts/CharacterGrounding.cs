using UnityEngine;

public class CharacterGrounding : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	private Transform groundedObject;
	public bool IsGrounded { get; private set; }

	[SerializeField]
	private LayerMask groundedLayer;
	private Vector2 origin, size, sizeOffsetY;


	private void Awake() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void Update() {
		sizeOffsetY = (Vector2.up * spriteRenderer.size.y * 0.9f);
		size = spriteRenderer.size - sizeOffsetY;
		origin = spriteRenderer.transform.position + (Vector3.down * spriteRenderer.size.y * 0.5f) - size.y * Vector3.up * 0.5f;

		var raycastHit = Physics2D.BoxCast(origin, size, 0f, Vector2.up, Mathf.Infinity, groundedLayer);
		if(raycastHit.collider != null) {
			IsGrounded = true;
		} else {
			IsGrounded = false;
		}
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(origin, size);
	}
}
