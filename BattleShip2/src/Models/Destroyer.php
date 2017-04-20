<?php
namespace App\Models;

class Destroyer extends Ship
{
	
	public function __construct($startingCoordinate, $orientation)
	{
		parent::__construct(4, $startingCoordinate, $orientation);
	}
}