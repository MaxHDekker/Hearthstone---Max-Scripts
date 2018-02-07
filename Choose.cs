using UnityEngine;
using UnityEngine.EventSystems;

public class Choose : MonoBehaviour
     , IPointerClickHandler
{
    public bool keep = true;

    public bool crossOn = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        keep = !keep;
    }

    void Update()
    {
        if (!keep)
        {
            this.gameObject.transform.GetChild(7).gameObject.SetActive(true);
        }
        else if(keep)
        {
            this.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }

    }
}
