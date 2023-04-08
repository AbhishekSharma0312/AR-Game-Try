using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VehicleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Transform deSpawnPoint;

    public void SetUpAndMoveVehicle(Transform spawnPos, Transform deSpawnPos)
    {
        deSpawnPoint = deSpawnPos;
        MoveVehicle();
    }

    void MoveVehicle()
    {
        var seq = DOTween.Sequence();
        seq.Append(gameObject.transform.DOMoveZ(deSpawnPoint.position.z,moveSpeed).SetEase(Ease.Linear));
        seq.AppendCallback(() => 
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        });
    }
}