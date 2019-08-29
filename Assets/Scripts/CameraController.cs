using UnityEngine;

public class CameraController : MonoBehaviour {


	[SerializeField] [Range(0f, 20f)] private float overwriteDistance = 10f;
	[SerializeField] [Range(0f, 1f)] private float lerpSpeed = 0.5f;
	[SerializeField] [Range(0f, -50f)] private float cameraDistance = -10;
	[SerializeField] private GameObject follow = null;

	private void FixedUpdate() {
		float magnitude = ((Vector2)follow.transform.position - (Vector2)transform.position).magnitude;
		transform.position = (Vector3)Vector2.Lerp(transform.position, follow.transform.position, magnitude <= overwriteDistance ? lerpSpeed : (magnitude - overwriteDistance) / 20 + 0.01f) + cameraDistance * Vector3.forward;
	}
}
