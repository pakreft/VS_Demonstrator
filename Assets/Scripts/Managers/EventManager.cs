using UnityEngine;

[DisallowMultipleComponent]
public class EventManager : MonoBehaviour
{
   [SerializeField] private GameManager GM;
   [SerializeField] private Event[] events;
   private Event currentEvent;
   private int index = 0;
   
   private void Awake()
   {
      if (events.Length == 0)
      {
         Debug.LogError("EventManager: No events found.");
      }
      else
      {
         currentEvent = events[0];
      }
   }
   
   public void NextEvent()
   {
      index++;
      
   }

   public void StartEvent()
   {
      currentEvent = events[index];
      
      // GUI
      GM.uiManager.SetStepCounter(index + 1);
      GM.uiManager.SetInfoText(currentEvent.instructionText);
      
      // Camera
      currentEvent.vCam.enabled = true;
   }
}
