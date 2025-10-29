using System.Collections.Generic;
using IDosGames;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private void OnEnable()
	{
		UserInventory.InventoryUpdated += UpdateAmount;
		UserDataService.VirtualCurrencyUpdated += UpdateAmount;
	}

	private void OnDisable()
	{
		UserInventory.InventoryUpdated -= UpdateAmount;
		UserDataService.VirtualCurrencyUpdated -= UpdateAmount;
	}

	private void UpdateAmount()
	{
		PlayerData.instance.coins = IGSUserData.UserInventory.VirtualCurrency.GetValueOrDefault("CO", 0);
		PlayerData.instance.premium = IGSUserData.UserInventory.VirtualCurrency.GetValueOrDefault("IG", 0);
	}
}
