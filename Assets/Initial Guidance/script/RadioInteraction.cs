using UnityEngine;
using TMPro;

public class RadioInteraction : MonoBehaviour
{
    public TMP_Text interactionText;
    public TMP_Text reply;
    public GameObject radioReply;
    private bool isPlayerNearby = false;

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            UseRadio();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            interactionText.gameObject.SetActive(true);
            isPlayerNearby = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.gameObject.SetActive(false);
            radioReply.gameObject.SetActive(false);
            isPlayerNearby = false;
        }
    }

    void UseRadio()
    {
        interactionText.gameObject.SetActive(false);
        radioReply.gameObject.SetActive(true);
        reply.text = "You are stranded in a warzone. You can help the East Camp or West Camp, talk to the old man in the wooden house nearby to get more information.";
        // Add logic to highlight markers or provide next steps
    }
}
