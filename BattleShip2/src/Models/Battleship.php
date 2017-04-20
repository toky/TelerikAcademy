<?php
namespace App\Models;

class Battleship extends Ship
{

	public function __construct($startingCoordinate, $orientation)
	{
		parent::__construct(5, $startingCoordinate, $orientation);
	}
}