using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class ATrigger : MonoBehaviour {
	[SerializeField] [Range(0, 10)] private float Delay = 0;
	[SerializeField] private bool Repeatable = false;
	private BoxCollider2D boxCollider2D;
	private bool Triggered;

	private void Awake() {
		boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
		boxCollider2D.isTrigger = true;
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if(!Triggered || Repeatable) {
			Triggered = true;
			StartCoroutine(DoYourThing(collision));
		}
	}
	private IEnumerator DoYourThing(Collider2D collision) {
		yield return new WaitForSeconds(Delay);
		Trigger(collision);
	}

	public abstract void Trigger(Collider2D collision);
}
