using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public ItemData_SO itemData;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //讲物品添加到背包

            //装备武器
            GameManager.Instance.playerStatus.EquipWeapon(itemData);

            Destroy(gameObject);
        }
    }
}
