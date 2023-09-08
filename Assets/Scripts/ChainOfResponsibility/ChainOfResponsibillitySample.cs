using UnityEngine;

namespace DesignPatternSample.ChainOfResponsibility
{
    public class ChainOfResponsibillitySample : MonoBehaviour
    {
        MapEntity currentMapEntity;
        void Start()
        {
            currentMapEntity = new MapEntity(1, 1);
            currentMapEntity.Init();
            currentMapEntity.Enter();
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                currentMapEntity.Clear();
                if(currentMapEntity.NextMap == null) {
                    Debug.Log("Game Finished");
                    return;
                }
                currentMapEntity = currentMapEntity.NextMap;
                currentMapEntity.Init();
                currentMapEntity.Enter();
            }
        }
    }
}