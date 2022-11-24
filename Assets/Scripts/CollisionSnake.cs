using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSnake : MonoBehaviour
{
    [SerializeField] private GameObject _snake = default;
    [SerializeField] private GameObject _snakeManager = default;
    [SerializeField] private int Quantity = 2;

    private void Start()
    {
        _snakeManager = GameObject.FindGameObjectWithTag("SnakeManager");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _snakeManager.GetComponent<SnakeManager>().AddPartList(_snake,Quantity);
            Destroy(gameObject);
        }
       
    }
}
