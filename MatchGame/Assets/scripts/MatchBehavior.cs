using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public Id idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(idObj);
        //Debug.Log(other.GetComponent<IdContainerBehavior>().idObj);
        
        var tempObj = other.GetComponent<IdContainerBehavior>();
        if (tempObj == null)
            return;

        var otherId = tempObj.idObj;
        if (otherId == idObj)
        {
            //Debug.Log("Match");
            matchEvent.Invoke();
        }

        else
        {
            //Debug.Log("No Match");
            noMatchEvent.Invoke();
        }
    }
}
