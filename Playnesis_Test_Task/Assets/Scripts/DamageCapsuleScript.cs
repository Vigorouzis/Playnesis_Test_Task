using ScriptableValues;
using UnityEngine;
using UnityEngine.EventSystems;

public class DamageCapsuleScript : InteractiveObject
{
    [SerializeField] private PlayerIndicators _playerIndicators;


    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                Debug.DrawRay(_camera.transform.position, hit.transform.position, Color.yellow);

                if (hit.transform.name == "DamageCapsule")
                {
                    _playerIndicators.health -= 10;
                }
            }
        }
    }
}