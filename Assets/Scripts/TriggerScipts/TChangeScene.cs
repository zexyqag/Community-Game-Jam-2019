using UnityEngine;
using UnityEngine.SceneManagement;

public class TChangeScene : ATrigger {

	[SerializeField] private string sceneName;
	public override void Trigger(GameObject collisionObject) {
		SceneManager.LoadScene(sceneName);
	}
}
