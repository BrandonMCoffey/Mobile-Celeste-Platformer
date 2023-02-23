﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : State
{
	private GameFSM _stateMachine;
	private GameController _controller;
	
	public GamePlayState(GameFSM stateMachine, GameController controller)
	{
		_stateMachine = stateMachine;
		_controller = controller;
	}
	
	protected override void OnEnter()
	{
		GameObject.Instantiate(_controller.PlayerUnitPrefab, _controller.PlayerUnitSpawnLocation);
	}
	protected override void OnTick() { }
	protected override void OnFixedTick() { }
	protected override void OnExit() { }
}