using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class ATrigger : MonoBehaviour {

	[SerializeField] private float Delay = 0;
	[SerializeField] private bool Repeatable = false;
	private BoxCollider2D boxCollider2D;
	private bool Triggered;

	private void Start() {
	}

	private void Awake() {
		boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if((!Triggered || Repeatable) && enabled) {
			Triggered = true;
			StartCoroutine(DoYourThing(collision.gameObject));
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if((!Triggered || Repeatable) && enabled) {
			Triggered = true;
			StartCoroutine(DoYourThing(collision.gameObject));
		}
	}

	private IEnumerator DoYourThing(GameObject collisionObject) {
		yield return new WaitForSeconds(Delay);
		Trigger(collisionObject);
	}

	void Reset() {
		boxCollider2D = GetComponent<BoxCollider2D>();
		boxCollider2D.isTrigger = true;
	}

	public abstract void Trigger(GameObject collisionObject);
}
