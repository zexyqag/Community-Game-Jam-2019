using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
	[SerializeField]private GameObject ConsoleObj, ChatObj;
	private TextMeshProUGUI Console, Chat;
	public static DialogueManager Instance;

	private void Awake() {
		Instance = this;

		Console = ConsoleObj.GetComponent<TextMeshProUGUI>();
		Chat = ChatObj.GetComponent<TextMeshProUGUI>();
	}


	public void ConsoleAdd(string text) {
		Console.text += "\n" + text;
	}
	public void ChatAdd(string text) {
		Chat.text += "\n" + ">"+text;
	}

}
