using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    public GameObject goPlayerObject;
    bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }

    bool CheckCanMove(float destinationPosition)
    {
        if(destinationPosition < -2 || destinationPosition > 2)
        {
            return false;
        }

        return true;
    }

    // public void MoveForward()
    // {
    //     if(canMove == false)
    //     {
    //         return;
    //     }

    //     var currentPosition = goPlayerObject.transform.position;
    //     var destinationPosition = currentPosition;
    //     destinationPosition.z = currentPosition.z + 1;

    //     var seq = DOTween.Sequence();
    //     seq.AppendCallback(() => canMove = false);
    //     seq.Append(goPlayerObject.transform.DOMoveZ(destinationPosition.z, 0.2f).SetEase(Ease.Linear));
    //     seq.AppendCallback(() => canMove = true);
    // }

    // public void MoveBackward()
    // {
    //     if(canMove == false)
    //     {
    //         return;
    //     }

    //     var currentPosition = goPlayerObject.transform.position;
    //     var destinationPosition = currentPosition;
    //     destinationPosition.z = currentPosition.z - 1;

    //     var seq = DOTween.Sequence();
    //     seq.AppendCallback(() => canMove = false);
    //     seq.Append(goPlayerObject.transform.DOMoveZ(destinationPosition.z, 0.2f).SetEase(Ease.Linear));
    //     seq.AppendCallback(() => canMove = true);
    // }

    public void MoveLeft()
    {
        if(canMove == false)
        {
            return;
        }

        var currentPosition = goPlayerObject.transform.position;
        var destinationPosition = currentPosition;
        destinationPosition.x = currentPosition.x - 1;

        if(!CheckCanMove(destinationPosition.x))
        {
            return;
        }

        var seq = DOTween.Sequence();
        seq.AppendCallback(() => canMove = false);
        seq.Append(goPlayerObject.transform.DOMoveX(destinationPosition.x, 0.2f).SetEase(Ease.Linear));
        seq.AppendCallback(() => canMove = true);
    }

    public void MoveRight()
    {
        if(canMove == false)
        {
            return;
        }

        var currentPosition = goPlayerObject.transform.position;
        var destinationPosition = currentPosition;
        destinationPosition.x = currentPosition.x + 1;

        if(!CheckCanMove(destinationPosition.x))
        {
            return;
        }

        var seq = DOTween.Sequence();
        seq.AppendCallback(() => canMove = false);
        seq.Append(goPlayerObject.transform.DOMoveX(destinationPosition.x, 0.2f).SetEase(Ease.Linear));
        seq.AppendCallback(() => canMove = true);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Debug.Log("Player died");
        }
    }
}